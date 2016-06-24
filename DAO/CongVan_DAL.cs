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
    public class CongVan_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<CongVan> LoadCongVan()
        {
            string TruyVan = "Select * from CongVan";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CongVan> listCongVan = new List<CongVan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CongVan cv = new CongVan();
                cv.MaCongVan = dt.Rows[i]["MaCongVan"].ToString();
                cv.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                cv.IDNhanVien = dt.Rows[i]["IDNhanVien"].ToString();
                cv.TieuDe = dt.Rows[i]["TieuDe"].ToString();
                cv.NgayLapCV =Convert.ToDateTime(dt.Rows[i]["NgayLapCV"].ToString());
                cv.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                cv.LoaiCV = dt.Rows[i]["LoaiCV"].ToString();
                listCongVan.Add(cv);
            }
            DongKetNoi(con);
            return listCongVan;
        }

        public static bool Insert(CongVan congVan)
        {
            string Insert = string.Format(@"Insert into CongVan(MaCongVan,MaDuAn,IDNhanVien,TieuDe,NgayLapCV,NoiDung,LoaiCV) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", congVan.MaCongVan, congVan.MaDuAn, congVan.IDNhanVien, congVan.TieuDe, congVan.NgayLapCV, congVan.NoiDung, congVan.LoaiCV);
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

        public static bool Update(CongVan congVan)
        {
            string TruyVan = string.Format(@"Update CongVan Set MaDuAn=N'{0}',IDNhanVien=N'{1}',TieuDe=N'{2}',NgayLapCV=N'{3}',NoiDung=N'{4}',LoaiCV=N'{5}' where MaCongVan=N'{6}'", congVan.MaDuAn, congVan.IDNhanVien, congVan.TieuDe, congVan.NgayLapCV, congVan.NoiDung, congVan.LoaiCV,congVan.MaCongVan);
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
        public static bool Delete(CongVan congVan)
        {
            string sTruyVan = string.Format(@"Delete from CongVan where  MaCongVan=N'{0}'", congVan.MaCongVan);
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
        public static DataTable LoadCV()
        {
            string sTruyVan = "Select * from CongVan";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadNVTheoDA(string maDA)
        {
            string sTruyVan = "select nv.IDNhanVien, nv.HoTen from NhanVien nv,Chi_Tiet_Dieu_Hanh ct, QDDieuHanhDuAn qd where nv.IDNhanVien=ct.IDNhanVien and ct.QDDieuHanh=qd.QDDieuHanh and MaDuAn='"+ maDA+"'";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadCV_ID(string ID)
        {
            string sTruyVan = "select a.* from CongVan a, HopDongGiaoKhoan b where a.MaDuAn=b.MaDuAn  and b.MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"') order by MaDuAn";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            string sTruyVan = "select a.* from CongVan a,HopDongGiaoKhoan b where (MaCongVan like '%" + sTimKiem + "%' or a.MaDuAn like '%" + sTimKiem + "%' or TieuDe like N'%" + sTimKiem + "%') and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "') and a.MaDuAn=b.MaDuAn";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from CongVan where MaCongVan like '%" + sTimKiem + "%' or MaDuAn like '%" + sTimKiem + "%' or TieuDe like N'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
