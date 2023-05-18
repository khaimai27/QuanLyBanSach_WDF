using DAL;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAL nhanVienDAL;

        public NhanVienBUS()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return nhanVienDAL.LayDanhSachNhanVien();
        }
        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            return nhanVienDAL.ThemNhanVien(nhanVien);
        }
        public bool CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            return nhanVienDAL.CapNhatNhanVien(nhanVien);
        }
        public bool XoaNhanVien(int maNhanVien)
        {
            return nhanVienDAL.XoaNhanVien(maNhanVien);
        }
        public NhanVienDTO LayThongTinNhanVien(int maNhanVien)
        {
            return nhanVienDAL.LayThongTinNhanVien(maNhanVien);
        }
        public List<NhanVienDTO> TimKiemNhanVien(string nhanVien)
        {
            return nhanVienDAL.TimKiemNhanVien(nhanVien);
        }
    }
}
