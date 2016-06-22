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
    public class LinhVuc_DAL : DBConnect
    {
        static SqlConnection con;
        public static List<LinhVuc> LoadLinhVuc()
        {
            //Câu truy vấn
            string sTruyVan = "select * from LinhVuc";
            //mo ket noi
            con = KetNoi();
            DataTable dt = LayDataTable(sTruyVan, con);
            if (dt.Rows.Count == 0)
            { return null; }
            //tạo list hocsinh_DTO
            List<LinhVuc> listLinhvuc = new List<LinhVuc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LinhVuc lv = new LinhVuc();
                lv.MaLinhVuc = dt.Rows[i]["MaLinhVuc"].ToString();
                lv.TenLinhVuc = dt.Rows[i]["TenLinhVuc"].ToString();
                listLinhvuc.Add(lv);
            }
            DongKetNoi(con);
            return listLinhvuc;
        }
        DataTable dt = new DataTable();

        public static bool Insert(LinhVuc linhVuc)
        {
            string sInsert = string.Format(@"Insert into LinhVuc(MaLinhVuc,TenLinhVuc) Values (N'{0}',N'{1}')", linhVuc.MaLinhVuc, linhVuc.TenLinhVuc);
            con = KetNoi();
            try
            {

                ThucThiTruyVanNonQuery(sInsert, con);
                DongKetNoi(con);
                return true;
            }
            catch
            {
                DongKetNoi(con);
                return false;
            }
        }
        public static bool Update(LinhVuc linhVuc)
        {
            //Tao cau truy van
            string sTruyVan = string.Format(@"Update LinhVuc Set  TenLinhVuc=N'{0}' where MaLinhVuc=N'{1}'", linhVuc.TenLinhVuc, linhVuc.MaLinhVuc);
            con = KetNoi();
            //Thuc thi truy van
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
        public static bool Delete(LinhVuc linhVuc)
        {
            //Tao cau truy van
            string sTruyVan = string.Format(@"Delete from LinhVuc where  MaLinhVuc=N'{0}'", linhVuc.MaLinhVuc);
            con = KetNoi();
            //Thuc thi truy van
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
        public static DataTable LoadLV()
        {
            string sTruyVan = "Select * from LinhVuc";
            return TaoBang(sTruyVan);
        }
    }
}
