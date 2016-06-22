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
namespace TediSouth
{
    public partial class FrmLinhVuc : Form
    {
        DataTable dt = new DataTable();
        public FrmLinhVuc()
        {
            InitializeComponent();
            LoadDGV();
        }
        public void Reload()
        {
            tbmalv.Clear();
            tbtenlv.Clear();
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = LinhVuc_BUS.LoadLV();
            dgvLV.DataSource = dt;

            dgvLV.Columns["MaLinhVuc"].HeaderText = "Lĩnh Vực";
            dgvLV.Columns["TenLinhVuc"].HeaderText = "Tên Lĩnh Vực";
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbtenlv.Text == "" || tbmalv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                LinhVuc bp = new LinhVuc();
                bp.MaLinhVuc = tbmalv.Text;
                bp.TenLinhVuc = tbtenlv.Text;
                if (LinhVuc_BUS.KiemTra(tbmalv.Text) == false)
                {
                    LinhVuc_BUS.Insert(bp);
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

            if (tbmalv.Text == "" || tbtenlv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            LinhVuc bp = new LinhVuc();
            bp.MaLinhVuc = tbmalv.Text;
            bp.TenLinhVuc = tbtenlv.Text;
            if (LinhVuc_BUS.Update(bp) == true)
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
            if (tbtenlv.Text == "" || tbmalv.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            LinhVuc bp = new LinhVuc();
            bp.MaLinhVuc = tbmalv.Text;
            if (LinhVuc_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvLV.SelectedRows[0];
                tbmalv.Text = dr.Cells["MaLinhVuc"].Value.ToString();
                tbtenlv.Text = dr.Cells["TenLinhVuc"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
