using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using System.Data.SqlClient;

namespace TediSouth
{
    public partial class FrmDuAn : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        
        public FrmDuAn()
        {
            InitializeComponent();
           
        }
        private void FrmDuAn_Load(object sender, EventArgs e)
        {
            Reload();
            LoadDGV();
            AutoLV();
        }
        public void Reload()
        {
            tbMaDuAn.Clear();
            tbTenDuAn.Clear();
            tbkhachang.Clear();
            dtNgayLap.Value = DateTime.Now;
            tbThoiGian1.Clear();
            tbKinhPhi1.Clear();
            tbTimKiem.Text= "Nhập mã hoặc tên dự án để tìm kiếm...";
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = DuAn_BUS.LoadDA();
            dgvDA.DataSource = dt;

            dgvDA.Columns["MaDuAn"].HeaderText = "Dự Án";
            dgvDA.Columns["TenDuAn"].HeaderText = "Tên Dự Án";
            dgvDA.Columns["MaKhachHang"].HeaderText = "Khách Hàng";
            dgvDA.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDA.Columns["SoThangTrienKhai"].HeaderText = "Thời Gian Triển Khai";
            dgvDA.Columns["TongKinhPhi"].HeaderText = "Kinh Phí";
            dgvDA.Columns["TongKinhPhi"].DefaultCellStyle.Format = "#,#"+" VNĐ" ;
        }
        public void AutoLV()
        {
            //Đang suy nghĩ chọn mã hay tên cho hợp lý
            SqlCommand cmd = new SqlCommand("Select MaKhachHang from KhachHang", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            tbkhachang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbkhachang.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbkhachang.AutoCompleteCustomSource = collection;
            con.Close();
        }
        
        private void click_Add(object sender, EventArgs e)
        {
            if (tbkhachang.Text == "" || tbKinhPhi1.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian1.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                DuAn bp = new DuAn();
                bp.MaDuAn = tbMaDuAn.Text;
                bp.TenDuAn = tbTenDuAn.Text;
                bp.MaKhachHang = tbkhachang.Text;
                bp.NgayLap =Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.SoThangTrienKhai =Convert.ToInt32( tbThoiGian1.Text);
                bp.TongKinhPhi = Convert.ToDouble(tbKinhPhi1.Text)* 1000000000;
                if (DuAn_BUS.KiemTra(tbMaDuAn.Text) == false)
                {
                    DuAn_BUS.Insert(bp);
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
            if (tbkhachang.Text == "" || tbKinhPhi1.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            DuAn bp = new DuAn();
            bp.MaDuAn = tbMaDuAn.Text;
            bp.TenDuAn = tbTenDuAn.Text;
            bp.MaKhachHang = tbkhachang.Text;
            bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
            bp.SoThangTrienKhai = Convert.ToInt32(tbThoiGian1.Text);
            bp.TongKinhPhi = Convert.ToDouble(tbKinhPhi1.Text) *1000000000;
            if (DuAn_BUS.Update(bp) == true)
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
            if (tbkhachang.Text == "" || tbKinhPhi1.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian1.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            DuAn bp = new DuAn();
            bp.MaDuAn = tbMaDuAn.Text;
            if (DuAn_BUS.Delete(bp) == true)
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

        private void click_cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDA.SelectedRows[0];
                tbMaDuAn.Text = dr.Cells["MaDuAn"].Value.ToString();
                tbTenDuAn.Text = dr.Cells["TenDuAn"].Value.ToString();
                tbkhachang.Text = dr.Cells["MaKhachHang"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                tbThoiGian1.Text = dr.Cells["SoThangTrienKhai"].Value.ToString();
                //tbKinhPhi.Text = dr.Cells["TongKinhPhi"].Value.ToString();
                string tam =dr.Cells["TongKinhPhi"].Value.ToString();
                tbKinhPhi1.Text = (Convert.ToDouble(tam) / 1000000000).ToString();
                tbKinhPhi1.Text= string.Format("{0:#,##}", double.Parse(tbKinhPhi1.Text));
            }
            catch (Exception ex)
            {

            }
        }
 
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DuAn_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
            dgvDA.DataSource = dt;
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }

        private void tbThoiGian1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số.", "Thông báo");
                tbThoiGian1.Clear();
            }
        }

        private void tbKinhPhi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
                char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
                char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
                char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo");
                tbKinhPhi1.Clear();
            }
        }

        
    }
}
