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
    public class NhanVien_BUS
    {

        public static DataTable LoadNV()
        {
            return NhanVien_DAL.LoadNV();
        }
        public static DataTable LoadNV_ID(string ID)
        {
            return NhanVien_DAL.LoadNV_ID(ID);
        }
        public static bool Insert(NhanVien nv)
        {
            return NhanVien_DAL.Insert(nv);
        }
        public static bool Update(NhanVien bp)
        {
            return NhanVien_DAL.Update(bp);
        }
        public static bool Delete(NhanVien bp)
        {
            return NhanVien_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from NhanVien") == true)
                return true;
            return false;
        }
        public static DataTable LoadBPTheoDV(string MaDV)
        {
            return NhanVien_DAL.LoadBPTheoDV(MaDV);
        }
    }
}
