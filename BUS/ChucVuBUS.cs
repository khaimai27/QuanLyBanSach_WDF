using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVuBUS
    {
        private ChucVuDAL chucVuDAL = new ChucVuDAL();
        public List<ChucVuDTO> LayDanhSachChucVu()
        {
            return chucVuDAL.LayDanhSachChucVu();
        }
        public ChucVuDTO LayChucVuTheoMa(int maTheLoai)
        {
            return chucVuDAL.LayChucVuTheoMa(maTheLoai);
        }
    }
}
