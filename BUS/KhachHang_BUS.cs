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
    public class KhachHang_BUS
    {
        public static DataTable LoadKH()
        {
            return KhachHang_DAL.LoadKH();
        }
        public static bool Insert(KhachHang bp)
        {
            return KhachHang_DAL.Insert(bp);
        }
        public static bool Update(KhachHang bp)
        {
            return KhachHang_DAL.Update(bp);
        }
        public static bool Delete(KhachHang bp)
        {
            return KhachHang_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from KhachHang") == true)
                return true;
            return false;
        }
    }
}
