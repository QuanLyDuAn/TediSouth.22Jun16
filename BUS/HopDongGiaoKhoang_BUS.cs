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
   public class HopDongGiaoKhoang_BUS
    {
        public static DataTable LoadHopDongGiaoKhoang()
        {
            return HopDongGiaoKhoan_DAL.LoadHopDongGiaoKhoang();
        }
    }
}
