using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class NhanVien_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();
        public static bool Insert(NhanVien nhanVien)
        {
            try
            {
                string ketnoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ketnoi);
                conn.Open();
                string sTruyVan = "Insert into NhanVien values(@IDNhanVien,@MaDonVi,@MaBoPhan,@NgaySinh,@HoTen,@Email,@DienThoaiNhanVien,@DiaChi,@HinhAnh)";
                SqlCommand cmd = new SqlCommand(sTruyVan, conn);
                cmd.Parameters.AddWithValue("@IDNhanVien", nhanVien.IDNhanVien);
                cmd.Parameters.AddWithValue("@MaDonVi", nhanVien.MaDonVi);
                cmd.Parameters.AddWithValue("@MaBoPhan", nhanVien.MaBoPhan);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@DienThoaiNhanVien", nhanVien.DienThoaiNhanVien);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool Update(NhanVien nhanVien)
        {
            try
            {
                
                string TruyVan = string.Format(@"Update NhanVien Set MaDonVi=@MaDonVi,MaBoPhan=@MaBoPhan,NgaySinh=@NgaySinh,HoTen=@HoTen,Email=@Email,DienThoaiNhanVien=@DienThoaiNhanVien,DiaChi=@DiaChi where IDNhanVien=@IDNhanVien");
                string ketnoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ketnoi);
                conn.Open();
                SqlCommand cmd = new SqlCommand(TruyVan, conn);
                cmd.Parameters.AddWithValue("@IDNhanVien", nhanVien.IDNhanVien);
                cmd.Parameters.AddWithValue("@MaDonVi", nhanVien.MaDonVi);
                cmd.Parameters.AddWithValue("@MaBoPhan", nhanVien.MaBoPhan);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@DienThoaiNhanVien", nhanVien.DienThoaiNhanVien);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Delete(NhanVien nhanVien)
        {
            string sTruyVan = string.Format(@"Delete from NhanVien where  IDNhanVien=N'{0}'", nhanVien.IDNhanVien);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(sTruyVan, con);
                DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DongKetNoi(con);
                return false;
            }
        }
        public static DataTable LoadNV()
        {
            string sTruyVan = "SELECT * FROM NhanVien";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadNV_ID(string ID)
        {
            string sTruyVan = "select * from NhanVien where MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"') order by IDNhanVien";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadBPTheoDV(string MaDV)
        {
            string sTruyVan = string.Format("select b.MaBoPhan,TenBoPhan from  ChiTietDonVi c, BoPhan b where  c.MaBoPhan = b.MaBoPhan and MaDonVi ='{0}'", MaDV);
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemTheoID(string ID,string sTimKiem)
        {
            string sTruyVan = "select * from NhanVien where MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"') and (IDNhanVien like'%"+sTimKiem+ "%'or HoTen like N'%"+sTimKiem+"%')";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from NhanVien where IDNhanVien like '%" + sTimKiem + "%'or HoTen like N'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }

}
