using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DuAn_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<DuAn> LoadDuAn()
        {
            string TruyVan = "Select * from DuAn";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DuAn> listDuAn = new List<DuAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DuAn da = new DuAn();
                da.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                da.TenDuAn = dt.Rows[i]["TenDuAn"].ToString();
                da.MaKhachHang = dt.Rows[i]["MaKhachHang"].ToString();
                da.NgayLap =Convert.ToDateTime(dt.Rows[i]["NgayLap"].ToString());
                da.SoThangTrienKhai =Convert.ToInt32(dt.Rows[i]["SoThangTrienKhai"].ToString());
                da.TongKinhPhi =Convert.ToDouble(dt.Rows[i]["TongKinhPhi"].ToString());
                listDuAn.Add(da);
            }
            DongKetNoi(con);
            return listDuAn;
        }

        public static bool Insert(DuAn duAn)
        {
            string Insert = string.Format(@"Insert into DuAn(MaDuAn,TenDuAn,MaKhachHang,NgayLap,SoThangTrienKhai,TongKinhPhi) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", duAn.MaDuAn,duAn.TenDuAn,duAn.MaKhachHang,duAn.NgayLap,duAn.SoThangTrienKhai,duAn.TongKinhPhi);
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

        public static bool Update(DuAn duAn)
        {
            string TruyVan = string.Format(@"Update DuAn Set TenDuAn=N'{0}',MaKhachHang=N'{1}',NgayLap=N'{2}',SoThangTrienKhai=N'{3}',TongKinhPhi=N'{4}' where MaDuAn=N'{5}'", duAn.TenDuAn, duAn.MaKhachHang, duAn.NgayLap, duAn.SoThangTrienKhai, duAn.TongKinhPhi,duAn.MaDuAn);
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
        public static bool Delete(DuAn duAn)
        {
            string sTruyVan = string.Format(@"Delete from DuAn where  MaDuAn=N'{0}'", duAn.MaDuAn);
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
        public static DataTable LoadDA()
        {
            string sTruyVan = "Select * from DuAn";
            return TaoBang(sTruyVan);
        }
        
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from DuAn where MaDuAn like '%" + sTimKiem + "%'or TenDuAn like N'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
