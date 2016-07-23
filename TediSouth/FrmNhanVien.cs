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
    public partial class FrmNhanVien : Form
    {

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public string ID;
        
        public FrmNhanVien()
        {
            InitializeComponent();

        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            //LoadBoPhan(cbdonvi.SelectedValue.ToString());
            LoadDonVi();
            LoadBoPhan(cbdonvi.SelectedValue.ToString());
            LoadDGV();
        }
        public void Reload()
        {
            tbEmail.Clear();
            tbDiaChi.Clear();
            tbhoten.Clear();
            tbmanv.Clear();
            tbSDT1.Clear();
            tbTimKiem.Text = "Nhập ID hoặc tên nhân viên để tìm kiếm...";
            pbHinhAnh.Image = null;
            txtHinhAnhPath.Clear();
        }
        public void LoadDGV()
        {
            DataTable dt = new DataTable();
            if (ID == "admin")
            {
                dt = NhanVien_BUS.LoadNV();
            }
            else
            {
                dt = NhanVien_BUS.LoadNV_ID(ID);
            }
            dgvNhanVien.DataSource = dt;
            //chinh sua column
            dgvNhanVien.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["MaDonVi"].HeaderText = "Mã Đơn Vị";
            dgvNhanVien.Columns["MaBoPhan"].HeaderText = "Mã Bộ Phận";
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["Email"].HeaderText = "Email";
            dgvNhanVien.Columns["DienThoaiNhanVien"].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            dgvNhanVien.Columns["HinhAnh"].ValueType = typeof(Image);
            DataGridViewImageColumn dc = dgvNhanVien.Columns["HinhAnh"] as DataGridViewImageColumn;
            dc.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        public void LoadDonVi()
        {
            if (ID == "admin")
            {
                cbdonvi.DataSource = DBConnect.TaoBang("select * from DonVi");
            }
            else
            {
                cbdonvi.DataSource = DBConnect.TaoBang("select * from DonVi where MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "')");
                cbdonvi.Enabled = false;
            }
            cbdonvi.DisplayMember = "TenDonVi";
            cbdonvi.ValueMember = "MaDonVi";

        }
        public void LoadBoPhan(string ma)
        {
            if (ma == "")
                cbBoPhan.Enabled = false;
            else
            {
                string lenh = string.Format("select b.MaBoPhan,TenBoPhan from  ChiTietDonVi c, BoPhan b where  c.MaBoPhan = b.MaBoPhan and MaDonVi ='{0}'", ma);
                cbBoPhan.DataSource = DBConnect.TaoBang(lenh);
                cbBoPhan.DisplayMember = "TenBoPhan";
                cbBoPhan.ValueMember = "MaBoPhan";
            }
        }

        private void click_Add(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text == "" || tbDiaChi.Text == "" || tbhoten.Text == "" || tbmanv.Text == "" || tbSDT1.Text == "" || txtHinhAnhPath.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                    return;
                }
                else
                {
                    NhanVien nv = new NhanVien();
                    nv.IDNhanVien = tbmanv.Text;
                    nv.MaDonVi = cbdonvi.SelectedValue.ToString();
                    nv.MaBoPhan = cbBoPhan.SelectedValue.ToString();
                    nv.NgaySinh = DateTime.Parse(dtngaysinh.Text);
                    nv.HoTen = tbhoten.Text;
                    nv.Email = tbDiaChi.Text;
                    nv.DienThoaiNhanVien = tbSDT1.Text;
                    nv.DiaChi = tbEmail.Text;
                    nv.HinhAnh = ConvertToByte();
                    if (NhanVien_BUS.KiemTra(tbmanv.Text) == false)
                    {
                        NhanVien_BUS.Insert(nv);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDGV();
                        Reload();
                        return;
                    }
                    else
                        MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm Thất Bại", "Thông Báo");
            }
        }
        private byte[] ConvertToByte()
        {
            FileStream fs;
            fs = new FileStream(txtHinhAnhPath.Text, FileMode.Open, FileAccess.Read);

            byte[] picByte = new byte[fs.Length];
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picByte;
        }
        private void click_Update(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbDiaChi.Text == "" || tbhoten.Text == "" || tbmanv.Text == "" || tbSDT1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            NhanVien nv = new NhanVien();
            nv.IDNhanVien = tbmanv.Text;
            nv.MaDonVi = cbdonvi.SelectedValue.ToString();
            nv.MaBoPhan = cbBoPhan.SelectedValue.ToString();
            nv.NgaySinh = DateTime.Parse(dtngaysinh.Text);
            nv.HoTen = tbhoten.Text;
            nv.Email = tbDiaChi.Text;
            nv.DienThoaiNhanVien = tbSDT1.Text;
            nv.DiaChi = tbEmail.Text;

            if (txtHinhAnhPath.Text == "")
            {
                
                if (NhanVien_BUS.UpdateKhongHinh(nv) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    LoadDGV();
                    Reload();
                    return;
                }
                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
            }
            else
            {
                nv.HinhAnh = ConvertToByte();
                if (NhanVien_BUS.Update(nv) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    LoadDGV();
                    Reload();
                    return;
                }
                MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");

            }
        }

        private void click_Delete(object sender, EventArgs e)
        {
            if (tbmanv.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Nhân Viên Cần Xóa", "Thông báo");
                return;
            }
            NhanVien bp = new NhanVien();
            bp.IDNhanVien = tbmanv.Text;
            if (NhanVien_BUS.Delete(bp) == true)
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
            LoadDonVi();
            //LoadBoPhan(cbdonvi.SelectedValue.ToString());
        }

        //ImageConverter objImageConverter = new ImageConverter();
        //pbHinhAnh.Image = (Image)objImageConverter.ConvertFrom(objGamePcRow.PicGame);
        //picAnhGame.SizeMode = PictureBoxSizeMode.StretchImage;

        private void cbdonvi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdonvi.SelectedValue != null && !(cbdonvi.SelectedValue is DataRowView))
            {
                DataTable dt = new DataTable();
                //string ketnoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
                //string sTruyVan = string.Format("select b.MaBoPhan,TenBoPhan from  ChiTietDonVi c, BoPhan b where  c.MaBoPhan = b.MaBoPhan and MaDonVi ='{0}'", cbDonVi.SelectedValue);
                //SqlDataAdapter da = new SqlDataAdapter(sTruyVan, ketnoi);
                //da.Fill(dt);   
                dt = NhanVien_BUS.LoadBPTheoDV(cbdonvi.SelectedValue.ToString());
                cbBoPhan.DataSource = dt;
                cbBoPhan.ValueMember = "MaBoPhan";
                cbBoPhan.DisplayMember = "TenBoPhan";
            }
        }
        OpenFileDialog open;
        private void AddHinhAnh_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "C:";
            DialogResult Result = open.ShowDialog();
            if (Result == DialogResult.OK)
            {
                pbHinhAnh.Image = Image.FromStream(open.OpenFile());
                txtHinhAnhPath.Text = open.FileName;

            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
                tbmanv.Text = dr.Cells["IDNhanVien"].Value.ToString();
                cbdonvi.SelectedValue = dr.Cells["MaDonVi"].Value.ToString();
                cbBoPhan.Text = dr.Cells["MaBoPhan"].Value.ToString();
                dtngaysinh.Text = dr.Cells["NgaySinh"].Value.ToString();
                tbhoten.Text = dr.Cells["HoTen"].Value.ToString();
                tbDiaChi.Text = dr.Cells["Email"].Value.ToString();
                tbSDT1.Text = dr.Cells["DienThoaiNhanVien"].Value.ToString();
                tbEmail.Text = dr.Cells["DiaChi"].Value.ToString();
                
                //Convert hình ảnh đổ vào picBox
                ImageConverter objImageConverter = new ImageConverter();
                try
                {
                    Image im = (Image)objImageConverter.ConvertFrom(dr.Cells["HinhAnh"].Value);
                    pbHinhAnh.Image = im;
                    pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    pbHinhAnh.Image = null;
                    MessageBox.Show("Không Có Hình Ảnh", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void QDChucVu_Click(object sender, EventArgs e)
        {
            if (tbmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo");
            }
            else
            {
                FrmChucVuNhanVien fm = new FrmChucVuNhanVien();
                fm.Sender(tbmanv.Text);
                fm.Show();
            }
        }
        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
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
                    dt = NhanVien_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
                }
                else
                {
                    dt = NhanVien_BUS.LoadTimKiemTheoID(ID, tbTimKiem.Text);
                }
                dgvNhanVien.DataSource = dt;
            }

        }

        private void tbSDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Ký tự Alphabe
               char.IsSymbol(e.KeyChar) || //Ký tự đặc biệt
               char.IsWhiteSpace(e.KeyChar) || //Khoảng cách
               char.IsPunctuation(e.KeyChar)) //Dấu chấm                
            {
                e.Handled = true; //Không cho thể hiện lên TextBox
                MessageBox.Show("Vui lòng nhập số", "Thông báo");
                tbSDT1.Clear();
            }
        }
    }
}
