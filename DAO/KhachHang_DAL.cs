using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHang_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<KhachHang> LoadKhachHang()
        {
            string TruyVan = "Select * from KhachHang";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang> listKhachHang = new List<KhachHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                kh.TenCongTy = dt.Rows[i]["TenCongTy"].ToString();
                kh.NguoiDaiDien = dt.Rows[i]["NguoiDaiDien"].ToString();
                kh.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                kh.Email = dt.Rows[i]["Email"].ToString();
                kh.SDT = dt.Rows[i]["SDT"].ToString();
                listKhachHang.Add(kh);
            }
            DongKetNoi(con);
            return listKhachHang;
        }

        public static bool Insert(KhachHang khachHang)
        {
            string Insert = string.Format(@"Insert into KhachHang(MaKhachHang,TenCongTy,NguoiDaiDien,DiaChi,Email,SDT) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", khachHang.MaKhachHang, khachHang.TenCongTy, khachHang.NguoiDaiDien, khachHang.DiaChi, khachHang.Email, khachHang.SDT);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(Insert, con);
                DongKetNoi(con);
                return true;
            }
            catch
            {
                DongKetNoi(con);
                return false;
            }
        }

        public static bool Update(KhachHang khachHang)
        {
            string TruyVan = string.Format(@"Update KhachHang Set TenCongTy=N'{0}',NguoiDaiDien=N'{1}',DiaChi=N'{2}',Email=N'{3}',SDT=N'{4}' where MaKhachHang=N'{5}'", khachHang.TenCongTy, khachHang.NguoiDaiDien, khachHang.DiaChi, khachHang.Email, khachHang.SDT, khachHang.MaKhachHang);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(TruyVan, con);
                DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DongKetNoi(con);
                return false;
            }
        }
        public static bool Delete(KhachHang khachHang)
        {
            string sTruyVan = string.Format(@"Delete from KhachHang where  MaKhachHang=N'{0}'", khachHang.MaKhachHang);
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
        public static DataTable LoadKH()
        {
            string query = "SELECT * FROM KhachHang";
            return TaoBang(query);
        }
        
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from KhachHang where MaKhachHang like '%" + sTimKiem + "%'or TenCongTy like N'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
