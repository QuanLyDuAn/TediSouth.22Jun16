using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BoPhan_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<BoPhan> LoadBoPhan()
        {
            string TruyVan = "Select * from BoPhan";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BoPhan> listBoPhan = new List<BoPhan>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BoPhan bp = new BoPhan();
                bp.MaBoPhan = dt.Rows[i]["MaBoPhan"].ToString();
                bp.TenBoPhan = dt.Rows[i]["TenBoPhan"].ToString();
                listBoPhan.Add(bp);
            }
            DongKetNoi(con);
            return listBoPhan;
        }

        public static bool Insert(BoPhan boPhan)
        {
            string Insert = string.Format(@"Insert into BoPhan(MaBoPhan,TenBoPhan) Values (N'{0}',N'{1}')", boPhan.MaBoPhan, boPhan.TenBoPhan);
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


        public static bool Update(BoPhan boPhan)
        {
            string TruyVan = string.Format(@"Update BoPhan Set TenBoPhan=N'{0}' where MaBoPhan=N'{1}'", boPhan.TenBoPhan, boPhan.MaBoPhan);

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
        public static bool Delete(BoPhan boPhan)
        {
            string sTruyVan = string.Format(@"Delete from BoPhan where  MaBoPhan=N'{0}'", boPhan.MaBoPhan);
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
        public static DataTable LoadBP()
        {
            string sTruyVan = "Select * from BoPhan";
            return TaoBang(sTruyVan);
        }
    }
}
