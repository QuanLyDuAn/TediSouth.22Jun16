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
    public class TaiKhoan_DAL:DBConnect
    {
        static SqlConnection con;
        public static DataTable LoadTK()
        {
            return TaoBang("Select * from TaiKhoan");
        }
        public static bool Insert(TaiKhoan tk)
        {
            string sInsert = string.Format(@"Insert into TaiKhoan(Name,Pass,IDNhanVien,HoatDong) Values (N'{0}',N'{1}',N'{2}',N'{3}')", tk.Name, tk.Pass,tk.IDNhanVien,tk.HoatDong);
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
        public static bool Update(TaiKhoan tk)
        {
            //Tao cau truy van
            string sTruyVan = string.Format(@"Update TaiKhoan Set  Pass=N'{0}',HoatDong='{1}',IDNhanVien=N'{2}' where Name=N'{3}'", tk.Pass, tk.HoatDong,tk.IDNhanVien,tk.Name);
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
        public static bool Delete(TaiKhoan tk)
        {
            //Tao cau truy van
            string sTruyVan = string.Format(@"Delete from TaiKhoan where  Name=N'{0}'", tk.Name);
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
    }
}
