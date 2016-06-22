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
    public class QuyetDinhDieuHanh_BUS
    {
        public static DataTable LoadQuyetDinhDH()
        {
            return QuyetDinhDieuHanh_DAL.LoadQuyetDinhDH();
        }
    }
}
