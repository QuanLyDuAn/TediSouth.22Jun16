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
    public class ChiTietDieuHanh_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<Chi_Tiet_Dieu_Hanh> LoadChi_Tiet_Dieu_Hanh()
        {
            string TruyVan = "Select * from Chi_Tiet_Dieu_Hanh";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Chi_Tiet_Dieu_Hanh> listCTDH = new List<Chi_Tiet_Dieu_Hanh>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Chi_Tiet_Dieu_Hanh ctdh = new Chi_Tiet_Dieu_Hanh();
                ctdh.QDDieuHanh = dt.Rows[i]["QDDIeuHanh"].ToString();
                ctdh.IDNhanVien = dt.Rows[i]["IDNhanVien"].ToString();
                ctdh.ViTriPhanCong = dt.Rows[i]["ViTriPhanCong"].ToString();
                listCTDH.Add(ctdh);
            }
            DongKetNoi(con);
            return listCTDH;
        }

        public static bool Insert(Chi_Tiet_Dieu_Hanh chiTietDieuHanh)
        {
            string Insert = string.Format(@"Insert into Chi_Tiet_Dieu_Hanh(QDDieuHanh,IDNhanVien,ViTriPhanCong) Values (N'{0}',N'{1}',N'{2}')", chiTietDieuHanh.QDDieuHanh,chiTietDieuHanh.IDNhanVien,chiTietDieuHanh.ViTriPhanCong);
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

        public static bool Update(Chi_Tiet_Dieu_Hanh chiTietDieuHanh)
        {
            string TruyVan = string.Format(@"Update Chi_Tiet_Dieu_Hanh Set ViTriPhanCong=N'{0}' where QDDieuHanh=N'{1}' and IDNhanVien=N'{2}'",chiTietDieuHanh.ViTriPhanCong,chiTietDieuHanh.QDDieuHanh,chiTietDieuHanh.IDNhanVien);
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
        public static bool Delete(Chi_Tiet_Dieu_Hanh chiTietDieuHanh)
        {
            string sTruyVan = string.Format(@"Delete from Chi_Tiet_Dieu_Hanh where  QDDieuHanh=N'{0}' and IDNhanVien=N'{1}'", chiTietDieuHanh.QDDieuHanh,chiTietDieuHanh.IDNhanVien);
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
        public static DataTable LoadCTDH()
        {
            string sTruyVan = "Select * from Chi_Tiet_Dieu_Hanh";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadCTDH_ID(string ID)
        {
            string sTruyVan = string.Format("Select * from Chi_Tiet_Dieu_Hanh where QDDieuHanh=N'{0}'",ID);
            return TaoBang(sTruyVan);
        }
    }
}
