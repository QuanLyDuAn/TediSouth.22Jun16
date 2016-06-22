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
using System.IO;

namespace TediSouth
{
    public partial class FrmCongVan : Form
    {
        DataTable dt = new DataTable();
        public string ID;
        public FrmCongVan()
        {
            InitializeComponent();
            
        }
        private void FrmCongVan_Load(object sender, EventArgs e)
        {
            LoadCbDuAn();
            LoadLoaiCV();
            LoadDGV();
        }
        public void Reload()
        {
            tbMaCV.Clear();
            cbLoaiCV.Text="Đi";
            tbTieuDe.Clear();
            linkFile.Text="No File Select.";
            dtNgayLap.Value = DateTime.Now;
            tbTimKiem.Clear();
        }
        public void LoadLoaiCV()
        {
            cbLoaiCV.Items.Add("Đi");
            cbLoaiCV.Items.Add("Đến");
        }
       
        public void LoadCbDuAn()
        {
            if (ID == "admin")
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select * from DuAn");
            }
            else
            {
                cbDuAn.DataSource = DBConnect.TaoBang("select a.* from DuAn a, HopDongGiaoKhoan b where a.MaDuAn=b.MaDuAn and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "')");
            }
            cbDuAn.DisplayMember = "TenDuAn";
            cbDuAn.ValueMember = "MaDuAn";
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = CongVan_BUS.LoadCV();
            }
            else
            {
                dt = CongVan_BUS.LoadCV_ID(ID);
            }
            dgvCV.DataSource = dt;
            dgvCV.Columns["MaCongVan"].HeaderText = "Mã Công Văn";
            dgvCV.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            dgvCV.Columns["IDNhanVien"].HeaderText = "ID Nhân Viên";
            dgvCV.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            dgvCV.Columns["NgayLapCV"].HeaderText = "Ngày Lập Công Văn";
            dgvCV.Columns["NoiDung"].HeaderText = "Nội Dung";
            dgvCV.Columns["LoaiCV"].HeaderText = "Loại Công Văn";
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbMaCV.Text == "" || cbDuAn.Text == "" || linkFile.Text == "" || tbTieuDe.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                CongVan bp = new CongVan();
                bp.MaCongVan = tbMaCV.Text;
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.IDNhanVien = cbnhanvien.SelectedValue.ToString();
                bp.TieuDe = tbTieuDe.Text;
                bp.NgayLapCV=Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NoiDung = "D:hồsơtổnghợp/CongVan/"+open.SafeFileName;
                bp.LoaiCV = cbLoaiCV.Text;
                if (CongVan_BUS.KiemTra(tbMaCV.Text) == false)
                {
                    
                    if (linkFile.Text != "No File Select.")
                    {
                        string sourcefolder = linkFile.Text;
                        string destfolder = "D:/hồsơtổnghợp/CongVan";
                        CoppyFile(sourcefolder, destfolder);
                        CongVan_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDGV();
                        Reload();
                        return;
                    }
                    else
                    {

                        CongVan_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDGV();
                        Reload();
                        return;
                    }
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }

        private void click_Update(object sender, EventArgs e)
        {
            if (tbMaCV.Text == "" || cbDuAn.Text == "" || linkFile.Text == "" || tbTieuDe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            CongVan bp = new CongVan();
            bp.MaCongVan = tbMaCV.Text;
            bp.MaDuAn = cbDuAn.SelectedValue.ToString();
            bp.IDNhanVien = cbnhanvien.SelectedValue.ToString();
            bp.TieuDe = tbTieuDe.Text;
            bp.NgayLapCV = Convert.ToDateTime(dtNgayLap.Value.ToString());
            bp.NoiDung = "D:/hồsơtổnghợp/CongVan/" + open.SafeFileName;
            bp.LoaiCV = cbLoaiCV.Text;
            string sourcefolder = linkFile.Text;
            string destfolder = "D:hồsơtổnghợp/CongVan";
            CoppyFile(sourcefolder, destfolder);
            if (CongVan_BUS.Update(bp) == true)
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
            if (tbMaCV.Text == "" || cbDuAn.Text == "" || linkFile.Text == "" || tbTieuDe.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            CongVan bp = new CongVan();
            bp.MaCongVan = tbMaCV.Text;
            if (CongVan_BUS.Delete(bp) == true)
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

        private void click_Find(object sender, EventArgs e)
        {

        }

        private void click_cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvCV.SelectedRows[0];
                tbMaCV.Text = dr.Cells["MaCongVan"].Value.ToString();
                cbDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                cbnhanvien.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
                tbTieuDe.Text = dr.Cells["TieuDe"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLapCV"].Value.ToString();
                linkFile.Text = dr.Cells["NoiDung"].Value.ToString();
                cbLoaiCV.Text = dr.Cells["LoaiCV"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void cbDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDuAn.SelectedValue != null && !(cbDuAn.SelectedValue is DataRowView))
            {
                DataTable dt = new DataTable();  
                dt = CongVan_BUS.LoadNVTheoDA(cbDuAn.SelectedValue.ToString());
                cbnhanvien.DataSource = dt;
                cbnhanvien.ValueMember = "IDNhanVien";
                cbnhanvien.DisplayMember = "HoTen";
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
