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
    public class QuyetDinhCongViec_BUS
    {
        public static DataTable LoadQDCV()
        {
            return QuyetDinhCongViec_DAL.LoadQDCV();
        }
        public static DataTable LoadQDCV_ID(string ID)
        {
            return QuyetDinhCongViec_DAL.LoadQDCV_ID(ID);
        }
        public static DataTable LoadNVChuaCV()
        {
            return QuyetDinhCongViec_DAL.LoadNVChuaCV();
        }
        public static DataTable LoadNVChuaCV_ID(string ID)
        {
            return QuyetDinhCongViec_DAL.LoadNVChuaCV_ID(ID);
        }
        public static bool Insert(QuyetDinhCongViec bp)
        {
            return QuyetDinhCongViec_DAL.Insert(bp);
        }
        public static bool Update(QuyetDinhCongViec bp)
        {
            return QuyetDinhCongViec_DAL.Update(bp);
        }
        public static bool Delete(QuyetDinhCongViec bp)
        {
            return QuyetDinhCongViec_DAL.Delete(bp);
        }
        public static bool KiemTra(string Chuoi)
        {
            if (DBConnect.KiemTraTonTai(Chuoi, "select * from QuyetDinhCongViec") == true)
                return true;
            return false;
        }
    }
}
