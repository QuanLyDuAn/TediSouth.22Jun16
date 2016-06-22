using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PhieuGiaoSanPham
    {
        public string IDPhieuGiao { get; set; }
        public string MaDuAn { get; set; }
        public string IDNhanVien { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoLuong { get; set; }
        public string NoiDungPhieuGiao { get; set; }
        public bool DuyetHoSo { get; set; }
    }
}
