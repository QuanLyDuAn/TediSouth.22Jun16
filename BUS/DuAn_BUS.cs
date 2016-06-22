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
    public class DuAn_BUS
    {
        public static DataTable LoadDA()
        {
            return DuAn_DAL.LoadDA();
        }
        public static bool Insert(DuAn bp)
        {
            return DuAn_DAL.Insert(bp);
        }
        public static bool Update(DuAn bp)
        {
            return DuAn_DAL.Update(bp);
        }
        public static bool Delete(DuAn bp)
        {
            return DuAn_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from DuAn") == true)
                return true;
            return false;
        }
    }
}
