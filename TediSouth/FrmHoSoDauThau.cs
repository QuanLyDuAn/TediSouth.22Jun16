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
    public partial class FrmHoSoDauThau : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public string ID;           
        public FrmHoSoDauThau()
        {
            InitializeComponent();           
        }
        private void FrmHoSoDauThau_Load(object sender, EventArgs e)
        {
            Reload();
            LoadDGV();
            LoadCbDoVi();
            LoadCbDuAn();
            AutoDA();
            AutoDV();
        }

        public void Reload()
        {

            dtngaylap.Value = DateTime.Now;
            tbMucGia.Clear();
            LinkFile.Text = "No file select.";
            tbTimKiem.Text= "Nhập Mã Đơn Vị hoặc Mã Dự Án để tìm...";
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            if (ID == "admin")
            {
                dt = HoSoDuThau_BUS.LoadHSDT();
            }
            else
            {
                dt = HoSoDuThau_BUS.LoadHSDT_ID(ID);
            }
            dgvHSDT.DataSource = dt;

            dgvHSDT.Columns["MaDonVi"].HeaderText = "Đơn Vị";
            dgvHSDT.Columns["MaDuAn"].HeaderText = "Dự Án";
            dgvHSDT.Columns["NgayLapHoSoDauThau"].HeaderText = "Ngày Lập";
            dgvHSDT.Columns["MucGiaBoThau"].HeaderText = "Mức giá";
            dgvHSDT.Columns["HoSoDauThau"].HeaderText = "Hồ Sơ";
        }
        public void AutoDV()
        {
            //Đang suy nghĩ chọn mã hay tên cho hợp lý
            SqlCommand cmd = new SqlCommand("Select MaDonVi from DonVi", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            cbDonVi.AutoCompleteCustomSource = collection;
            con.Close();
        }
        public void AutoDA()
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
            cbDuAn.AutoCompleteCustomSource = collection;
            con.Close();
        }
        public void LoadCbDoVi()
        {
            if (ID == "admin")
            {
                cbDonVi.DataSource = DBConnect.TaoBang("Select * from DonVi");
            }
            else
            {
                cbDonVi.DataSource = DBConnect.TaoBang("Select a.* from DonVi a, NhanVien b where a.MaDonVi=b.MaDonVi and IDNhanVien='" + ID + "'");
            }
            cbDonVi.ValueMember = "MaDonVi";
            cbDonVi.DisplayMember = "TenDonVi";
        }
        public void LoadCbDuAn()
        {
            cbDuAn.DataSource = DBConnect.TaoBang("Select * from DuAn");
            cbDuAn.ValueMember = "MaDuAn";
            cbDuAn.DisplayMember = "TenDuAn";
        }
        private void click_Add(object sender, EventArgs e)
        {
            if (tbMucGia.Text == "" || cbDuAn.SelectedValue == null || cbDonVi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                HoSoDuThau bp = new HoSoDuThau();
                bp.MaDonVi = cbDonVi.SelectedValue.ToString();
                bp.MaDuAn = cbDuAn.SelectedValue.ToString();
                bp.NgayLapHoSoDauThau = Convert.ToDateTime(dtngaylap.Value.ToString());
                bp.MucGiaBoThau = Convert.ToDouble(tbMucGia.Text);
                bp.HoSoDauThau = "D:/HồSơTổngHợp/HSDauThau/" + open.SafeFileName;
                if (HoSoDuThau_BUS.KiemTra(cbDonVi.SelectedValue.ToString(), cbDuAn.SelectedValue.ToString()) == false)
                {
                    HoSoDuThau_BUS.Insert(bp);
                    string SourceFolder = LinkFile.Text;
                    string DestFolder = "D:/HồSơTổngHợp/HSDauThau";
                    CoppyFile(SourceFolder, DestFolder);
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
            if (tbMucGia.Text == "" || cbDuAn.SelectedValue == null || cbDonVi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            HoSoDuThau bp = new HoSoDuThau();
            bp.MaDonVi = cbDonVi.SelectedValue.ToString();
            bp.MaDuAn = cbDuAn.SelectedValue.ToString();
            bp.NgayLapHoSoDauThau = Convert.ToDateTime(dtngaylap.Value.ToString());
            bp.MucGiaBoThau = Convert.ToDouble(tbMucGia.Text);
            bp.HoSoDauThau = "D:/HồSơTổngHợp/HSDauThau/" + open.SafeFileName;
            string SourceFolder = LinkFile.Text;
            string DestFolder = "D:/HồSơTổngHợp/HSDauThau";
            CoppyFile(SourceFolder, DestFolder);
            if (HoSoDuThau_BUS.Update(bp) == true)
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
            if (tbMucGia.Text == "" || cbDuAn.SelectedValue == null || cbDonVi.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            HoSoDuThau bp = new HoSoDuThau();
            bp.MaDonVi = cbDonVi.SelectedValue.ToString();
            bp.MaDuAn = cbDuAn.SelectedValue.ToString();
            if (HoSoDuThau_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvHSDT.SelectedRows[0];
                cbDonVi.SelectedValue = dr.Cells["MaDonVi"].Value.ToString();
                cbDuAn.SelectedValue = dr.Cells["MaDuAn"].Value.ToString();
                dtngaylap.Text = dr.Cells["NgayLapHoSoDauThau"].Value.ToString();
                tbMucGia.Text = dr.Cells["MucGiaBoThau"].Value.ToString();
                LinkFile.Text = dr.Cells["HoSoDauThau"].Value.ToString();
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
                LinkFile.Text = open.FileName;
            }
        }

        //private void btnLuuFile_Click(object sender, EventArgs e)
        //{
        //    //string TMDich = "D:/HồSơTổngHợp/HSDauThau";
        //    //CoppyFile(LinkFile.Text,TMDich);
        //    string SourceFolder = LinkFile.Text;
        //    string DestFolder = "D:/HồSơTổngHợp/HSDauThau";
        //    CoppyFile(SourceFolder, DestFolder);
        //}
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

        //private void CoppyFile(string sourcePath, string targetPath)
        //{
        //    try
        //    {


        //        string sourceFile = System.IO.Path.Combine(sourcePath, open.FileName);
        //        string destFile = System.IO.Path.Combine(targetPath, open.FileName);

        //        // To copy a folder's contents to a new location:
        //        // Create a new target folder, if necessary.
        //        if (!System.IO.Directory.Exists(targetPath))
        //        {
        //            System.IO.Directory.CreateDirectory(targetPath);
        //        }

        //        // To copy a file to another location and 
        //        // overwrite the destination file if it already exists.
        //        System.IO.File.Copy(sourceFile, destFile, true);

        //        // To copy all the files in one directory to another directory.
        //        // Get the files in the source folder. (To recursively iterate through
        //        // all subfolders under the current directory, see
        //        // "How to: Iterate Through a Directory Tree.")
        //        // Note: Check for target path was performed previously
        //        //       in this code example.
        //        if (System.IO.Directory.Exists(sourcePath))
        //        {
        //            string[] files = System.IO.Directory.GetFiles(sourcePath);

        //            // Copy the files and overwrite destination files if they already exist.
        //            foreach (string s in files)
        //            {
        //                // Use static Path methods to extract only the file name from the path.
        //                open.FileName = System.IO.Path.GetFileName(s);
        //                destFile = System.IO.Path.Combine(targetPath, open.FileName);
        //                System.IO.File.Copy(s, destFile, true);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Source path does not exist!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
                    dt = HoSoDuThau_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
                }
                else
                {
                    dt = HoSoDuThau_BUS.LoadTimKiemTheoID(ID, tbTimKiem.Text);
                }
                dgvHSDT.DataSource = dt;
            }
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }
    }
}
