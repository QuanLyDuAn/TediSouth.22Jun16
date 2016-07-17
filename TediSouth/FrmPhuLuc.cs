using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TediSouth
{
    public partial class FrmPhuLuc : Form
    {
        public string ID;
        public FrmPhuLuc()
        {
            InitializeComponent();
        }
        private void FrmPhuLuc_Load(object sender, EventArgs e)
        {
            LoadCbHopDong();
            LoadDGV();
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

        private void dgvhopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvPhuLucHopDong.SelectedRows[0];
                tbmaphuluc.Text = dr.Cells["MaPhuLuc"].Value.ToString();
                cbmahopdong.SelectedValue = dr.Cells["MaHopDong"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                linkFile.Text = dr.Cells["NoiDung"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reload();
            LoadDGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbmahopdong.Text == "" || tbmaphuluc.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            PhuLuc bp = new PhuLuc();
            bp.MaPhuLuc = tbmaphuluc.Text;
            if (PhuLuc_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbmahopdong.Text == "" || tbmaphuluc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            PhuLuc bp = new PhuLuc();
            bp.MaPhuLuc = tbmaphuluc.Text;
            bp.MaHopDong = cbmahopdong.SelectedValue.ToString();
            bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
            bp.NoiDung = "D:/hồsơtổnghợp/HDDuAn/PhuLuc" + open.SafeFileName;
            string sourcefolder = linkFile.Text;
            string destfolder = "D:/hồsơtổnghợp/HDDuAn/PhuLuc";
            CoppyFile(sourcefolder, destfolder);
            if (PhuLuc_BUS.Update(bp) == true)
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbmahopdong.Text == "" || tbmaphuluc.Text == "" || linkFile.Text == "No File Select.")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                PhuLuc bp = new PhuLuc();
                bp.MaPhuLuc = tbmaphuluc.Text;
                bp.MaHopDong = cbmahopdong.SelectedValue.ToString();
                bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.NoiDung = "D:/hồsơtổnghợp/HDDuAn/PhuLuc" + open.SafeFileName;
                if (PhuLuc_BUS.KiemTra(tbmaphuluc.Text) == false)
                {
                    PhuLuc_BUS.Insert(bp);
                    string sourcefolder = linkFile.Text;
                    string destfolder = "D:/hồsơtổnghợp/HDDuAn/PhuLuc";
                    CoppyFile(sourcefolder, destfolder);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDGV();
                    Reload();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }
        public void Reload()
        {
            linkFile.Text = "No File Select.";
            cbmahopdong.Text = null;
            tbmaphuluc.Clear();
            tbTimKiem.Text = "Vui lòng nhập thông tin để tìm kiếm...";
        }
        public void LoadDGV()
        {
            DataTable dt = new DataTable();
            if (ID == "admin")
            {
                dt = PhuLuc_BUS.LoadPL();
            }
            else
            {
                dt = PhuLuc_BUS.LoadPL_ID(ID);
            }
            dgvPhuLucHopDong.DataSource = dt;

            dgvPhuLucHopDong.Columns["MaHopDong"].HeaderText = "Hợp Đồng";
            dgvPhuLucHopDong.Columns["MaPhuLuc"].HeaderText = "Phụ Lục";
            dgvPhuLucHopDong.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvPhuLucHopDong.Columns["NoiDung"].HeaderText = "Nội Dung";
        }
        public void LoadCbHopDong()
        {
            if (ID == "admin")
            {
                cbmahopdong.DataSource = DBConnect.TaoBang("select * from HopDong");
            }
            else
            {
                cbmahopdong.DataSource = DBConnect.TaoBang("select a.* from HopDong a, HopDongGiaoKhoan b where a.MaHopDong=b.MaHopDong and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "')");
            }
            cbmahopdong.DisplayMember = "MaDuAn";
            cbmahopdong.ValueMember = "MaHopDong";
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
                    dt = PhuLuc_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
                }
                else
                {
                    dt = PhuLuc_BUS.LoadTimKiemTheoID(ID, tbTimKiem.Text);
                }
                dgvPhuLucHopDong.DataSource = dt;
            }
        }

        private void linkFile_Click(object sender, EventArgs e)
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

        private void dgvPhuLucHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvPhuLucHopDong.SelectedRows[0];
                tbmaphuluc.Text = dr.Cells["MaPhuLuc"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                cbmahopdong.SelectedValue = dr.Cells["MaHopDong"].Value.ToString();
                linkFile.Text = dr.Cells["NoiDung"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
