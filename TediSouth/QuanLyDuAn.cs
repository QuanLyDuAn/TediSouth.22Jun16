using DevExpress.XtraEditors.Repository;
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

namespace TediSouth
{
    public partial class QuanLyDuAn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public delegate void  Send(string ID);
        public Send Sender;
        static string MaNV;
        public QuanLyDuAn()
        {
            InitializeComponent();
            Sender = new Send(LayID);
            MacDinh(); 
        }
        private void LayID( string ID)
        {
            MaNV = ID;
        }
        
        public Boolean KiemTra(string TenForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(TenForm))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }
        public void MacDinh()
        {
            btDangNhap.Enabled = true;
            btdangxuat.Enabled = false;
            btthoat.Enabled = true;
            btketnoi.Enabled = false;
            btkhachhang.Enabled = false;
            btduan.Enabled = false;
            bthotro.Enabled = false;
            bthopdong.Enabled = false;
            btdauthau.Enabled = false;
            btgiaokhoan.Enabled = false;
            btcongvan.Enabled = false;
            btdieuhanh.Enabled = false;
            btgiaosp.Enabled = false;
            btdonvi.Enabled = false;
            btlinhvuc.Enabled = false;
            btbophan.Enabled = false;
            btchucvu.Enabled = false;
            bttaikhoan.Enabled = false;
            btnhanvien.Enabled = false;
            btcongviec.Enabled = false;
            btDoiPass.Enabled = false;
            btnPhuLuc.Enabled = false;
            rbtrangchu.Visible = true;
            rbnoibo.Visible = false;
            rbduan.Visible = false;
            rbthongke.Visible = false;
            tim.Enabled = false;
        }

        public void Admin()
        {
            btDangNhap.Enabled = false;
            btdangxuat.Enabled = true;
            btthoat.Enabled = true;
            btketnoi.Enabled = true;
            btkhachhang.Enabled = true;
            btduan.Enabled = true;
            bthotro.Enabled = true;
            bthopdong.Enabled = true;
            btdauthau.Enabled = true;
            btgiaokhoan.Enabled = true;
            btcongvan.Enabled = true;
            btdieuhanh.Enabled = true;
            btgiaosp.Enabled = true;
            btdonvi.Enabled = true;
            btlinhvuc.Enabled = true;
            btbophan.Enabled = true;
            btchucvu.Enabled = true;
            bttaikhoan.Enabled = true;
            btnhanvien.Enabled = true;
            btcongviec.Enabled = true;
            bttaikhoan.Enabled = true;
            rbtrangchu.Visible = true;
            rbnoibo.Visible = true;
            rbduan.Visible = true;
            rbthongke.Visible = true;
            tbID.EditValue = MaNV;
            lbID.Caption = MaNV;
            lbHoTen.Caption = null;
            lbDonVi.Caption = null;
            lbChucVu.Caption = null;
            tim.Enabled = true;
            btnPhuLuc.Enabled = true;
            btDoiPass.Enabled = false;
        }

        public void NhanVien()
        {
            btDangNhap.Enabled = false;
            btdangxuat.Enabled = true;
            btthoat.Enabled = true;
            btketnoi.Enabled = true;
            btkhachhang.Enabled = true;
            btduan.Enabled = true;
            bthotro.Enabled = true;
            bthopdong.Enabled = true;
            btdauthau.Enabled = true;
            btgiaokhoan.Enabled = true;
            btcongvan.Enabled = true;
            btdieuhanh.Enabled = true;
            btgiaosp.Enabled = true;
            btdonvi.Enabled = false;
            btlinhvuc.Enabled = false;
            btbophan.Enabled = false;
            btchucvu.Enabled = false;
            bttaikhoan.Enabled = false;
            btnhanvien.Enabled = false;
            btcongviec.Enabled = false;
            btDoiPass.Enabled = true;
            rbtrangchu.Visible = true;
            rbnoibo.Visible = false;
            rbduan.Visible = true;
            rbthongke.Visible = false;
            tim.Enabled = false;
            btnPhuLuc.Enabled = false;
        }

        public void GiamDoc()
        {
            btDangNhap.Enabled = false;
            btdangxuat.Enabled = true;
            btthoat.Enabled = true;
            btketnoi.Enabled = true;
            btkhachhang.Enabled = true;
            btduan.Enabled = true;
            bthotro.Enabled = true;
            bthopdong.Enabled = true;
            btdauthau.Enabled = true;
            btgiaokhoan.Enabled = true;
            btcongvan.Enabled = true;
            btdieuhanh.Enabled = true;
            btgiaosp.Enabled = true;
            btdonvi.Enabled = false;
            btlinhvuc.Enabled = false;
            btbophan.Enabled = false;
            btchucvu.Enabled = false;
            bttaikhoan.Enabled = false;
            btnhanvien.Enabled = true;
            btcongviec.Enabled = true;
            btDoiPass.Enabled = true;
            rbtrangchu.Visible = true;
            rbnoibo.Visible = true;
            rbduan.Visible = true;
            rbthongke.Visible = true;
            tbID.EditValue = MaNV;
            tim.Enabled = true;
            btnPhuLuc.Enabled = true;
            DataTable dt = new DataTable();
            dt = DBConnect.TaoBang("select a.IDNhanVien,HoTen,TenDonVi,TenChucVu  from NhanVien a, DonVi b, QuyetDinhCongViec c, ChucVu d where a.MaDonVi=b.MaDonVi and a.IDNhanVien=c.IDNhanVien and c.MaChucVu=d.MaChucVu and a.IDNhanVien='"+MaNV+"'");
            try
            {
                DataRow dr = dt.Rows[0];
                lbID1.Caption = "Mã Nhân Viên: " + MaNV;
                lbHoTen1.Caption = "Họ Tên: " + dr["HoTen"].ToString();
                lbDonVi1.Caption = "Đơn Vị: " + dr["TenDonVi"].ToString();
                lbChucVu1.Caption = "Chức Vụ: " + dr["TenChucVu"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        #region Tab 1
        private void click_DoiPass(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Đổi Mật Khẩu") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    Frm_DoiPass dn = new Frm_DoiPass();
                    dn.Name = "Đổi Mật Khẩu";
                    dn.Sender(MaNV);
                    dn.Show();
                }
            }
        }
        private void click_DangNhap(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Đăng Nhập") == false)
                {
                    FrmDangNhap dn = new FrmDangNhap();
                    dn.Name = "Đăng Nhập";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_DangXuat(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                foreach (Form f in this.MdiChildren)
                    f.Close();
                lbHoTen.Caption ="...";
                lbDonVi.Caption = "...";
                lbID.Caption = "...";
                lbChucVu.Caption = "...";
                MacDinh();
            }
        }

        private void click_Thoat(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void click_KetNoi(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Kết Nối Thành Công.", "Thông Báo");
            }
        }
        #endregion

        #region Tab2
        private void click_KhachHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Khách Hàng") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmKhachHang dn = new FrmKhachHang();
                    dn.Name = "Khách Hàng";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_DuAn(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Dự Án") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmDuAn dn = new FrmDuAn();
                    dn.Name = "Dự Án";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }
        private void click_PhuLuc(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Phụ Lục Hợp Đồng") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmPhuLuc dn = new FrmPhuLuc();
                    dn.ID = MaNV;
                    dn.Name = "Phụ Lục Hợp Đồng";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_DauThau(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Hồ Sơ Đấu Thầu") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmHoSoDauThau dn = new FrmHoSoDauThau();
                    dn.ID = MaNV;
                    dn.Name = "Hồ Sơ Đấu Thầu";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_HopDong(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Hợp Đồng Dự Án") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmHopDong dn = new FrmHopDong();
                    dn.Name = "Hợp Đồng Dự Án";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_GiaoKhoan(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Hợp Đồng Giao Khoán") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmHopDongGiaoKhoan dn = new FrmHopDongGiaoKhoan();
                    dn.ID = MaNV;
                    dn.Name = "Hợp Đồng Giao Khoán";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_DieuHanh(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Điều Hành Dự Án") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmQDDieuHanhDuAn dn = new FrmQDDieuHanhDuAn();
                    dn.ID = MaNV;
                    dn.Name = "Điều Hành Dự Án";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_CongVan(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Công Văn Trao Đổi") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmCongVan dn = new FrmCongVan();
                    dn.ID = MaNV;
                    dn.Name = "Công Văn Trao Đổi";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_GiaoSanPham(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Giao Sản Phẩm") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmPhieuGiaoSanPham dn = new FrmPhieuGiaoSanPham();
                    dn.ID = MaNV;
                    dn.Name = "Giao Sản Phẩm";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }
        #endregion

        #region Tab 3
        private void click_LinhVuc(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Lĩnh Vực") == false)
                {
                    //foreach (Form f in this.MdiChildren)
                    //    f.Close();
                    FrmLinhVuc dn = new FrmLinhVuc();
                    dn.Name = "Lĩnh Vực";
                    //dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_DonVi(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Đơn Vị") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmDonVi dn = new FrmDonVi();
                    dn.Name = "Đơn Vị";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_BoPhan(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Bộ Phận") == false)
                {
                    //foreach (Form f in this.MdiChildren)
                    //    f.Close();
                    FrmBoPhan dn = new FrmBoPhan();
                    dn.Name = "Bộ Phận";
                    //dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_ChucVu(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Chức Vụ") == false)
                {
                    //foreach (Form f in this.MdiChildren)
                    //    f.Close();
                    FrmChucVu dn = new FrmChucVu();
                    dn.Name = "Chức Vụ";
                    //dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_NhanVien(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Thông Tin Nhân Viên") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmNhanVien dn = new FrmNhanVien();
                    dn.ID = MaNV;
                    dn.Name = "Thông Tin Nhân Viên";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }

        private void click_CongViec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Quyết Định Chức Vụ") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmQuyetDinhCongViec dn = new FrmQuyetDinhCongViec();
                    dn.ID = MaNV;
                    dn.Name = "Quyết Định Chức Vụ";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }
        private void bttaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Tài Khoản") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmTaiKhoan dn = new FrmTaiKhoan();
                    dn.Name = "Tài Khoản";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }
        #endregion

        #region Tab 4
        private void click_LocNam(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                foreach (Form f in this.MdiChildren)
                    f.Close();
                FrmDoanhSo dn = new FrmDoanhSo();
                dn.Name = "Lọc Theo Năm";
                dn.MdiParent = this;
                dn.HamNam(Convert.ToInt32(barEditItem1.EditValue));
                dn.Show();
                barEditItem1.EditValue = null;
            }
        }

        private void click_LocKhoang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                foreach (Form f in this.MdiChildren)
                    f.Close();
                FrmDoanhSo dn = new FrmDoanhSo();
                dn.Name = "Lọc Theo Khoảng";
                dn.MdiParent = this;
                dn.HamKhoang(Convert.ToDateTime(barEditItem4.EditValue), Convert.ToDateTime(barEditItem3.EditValue));
                dn.Show();
                barEditItem3.EditValue = null;
                barEditItem4.EditValue = null;
            }
        }

        private void click_ThongTin(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (DAL.DBConnect.kiemtraketnoi() == false)
            {
                MessageBox.Show("Không Thể Kết Nối DATA.", "Thông Báo");
            }
            else
            {
                if (KiemTra("Thông Tin Dự Án") == false)
                {
                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    FrmTongQuatDuAn dn = new FrmTongQuatDuAn();
                    dn.Name = "Thông Tin Dự Án";
                    dn.MdiParent = this;
                    dn.Show();
                }
            }
        }


        #endregion
    }
}
