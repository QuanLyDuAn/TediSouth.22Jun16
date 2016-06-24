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
using DTO;
using BUS;

namespace TediSouth
{
    public partial class FrmChucVuNhanVien : Form
    {
        public delegate void Send(string ID);
        public Send Sender;
        static string MaNV2;
        public FrmChucVuNhanVien()
        {
            InitializeComponent();
            Sender = new Send(LayID);
        }
        private void LayID(string ID)
        {
            MaNV2 = ID;
        }
        public void LoadQDCongViec()
        {
            DataTable dt = new DataTable();
            string lenh = string.Format("select * from QuyetDinhCongViec where IDnhanvien like N'{0}'", MaNV2);      
            dt = DBConnect.TaoBang(lenh);
            dgvQDChucVu.DataSource = dt;
            //chinh sua column
            dgvQDChucVu.Columns["QDCongViec"].HeaderText = "Mã Quyết Định";
            dgvQDChucVu.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvQDChucVu.Columns["MaChucVu"].HeaderText = "Mã Chức Vụ";
            dgvQDChucVu.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvQDChucVu.Columns["NoiDung"].HeaderText = "Nội Dung";
            if (dt.Rows.Count == 0)
                MessageBox.Show("Nhân viên này chưa có quyết định công việc", "Thông báo");
        }
        public void LoadCbChucVu()
        {
            cbChucVu.DataSource = DBConnect.TaoBang("Select * from ChucVU");
            cbChucVu.ValueMember = "MaChucVu";
            cbChucVu.DisplayMember = "TenChucVu";
        }
        public void LoadTen()
        {
            DataTable dt = new DataTable();
            string lenh = string.Format("select hoten from nhanvien where idnhanvien=N'{0}'", MaNV2);
            dt = DBConnect.TaoBang(lenh);
            DataRow dr = dt.Rows[0];
            lbMaNV.Text = dr["HoTen"].ToString();
        }

        private void click_them(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || tbNoiDung.Text == "" || cbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                QuyetDinhCongViec cv = new QuyetDinhCongViec();
                cv.QDCongViec = tbMaQD.Text;
                cv.NoiDung = tbNoiDung.Text;
                cv.NgayLap = DateTime.Parse(dtNgayLap.Value.ToString());
                cv.IDNhanVien = MaNV2;
                cv.MaChucVu = cbChucVu.SelectedValue.ToString();
                if (QuyetDinhCongViec_BUS.KiemTra(tbMaQD.Text) == false)
                {
                    if (QuyetDinhCongViec_BUS.Insert(cv) == true)
                    {
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        ReLoad();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại", "Thông Báo");
                        return;
                    }
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }
        private void ReLoad()
        {
            LoadQDCongViec();
            LoadTen();
            tbMaQD.Clear();
            tbNoiDung.Clear();
            cbChucVu.Text = null;
        }

        private void FrmChucVuNhanVien_Load(object sender, EventArgs e)
        {
            LoadQDCongViec();
            LoadCbChucVu();
            LoadTen();
        }

        private void click_Luu(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || tbNoiDung.Text == "" || cbChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                QuyetDinhCongViec cv = new QuyetDinhCongViec();
                cv.QDCongViec = tbMaQD.Text;
                cv.NoiDung = tbNoiDung.Text;
                cv.NgayLap = DateTime.Parse(dtNgayLap.Value.ToString());
                cv.IDNhanVien = MaNV2;
                cv.MaChucVu = cbChucVu.SelectedValue.ToString();
                if (QuyetDinhCongViec_BUS.Update(cv) == true)
                {
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    ReLoad();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại", "Thông Báo");
                    return;
                }
            }
        }

        private void click_xoa(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Quyết Định Cần Xóa", "Thông báo");
                return;
            }
            QuyetDinhCongViec qd = new QuyetDinhCongViec();
            qd.QDCongViec = tbMaQD.Text;
            if (QuyetDinhCongViec_BUS.Delete(qd) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                ReLoad();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void click_reset(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void click_cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvQDChucVu.SelectedRows[0];
                tbMaQD.Text = dr.Cells["QDCongviec"].Value.ToString();
                tbNoiDung.Text = dr.Cells["NoiDung"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                cbChucVu.SelectedValue = dr.Cells["MaChucVu"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
