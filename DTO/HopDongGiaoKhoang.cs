using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HopDongGiaoKhoang
    {
        public string MaHopDongGK { get; set; }
        public string MaHopDong { get; set; }
        public string MaDonVi { get; set; }
        public string MaDuAn { get; set; }
        public DateTime NgayLapHDGK { get; set; }
        public DateTime NgayDuyetHDGK { get; set; }
        public double KinhPhi { get; set; }
        public string NoiDungHoDongGK { get; set; }

    }
}
