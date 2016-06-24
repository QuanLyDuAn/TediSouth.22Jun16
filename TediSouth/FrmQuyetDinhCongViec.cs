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
using System.Data.SqlClient;
using System.IO;

namespace TediSouth
{
    public partial class FrmQuyetDinhCongViec : Form
    {
        public string ID;

        public FrmQuyetDinhCongViec()
        {
            InitializeComponent();
        }
        private void FrmQuyetDinhCongViec_Load(object sender, EventArgs e)
        {
            LoadQDCongViec();
            LoadDgvNVChuaCV();
            LoadCbMaNV();
            LoadCbChucVu();
        }
        public void LoadQDCongViec()
        {
            DataTable dt = new DataTable();
            if (ID == "admin")
            {
                dt = QuyetDinhCongViec_BUS.LoadQDCV();
            }
            else
            {
                dt = QuyetDinhCongViec_BUS.LoadQDCV_ID(ID);
            }
            dgvQDChucVu.DataSource = dt;
            //chinh sua column
            dgvQDChucVu.Columns["QDCongViec"].HeaderText = "Mã Quyết Định";
            dgvQDChucVu.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvQDChucVu.Columns["MaChucVu"].HeaderText = "Mã Chức Vụ";
            dgvQDChucVu.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvQDChucVu.Columns["NoiDung"].HeaderText = "Nội Dung";
        }
        public void LoadDgvNVChuaCV()
        {
            DataTable dt = new DataTable();
            if (ID=="admin")
            {
                dt = QuyetDinhCongViec_BUS.LoadNVChuaCV();
            }
            else
            {
                dt = QuyetDinhCongViec_BUS.LoadNVChuaCV_ID(ID);
            }
            dgvNVChuaCV.DataSource = dt;
            dgvNVChuaCV.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvNVChuaCV.Columns["HoTen"].HeaderText = "Họ Tên";
        }
        public void LoadCbMaNV()
        {
            if (ID == "admin")
            {
                cbMaNV.DataSource = DBConnect.TaoBang("Select IDNhanVien from NhanVien");
            }
            else
            {
                cbMaNV.DataSource = DBConnect.TaoBang("Select IDNhanVien from NhanVien where MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"')");
            }
            cbMaNV.ValueMember = "IDNhanVien";
            cbMaNV.DisplayMember = "IDNhanVien";
        }
        public void LoadCbChucVu()
        {
            cbChucVu.DataSource = DBConnect.TaoBang("Select * from ChucVU");
            cbChucVu.ValueMember = "MaChucVu";
            cbChucVu.DisplayMember = "TenChucVu";
        }


        private void dgvQDChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvQDChucVu.SelectedRows[0];
                tbMaQD.Text = dr.Cells["QDCongviec"].Value.ToString();
                tbNoiDung.Text = dr.Cells["NoiDung"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                cbMaNV.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
                cbChucVu.SelectedValue = dr.Cells["MaChucVu"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
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
                cv.IDNhanVien = cbMaNV.SelectedValue.ToString();
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
        private void btnLuu_Click(object sender, EventArgs e)
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
                cv.IDNhanVien = cbMaNV.SelectedValue.ToString();
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
        private void ReLoad()
        {
            LoadQDCongViec();
            LoadDgvNVChuaCV();
            tbMaQD.Clear();
            tbNoiDung.Clear();
            cbMaNV.Text = null;
            cbChucVu.Text = null;
        }

        private void dgvNVChuaChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvNVChuaCV.SelectedRows[0];
                tbMaQD.Text = null;
                tbNoiDung.Text = null;
                dtNgayLap.Text = DateTime.Today.ToString();
                cbMaNV.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}

