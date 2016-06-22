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
    public class QuyetDinhCongViec_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<QuyetDinhCongViec> LoadQuyetDinhCongViec()
        {
            string TruyVan = "Select * from QuyetDinhCongViec";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuyetDinhCongViec> listQuyetDinhCongViec = new List<QuyetDinhCongViec>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuyetDinhCongViec qdcv = new QuyetDinhCongViec();
                qdcv.QDCongViec = dt.Rows[i]["QDCongViec"].ToString();
                qdcv.IDNhanVien = dt.Rows[i]["IDNhanVien"].ToString();
                qdcv.MaChucVu = dt.Rows[i]["MaChucVu"].ToString();
                qdcv.NgayLap = Convert.ToDateTime(dt.Rows[i]["NgayLap"].ToString());
                qdcv.NoiDung = dt.Rows[i]["NoiDung"].ToString();
                listQuyetDinhCongViec.Add(qdcv);
            }
            DongKetNoi(con);
            return listQuyetDinhCongViec;
        }

        public static bool Insert(QuyetDinhCongViec qdcv)
        {
            string Insert = string.Format(@"Insert into QuyetDinhCongViec(QDCongViec,IDNhanVien,MaChucVu,NgayLap,NoiDung) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", qdcv.QDCongViec, qdcv.IDNhanVien, qdcv.MaChucVu, qdcv.NgayLap, qdcv.NoiDung);
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

        public static bool Update(QuyetDinhCongViec qdcv)
        {
            string TruyVan = string.Format(@"Update QuyetDinhCongViec Set IDNhanVien=N'{0}',MaChucVu=N'{1}',NgayLap=N'{2}',NoiDung=N'{3}' where QDCongViec=N'{4}'", qdcv.IDNhanVien, qdcv.MaChucVu, qdcv.NgayLap, qdcv.NoiDung, qdcv.QDCongViec);
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
        public static bool Delete(QuyetDinhCongViec qdcv)
        {
            string sTruyVan = string.Format(@"Delete from QuyetDinhCongViec where  QDCongViec=N'{0}'", qdcv.QDCongViec);
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
        public static DataTable LoadQDCV()
        {
            string sTruyVan = "Select * from QuyetDinhCongViec";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadQDCV_ID(string ID)
        {
            string sTruyVan = "Select a.* from QuyetDinhCongViec a,NhanVien b where a.IDNhanVien=b.IDNhanVien and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"')";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadNVChuaCV()
        {
            string sTruyVan = "select IDNhanVien,HoTen from NhanVien where IDNhanVien not in (select IDNhanVien from QuyetDinhCongViec)";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadNVChuaCV_ID(string ID)
        {
            string sTruyVan = "select IDNhanVien,HoTen from NhanVien where IDNhanVien not in (select IDNhanVien from QuyetDinhCongViec) and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"')";
            return TaoBang(sTruyVan);
        }
    }
}
