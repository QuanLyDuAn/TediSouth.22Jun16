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
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace TediSouth
{
    public partial class FrmTongQuatDuAn : Form
    {
        DBConnect dbc = new DBConnect();
        public string ten;
        public FrmTongQuatDuAn()
        {
            InitializeComponent();
            MacDinh();
        }
        void Mo()
        {
            simpleButton1.Visible = true;
            simpleButton2.Visible = true;
            simpleButton3.Visible = true;
            simpleButton4.Visible = true;
            simpleButton5.Visible = true;
            simpleButton6.Visible = true;
        }
        void MacDinh()
        {
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            simpleButton5.Visible = false;
            simpleButton6.Visible = false;
        }

        private void click_Find(object sender, EventArgs e)
        {
            if (tbDuAn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên dự án", "Thông Báo");
                MacDinh();
            }
            else
            {
                string tim = string.Format("select * from duan where tenduan like N'%{0}%'", tbDuAn.Text);
                DataTable tam = DBConnect.TaoBang(tim);

                if (tam.Rows.Count == 0)
                {
                    MacDinh();
                    MessageBox.Show("Không có dự án này", "Thông Báo");
                }
                else
                    Mo();
            }
        }

        private void tbclick(object sender, EventArgs e)
        {
            tbDuAn.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string duan = string.Format("select MaDuAn, TenDuAn, tencongty,NgayLap,TongKinhPhi,SoThangTrienKhai from DuAn a, KhachHang k where k.MaKhachHang=a.MaKhachHang and TenDuAn like N'%{0}%'", tbDuAn.Text);
            DataTable da = DBConnect.TaoBang(duan);
            gird.DataSource = da;
            gird.Columns["maduan"].HeaderText = "Mã dự án";
            gird.Columns["tenduan"].HeaderText = "Dự án";
            gird.Columns["tencongty"].HeaderText = "Công Ty";
            gird.Columns["NgayLap"].HeaderText = "Ngày Lập";
            gird.Columns["SoThangTrienKhai"].HeaderText = "Thời Gian Triển Khai";
            gird.Columns["TongKinhPhi"].HeaderText = "Kinh Phí";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string hopdong = string.Format("select * from HopDong where maduan=(select maduan from Duan where tenduan like N'%{0}%')", tbDuAn.Text);
            DataTable hd = DBConnect.TaoBang(hopdong);
            gird.DataSource = hd;
            gird.Columns["MaHopDong"].HeaderText = "Hợp Đồng";
            gird.Columns["MaDuAn"].HeaderText = "Dự Án";
            gird.Columns["NgayLapHD"].HeaderText = "Ngày Lập";
            gird.Columns["NgayKyHD"].HeaderText = "Ngày Ký";
            gird.Columns["NoiDungHopDong"].HeaderText = "Nội Dung";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string hdgk = string.Format("select * from HopDongGiaoKhoan where mahopdong=(select mahopdong from hopdong where maduan=(select maduan from Duan where tenduan like N'%{0}%' ))", tbDuAn.Text);
            DataTable giaokhoan = DBConnect.TaoBang(hdgk);
            gird.DataSource = giaokhoan;
            gird.Columns["MaHopDong"].HeaderText = "Mã Hợp Đồng";
            gird.Columns["MaHopDongGK"].HeaderText = "Mã Hợp Đồng GK";
            gird.Columns["MaDonVi"].HeaderText = "Mã Đơn Vị";
            gird.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            gird.Columns["NgayLapHDGK"].HeaderText = "Ngày Lập HĐGK";
            gird.Columns["NgayKyDuyetHDGK"].HeaderText = "Ngày Ký Duyệt HĐGK";
            gird.Columns["KinhPhi"].HeaderText = "Kinh Phí";
            gird.Columns["NoiDungHopDongGK"].HeaderText = " Nội Dung Hợp Đồng";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string dieuhanh = string.Format("select * from Chi_Tiet_Dieu_Hanh where qddieuhanh=(select qddieuhanh from qddieuhanhduan where maduan=(select maduan from Duan where tenduan like N'%{0}%' ))", tbDuAn.Text);
            DataTable dh = DBConnect.TaoBang(dieuhanh);
            gird.DataSource = dh;
            gird.Columns["QDDieuHanh"].HeaderText = "Mã Quyết Định";
            gird.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            gird.Columns["ViTriPhanCong"].HeaderText = "Vị Trí Phân Công";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string congvan = string.Format("select * from CongVan where maduan=(select maduan from Duan where tenduan like N'%{0}%' )", tbDuAn.Text);
            DataTable cv = DBConnect.TaoBang(congvan);
            gird.DataSource = cv;
            gird.Columns["MaCongVan"].HeaderText = "Mã Công Văn";
            gird.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            gird.Columns["IDNhanVien"].HeaderText = "ID Nhân Viên";
            gird.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            gird.Columns["NgayLapCV"].HeaderText = "Ngày Lập Công Văn";
            gird.Columns["NoiDung"].HeaderText = "Nội Dung";
            gird.Columns["LoaiCV"].HeaderText = "Loại Công Văn";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            string sanpham = string.Format("select * from Phieugiaosanpham where maduan=(select maduan from Duan where tenduan like N'%{0}%' )", tbDuAn.Text);
            DataTable sp = DBConnect.TaoBang(sanpham);
            gird.DataSource = sp;
            gird.Columns["IDPhieuGiao"].HeaderText = "Mã Phiếu Giao";
            gird.Columns["MaDuAn"].HeaderText = "Mã Dự Án";
            gird.Columns["IDNhanVien"].HeaderText = "Mã Nhân Viên";
            gird.Columns["TieuDe"].HeaderText = "Tiêu Đề";
            gird.Columns["NoiDungPhieuGiao"].HeaderText = "Nội Dung";
            gird.Columns["NgayLap"].HeaderText = "Ngày Lập";
            gird.Columns["SoLuong"].HeaderText = "Số Lượng";
            gird.Columns["DuyetHoSo"].HeaderText = "Đã Duyệt";
        }
        private void AutoTenK()
        {

            string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                string lenh = string.Format("select tenduan from duan where tenduan like N'%{0}%'", tbDuAn.Text);
                SqlCommand cmd = new SqlCommand(lenh, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader["TenDuAn"].ToString());
                }
                tbDuAn.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }

        }

        private void FrmTongQuatDuAn_Load(object sender, EventArgs e)
        {
            AutoTenK();
        }

        private void tbDuAn_TextChanged_1(object sender, EventArgs e)
        {
            MacDinh();
            DataTable dt = new DataTable();
            gird.DataSource = dt;
        }
    }
}
