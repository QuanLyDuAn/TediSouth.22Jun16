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
    public partial class FrmHopDongGiaoKhoan : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public string ID;
        public FrmHopDongGiaoKhoan()
        {
            InitializeComponent();
        }

        private void FrmHopDongGiaoKhoan_Load(object sender, EventArgs e)
        {
            LoadDgvHDGK();
            LoadCbMaHD();
            LoadCbDuAn();
            LoadCbDonVi();
        }
        private void LoadDgvHDGK()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = HopDongGiaoKhoan_BUS.LoadHDGK();
            }
            else
            {
                dt = HopDongGiaoKhoan_BUS.LoadHDGK_ID(ID);
            }
            dgvHDGK.DataSource = dt;
            dgvHDGK.Columns["MaHopDong"].HeaderText = "Mã Hợp Đồng";
            dgvHDGK.Columns["MaHopDongGK"].HeaderText = "Mã Hợp Đồng GK";
            dgvHDGK.Columns["MaDonVi"].HeaderText = "Mã Đơn Vị";
            dgvHDGK.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            dgvHDGK.Columns["NgayLapHDGK"].HeaderText = "Ngày Lập HĐGK";
            dgvHDGK.Columns["NgayKyDuyetHDGK"].HeaderText = "Ngày Ký Duyệt HĐGK";
            dgvHDGK.Columns["KinhPhi"].HeaderText = "Kinh Phí";
            dgvHDGK.Columns["NoiDungHopDongGK"].HeaderText = " Nội Dung Hợp Đồng";
        }
        private void LoadCbMaHD()
        {
            cbMaHD.DataSource = DBConnect.TaoBang("Select * from HopDong");
            cbMaHD.DisplayMember = "MaHopDong";
            cbMaHD.ValueMember = "MaHopDong";
        }
        private void LoadCbDuAn()
        {
            cbMaDuAn.DataSource = DBConnect.TaoBang("Select * from DuAn");
            cbMaDuAn.DisplayMember = "TenDuAn";
            cbMaDuAn.ValueMember = "MaDuAn";
        }
        private void LoadCbDonVi()
        {
            if (ID == "admin")
            {
                cbMaDonVi.DataSource = DBConnect.TaoBang("Select * from DonVi");
            }
            else
            {
                cbMaDonVi.DataSource = DBConnect.TaoBang("Select a.* from DonVi a, NhanVien b where a.MaDonVi = b.MaDonVi and IDNhanVien = '" + ID + "'");
            }

            cbMaDonVi.DisplayMember = "TenDonVi";
            cbMaDonVi.ValueMember = "MaDonVi";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaHopDongGiaoKhoan.Text == "" || cbMaDuAn.Text == "" || tbKinhPhi.Text == "" || linkFile.Text == "No File Select.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                HopDongGiaoKhoang bp = new HopDongGiaoKhoang();
                bp.MaHopDong = cbMaHD.SelectedValue.ToString();
                bp.MaHopDongGK = tbMaHopDongGiaoKhoan.Text;
                bp.MaDonVi = cbMaDonVi.SelectedValue.ToString();
                bp.MaDuAn = cbMaDuAn.SelectedValue.ToString();
                bp.NgayLapHDGK = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NgayDuyetHDGK = Convert.ToDateTime(dtNgayKy.Value.ToString());
                bp.KinhPhi = int.Parse(tbKinhPhi.Text);
                bp.NoiDungHoDongGK = "D:/hồsơtổnghợp/HDGiaoKhoang/" + open.SafeFileName;
                if (HopDongGiaoKhoan_BUS.KiemTra(tbMaHopDongGiaoKhoan.Text) == false)
                {
                    if (linkFile.Text != "No File Select.")
                    {
                        string sourcefolder = linkFile.Text;
                        string destfolder = "D:/hồsơtổnghợp/HDGiaoKhoang";
                        CoppyFile(sourcefolder, destfolder);
                        HopDongGiaoKhoan_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDgvHDGK();
                        Reload();
                        return;
                    }
                    else
                    {

                        HopDongGiaoKhoan_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDgvHDGK();
                        Reload();
                        return;
                    }
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMaHopDongGiaoKhoan.Text == "" || cbMaDuAn.Text == "" || tbKinhPhi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                HopDongGiaoKhoang bp = new HopDongGiaoKhoang();
                bp.MaHopDong = cbMaHD.SelectedValue.ToString();
                bp.MaHopDongGK = tbMaHopDongGiaoKhoan.Text;
                bp.MaDonVi = cbMaDonVi.SelectedValue.ToString();
                bp.MaDuAn = cbMaDuAn.SelectedValue.ToString();
                bp.NgayLapHDGK = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NgayDuyetHDGK = Convert.ToDateTime(dtNgayKy.Value.ToString());
                bp.KinhPhi = double.Parse(tbKinhPhi.Text);
                bp.NoiDungHoDongGK = "D:/hồsơtổnghợp/HDGiaoKhoang/" + open.SafeFileName;
                string sourcefolder = linkFile.Text;
                string destfolder = "D:/hồsơtổnghợp/HDGiaoKhoang";
                CoppyFile(sourcefolder, destfolder);
                if (HopDongGiaoKhoan_BUS.Update(bp) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    LoadDgvHDGK();
                    Reload();
                    return;
                }
                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaHopDongGiaoKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            HopDongGiaoKhoang bp = new HopDongGiaoKhoang();
            bp.MaHopDongGK = tbMaHopDongGiaoKhoan.Text;
            if (HopDongGiaoKhoan_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDgvHDGK();
                Reload();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDgvHDGK();
            Reload();
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
        private void Reload()
        {
            cbMaHD.Text = null;
            cbMaDonVi.Text = null;
            tbMaHopDongGiaoKhoan.Clear();
            cbMaDuAn.Text = null;
            tbKinhPhi.Clear();
            linkFile.Text = null;
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaHD.SelectedValue != null && !(cbMaHD.SelectedValue is DataRowView))
            {
                DataTable dt = new DataTable();
                //string ketnoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
                //string sTruyVan = string.Format("select b.MaBoPhan,TenBoPhan from  ChiTietDonVi c, BoPhan b where  c.MaBoPhan = b.MaBoPhan and MaDonVi ='{0}'", cbDonVi.SelectedValue);
                //SqlDataAdapter da = new SqlDataAdapter(sTruyVan, ketnoi);
                //da.Fill(dt);   
                dt = HopDongGiaoKhoan_BUS.LoadDuAnTheoHD(cbMaHD.SelectedValue.ToString());
                cbMaDuAn.DataSource = dt;
                cbMaDuAn.ValueMember = "MaDuAn";
                cbMaDuAn.DisplayMember = "TenDuAn";
            }
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

        private void dgvHDGK_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvHDGK.SelectedRows[0];
                cbMaHD.SelectedValue = dr.Cells["MaHopDong"].Value.ToString();
                cbMaDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLapHDGK"].Value.ToString();
                dtNgayKy.Text = dr.Cells["NgayKyDuyetHDGK"].Value.ToString();
                tbMaHopDongGiaoKhoan.Text = dr.Cells["MaHopDongGK"].Value.ToString();
                tbKinhPhi.Text = dr.Cells["KinhPhi"].Value.ToString();
                cbMaDonVi.SelectedValue = dr.Cells["MaDonVi"].Value.ToString();
                if (dr.Cells["NoiDungHopDongGK"].Value.ToString() == null)
                {
                    linkFile.Text = "No File Select.";
                }
                linkFile.Text = dr.Cells["NoiDungHopDongGK"].Value.ToString();
            }
            catch (Exception ex)
            {

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
    }
}
