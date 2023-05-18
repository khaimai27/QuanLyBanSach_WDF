using System.Collections.Generic;using DTO;
using DAL;
namespace BUS{
    public class TheLoaiBUS
    {
        private TheLoaiDAL theLoaiDAL = new TheLoaiDAL();
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            return theLoaiDAL.LayDanhSachTheLoai();
        }
        public TheLoaiDTO LayTheLoaiTheoMa(int maTheLoai)
        {
            return theLoaiDAL.LayTheLoaiTheoMa(maTheLoai);
        }
        //Về Nhà Làm
        //public bool ThemTheLoai(TheLoaiDTO theLoai)
        //{
        // return theLoaiDAL.ThemTheLoai(theLoai);
        //}
        //public bool CapNhatTheLoai(TheLoaiDTO theLoai)
        //{
        // return theLoaiDAL.CapNhatTheLoai(theLoai);
        //}
        //public bool XoaTheLoai(int MaTheLoai)
        //{
        // return theLoaiDAL.XoaTheLoai(MaTheLoai);
        //}
        //public List<TheLoaiDTO> TimKiemTheLoai(string tenTheLoai)
        //{
        // return theLoaiDAL.TimKiemTheLoai(tenTheLoai);
        //}
    }}