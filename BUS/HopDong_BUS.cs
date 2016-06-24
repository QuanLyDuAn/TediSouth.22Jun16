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
    public class HopDong_BUS
    {
        public static DataTable LoadHD()
        {
            return HopDong_DAL.LoadHD();
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            return HopDong_DAL.LoadTimKiemAdmin(sTimKiem);
        }
        public static bool Insert(HopDong bp)
        {
            return HopDong_DAL.Insert(bp);
        }
        public static bool Update(HopDong bp)
        {
            return HopDong_DAL.Update(bp);
        }
        public static bool Delete(HopDong bp)
        {
            return HopDong_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from HopDong") == true)
                return true;
            return false;
        }
    }
}
