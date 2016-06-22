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
    public class ChiTietDonVi_BUS
    {
        public static DataTable LoadCTDV()
        {
            return ChiTietDonVi_DAL.LoadCTDV();
        }
        public static bool Insert(ChiTietDonVi bp)
        {
            return ChiTietDonVi_DAL.Insert(bp);
        }
        public static bool Update(ChiTietDonVi bp)
        {
            return ChiTietDonVi_DAL.Update(bp);
        }
        public static bool Delete(ChiTietDonVi bp)
        {
            return ChiTietDonVi_DAL.Delete(bp);
        }
        public static bool KiemTra(string chuoi1,string chuoi2)
        {
            if (DBConnect.KiemTraTonTai2(chuoi1,chuoi2, "select * from ChiTietDonVi") == true)
                return true;
            return false;
        }
    }
}
