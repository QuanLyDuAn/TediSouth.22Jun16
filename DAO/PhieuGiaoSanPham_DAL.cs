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
    public class PhieuGiaoSanPham_DAL : DBConnect
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<PhieuGiaoSanPham> LoadPhieuGiaoSanPham()
        {
            string TruyVan = "Select * from PhieuGiaoSanPham";
            con = KetNoi();
            DataTable dt = LayDataTable(TruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuGiaoSanPham> listPhieuGiaoSanPham = new List<PhieuGiaoSanPham>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuGiaoSanPham pgsp = new PhieuGiaoSanPham();
                pgsp.IDPhieuGiao = dt.Rows[i]["IDPhieuGiao"].ToString();
                pgsp.MaDuAn = dt.Rows[i]["MaDuAn"].ToString();
                pgsp.IDNhanVien = dt.Rows[i]["IDNhanVien"].ToString();
                pgsp.TieuDe = dt.Rows[i]["TieuDe"].ToString();
                pgsp.NgayLap = Convert.ToDateTime(dt.Rows[i]["NgayLap"].ToString());
                pgsp.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());
                pgsp.NoiDungPhieuGiao = dt.Rows[i]["NoiDungPhieuGiao"].ToString();
                pgsp.DuyetHoSo = Convert.ToBoolean(dt.Rows[i]["DuyetHoSo"].ToString());
                listPhieuGiaoSanPham.Add(pgsp);
            }
            DongKetNoi(con);
            return listPhieuGiaoSanPham;
        }

        public static bool Insert(PhieuGiaoSanPham phieuGiaoSP)
        {
            string Insert = string.Format(@"Insert into PhieuGiaoSanpham(IDPhieuGiao,MaDuAn,IDNhanVien,TieuDe,NgayLap,SoLuong,NoiDungPhieuGiao,DuyetHoSo) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", phieuGiaoSP.IDPhieuGiao, phieuGiaoSP.MaDuAn, phieuGiaoSP.IDNhanVien, phieuGiaoSP.TieuDe, phieuGiaoSP.NgayLap, phieuGiaoSP.SoLuong, phieuGiaoSP.NoiDungPhieuGiao, phieuGiaoSP.DuyetHoSo);
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

        public static bool Update(PhieuGiaoSanPham phieuGiaoSP)
        {
            string TruyVan = string.Format(@"Update PhieuGiaoSanPham Set MaDuAn=N'{0}',IDNhanVien=N'{1}',TieuDe=N'{2}',NgayLap=N'{3}',SoLuong=N'{4}',NoiDungPhieuGiao=N'{5}',DuyetHoSo=N'{6}' where IDPhieuGiao=N'{7}'", phieuGiaoSP.MaDuAn, phieuGiaoSP.IDNhanVien, phieuGiaoSP.TieuDe, phieuGiaoSP.NgayLap, phieuGiaoSP.SoLuong, phieuGiaoSP.NoiDungPhieuGiao, phieuGiaoSP.DuyetHoSo, phieuGiaoSP.IDPhieuGiao);
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
        public static bool Delete(PhieuGiaoSanPham phieuGiaoSP)
        {
            string sTruyVan = string.Format(@"Delete from PhieuGiaoSanPham where  IDPhieuGiao=N'{0}'", phieuGiaoSP.IDPhieuGiao);
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
        public static DataTable LoadPGSP()
        {
            string sTruyVan = "Select * from PhieuGiaoSanPham";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadPGSP_ID(string ID)
        {
            string sTruyVan = "select a.* from PhieuGiaoSanPham a, HopDongGiaoKhoan b where a.MaDuAn=b.MaDuAn  and b.MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='"+ID+"') order by NgayLap desc";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadLabel(string ma)
        {
            return TaoBang("select MaChucVu,TenDonVi from DonVi a, NhanVien b, QuyetDinhCongViec c where a.MaDonVi=b.MaDonVi and  b.IDNhanVien=c.IDNhanVien and b.IDNhanVien='"+ma+"'");
        }
        public static DataTable LoadTimKiemTheoID(string ID, string sTimKiem)
        {
            string sTruyVan = "select a.* from PhieuGiaoSanPham a, HopDongGiaoKhoan b where (IDPhieuGiao like '%" + sTimKiem + "%' or a.MaDuAn like '%" + sTimKiem + "%' or IDNhanVien like '%" + sTimKiem + "%' or TieuDe like N'%" + sTimKiem + "%') and MaDonVi=(select MaDonVi from NhanVien where IDNhanVien='" + ID + "') and a.MaDuAn=b.MaDuAn";
            return TaoBang(sTruyVan);
        }
        public static DataTable LoadTimKiemAdmin(string sTimKiem)
        {
            string sTruyVan = "select * from PhieuGiaoSanPham where IDPhieuGiao like '%" + sTimKiem + "%' or MaDuAn like '%" + sTimKiem + "%' or IDNhanVien like '%" + sTimKiem + "%' or TieuDe like N'%" + sTimKiem + "%'";
            return TaoBang(sTruyVan);
        }
    }
}
