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
    public partial class FrmChiTietDonVi : Form
    {
        DataTable dt = new DataTable();
        public FrmChiTietDonVi()
        {
            InitializeComponent();
            LoadDGV();
            LoadDonVi();
        }
        public void Reload()
        {
            tbMaDV.Clear();
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = ChiTietDonVi_BUS.LoadCTDV();
            dgvCTDV.DataSource = dt;

            dgvCTDV.Columns["MaDonVi"].HeaderText = "Đơn Vị";
            dgvCTDV.Columns["MaBoPhan"].HeaderText = "Bộ Phận";
        }

        public void LoadDonVi()
        {
            cbMaBP.DataSource = DBConnect.TaoBang("select * from DonVi");
            cbMaBP.DisplayMember ="MaDonVi";
            cbMaBP.ValueMember = "MaDonVi";
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                ChiTietDonVi bp = new ChiTietDonVi();
                bp.MaDonVi = tbMaDV.Text;
                bp.MaBoPhan = cbMaBP.SelectedValue.ToString();
                if (DonVi_BUS.KiemTra(tbMaDV.Text) == true)
                {
                    MessageBox.Show("Đơn vị này chưa có trong hệ thống", "Thông Báo");
                    return;
                }
                else
                {
                    if (ChiTietDonVi_BUS.KiemTra(tbMaDV.Text, cbMaBP.SelectedValue.ToString()) == false)
                    {
                        ChiTietDonVi_BUS.Insert(bp);
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        LoadDGV();
                        Reload();
                        return;
                    }
                    else
                        MessageBox.Show("Trùng lắp dữ liệu", "Thông Báo");
                }
            }
        }

        private void click_Update(object sender, EventArgs e)
        {
            if (tbMaDV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            ChiTietDonVi bp = new ChiTietDonVi();
            bp.MaDonVi = tbMaDV.Text;
            bp.MaBoPhan = cbMaBP.SelectedValue.ToString();
            if (ChiTietDonVi_BUS.Update(bp) == true)
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
            if (tbMaDV.Text == "" )
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            ChiTietDonVi bp = new ChiTietDonVi();
            bp.MaDonVi = tbMaDV.Text;
            bp.MaBoPhan = cbMaBP.SelectedValue.ToString();
            if (ChiTietDonVi_BUS.Delete(bp) == true)
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
        }

        private void click_Cell(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvCTDV.SelectedRows[0];
                tbMaDV.Text = dr.Cells["MaDonVi"].Value.ToString();
                cbMaBP.Text = dr.Cells["MaBoPhan"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
