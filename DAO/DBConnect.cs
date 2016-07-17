using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DBConnect
    {
        //string sqlConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static string chuoiKetNoi = "Data Source=./;Initial Catalog=QLDA_TediSouth;Integrated Security=True";

        public static SqlConnection KetNoi()
        {
            SqlConnection con = new SqlConnection(chuoiKetNoi);
            con.Open();
            return con;
        }
        public static void DongKetNoi(SqlConnection con)
        {
            con.Close();
        }
        public static DataTable LayDataTable(string sTruyVan, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public static bool ThucThiTruyVanNonQuery(string sTruyVan, SqlConnection con)
        {
            try
            {
                SqlCommand com = new SqlCommand(sTruyVan, con);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool kiemtraketnoi()
        {
            SqlConnection con = new SqlConnection(chuoiKetNoi);
            try
            {
                con.Open();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable TaoBang(string TruyVan)
        {
            SqlConnection con = new SqlConnection(chuoiKetNoi);
            SqlDataAdapter da = new SqlDataAdapter(TruyVan, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public static bool KiemTraTonTai(string chuoi, string sTruyVan)

        {
            bool KT = false;
            SqlConnection con = new SqlConnection(chuoiKetNoi);
            SqlCommand da = new SqlCommand(sTruyVan, con);
            con.Open();
            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                if (chuoi == dr.GetString(0))

                {
                    KT = true;
                    break;
                }
            }
            con.Close();
            return KT;
        }
        public static bool KiemTraTonTai2(string chuoi1, string chuoi2, string sTruyVan)
        {
            bool KT = false;
            SqlConnection con = new SqlConnection(chuoiKetNoi);
            SqlCommand da = new SqlCommand(sTruyVan, con);
            con.Open();
            SqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                if (chuoi1 == dr.GetString(0) && chuoi2 == dr.GetString(1))
                {
                    KT = true;
                    break;
                }
            }
            con.Close();
            return KT;
        }


    }
}
