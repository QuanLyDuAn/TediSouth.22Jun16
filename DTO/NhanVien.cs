using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string IDNhanVien { get; set; }
        public string MaDonVi { get; set; }
        public string MaBoPhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string DienThoaiNhanVien { get; set; }
        public string DiaChi { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
