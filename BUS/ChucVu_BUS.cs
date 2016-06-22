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
    public class ChucVu_BUS
    {

        public static DataTable LoadCV()
        {
            return ChucVu_DAL.LoadCV();
        }
        public static bool Insert(ChucVu bp)
        {
            return ChucVu_DAL.Insert(bp);
        }
        public static bool Update(ChucVu bp)
        {
            return ChucVu_DAL.Update(bp);
        }
        public static bool Delete(ChucVu bp)
        {
            return ChucVu_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from ChucVu") == true)
                return true;
            return false;
        }
    }
}
