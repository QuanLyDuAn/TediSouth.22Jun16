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
    public class ChiTietDieuHanh_BUS
    {
        public static DataTable LoadCTDH()
        {
            return ChiTietDieuHanh_DAL.LoadCTDH();
        }
        public static bool Insert(Chi_Tiet_Dieu_Hanh bp)
        {
            return ChiTietDieuHanh_DAL.Insert(bp);
        }
        public static bool Update(Chi_Tiet_Dieu_Hanh bp)
        {
            return ChiTietDieuHanh_DAL.Update(bp);
        }
        public static bool Delete(Chi_Tiet_Dieu_Hanh bp)
        {
            return ChiTietDieuHanh_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi1, string chuoi2)
        {
            if (DBConnect.KiemTraTonTai2(Chuoi1, chuoi2, "select * from Chi_Tiet_Dieu_Hanh") == true)
                return true;
            return false;
        }
    }
}

