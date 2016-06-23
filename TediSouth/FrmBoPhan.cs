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
    public partial class FrmBoPhan : Form
    {
        DataTable dt = new DataTable();

        public FrmBoPhan()
        {
            InitializeComponent();
            LoadDGV();
        }
        public void Reload()
        {
            tbMaBP.Clear();
            tbTenBP.Clear();
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = BoPhan_BUS.LoadBoPhan();
            dgvBoPhan.DataSource = dt;
            dgvBoPhan.Columns["MaBoPhan"].HeaderText = "Bộ Phận";
            dgvBoPhan.Columns["TenBoPhan"].HeaderText = "Tên Bộ Phận";
            //dgvBoPhan.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            //dgvBoPhan.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            //dgvBoPhan.EnableHeadersVisualStyles = false;
        }

        private void click_Update(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            BoPhan bp = new BoPhan();
            bp.MaBoPhan = tbMaBP.Text;
            bp.TenBoPhan = tbTenBP.Text;
            if (BoPhan_BUS.Update(bp) == true)
            {
                MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Cập Nhật Thất Bại", "Thông Báo");
        }

        private void click_Reset(object sender, EventArgs e)
        {
            Reload();
            LoadDGV();
        }

        private void click_Delete(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            BoPhan bp = new BoPhan();
            bp.MaBoPhan = tbMaBP.Text;
            if (BoPhan_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDGV();
                Reload();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                BoPhan bp = new BoPhan();
                bp.MaBoPhan = tbMaBP.Text;
                bp.TenBoPhan = tbTenBP.Text;
                if (BoPhan_BUS.KiemTra(tbMaBP.Text) == false)
                {
                    BoPhan_BUS.Insert(bp);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDGV();
                    Reload();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }

        private void click_Cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBoPhan.SelectedRows[0];
                tbMaBP.Text = dr.Cells["MaBoPhan"].Value.ToString();
                tbTenBP.Text = dr.Cells["TenBoPhan"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
       
        private void LoadDgvBoPhan()
        {
            dt = new DataTable();
            dt = BoPhan_BUS.LoadBoPhan();
            dgvBoPhan.DataSource = dt;
            //chinh sua column
            dgvBoPhan.Columns["MaBoPhan"].HeaderText = "Mã Bộ Phận";
            dgvBoPhan.Columns["TenBoPhan"].HeaderText = "Tên Bộ Phận";
        }
        public void ReLoad()
        {
            tbMaBP.Clear();
            tbTenBP.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            BoPhan bp = new BoPhan();
            bp.MaBoPhan = tbMaBP.Text;
            bp.TenBoPhan = tbTenBP.Text;
            if (BoPhan_BUS.Update(bp) == true)
            {
                MessageBox.Show("Sửa Thành Công", "Thông Báo");
                LoadDgvBoPhan();
                ReLoad();
                return;
            }
            MessageBox.Show("Sửa Thất Bại", "Thông Báo");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ReLoad();
            LoadDgvBoPhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                BoPhan bp = new BoPhan();
                bp.MaBoPhan = tbMaBP.Text;
                bp.TenBoPhan = tbTenBP.Text;
                if (BoPhan_BUS.KiemTra(tbMaBP.Text) == false)
                {
                    BoPhan_BUS.Insert(bp);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo");
                    LoadDgvBoPhan();
                    ReLoad();
                    return;
                }
                else
                    MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbMaBP.Text == "" || tbTenBP.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            BoPhan bp = new BoPhan();
            bp.MaBoPhan = tbMaBP.Text;
            if (BoPhan_BUS.Delete(bp) == true)
            {
                MessageBox.Show("Xóa Thành Công", "Thông Báo");
                LoadDgvBoPhan();
                ReLoad();
                return;
            }
            MessageBox.Show("Xóa Thất Bại", "Thông Báo");
        }

        private void dgvBoPhan_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvBoPhan.SelectedRows[0];
                tbMaBP.Text = dr.Cells["MaBoPhan"].Value.ToString();
                tbTenBP.Text = dr.Cells["TenBoPhan"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmBoPhan_Load_1(object sender, EventArgs e)
        {
            LoadDgvBoPhan();
        }
    }
}
