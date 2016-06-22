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
    public class DonVi_BUS
    {
        public static DataTable LoadDV()
        {
            return DonVi_DAL.LoadDV();
        }
        public static bool Insert(DonVi bp)
        {
            return DonVi_DAL.Insert(bp);
        }
        public static bool Update(DonVi bp)
        {
            return DonVi_DAL.Update(bp);
        }
        public static bool Delete(DonVi bp)
        {
            return DonVi_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from DonVi") == true)
                return true;
            return false;
        }
    }
}
