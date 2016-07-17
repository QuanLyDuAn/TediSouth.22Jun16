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
     public class PhuLuc_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<PhuLuc> LoadPhuLuc()
        {
            string TruyVan = "Select * from PhuLuc";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhuLuc> listHopDong = new List<PhuLuc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhuLuc pl = new PhuLuc();

                pl.MaPhuLuc = dt.Rows[i]["MaPhuLuc"].ToString();
                pl.MaHopDong = dt.Rows[i]["MaHopDong"].ToString();
                pl.NgayLap = Convert.ToDateTime(dt.Rows[i]["NgayLap"].ToString());
                pl.NoiDung = dt.Rows[i]["NoiDungHD"].ToString();
                listHopDong.Add(pl);
            }
            DongKetNoi(con);
            return listHopDong;
        }
        public static DataTable LoadPL_ID(string ID)
        {
            string sTruyVan = "select a.* from PhuLuc a, HopDongGiaoKhoan b where a.MaHopDong=b.MaHopDong  and b.MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "') order by MaPhuLuc";
            return TaoBang(sTruyVan);
        }
        public static bool Insert(PhuLuc phuluc)
        {
            string Insert = string.Format(@"Insert into PhuLuc(MaPhuLuc,MaHopDong,NgayLap,NoiDung) Values (N'{0}',N'{1}',N'{2}',N'{3}')",phuluc.MaPhuLuc,phuluc.MaHopDong,phuluc.NgayLap,phuluc.NoiDung);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(Insert, con);
                DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DongKetNoi(con);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool Update(PhuLuc phuluc)
        {
            string TruyVan = string.Format(@"Update PhuLuc Set MaHopDong=N'{0}',NgayLap=N'{1}',NoiDung=N'{2}' where MaPhuLuc=N'{3}'", phuluc.MaHopDong, phuluc.NgayLap, phuluc.NoiDung,phuluc.MaPhuLuc);
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
        public static bool Delete(PhuLuc phuluc)
        {
            string sTruyVan = string.Format(@"Delete from PhuLuc where  MaPhuLuc=N'{0}'", phuluc.MaPhuLuc);
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
        public static DataTable LoadPL()
        {
            string sTruyVan = "Select * from PhuLuc";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            string sTruyVan = "select a.* from PhuLuc a,HopDongGiaoKhoan b where (MaPhuLuc like '%" + sTimKiem + "%' or a.MaHopDong like '%" + sTimKiem + "%' ) and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID+"') and a.MaHopDong=b.MaHopDong";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from PhuLuc where MaPhuLuc like '%" + sTimKiem + "%' or MaHopDong like '%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
