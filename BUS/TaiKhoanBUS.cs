using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public TaiKhoanDTO DangNhap(string taiKhoan, string matKhau)
        {
            return taiKhoanDAL.DangNhap(taiKhoan, matKhau);
        }
        // Lấy danh sách tài khoản
        public List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            return taiKhoanDAL.LayDanhSachTaiKhoan();
        }
        // Thêm tài khoản
        public bool ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return taiKhoanDAL.ThemTaiKhoan(taiKhoan);
        }
        // Cập nhật tài khoản
        public bool CapNhatTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            return taiKhoanDAL.CapNhatTaiKhoan(taiKhoan);
        }
        // Xóa tài khoản
        public bool XoaTaiKhoan(int maTaiKhoan)
        {
            return taiKhoanDAL.XoaTaiKhoan(maTaiKhoan);
        }
        // Tìm kiếm tài khoản
        public List<TaiKhoanDTO> TimKiemTaiKhoan(string tenTaiKhoan)
        {
            return taiKhoanDAL.TimKiemTaiKhoan(tenTaiKhoan);
        }
    }
}