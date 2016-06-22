﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using System.Data.SqlClient;

namespace TediSouth
{
    public partial class FrmDuAn : Form
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
        SqlConnection con = new SqlConnection(chuoiKetNoi);
        
        public FrmDuAn()
        {
            InitializeComponent();
            Reload();
            LoadDGV();
            AutoLV();
        }
        
        public void Reload()
        {
            tbMaDuAn.Clear();
            tbTenDuAn.Clear();
            tbkhachang.Clear();
            dtNgayLap.Value = DateTime.Now;
            tbThoiGian.Clear();
            tbKinhPhi.Clear();
            tbTimKiem.Clear();
        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = DuAn_BUS.LoadDA();
            dgvDA.DataSource = dt;

            dgvDA.Columns["MaDuAn"].HeaderText = "Dự Án";
            dgvDA.Columns["TenDuAn"].HeaderText = "Tên Dự Án";
            dgvDA.Columns["MaKhachHang"].HeaderText = "Khách Hàng";
            dgvDA.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvDA.Columns["SoThangTrienKhai"].HeaderText = "Thời Gian Triển Khai";
            dgvDA.Columns["TongKinhPhi"].HeaderText = "Kinh Phí";
        }
        public void AutoLV()
        {
            //Đang suy nghĩ chọn mã hay tên cho hợp lý
            SqlCommand cmd = new SqlCommand("Select MaKhachHang from KhachHang", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collection.Add(dr.GetString(0));
            }
            tbkhachang.AutoCompleteCustomSource = collection;
            con.Close();
        }

        private void click_Add(object sender, EventArgs e)
        {
            if (tbkhachang.Text == "" || tbKinhPhi.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                DuAn bp = new DuAn();
                bp.MaDuAn = tbMaDuAn.Text;
                bp.TenDuAn = tbTenDuAn.Text;
                bp.MaKhachHang = tbkhachang.Text;
                bp.NgayLap =Convert.ToDateTime(dtNgayLap.Value.ToString());
                bp.SoThangTrienKhai =Convert.ToInt32( tbThoiGian.Text);
                bp.TongKinhPhi =Convert.ToDouble( tbKinhPhi.Text);
                if (DuAn_BUS.KiemTra(tbMaDuAn.Text) == false)
                {
                    DuAn_BUS.Insert(bp);
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
            if (tbkhachang.Text == "" || tbKinhPhi.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            DuAn bp = new DuAn();
            bp.MaDuAn = tbMaDuAn.Text;
            bp.TenDuAn = tbTenDuAn.Text;
            bp.MaKhachHang = tbkhachang.Text;
            bp.NgayLap = Convert.ToDateTime(dtNgayLap.Value.ToString());
            bp.SoThangTrienKhai = Convert.ToInt32(tbThoiGian.Text);
            bp.TongKinhPhi = Convert.ToDouble(tbKinhPhi.Text);
            if (DuAn_BUS.Update(bp) == true)
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
            if (tbkhachang.Text == "" || tbKinhPhi.Text == "" || tbMaDuAn.Text == "" || tbTenDuAn.Text == "" || tbThoiGian.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            DuAn bp = new DuAn();
            bp.MaDuAn = tbMaDuAn.Text;
            if (DuAn_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvDA.SelectedRows[0];
                tbMaDuAn.Text = dr.Cells["MaDuAn"].Value.ToString();
                tbTenDuAn.Text = dr.Cells["TenDuAn"].Value.ToString();
                tbkhachang.Text = dr.Cells["MaKhachHang"].Value.ToString();
                dtNgayLap.Text = dr.Cells["NgayLap"].Value.ToString();
                tbThoiGian.Text = dr.Cells["SoThangTrienKhai"].Value.ToString();
                tbKinhPhi.Text = dr.Cells["TongKinhPhi"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void click_TimKiem(object sender, EventArgs e)
        {

        }
    }
}