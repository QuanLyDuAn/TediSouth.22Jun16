using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class PhuLuc_BUS:DBConnect
    {

        public static DataTable LoadPL()
        {
            return PhuLuc_DAL.LoadPL();
        }
        public static DataTable LoadPL_ID(string ID)
        {
            return PhuLuc_DAL.LoadPL_ID(ID);
        }
        public static bool Insert(PhuLuc bp)
        {
            return PhuLuc_DAL.Insert(bp);
        }
        public static bool Update(PhuLuc bp)
        {
            return PhuLuc_DAL.Update(bp);
        }
        public static bool Delete(PhuLuc bp)
        {
            return PhuLuc_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from PhuLuc") == true)
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
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            return PhuLuc_DAL.LoadTimKiemTheoID(ID, sTimKiem);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            return PhuLuc_DAL.LoadTimKiemAdmin(sTimKiem);
        }
    }
}

