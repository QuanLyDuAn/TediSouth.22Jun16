using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class HopDongGiaoKhoan_BUS
    {
        public static DataTable LoadHDGK()
        {
            return HopDongGiaoKhoan_DAL.LoadHDGK();
        }
        public static DataTable LoadHDGK_ID(string ID)
        {
            return HopDongGiaoKhoan_DAL.LoadHDGK_ID(ID);
        }
        public static bool Insert(HopDongGiaoKhoang bp)
        {
            return HopDongGiaoKhoan_DAL.Insert(bp);
        }
        public static bool Update(HopDongGiaoKhoang bp)
        {
            return HopDongGiaoKhoan_DAL.Update(bp);
        }
        public static bool Delete(HopDongGiaoKhoang bp)
        {
            return HopDongGiaoKhoan_DAL.Delete(bp);
        }
        public static DataTable LoadDuAnTheoHD(string maHD)
        {
            return HopDongGiaoKhoan_DAL.LoadDuAnTheoHD(maHD);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from HopDongGiaoKhoan") == true)
                return true;
            return false;
        }
    }
}
