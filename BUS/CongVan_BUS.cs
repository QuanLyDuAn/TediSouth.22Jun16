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
    public class CongVan_BUS
    {
        public static DataTable LoadCV()
        {
            return CongVan_DAL.LoadCV();
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            return CongVan_DAL.LoadTimKiemTheoID(ID, sTimKiem);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            return CongVan_DAL.LoadTimKiemAdmin(sTimKiem);
        }
        public static DataTable LoadCV_ID(string ID)
        {
            return CongVan_DAL.LoadCV_ID(ID);
        }
        public static bool Insert(CongVan bp)
        {
            return CongVan_DAL.Insert(bp);
        }
        public static bool Update(CongVan bp)
        {
            return CongVan_DAL.Update(bp);
        }
        public static bool Delete(CongVan bp)
        {
            return CongVan_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from CongVan") == true)
                return true;
            return false;
        }
        public static DataTable LoadNVTheoDA(string maDA)
        {
            return CongVan_DAL.LoadNVTheoDA(maDA);
        }
    }
}
