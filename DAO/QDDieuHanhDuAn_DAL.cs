using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class QDDieuHanhDuAn_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<DTO.QDDieuHanhDuAn> LoadQuyetDinhDieuHanh()
        {
            string TruyVan = "Select * from QuyetDinhDieuHanh";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO.QDDieuHanhDuAn> listQDDieuHanhDuAn = new List<DTO.QDDieuHanhDuAn>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO.QDDieuHanhDuAn qddh = new DTO.QDDieuHanhDuAn();
                qddh.QDDieuHanh = dt.Rows[i]["QDDieuHanh"].ToString();
                qddh.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                qddh.NgayLapDieuHanh = Convert.ToDateTime(dt.Rows[i]["NgayLapDieuHanh"].ToString());
                qddh.NgayDuyetDieuHanh = Convert.ToDateTime(dt.Rows[i]["NgayDuyetDieuHanh"].ToString());
                qddh.NoiDungDieuHanh = dt.Rows[i]["NoiDungDieuHanh"].ToString();
                listQDDieuHanhDuAn.Add(qddh);
            }
            DongKetNoi(con);
            return listQDDieuHanhDuAn;
        }

        public static bool Insert(DTO.QDDieuHanhDuAn qddh)
        {
            string Insert = string.Format(@"Insert into QDDieuHanhDuAn(QDDieuHanh,MaDuAn,NgayLapDieuHanh,NgayDuyetDieuHanh,NoiDungDieuHanh) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", qddh.QDDieuHanh, qddh.MaDuAn, qddh.NgayLapDieuHanh, qddh.NgayDuyetDieuHanh, qddh.NoiDungDieuHanh);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(Insert, con);
                DongKetNoi(con);
                return true;
            }
            catch
            {
                DongKetNoi(con);
                return false;
            }
        }

        public static bool Update(DTO.QDDieuHanhDuAn qddh)
        {
            string TruyVan = string.Format(@"Update QDDieuHanhDuAn Set MaDuAn=N'{0}',NgayLapDieuHanh=N'{1}',NgayDuyetDieuHanh=N'{2}',NoiDungDieuHanh=N'{3}' where QDDieuHanh=N'{4}'", qddh.MaDuAn, qddh.NgayLapDieuHanh, qddh.NgayDuyetDieuHanh, qddh.NoiDungDieuHanh, qddh.QDDieuHanh);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(TruyVan, con);
                DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DongKetNoi(con);
                return false;
            }
        }
        public static bool Delete(DTO.QDDieuHanhDuAn qddh)
        {
            string sTruyVan = string.Format(@"Delete from QDDieuHanhDuAn where  QDDieuHanh=N'{0}'", qddh.QDDieuHanh);
            con = KetNoi();
            try
            {
                ThucThiTruyVanNonQuery(sTruyVan, con);
                DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DongKetNoi(con);
                return false;
            }
        }
        public static DataTable LoadQDDH()
        {
            string sTruyVan = "Select * from QDDieuHanhDuAn";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadQDDH_ID(string ID)
        {
            string sTruyVan = "select a.* from QDDieuHanhDuAn a, HopDongGiaoKhoan b, NhanVien c where b.MaDuAn=a.MaDuAn and c.MaDonVi=b.MaDonVi and c.IDNhanVien='"+ID+"'";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadCbbNV()
        {
            return TaoBang("select a.IDNhanVien,HoTen,MaChucVu from NhanVien a,QuyetDinhCongViec c where a.IDNhanVien=c.IDNhanVien and MaChucVu!='CV'");
        }
        public static DataTable LoadCbbNV_ID(string ID)
        {
            return TaoBang("select a.IDNhanVien,HoTen,MaChucVu from NhanVien a,QuyetDinhCongViec c where a.IDNhanVien=c.IDNhanVien and MaChucVu!='CV' and MaDonVi = (select MaDonVi from NhanVien where IDNhanVien='"+ID+"')");
        }
        public static DataTable LoadDgvChiTiet()
        {
            return TaoBang("select  * from Chi_Tiet_Dieu_Hanh");
        }
        public static DataTable LoadDgvChiTiet_ID(string ID)
        {
            return TaoBang("select a.* from Chi_Tiet_Dieu_Hanh a, NhanVien b where a.IDNhanVien=b.IDNhanVien and MaDonVi = (select MaDonVi from NhanVien where IDNhanVien='"+ID+"')");
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            string sTruyVan = "select a.* from QDDieuHanhDuAn a, HopDongGiaoKhoan b where (QDDieuHanh like '%" + sTimKiem + "%' or a.MaDuAn like	'%" + sTimKiem + "%') and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "') and a.MaDuAn=b.MaDuAn";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from QDDieuHanhDuAn where QDDieuHanh like '%" + sTimKiem + "%' or MaDuAn like	'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
