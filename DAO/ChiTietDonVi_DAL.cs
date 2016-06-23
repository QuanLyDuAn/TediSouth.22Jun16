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
    public class ChiTietDonVi_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<ChiTietDonVi> LoadChiTietDonVi()
        {
            string TruyVan = "Select * from ChiTietDonVi";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietDonVi> listCTDV = new List<ChiTietDonVi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietDonVi ctdv = new ChiTietDonVi();
                ctdv.MaDonVi = dt.Rows[i]["MaDonVi"].ToString();
                ctdv.MaBoPhan= dt.Rows[i]["MaBoPhan"].ToString();
                listCTDV.Add(ctdv);
            }
            DongKetNoi(con);
            return listCTDV;
        }

        public static bool Insert(ChiTietDonVi chiTietDonVi)
        {
            string Insert = string.Format(@"Insert into ChiTietDonVi(MaDonVi,MaBoPhan) Values (N'{0}',N'{1}')", chiTietDonVi.MaDonVi,chiTietDonVi.MaBoPhan);
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

        public static bool Update(ChiTietDonVi chiTietDonVi)
        {
            string TruyVan = string.Format(@"Update ChiTietDonVi Set MaBoPhan=N'{0}' where MaDonVi=N'{1}'", chiTietDonVi.MaBoPhan,chiTietDonVi.MaDonVi);
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
        public static bool Delete(ChiTietDonVi ChiTietDonVi)
        {
            string sTruyVan = string.Format(@"Delete from ChiTietDonVi where  MaBoPhan=N'{0}' and MaDonVi=N'{1}' ", ChiTietDonVi.MaBoPhan,ChiTietDonVi.MaDonVi);
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
        public static DataTable LoadCTDV()
        {
            string sTruyVan = "Select * from ChiTietDonVi";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadCTDV_ID(string MaDV)
        {
            string sTruyVan =string.Format("select * from ChiTietDonVi where MaDonVi ='{0}'", MaDV);
            return TaoBang(sTruyVan);
        }
    }
}
