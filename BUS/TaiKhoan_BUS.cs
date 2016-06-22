using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static DataTable LoadTK()
        {
            return TaiKhoan_DAL.LoadTK();
        }
        public static bool Insert(TaiKhoan tk)
        {
            return TaiKhoan_DAL.Insert(tk);
        }
        public static bool Update(TaiKhoan tk)
        {
            return TaiKhoan_DAL.Update(tk);
        }
        public static bool Delete(TaiKhoan tk)
        {
            return TaiKhoan_DAL.Delete(tk);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from TaiKhoan") == true)
                return true;
            return false;
        }
    }
}
