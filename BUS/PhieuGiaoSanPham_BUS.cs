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
    public class PhieuGiaoSanPham_BUS
    {

        public static DataTable LoadPGSP()
        {
            return PhieuGiaoSanPham_DAL.LoadPGSP();
        }
        public static DataTable LoadPGSP_ID(string ID)
        {
            return PhieuGiaoSanPham_DAL.LoadPGSP_ID(ID);
        }
        public static bool Insert(PhieuGiaoSanPham bp)
        {
            return PhieuGiaoSanPham_DAL.Insert(bp);
        }
        public static bool Update(PhieuGiaoSanPham bp)
        {
            return PhieuGiaoSanPham_DAL.Update(bp);
        }
        public static bool Delete(PhieuGiaoSanPham bp)
        {
            return PhieuGiaoSanPham_DAL.Delete(bp);
        }
        public static DataTable LoadLabel(string ma)
        {
            return PhieuGiaoSanPham_DAL.LoadLabel(ma);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from PhieuGiaoSanPham") == true)
                return true;
            return false;
        }
    }
}
