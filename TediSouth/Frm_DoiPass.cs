using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DTO;

namespace TediSouth
{

    public partial class Frm_DoiPass : Form
    {
        public delegate void Send(string ID);
        public Send Sender;
        static string MaNV2;
        public Frm_DoiPass()
        {
            InitializeComponent();
            Sender = new Send(LayID);
        }
        private void LayID(string ID)
        {
            MaNV2 = ID;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (tbMatKhauCu.Text == "" || tbMatKhauMoi.Text == "" || tbNhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                TaiKhoan bp = new TaiKhoan();
                string lenh = string.Format("select name from taikhoan where idnhanvien=N'{0}'", MaNV2);
                DataTable dt = DBConnect.TaoBang(lenh);
                DataRow dr = dt.Rows[0];
                bp.Name = dr["name"].ToString();
                bp.Pass = tbMatKhauMoi.Text;
                bp.IDNhanVien = MaNV2;
                bp.HoatDong = true;
                if (TaiKhoan_BUS.Update(bp) == true)
                {
                    MessageBox.Show("Cập nhật thành công. Vui lòng đăng nhập lần sau bằng mật khẩu mới.", "Thông Báo");
                    this.Close();
                }
            }
        }

        private void Frm_DoiPass_Load(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
                tbMatKhauCu.UseSystemPasswordChar = false;
            else
                tbMatKhauCu.UseSystemPasswordChar = true;
        }
        public void Reload()
        {
            tbMatKhauMoi.Clear();
            tbMatKhauCu.Clear();
            lbLoiMatKhauCu.Text = "";
            lbMatKhauMoi.Text = "";
        }

        private void tbMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            lbLoiMatKhauCu.Text = "";
            DataTable dt = new DataTable();
            string lenh = string.Format("select pass from taikhoan where hoatdong= 'True' and idnhanvien=N'{0}'", MaNV2);
            dt = DBConnect.TaoBang(lenh);
            DataRow dr = dt.Rows[0];
            string tam = dr["pass"].ToString();
            if (tam != tbMatKhauCu.Text && tbMatKhauCu.Text != "")
            {
                lbLoiMatKhauCu.Text = "Sai pass";
            }
        }

        private void tbMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

            if (tbMatKhauCu.Text == tbMatKhauMoi.Text && tbMatKhauCu.Text != "" && tbMatKhauMoi.Text != "")
            {
                lbMatKhauMoi.Text = "Không thể trùng mật khẩu cũ.";
            }
            if (tbMatKhauCu.Text != tbMatKhauMoi.Text && tbMatKhauCu.Text != "" && tbMatKhauMoi.Text != "")
                lbMatKhauMoi.Text = "Có thể sử dụng.";
        }

        private void tbNhapLai_TextChanged(object sender, EventArgs e)
        {
            if (tbMatKhauMoi.Text != tbNhapLai.Text && tbMatKhauMoi.Text != "" && tbNhapLai.Text != "")
            {
                lbMatKhauMoi.Text = "Mật khẩu mới không khớp";
            }
            if (tbMatKhauMoi.Text == tbNhapLai.Text && tbMatKhauMoi.Text != "" && tbNhapLai.Text != "")
            {
                lbMatKhauMoi.Text = "";
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
                tbMatKhauCu.UseSystemPasswordChar = false;
            else
                tbMatKhauCu.UseSystemPasswordChar = true;
        }
    }
}
