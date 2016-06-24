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
        public FrmPhuLuc()
        {
            InitializeComponent();
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
                DataGridViewRow dr = dgvhopDong.SelectedRows[0];
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
            bp.NoiDung = "D:/hồsơtổnghợp/HDDuAn/" + open.SafeFileName;
            string sourcefolder = linkFile.Text;
            string destfolder = "D:/hồsơtổnghợp/HDDuAn";
            CoppyFile(sourcefolder, destfolder);
            if (HopDong_BUS.Update(bp) == true)
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
                bp.NoiDung = "D:/hồsơtổnghợp/HDDuAn/" + open.SafeFileName;
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
            tbTimKiem.Clear();

        }
        public void LoadDGV()
        {
            DataTable dt = new DataTable();
            dt = new DataTable();
            dt = PhuLuc_BUS.LoadPhuLuc();
            dgvhopDong.DataSource = dt;

            dgvhopDong.Columns["MaHopDong"].HeaderText = "Hợp Đồng";
            dgvhopDong.Columns["MaPhuLuc"].HeaderText = "Phụ Lục";
            dgvhopDong.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvhopDong.Columns["NoiDung"].HeaderText = "Nội Dung";
        }
        public void LoadCbDuAn()
        {
            cbmahopdong.DataSource = DBConnect.TaoBang("Select * from HopDong");
            cbmahopdong.DisplayMember = "MaHopDong";
            cbmahopdong.ValueMember = "MaHopDong";
        }
    }
}
