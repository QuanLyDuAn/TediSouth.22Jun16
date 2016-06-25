using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;
using System.Data.SqlClient;

namespace TediSouth
{
    public partial class FrmDonVi : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public static string IDDV;

        public FrmDonVi()
        {
            InitializeComponent();
            LoadDGV();
            AutoLV();
        }
        public void Reload()
        {
            tbDiaChi.Clear();
            tbGioiThieu.Clear();
            tbMaLV.Clear();
            tbMaDV.Clear();
            tbNgDD.Clear();
            tbSDT1.Clear();
            tbTenCongTy.Clear();
            tbTimKiem.Text= "Nhập mã hoặc tên đơn vị để tìm kiếm...";
            tbWeb.Clear();

        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = DonVi_BUS.LoadDV();
            dgvDV.DataSource = dt;

            dgvDV.Columns["MaDonVi"].HeaderText = "Đơn Vị";
            dgvDV.Columns["MaLinhVuc"].HeaderText = "Lĩnh Vực Chính";
            dgvDV.Columns["TenDonVi"].HeaderText = "Tên Đơn Vị";
            dgvDV.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
            dgvDV.Columns["Website"].HeaderText = "Website";
            dgvDV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvDV.Columns["SDTDonVi"].HeaderText = "Điện Thoại";
            dgvDV.Columns["GioiThieu"].HeaderText = "Giới Thiệu";
        }
        public void AutoLV()
        {
            //Đang suy nghĩ chọn mã hay tên cho hợp lý
            SqlCommand cmd = new SqlCommand("Select TenLinhVuc from LinhVuc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            tbMaLV.AutoCompleteCustomSource = collection;
            con.Close();
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "" || tbMaLV.Text == "" || tbNgDD.Text == "" || tbTenCongTy.Text == "" || tbDiaChi.Text == "" || tbSDT1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                DonVi bp = new DonVi();
                bp.MaDonVi = tbMaDV.Text;
                bp.MaLinhVuc = tbMaLV.Text;
                bp.TenDonVi = tbTenCongTy.Text;
                bp.NguoiDaiDien = tbNgDD.Text;
                bp.GioiThieu = tbGioiThieu.Text;
                bp.WebSite = tbWeb.Text;
                bp.DiaChi = tbDiaChi.Text;
                bp.SDTDonVi = tbSDT1.Text;
                if (DonVi_BUS.KiemTra(tbMaDV.Text) == false)
                {
                    DonVi_BUS.Insert(bp);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDGV();
                    Reload();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }

        private void click_Update(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "" || tbMaLV.Text == "" || tbNgDD.Text == "" || tbTenCongTy.Text == "" || tbDiaChi.Text == "" || tbSDT1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            DonVi bp = new DonVi();
            bp.MaDonVi = tbMaDV.Text;
            bp.MaLinhVuc = tbMaLV.Text;
            bp.TenDonVi = tbTenCongTy.Text;
            bp.NguoiDaiDien = tbNgDD.Text;
            bp.GioiThieu = tbGioiThieu.Text;
            bp.WebSite = tbWeb.Text;
            bp.DiaChi = tbDiaChi.Text;
            bp.SDTDonVi = tbSDT1.Text;
            if (DonVi_BUS.Update(bp) == true)
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
        }

        private void click_Delete(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "" || tbMaLV.Text == "" || tbNgDD.Text == "" || tbTenCongTy.Text == "" || tbDiaChi.Text == "" || tbSDT1.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            DonVi bp = new DonVi();
            bp.MaDonVi = tbMaDV.Text;
            if (DonVi_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void click_Reset(object sender, EventArgs e)
        {
            Reload();
            LoadDGV();
        }

        private void click_PhongBan(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "")
                MessageBox.Show("Chưa chọn đơn vị", "Thông Báo");
            else
            {
                IDDV = tbMaDV.Text;
                FrmChiTietDonVi fm = new FrmChiTietDonVi();
                fm.Sender(IDDV);
                fm.Show();
            }
        }

        private void click_cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDV.SelectedRows[0];
                tbMaDV.Text = dr.Cells["MaDonVi"].Value.ToString();
                tbMaLV.Text = dr.Cells["MaLinhVuc"].Value.ToString();
                tbTenCongTy.Text = dr.Cells["TenDonVi"].Value.ToString();
                tbNgDD.Text = dr.Cells["NguoiDaiDien"].Value.ToString();
                tbGioiThieu.Text = dr.Cells["GioiThieu"].Value.ToString();
                tbWeb.Text = dr.Cells["Website"].Value.ToString();
                tbDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                tbSDT1.Text = dr.Cells["SDTDonVi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = DonVi_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
            dgvDV.DataSource = dt;
            
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }

        private void tbSDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
               char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
               char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
               char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo");
                tbSDT1.Clear();
            }
        }
    }
}
