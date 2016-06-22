using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class DonVi_DAL:DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<DonVi> LoadDonVi()
        {
            string TruyVan = "Select * from DonVi";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DonVi> listDonVi = new List<DonVi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonVi dv = new DonVi();
                dv.MaDonVi = dt.Rows[i]["MaDonVi"].ToString();
                dv.MaLinhVuc = dt.Rows[i]["MaLinhVuc"].ToString();
                dv.TenDonVi = dt.Rows[i]["TenDonVi"].ToString();
                dv.NguoiDaiDien = dt.Rows[i]["NguoiDaiDien"].ToString();
                dv.GioiThieu = dt.Rows[i]["GioiThieu"].ToString();
                dv.WebSite = dt.Rows[i]["WebSite"].ToString();
                dv.SDTDonVi = dt.Rows[i]["SDTDonVi"].ToString();
                dv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                listDonVi.Add(dv);
            }
            DongKetNoi(con);
            return listDonVi;
        }

        public static bool Insert(DonVi donVi)
        {
            string Insert = string.Format(@"Insert into CongVan(MaDonVi,MaLinhVuc,TenDonVi,NguoiDaiDien,GioiThieu,WebSite,SDTDonVi,DiaChi) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", donVi.MaDonVi,donVi.MaLinhVuc,donVi.TenDonVi, donVi.NguoiDaiDien, donVi.GioiThieu, donVi.WebSite, donVi.DiaChi, donVi.SDTDonVi);
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

        public static bool Update(DonVi donVi)
        {
            string TruyVan = string.Format(@"Update DonVi Set MaLinhVuc=N'{0}',TenDonVi=N'{1}',NguoiDaiDien=N'{2}',GioiThieu=N'{3}',WebSite=N'{4}',SDTDonVi=N'{5}',DiaChi=N'{6}' where MaDonVi=N'{7}'", donVi.MaLinhVuc, donVi.TenDonVi, donVi.NguoiDaiDien, donVi.GioiThieu, donVi.WebSite, donVi.DiaChi, donVi.SDTDonVi,donVi.MaDonVi);
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
        public static bool Delete(DonVi donVi)
        {
            string sTruyVan = string.Format(@"Delete from DonVi where  MaDonVI=N'{0}'", donVi.MaDonVi);
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
        public static DataTable LoadDV()
        {
            string sTruyVan = "Select * from DonVi";
            return TaoBang(sTruyVan);
        }
    }
}
