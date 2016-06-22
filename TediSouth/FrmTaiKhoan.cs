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
    public partial class FrmTaiKhoan : Form
    {
        DataTable dt;
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }


        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDgvTK();
            LoadCbVN();
        }
        public void LoadDgvTK()
        {
            dt = new DataTable();
            dt = TaiKhoan_BUS.LoadTK();
            dgvTaiKhoan.DataSource = dt;
            dgvTaiKhoan.Columns["Name"].HeaderText = "Tên Tài Khoản";
            dgvTaiKhoan.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvTaiKhoan.Columns["Pass"].HeaderText = "Mật Khẩu";
            dgvTaiKhoan.Columns["HoatDong"].HeaderText = "Còn Hoạt Động";
            DataGridViewCheckBoxColumn ck = dgvTaiKhoan.Columns["HoatDong"] as DataGridViewCheckBoxColumn;

        }
        public void LoadCbVN()
        {
            dt = new DataTable();
            dt = DBConnect.TaoBang("Select IDNhanVien from NhanVien "); //where IdNhanVien not in (Select IdNhanVien from TaiKhoan)
            cbMaNV.DataSource = dt;
            cbMaNV.ValueMember = "IDNhanVien";
            cbMaNV.DisplayMember = "IDNhanVien";
        }
        public void ReLoad()
        {
            LoadCbVN();
            tbTaiKhoan.Clear();
            tbMatKhau.Clear();
            ckHoatDong.Checked = false;
            tbTaiKhoan.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "" || tbTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                TaiKhoan bp = new TaiKhoan();
                bp.Name = tbTaiKhoan.Text;
                bp.Pass = tbMatKhau.Text;
                bp.IDNhanVien = cbMaNV.SelectedValue.ToString();
                if (ckHoatDong.Checked == true)
                {
                    bp.HoatDong = true;
                }
                else
                {
                    bp.HoatDong = false;
                }
                if (TaiKhoan_BUS.KiemTra(tbTaiKhoan.Text) == false)
                {
                    TaiKhoan_BUS.Insert(bp);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDgvTK();
                    ReLoad();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }        
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            if (cbMaNV.SelectedValue != null && !(cbMaNV.SelectedValue is DataRowView))
            {
                dt = DBConnect.TaoBang("Select HoTen,TenDonVi from NhanVien a,DonVi b where a.MaDonVi=b.MaDonVi and IDNhanVien='" + cbMaNV.SelectedValue.ToString() + "'");
                DataRow dr = dt.Rows[0];
                lbTen.Text = dr["HoTen"].ToString();
                lbDonVi.Text = dr["TenDonVi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "" || tbTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                TaiKhoan bp = new TaiKhoan();
                bp.Name = tbTaiKhoan.Text;
                bp.Pass = tbMatKhau.Text;
                bp.IDNhanVien = cbMaNV.SelectedValue.ToString();
                if (ckHoatDong.Checked == true)
                {
                    bp.HoatDong = true;
                }
                else
                {
                    bp.HoatDong = false;
                }
                if (TaiKhoan_BUS.Update(bp) == true)
                {

                    MessageBox.Show("Lưu Thành Công", "Thông Báo");
                    LoadDgvTK();
                    ReLoad();
                    return;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Text == "" || tbTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            TaiKhoan bp = new TaiKhoan();
            bp.Name = tbTaiKhoan.Text;
            if (TaiKhoan_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDgvTK();
                ReLoad();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDgvTK();
            ReLoad();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvTaiKhoan.SelectedRows[0];
                tbTaiKhoan.Text = dr.Cells["Name"].Value.ToString();
                tbTaiKhoan.Enabled = false;
                tbMatKhau.Text = dr.Cells["Pass"].Value.ToString();
                cbMaNV.SelectedValue = dr.Cells["IDNhanVien"].Value.ToString();
                bool ck = bool.Parse(dr.Cells["HoatDong"].Value.ToString());
                if (ck == true)
                {
                    ckHoatDong.Checked = true;
                }
                else
                {
                    ckHoatDong.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    if (e.Value != null)
                    {
                        e.Value = new string('*', e.Value.ToString().Length);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvTaiKhoan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.CurrentCell.ColumnIndex == 1)//select target column
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                    {
                        textBox.PasswordChar = '*';
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
