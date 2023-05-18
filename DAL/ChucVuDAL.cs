using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        public List<ChucVuDTO> LayDanhSachChucVu()
        {
            List<ChucVuDTO> dsChucVu = new List<ChucVuDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CHUCVU", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ChucVuDTO chucVuDTO = new ChucVuDTO();
                    chucVuDTO.MaChucVu = reader.GetInt32(0);
                    chucVuDTO.TenChucVu = reader.GetString(1);
                    chucVuDTO.TrangThai = reader.GetInt32(2);
                    dsChucVu.Add(chucVuDTO);
                }

                reader.Close();
            }

            return dsChucVu;
        }
        public ChucVuDTO LayChucVuTheoMa(int maChucVu)
        {
            ChucVuDTO chucVuDTO = null;
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CHUCVU WHERE MaChucVu = @MaChucVu ", connection);
                command.Parameters.AddWithValue("@MaChucVu", maChucVu);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    chucVuDTO = new ChucVuDTO();
                    chucVuDTO.MaChucVu = reader.GetInt32(0);
                    chucVuDTO.TenChucVu = reader.GetString(1);
                    chucVuDTO.TrangThai = reader.GetInt32(2);
                }
                reader.Close();
            }
            return chucVuDTO;
        }
    }
}
