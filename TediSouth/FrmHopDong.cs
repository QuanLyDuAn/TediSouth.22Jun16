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
    public partial class FrmHopDong : Form
    {
        DataTable dt ;
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public FrmHopDong()
        {
            InitializeComponent();
            Reload();
            LoadDGV();
            LoadCbDuAn();
            AutoDuAn();
        }
        public void Reload()
        {
            linkFile.Text="No File Select.";
            cbbDuAn.Text =null  ;
            tbMaHopDong.Clear();
            tbTimKiem.Text= "Nhập Mã Hợp Đồng hoặc Mã Dự Án Để Tìm...";

        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = HopDong_BUS.LoadHD();
            dgvhopDong.DataSource = dt;

            dgvhopDong.Columns["MaHopDong"].HeaderText = "Hợp Đồng";
            dgvhopDong.Columns["MaDuAn"].HeaderText = "Dự Án";
            dgvhopDong.Columns["NgayLapHD"].HeaderText = "Ngày Lập";
            dgvhopDong.Columns["NgayKyHD"].HeaderText = "Ngày Ký";
            dgvhopDong.Columns["NoiDungHopDong"].HeaderText = "Nội Dung";
        }
        public void LoadCbDuAn()
        {
            cbbDuAn.DataSource = DBConnect.TaoBang("Select * from DuAn");
            cbbDuAn.DisplayMember = "TenDuAn";
            cbbDuAn.ValueMember = "MaDuAn";
        }
        public void AutoDuAn()
        {
            //Đang suy nghĩ chọn mã hay tên cho hợp lý
            SqlCommand cmd = new SqlCommand("Select MaDuAn from DuAn", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            cbbDuAn.AutoCompleteCustomSource = collection;
            con.Close();
        }

        private void click_Add(object sender, EventArgs e)
        {
            if ( cbbDuAn.Text == "" || tbMaHopDong.Text == ""||linkFile.Text=="No File Select." )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                HopDong bp = new HopDong();
                bp.MaHopDong = tbMaHopDong.Text;
                bp.MaDuAn = cbbDuAn.SelectedValue.ToString();
                bp.NgayLapHD =Convert.ToDateTime( dtNgayLap.Value.ToString());
                bp.NgayKyHD =Convert.ToDateTime( dtNgayKy.Value.ToString());
                bp.NoiDungHD = "D:/hồsơtổnghợp/HDDuAn/"+open.SafeFileName;
                if (HopDong_BUS.KiemTra(tbMaHopDong.Text) == false)
                {
                    HopDong_BUS.Insert(bp);
                    string sourcefolder = linkFile.Text;
                    string destfolder = "D:/hồsơtổnghợp/HDDuAn";
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

        private void click_Update(object sender, EventArgs e)
        {
            if ( cbbDuAn.Text == "" || tbMaHopDong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            HopDong bp = new HopDong();
            bp.MaHopDong = tbMaHopDong.Text;
            bp.MaDuAn = cbbDuAn.SelectedValue.ToString();
            bp.NgayLapHD = Convert.ToDateTime(dtNgayLap.Value.ToString());
            bp.NgayKyHD = Convert.ToDateTime(dtNgayKy.Value.ToString());
            bp.NoiDungHD = "D:/hồsơtổnghợp/HDDuAn/" + open.SafeFileName;
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

        private void click_Delete(object sender, EventArgs e)
        {
            if ( cbbDuAn.Text == "" || tbMaHopDong.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            HopDong bp = new HopDong();
            bp.MaHopDong = tbMaHopDong.Text;
            if (HopDong_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvhopDong.SelectedRows[0];
                tbMaHopDong.Text = dr.Cells["MaHopDong"].Value.ToString();
                cbbDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLapHD"].Value.ToString();
                dtNgayKy.Text = dr.Cells["NgayKyHD"].Value.ToString();
                linkFile.Text = dr.Cells["NoiDungHopDong"].Value.ToString();
            }
            catch (Exception ex)
            {

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HopDong_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
            dgvhopDong.DataSource = dt;
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }
    }
}
