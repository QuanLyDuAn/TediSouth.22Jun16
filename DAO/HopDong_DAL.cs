using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
   public class HopDong_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<HopDong> LoadHopDong()
        {
            string TruyVan = "Select * from HopDong";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HopDong> listHopDong = new List<HopDong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HopDong hd = new HopDong();
                hd.MaHopDong = dt.Rows[i]["MaHopDong"].ToString();
                hd.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                hd.NgayLapHD = Convert.ToDateTime(dt.Rows[i]["NgayLapHD"].ToString());
                hd.NgayKyHD = Convert.ToDateTime(dt.Rows[i]["NgayKyHD"].ToString());
                hd.NoiDungHD = dt.Rows[i]["NoiDungHD"].ToString();
                listHopDong.Add(hd);
            }
            DongKetNoi(con);
            return listHopDong;
        }

        public static bool Insert(HopDong hopDong)
        {
            string Insert = string.Format(@"Insert into HopDong(MaHopDong,MaDuAn,NgayLapHD,NgayKyHD,NoiDungHopDong) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", hopDong.MaHopDong,hopDong.MaDuAn,hopDong.NgayLapHD,hopDong.NgayKyHD,hopDong.NoiDungHD);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(Insert, con);
                DongKetNoi(con);
                return true;
            }
            catch(Exception ex)
            {
                DongKetNoi(con);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool Update(HopDong hopDong)
        {
            string TruyVan = string.Format(@"Update HopDong Set MaDuAn=N'{0}',NgayLapHD=N'{1}',NgayKyHD=N'{2}',NoiDungHopDong=N'{3}' where MaHopDong=N'{4}'", hopDong.MaDuAn, hopDong.NgayLapHD, hopDong.NgayKyHD, hopDong.NoiDungHD,hopDong.MaHopDong);
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
        public static bool Delete(HopDong hopDong)
        {
            string sTruyVan = string.Format(@"Delete from HopDong where  MaHopDong=N'{0}'", hopDong.MaHopDong);
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
        public static DataTable LoadHD()
        {
            string sTruyVan = "Select * from HopDong";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from HopDong where MaHopDong like '%" + sTimKiem + "%' or MaDuAn like '%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
