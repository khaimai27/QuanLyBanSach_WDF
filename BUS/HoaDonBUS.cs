using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    
    public class HoaDonBUS
    {
        private HoaDonDAL hoaDonDAL;
        public HoaDonBUS()
        {
            hoaDonDAL = new HoaDonDAL();
        }


        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            return hoaDonDAL.LayDanhSachHoaDon();
        }
    }
}
