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
using DTO;
using DAL;
using System.Data.SqlClient;
using System.IO;

namespace TediSouth
{
    public partial class FrmQDDieuHanhDuAn : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public string ID;
        public FrmQDDieuHanhDuAn()
        {
            InitializeComponent();
        }

        private void FrmQDDieuHanhDuAn_Load(object sender, EventArgs e)
        {
            LoadDgvQDDH();
            LoadCbDuAn();
            LoadDgvNV();
            LoadCbbNV();
        }
        private void LoadDgvQDDH()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = QDDieuHanhDuAn_BUS.LoadQDDHDA();
            }
            else
            {
                dt = QDDieuHanhDuAn_BUS.LoadQDDHDA_ID(ID);
            }

            dgvQDDH.DataSource = dt;
            dgvQDDH.Columns["QDDieuHanh"].HeaderText = "Mã Quyết Định";
            dgvQDDH.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            dgvQDDH.Columns["NgayLapDieuHanh"].HeaderText = "Ngày Lập Quyết Định";
            dgvQDDH.Columns["NgayDuyetDieuHanh"].HeaderText = "Ngày Ký Duyệt";
            dgvQDDH.Columns["NoiDungDieuHanh"].HeaderText = " Nội Dung Điều Hành";
        }
        private void LoadDgvNV()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = QDDieuHanhDuAn_BUS.LoadDgvChiTiet();
            }
            else
            {
                dt = QDDieuHanhDuAn_BUS.LoadDgvChiTiet_ID(ID);
            }
            dgvNV.DataSource = dt;
            dgvNV.Columns["QDDieuHanh"].HeaderText = "Mã Quyết Định";
            dgvNV.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvNV.Columns["ViTriPhanCong"].HeaderText = "Vị Trí Phân Công";
        }
        private void LoadCbDuAn()
        {
            if (ID == "admin")
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select * from DuAn");
            }
            else
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select a.* from DuAn a, HopDongGiaoKhoan b where a.MaDuAn=b.MaDuAn and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"')");
            }
            cbDuAn.ValueMember = "MaDuAn";
            cbDuAn.DisplayMember = "TenDuAn";
        }
        private void LoadCbbNV()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = QDDieuHanhDuAn_BUS.LoadCbNV();
            }
            else
            {
                dt = QDDieuHanhDuAn_BUS.LoadCbNV_ID(ID);
            }
            cbMaNV.DataSource = dt;
            cbMaNV.ValueMember = "IDNhanVien";
            cbMaNV.DisplayMember = "IDNhanVien";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || cbDuAn.Text == "" || linkFile.Text == "No File Select.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                QDDieuHanhDuAn bp = new QDDieuHanhDuAn();
                bp.QDDieuHanh = tbMaQD.Text;
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.NgayLapDieuHanh = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NgayDuyetDieuHanh = Convert.ToDateTime(dtNgayKy.Value.ToString());
                bp.NoiDungDieuHanh = "D:/hồsơtổnghợp/DieuHanhDA/" + open.SafeFileName;
                if (QDDieuHanhDuAn_BUS.KiemTra(tbMaQD.Text) == false)
                {
                    if (linkFile.Text != "No File Select.")
                    {
                        string sourcefolder = linkFile.Text;
                        string destfolder = "D:/hồsơtổnghợp/DieuHanhDA";
                        CoppyFile(sourcefolder, destfolder);
                        if (QDDieuHanhDuAn_BUS.Insert(bp) == true)
                        {
                            MessageBox.Show("Thêm Thành Công", "Thông Báo");
                            LoadDgvQDDH();
                            ReLoad();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại", "Thông Báo");
                            return;
                        }
                    }
                    else
                    {

                        QDDieuHanhDuAn_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDgvQDDH();
                        ReLoad();
                        return;
                    }
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }
        private void CoppyFile(string SourceFolder, string DestFolder)
        {

            if (!Directory.Exists(DestFolder)) // folder ton tai thi moi thuc hien copy
            {
                Directory.CreateDirectory(DestFolder); //Tao folder moi
            }
            else
            {

                string name = Path.GetFileName(SourceFolder);
                string dest = Path.Combine(DestFolder, name);
                try
                {
                    File.Copy(SourceFolder, dest);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Tồn Tại File Trong dữ Liệu!", "Thông Báo");
                    return;
                }
                MessageBox.Show("Luu File thanh cong!", "Thong bao");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || cbDuAn.Text == "" || linkFile.Text == "No File Select.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                QDDieuHanhDuAn bp = new QDDieuHanhDuAn();
                bp.QDDieuHanh = tbMaQD.Text;
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.NgayLapDieuHanh = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NgayDuyetDieuHanh = Convert.ToDateTime(dtNgayKy.Value.ToString());
                bp.NoiDungDieuHanh = "D:/hồsơtổnghợp/DieuHanhDA/" + open.SafeFileName;
                string sourcefolder = linkFile.Text;
                string destfolder = "D:/hồsơtổnghợp/DieuHanhDA";
                CoppyFile(sourcefolder, destfolder);
                if (QDDieuHanhDuAn_BUS.Update(bp) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    LoadDgvQDDH();
                    ReLoad();
                    return;
                }
                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            QDDieuHanhDuAn bp = new QDDieuHanhDuAn();
            bp.QDDieuHanh = tbMaQD.Text;
            if (QDDieuHanhDuAn_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDgvQDDH();
                ReLoad();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReLoad();
            LoadDgvQDDH();
        }
        private void ReLoad()
        {
            tbMaQD.Clear();
            cbDuAn.Text = null;
            linkFile.Text = "No File Select.";

        }
        OpenFileDialog open = new OpenFileDialog();
        private void btnDuyetFile_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "C:";
            DialogResult Result = open.ShowDialog();
            if (Result == DialogResult.OK)
            {
                linkFile.Text = open.FileName;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dr = dgvQDDH.SelectedRows[0];
                tbMaQD.Text = dr.Cells["QDDieuHanh"].Value.ToString();
                cbDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLapDieuHanh"].Value.ToString();
                dtNgayKy.Text = dr.Cells["NgayDuyetDieuHanh"].Value.ToString();
                if (dr.Cells["NoiDungDieuHanh"].Value.ToString() == null)
                {
                    linkFile.Text = "No File Select.";
                }
                linkFile.Text = dr.Cells["NoiDungDieuHanh"].Value.ToString();

                DataTable tam = ChiTietDieuHanh_BUS.LoadCTDH_ID(dr.Cells["QDDieuHanh"].Value.ToString());
                dgvNV.DataSource = tam;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemCTDH_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || cbMaNV.SelectedValue.ToString() == "" || txtPhanCong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                Chi_Tiet_Dieu_Hanh bp = new Chi_Tiet_Dieu_Hanh();
                bp.QDDieuHanh = tbMaQD.Text;
                bp.IDNhanVien = cbMaNV.SelectedValue.ToString();
                bp.ViTriPhanCong = txtPhanCong.Text;
                if (ChiTietDieuHanh_BUS.KiemTra(tbMaQD.Text, cbMaNV.SelectedValue.ToString()) == false)
                {
                    if (ChiTietDieuHanh_BUS.Insert(bp) == true)
                    {
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDgvNV();
                        ReLoadNV();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại!", "Thông Báo");
                        return;
                    }
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }

        }

        private void btnSuaCTDH_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || cbMaNV.SelectedValue.ToString() == "" || txtPhanCong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                Chi_Tiet_Dieu_Hanh bp = new Chi_Tiet_Dieu_Hanh();
                bp.QDDieuHanh = tbMaQD.Text;
                bp.IDNhanVien = cbMaNV.SelectedValue.ToString();
                bp.ViTriPhanCong = txtPhanCong.Text;

                if (ChiTietDieuHanh_BUS.Update(bp) == true)
                {
                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    LoadDgvNV();
                    ReLoadNV();
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu Thất Bại!", "Thông Báo");
                    return;
                }
            }

        }
        private void btnXoaCTDH_Click(object sender, EventArgs e)
        {
            if (tbMaQD.Text == "" || cbMaNV.SelectedValue.ToString() == "" || txtPhanCong.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            Chi_Tiet_Dieu_Hanh bp = new Chi_Tiet_Dieu_Hanh();
            bp.QDDieuHanh = tbMaQD.Text;
            bp.IDNhanVien = cbMaNV.SelectedValue.ToString();
            if (ChiTietDieuHanh_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDgvNV();
                ReLoadNV();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }
        private void ReLoadNV()
        {
            cbMaNV.Text = "";
            txtPhanCong.Clear();
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvNV.SelectedRows[0];
                tbMaQD.Text = dr.Cells["QDDieuHanh"].Value.ToString();
                cbMaNV.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
                txtPhanCong.Text = dr.Cells["ViTriPhanCong"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = linkFile.Text;
            try
            {
                System.Diagnostics.Process.Start(txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedValue != null && !(cbMaNV.SelectedValue is DataRowView))
            {
                dt = new DataTable();
                dt = DBConnect.TaoBang("select MaChucVu, HoTen from DonVi a, NhanVien b, QuyetDinhCongViec c where a.MaDonVi = b.MaDonVi and  b.IDNhanVien = c.IDNhanVien and b.IDNhanVien = '" + cbMaNV.SelectedValue.ToString() + "'");
                DataRow dr = dt.Rows[0];
                lbHoTen.Text = dr["HoTen"].ToString();
                lbChucVu.Text = dr["MaChucVu"].ToString();
            }
        }
    }
}


