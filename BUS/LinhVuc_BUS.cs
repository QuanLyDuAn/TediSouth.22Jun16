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
    public class LinhVuc_BUS
    {
        public static DataTable LoadLV()
        {
            return LinhVuc_DAL.LoadLV();
        }
        public static bool Insert(LinhVuc bp)
        {
            return LinhVuc_DAL.Insert(bp);
        }
        public static bool Update(LinhVuc bp)
        {
            return LinhVuc_DAL.Update(bp);
        }
        public static bool Delete(LinhVuc bp)
        {
            return LinhVuc_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from LinhVuc") == true)
                return true;
            return false;
        }
    }
}
