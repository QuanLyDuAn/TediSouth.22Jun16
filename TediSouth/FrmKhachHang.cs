﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using DTO;
namespace TediSouth
{
    public partial class FrmKhachHang : Form
    {
        DataTable dt = new DataTable();
        public FrmKhachHang()
        {
            InitializeComponent();
            Reload();
            LoadDGV();
        }
        public void Reload()
        {
            tbMaKhach.Clear();
            tbTenCongTy.Clear();
            tbDiaChi.Clear();
            tbEmail.Clear();
            tbNgDD.Clear();
            tbSDT1.Clear();
            tbTimKiem.Text= "Nhập mã hoặc tên công ty để tìm kiếm...";

        }
        public void LoadDGV()
        {
            dt = new DataTable();
            dt = KhachHang_BUS.LoadKH();
            dgvKhachHang.DataSource = dt;

            dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Khách ";
            dgvKhachHang.Columns["TenCongTy"].HeaderText = "Công Ty";
            dgvKhachHang.Columns["NguoiDaiDien"].HeaderText = "Người Đại Diện";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";
            dgvKhachHang.Columns["SDT"].HeaderText = "Điện Thoại";
        }

        private void click_Add(object sender, EventArgs e)
        {

            if (tbDiaChi.Text == "" || tbEmail.Text == "" || tbMaKhach.Text == "" || tbNgDD.Text == "" || tbSDT1.Text == "" || tbTenCongTy.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            else
            {
                KhachHang bp = new KhachHang();
                bp.MaKhachHang = tbMaKhach.Text;
                bp.TenCongTy = tbTenCongTy.Text;
                bp.NguoiDaiDien = tbNgDD.Text;
                bp.DiaChi = tbDiaChi.Text;
                bp.Email = tbEmail.Text;
                bp.SDT = tbSDT1.Text;
                if (KhachHang_BUS.KiemTra(tbMaKhach.Text) == false)
                {
                    KhachHang_BUS.Insert(bp);
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
            if (tbDiaChi.Text == "" || tbEmail.Text == "" || tbMaKhach.Text == "" || tbNgDD.Text == "" || tbSDT1.Text == "" || tbTenCongTy.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo");
                return;
            }
            KhachHang bp = new KhachHang();
            bp.MaKhachHang = tbMaKhach.Text;
            bp.TenCongTy = tbTenCongTy.Text;
            bp.NguoiDaiDien = tbNgDD.Text;
            bp.DiaChi = tbDiaChi.Text;
            bp.Email = tbEmail.Text;
            bp.SDT = tbSDT1.Text;
            if (KhachHang_BUS.Update(bp) == true)
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
            if (tbDiaChi.Text == "" || tbEmail.Text == "" || tbMaKhach.Text == "" || tbNgDD.Text == "" || tbSDT1.Text == "" || tbTenCongTy.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Dữ Liệu Cần Xóa", "Thông báo");
                return;
            }
            KhachHang bp = new KhachHang();
            bp.MaKhachHang = tbMaKhach.Text;
            if (KhachHang_BUS.Delete(bp) == true)
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
                DataGridViewRow dr = dgvKhachHang.SelectedRows[0];
                tbMaKhach.Text = dr.Cells["MaKhachHang"].Value.ToString();
                tbTenCongTy.Text = dr.Cells["TenCongTy"].Value.ToString();
                tbNgDD.Text = dr.Cells["NguoiDaiDien"].Value.ToString();
                tbDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
                tbEmail.Text = dr.Cells["Email"].Value.ToString();
                tbSDT1.Text = dr.Cells["SDT"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void tbTimKiem_Click(object sender, EventArgs e)
        {
            tbTimKiem.Clear();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KhachHang_BUS.LoadTimKiemAdmin(tbTimKiem.Text);
            dgvKhachHang.DataSource = dt;
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
