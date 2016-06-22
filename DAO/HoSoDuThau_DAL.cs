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
   public class HoSoDuThau_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<HoSoDuThau> LoadHoSoDuThau()
        {
            string TruyVan = "Select * from HoSoDuThau";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoSoDuThau> listHoSoDuThau = new List<HoSoDuThau>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoSoDuThau hsdt = new HoSoDuThau();
                hsdt.MaDonVi = dt.Rows[i]["MaDonVi"].ToString();
                hsdt.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                hsdt.NgayLapHoSoDauThau = Convert.ToDateTime(dt.Rows[i]["NgayLapHoSoDauThau"].ToString());
                hsdt.MucGiaBoThau = Convert.ToDouble(dt.Rows[i]["MucGiaBoThau"].ToString());
                hsdt.HoSoDauThau = dt.Rows[i]["HoSoDauThau"].ToString();
                listHoSoDuThau.Add(hsdt);
            }
            DongKetNoi(con);
            return listHoSoDuThau;
        }

        public static bool Insert(HoSoDuThau hoSoDuThau)
        {
            string Insert = string.Format(@"Insert into HoSoDuThau(MaDonVi,MaDuAn,NgayLapHoSoDauThau,MucGiaBoThau,HoSoDauThau) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",hoSoDuThau.MaDonVi,hoSoDuThau.MaDuAn,hoSoDuThau.NgayLapHoSoDauThau,hoSoDuThau.MucGiaBoThau,hoSoDuThau.HoSoDauThau);
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

        public static bool Update(HoSoDuThau hoSoDuThau)
        {
            string TruyVan = string.Format(@"Update HoSoDuThau Set NgayLapHoSoDauThau=N'{0}',MucGiaBoThau=N'{1}',HoSoDauThau=N'{2}' where MaDonVi=N'{3}' and MaDuAn=N'{4}'", hoSoDuThau.NgayLapHoSoDauThau, hoSoDuThau.MucGiaBoThau, hoSoDuThau.HoSoDauThau,hoSoDuThau.MaDonVi,hoSoDuThau.MaDuAn);
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
        public static bool Delete(HoSoDuThau hoSoDauThau)
        {
            string sTruyVan = string.Format(@"Delete from HoSoDuThau where MaDonVi='{0}' and MaDuAn=N'{1}'", hoSoDauThau.MaDonVi, hoSoDauThau.MaDuAn);
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
        public static DataTable LoadHSDT()
        {
            string sTruyVan = "Select * from HoSoDuThau";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadHSDT_ID(string id)
        {
            string sTruyVan = "Select a.* from HoSoDuThau a, NhanVien b where a.MaDonVi=b.MaDonVi and IDNhanVien='"+id+"'";
            return TaoBang(sTruyVan);
        }
    }
}
