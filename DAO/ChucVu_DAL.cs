
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
    public class ChucVu_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<ChucVu> LoadChucVu()
        {
            string TruyVan = "Select * from ChucVu";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu> listChucVu = new List<ChucVu>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu cv = new ChucVu();
                cv.MaChucVu = dt.Rows[i]["MaChucVu"].ToString();
                cv.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                listChucVu.Add(cv);
            }
            DongKetNoi(con);
            return listChucVu;
        }

        public static bool Insert(ChucVu chucVu)
        {
            string Insert = string.Format(@"Insert into ChucVu(MaChucVu,TenChucVu) Values (N'{0}',N'{1}')", chucVu.MaChucVu,chucVu.TenChucVu);
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

        public static bool Update(ChucVu chucVu)
        {
            string TruyVan = string.Format(@"Update ChucVu Set TenChucVu=N'{0}' where MaChucVu=N'{1}'", chucVu.TenChucVu,chucVu.MaChucVu);
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
        public static bool Delete(ChucVu chucVu)
        {
            string sTruyVan = string.Format(@"Delete from ChucVu where  MaChucVu=N'{0}'", chucVu.MaChucVu);
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
            string sTruyVan = "Select * from ChucVu";
            return TaoBang(sTruyVan);
        }
    }
}
