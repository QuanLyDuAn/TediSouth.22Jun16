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
    public class QDDieuHanhDuAn_BUS
    {
        public static DataTable LoadQDDHDA()
        {
            return QDDieuHanhDuAn_DAL.LoadQDDH();
        }
        public static DataTable LoadQDDHDA_ID(string ID)
        {
            return QDDieuHanhDuAn_DAL.LoadQDDH_ID(ID);
        }
        public static bool Insert(QDDieuHanhDuAn bp)
        {
            return QDDieuHanhDuAn_DAL.Insert(bp);
        }
        public static bool Update(QDDieuHanhDuAn bp)
        {
            return QDDieuHanhDuAn_DAL.Update(bp);
        }
        public static bool Delete(QDDieuHanhDuAn bp)
        {
            return QDDieuHanhDuAn_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from QDDieuHanhDuAn") == true)
                return true;
            return false;
        }
        public static DataTable LoadDgvChiTiet()
        {
            return QDDieuHanhDuAn_DAL.LoadDgvChiTiet();
        }
        public static DataTable LoadDgvChiTiet_ID(string ID)
        {
            return QDDieuHanhDuAn_DAL.LoadDgvChiTiet_ID(ID);
        }
        public static DataTable LoadCbNV()
        {
            return QDDieuHanhDuAn_DAL.LoadCbbNV();
        }
        public static DataTable LoadCbNV_ID(string ID)
        {
            return QDDieuHanhDuAn_DAL.LoadCbbNV_ID(ID);
        }
    }
}
