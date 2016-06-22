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
    public class BoPhan_BUS : DBConnect
    {

        public static DataTable LoadBoPhan()
        {
            return BoPhan_DAL.LoadBP();
        }
        public static bool Insert(BoPhan bp)
        {
            return BoPhan_DAL.Insert(bp);
        }
        public static bool Update(BoPhan bp)
        {
            return BoPhan_DAL.Update(bp);
        }
        public static bool Delete(BoPhan bp)
        {
            return BoPhan_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from BoPhan") == true)
                return true;
            return false;
        }
        public static bool KiemTra1(string txtbox)
        {
            string lenh = "Select * from BoPhan";
            if (KiemTraTonTai(txtbox, lenh) == true)
                return true;
            else
                return false;
        }
    }
}
