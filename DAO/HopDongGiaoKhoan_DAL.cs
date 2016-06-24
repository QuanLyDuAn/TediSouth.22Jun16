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
   public class HopDongGiaoKhoan_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<HopDongGiaoKhoang> LoadHopDongGiaoKhoang()
        {
            string TruyVan = "Select * from HopDongGiaoKhoang";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HopDongGiaoKhoang> listHopDongGiaoKhoang = new List<HopDongGiaoKhoang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HopDongGiaoKhoang hdgk = new HopDongGiaoKhoang();
                hdgk.MaHopDongGK = dt.Rows[i]["MaHopDongGK"].ToString();
                hdgk.MaHopDong = dt.Rows[i]["MaHopDong"].ToString();
                hdgk.MaDonVi = dt.Rows[i]["MaDonVi"].ToString();
                hdgk.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                hdgk.NgayLapHDGK = Convert.ToDateTime(dt.Rows[i]["NgayLapHDGK"].ToString());
                hdgk.NgayDuyetHDGK = Convert.ToDateTime(dt.Rows[i]["NgayDuyetHDGK"].ToString());
                hdgk.KinhPhi = Convert.ToDouble(dt.Rows[i]["KinhPhi"].ToString());
                hdgk.NoiDungHoDongGK = dt.Rows[i]["NoiDungHoDongGK"].ToString();
                listHopDongGiaoKhoang.Add(hdgk);
            }
            DongKetNoi(con);
            return listHopDongGiaoKhoang;
        }

        public static bool Insert(HopDongGiaoKhoang hopDongGiaoKhoan)
        {
            string Insert = string.Format(@"Insert into HopDongGiaoKhoan(MaHopDongGK,MaHopDong,MaDonVi,MaDuAn,NgayLapHDGK,NgayKyDuyetHDGK,KinhPhi,NoiDungHopDongGK) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", hopDongGiaoKhoan.MaHopDongGK,hopDongGiaoKhoan.MaHopDong,hopDongGiaoKhoan.MaDonVi,hopDongGiaoKhoan.MaDuAn,hopDongGiaoKhoan.NgayLapHDGK,hopDongGiaoKhoan.NgayDuyetHDGK,hopDongGiaoKhoan.KinhPhi,hopDongGiaoKhoan.NoiDungHoDongGK);
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

        public static bool Update(HopDongGiaoKhoang hopDongGiaoKhoan)
        {
            string TruyVan = string.Format(@"Update HopDongGiaoKhoan Set MaHopDong=N'{0}',MaDonVi=N'{1}',MaDuAn=N'{2}',NgayLapHDGK=N'{3}',NgayKyDuyetHDGK=N'{4}',KinhPhi=N'{5}',NoiDungHopDongGK=N'{6}' where MaHopDongGK=N'{7}'", hopDongGiaoKhoan.MaHopDong, hopDongGiaoKhoan.MaDonVi, hopDongGiaoKhoan.MaDuAn, hopDongGiaoKhoan.NgayLapHDGK, hopDongGiaoKhoan.NgayDuyetHDGK, hopDongGiaoKhoan.KinhPhi, hopDongGiaoKhoan.NoiDungHoDongGK,hopDongGiaoKhoan.MaHopDongGK);
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
        public static bool Delete(HopDongGiaoKhoang hopDongGiaoKhoan)
        {
            string sTruyVan = string.Format(@"Delete from HopDongGiaoKhoang where  MaHopDongGK=N'{0}'", hopDongGiaoKhoan.MaHopDongGK);
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
        public static DataTable LoadHDGK()
        {
            string sTruyVan = "Select * from HopDongGiaoKhoan";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadDuAnTheoHD(string maHD)
        {
            string sTruyVan = string.Format("  Select d.MaDuAn,TenDuAn from DuAn d, HopDong h where d.MaDuAn=h.MaDuAn and MaHopDong='{0}'", maHD);
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadHDGK_ID(string ID)
        {
            string sTruyVan = "Select a.* from HopDongGiaoKhoan a, NhanVien b where a.MaDonVi=b.MaDonVi and IDNhanVien='"+ID+"'";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            string sTruyVan = "select * from HopDongGiaoKhoan where (MaHopDong like '%" + sTimKiem + "%' or MaDuAn like '%" + sTimKiem + "%' or MaHopDongGK like '%" + sTimKiem + "%') and MaDonVi = (select MaDonVi from NhanVien where IDNhanVien='"+ID+"')";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from HopDongGiaoKhoan where MaHopDong like '%" + sTimKiem + "%' or MaDuAn like '%" + sTimKiem + "%' or MaDonVi like '%" + sTimKiem + "%' or MaHopDongGK like '%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
