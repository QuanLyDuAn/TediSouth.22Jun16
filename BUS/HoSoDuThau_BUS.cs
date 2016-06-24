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
    public class HoSoDuThau_BUS
    {
        public static DataTable LoadHSDT()
        {
            return HoSoDuThau_DAL.LoadHSDT();
        }
        public static DataTable LoadHSDT_ID(string id)
        {
            return HoSoDuThau_DAL.LoadHSDT_ID(id);
        }
        public static bool Insert(HoSoDuThau bp)
        {
            return HoSoDuThau_DAL.Insert(bp);
        }
        public static bool Update(HoSoDuThau bp)
        {
            return HoSoDuThau_DAL.Update(bp);
        }
        public static bool Delete(HoSoDuThau bp)
        {
            return HoSoDuThau_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi1, string chuoi2)
        {
            if (DBConnect.KiemTraTonTai2(Chuoi1,chuoi2, "select * from HoSoDuThau") == true)
                return true;
            return false;
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            return HoSoDuThau_DAL.LoadTimKiemTheoID(ID, sTimKiem);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            return HoSoDuThau_DAL.LoadTimKiemAdmin(sTimKiem);
        }
    }
}
