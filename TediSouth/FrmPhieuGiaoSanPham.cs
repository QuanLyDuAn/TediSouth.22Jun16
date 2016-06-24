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
using System.IO;

namespace TediSouth
{
    public partial class FrmPhieuGiaoSanPham : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public string ID;
        public FrmPhieuGiaoSanPham()
        {
            InitializeComponent();
        }
        private void FrmPhieuGiaoSanPham_Load(object sender, EventArgs e)
        {
            LoadDgvPhieuGiao();
            LoadCbDA();
        }
        private void LoadDgvPhieuGiao()
        {
            if (ID == "admin")
            {
                dt = PhieuGiaoSanPham_BUS.LoadPGSP();
            }
            else
            {
                dt = PhieuGiaoSanPham_BUS.LoadPGSP_ID(ID);
            }
            dgvPhieuGiao.DataSource = dt;
            dgvPhieuGiao.Columns["IDPhieuGiao"].HeaderText = "Mã Phiếu Giao";
            dgvPhieuGiao.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            dgvPhieuGiao.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvPhieuGiao.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dgvPhieuGiao.Columns["NoiDungPhieuGiao"].HeaderText = "Nội Dung";
            dgvPhieuGiao.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvPhieuGiao.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvPhieuGiao.Columns["DuyetHoSo"].HeaderText = "Đã Duyệt";
            DataGridViewCheckBoxColumn ck = dgvPhieuGiao.Columns["DuyetHoSo"] as DataGridViewCheckBoxColumn;
           
        }
        private void LoadCbDA()
        {
            if (ID == "admin")
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select * from DuAn");
            }
            else
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select a.* from DuAn a, HopDongGiaoKhoan b where a.MaDuAn=b.MaDuAn and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "')");
            }
            cbDuAn.ValueMember = "MaDuAn";
            cbDuAn.DisplayMember = "TenDuAn";
        }
        private void LoadNVTheoDA()
        {
            cbNhanVien.DataSource = DBConnect.TaoBang("  select a.IDNhanVien,HoTen,MaChucVu from NhanVien a, DonVi d, HopDongGiaoKhoan e,QuyetDinhCongViec b where	 a.MaDonVi=d.MaDonVi and e.MaDonVi=d.MaDonVi and b.IDNhanVien=a.IDNhanVien and  e.MaDuAn='TVKT-CLSV' and (MaChucVu='GD' or MaChucVu='TP'or MaChucVu='PP')");
            cbNhanVien.DisplayMember = "IDNhanVien";
            cbNhanVien.ValueMember = "IDNhanVien";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbPhieuGiao.Text == "" || cbDuAn.SelectedValue == null || tbSoLuong.Text == ""||tbTieuDe.Text==""||LinkFile.Text== "No file Select .")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                PhieuGiaoSanPham bp = new PhieuGiaoSanPham();
                bp.IDPhieuGiao = tbPhieuGiao.Text;
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.IDNhanVien = cbNhanVien.SelectedValue.ToString();
                bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.TieuDe = tbTieuDe.Text;
                bp.NoiDungPhieuGiao = "D:/HồSơTổngHợp/SanPham/" + open.SafeFileName;
                bp.SoLuong = int.Parse(tbSoLuong.Text);
                if (ckOk.Checked == true)
                {
                    bp.DuyetHoSo = true;
                }
                else {
                    bp.DuyetHoSo = false;
                }
                if (PhieuGiaoSanPham_BUS.KiemTra(tbPhieuGiao.Text) == false)
                {
                    PhieuGiaoSanPham_BUS.Insert(bp);
                    string SourceFolder = LinkFile.Text;
                    string DestFolder = "D:/HồSơTổngHợp/SanPham";
                    CoppyFile(SourceFolder, DestFolder);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDgvPhieuGiao();
                    ReLoad();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbPhieuGiao.Text == "" || cbDuAn.SelectedValue == null || tbSoLuong.Text == "" || tbTieuDe.Text == "" || LinkFile.Text == "No Select file.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                PhieuGiaoSanPham bp = new PhieuGiaoSanPham();
                bp.IDPhieuGiao = tbPhieuGiao.Text;
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.IDNhanVien = cbNhanVien.SelectedValue.ToString();
                bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.TieuDe = tbTieuDe.Text;
                bp.NoiDungPhieuGiao = "D:/HồSơTổngHợp/SanPham/" + open.SafeFileName;
                bp.SoLuong = int.Parse(tbSoLuong.Text);
                if (ckOk.Checked == true)
                {
                    bp.DuyetHoSo = true;
                }
                else
                {
                    bp.DuyetHoSo = false;
                }
                string SourceFolder = LinkFile.Text;
                string DestFolder = "D:/HồSơTổngHợp/SanPham";
                CoppyFile(SourceFolder, DestFolder);
                if (PhieuGiaoSanPham_BUS.Update(bp) == true)
                {
                    MessageBox.Show("Sửa Thành Công", "Thông Báo");
                    LoadDgvPhieuGiao();
                    ReLoad();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo");

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbPhieuGiao.Text == "" || cbDuAn.SelectedValue == null || tbSoLuong.Text == "" || tbTieuDe.Text == "" || LinkFile.Text == "No Select file.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                PhieuGiaoSanPham bp = new PhieuGiaoSanPham();
                bp.IDPhieuGiao = tbPhieuGiao.Text;
                if(PhieuGiaoSanPham_BUS.Delete(bp)==true)
                {
                    MessageBox.Show("Xóa Thành Công","Thông Báo");
                    LoadDgvPhieuGiao();
                    ReLoad();
                }
                else
                MessageBox.Show("Xóa Thất Bại", "Thông Báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReLoad();
            LoadDgvPhieuGiao();
        }
        private void ReLoad()
        {
            tbPhieuGiao.Clear();
            tbTieuDe.Clear();
            tbSoLuong.Clear();
            LinkFile.Text = "No file select.";
            tbTimKiem.Text = "Vui lòng nhập thông tin để tìm kiếm...";
        }
        private void cbDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDA = cbDuAn.SelectedValue.ToString();
            string sTruyVan = string.Format("select a.IDNhanVien,HoTen,MaChucVu from NhanVien a, DonVi d, HopDongGiaoKhoan e,QuyetDinhCongViec b where	 a.MaDonVi=d.MaDonVi and e.MaDonVi=d.MaDonVi and b.IDNhanVien=a.IDNhanVien and  e.MaDuAn='{0}' and (MaChucVu='GD' or MaChucVu='TP'or MaChucVu='PP')", maDA);
            cbNhanVien.DataSource = DBConnect.TaoBang(sTruyVan);
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "IDNhanVien";
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            //lbTen.Text = cbNhanVien.SelectedValue.ToString();
            dt= PhieuGiaoSanPham_BUS.LoadLabel(cbNhanVien.SelectedValue.ToString());
            DataRow dr = dt.Rows[0];
            lbChucVu.Text = dr["MaChucVu"].ToString();
            lbDonVi.Text = dr["TenDonVi"].ToString();

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
        OpenFileDialog open = new  OpenFileDialog();
        private void btnDuyetFile_Click(object sender, EventArgs e)
        {
            open.InitialDirectory = "C:";
            DialogResult Result = open.ShowDialog();
            if (Result == DialogResult.OK)
            {
                LinkFile.Text = open.FileName;
            }
        }

        private void dgvPhieuGiao_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvPhieuGiao.SelectedRows[0];
                tbPhieuGiao.Text = dr.Cells["IDPhieuGiao"].Value.ToString();
                cbDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                cbNhanVien.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                tbSoLuong.Text = dr.Cells["Soluong"].Value.ToString();
                tbTieuDe.Text = dr.Cells["TieuDe"].Value.ToString();
                LinkFile.Text = dr.Cells["NoiDungPhieuGiao"].Value.ToString();
                bool ck = bool.Parse(dr.Cells["DuyetHoSo"].Value.ToString());
                if (ck == true)
                {
                    ckOk.Checked = true;
                    return;
                }
                ckOk.Checked = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LinkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = LinkFile.Text;
            try
            {
                System.Diagnostics.Process.Start(txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (tbTimKiem.Text == "")
            {
                dt = null;
            }
            else
            {
                if (ID == "admin")
                {
                    dt = PhieuGiaoSanPham_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
                }
                else
                {
                    dt = PhieuGiaoSanPham_BUS.LoadTimKiemTheoID(ID, tbTimKiem.Text);
                }
                dgvPhieuGiao.DataSource = dt;
            }
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }
    }
}
