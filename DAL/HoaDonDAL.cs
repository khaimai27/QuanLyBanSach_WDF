using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class HoaDonDAL
    {
        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            List<HoaDonDTO> dsHoaDon = new List<HoaDonDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM HOADON", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    HoaDonDTO hoaDonDTO = new HoaDonDTO();
                    hoaDonDTO.MaHoaDon = reader.GetInt32(0);
                    hoaDonDTO.MaNhanVien = reader.GetInt32(1);
                    hoaDonDTO.MaKhachHang = reader.GetInt32(2);
                    hoaDonDTO.NgayLap = reader.GetDateTime(3);
                    hoaDonDTO.ThanhTien = (float)reader.GetDouble(4);
                    hoaDonDTO.TrangThai = reader.GetInt32(5);
                    dsHoaDon.Add(hoaDonDTO);
                }

                reader.Close();
            }
            return dsHoaDon;
        }
    }
}
