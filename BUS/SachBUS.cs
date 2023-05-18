﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
    public class SachBUS
    {
        private SachDAL sachDAL = new SachDAL();
        public List<SachDTO> LayDanhSachSach()
        {
            return sachDAL.LayDanhSachSach();
        }
        public bool ThemSach(SachDTO sach)
        {
            return sachDAL.ThemSach(sach);
        }
        public bool CapNhatSach(SachDTO sach)
        {
            return sachDAL.CapNhatSach(sach);
        }
        public bool XoaSach(int MaSach)
        {
            return sachDAL.XoaSach(MaSach);
        }
        public List<SachDTO> TimKiemSach(string tenSach)
        {
            return sachDAL.TimKiemSach(tenSach);
        }
    }