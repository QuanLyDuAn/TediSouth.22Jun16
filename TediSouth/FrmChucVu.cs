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
namespace TediSouth
{
    public partial class FrmChucVu : Form
    {
        DataTable dt = new DataTable();
        public FrmChucVu()
        {
            InitializeComponent();

            LoadDGV();
        }
        public void Reload()
        {
            tbMaCV.Clear();
            tbTenCV.Clear();
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = ChucVu_BUS.LoadCV();
            dgvChucVu.DataSource = dt;

            dgvChucVu.Columns["MaChucVu"].HeaderText = "Chức Vụ";
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbMaCV.Text == "" || tbTenCV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                ChucVu bp = new ChucVu();
                bp.MaChucVu = tbMaCV.Text;
                bp.TenChucVu = tbTenCV.Text;
                if (ChucVu_BUS.KiemTra(tbMaCV.Text) == false)
                {
                    ChucVu_BUS.Insert(bp);
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
            if (tbMaCV.Text == "" || tbTenCV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            ChucVu bp = new ChucVu();
            bp.MaChucVu = tbMaCV.Text;
            bp.TenChucVu = tbTenCV.Text;
            if (ChucVu_BUS.Update(bp) == true)
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
            if (tbTenCV.Text == "" || tbMaCV.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            ChucVu bp = new ChucVu();
            bp.MaChucVu = tbMaCV.Text;
            if (ChucVu_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvChucVu.SelectedRows[0];
                tbMaCV.Text = dr.Cells["MaChucVu"].Value.ToString();
                tbTenCV.Text = dr.Cells["TenChucVu"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
