using System.Collections.Generic;using System.Data.SqlClient;using DTO;
namespace DAL{
    public class TheLoaiDAL
    {
        public List<TheLoaiDTO> LayDanhSachTheLoai()
        {
            List<TheLoaiDTO> dsTheLoai = new List<TheLoaiDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM THELOAI Where TrangThai= 1", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TheLoaiDTO theLoaiDTO = new TheLoaiDTO();
                    theLoaiDTO.MaTheLoai = reader.GetInt32(0);
                    theLoaiDTO.TenTheLoai = reader.GetString(1);
                    theLoaiDTO.TrangThai = reader.GetInt32(2);
                    dsTheLoai.Add(theLoaiDTO);
                }
                reader.Close();
            }
            return dsTheLoai;
        }
        public TheLoaiDTO LayTheLoaiTheoMa(int maTheLoai)
        {
            TheLoaiDTO theLoaiDTO = null;
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM THELOAI WHERE MaTheLoai =@MaTheLoai ", connection);
                command.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    theLoaiDTO = new TheLoaiDTO();
                    theLoaiDTO.MaTheLoai = reader.GetInt32(0);
                    theLoaiDTO.TenTheLoai = reader.GetString(1);
                    theLoaiDTO.TrangThai = reader.GetInt32(2);
                }
                reader.Close();
            }
            return theLoaiDTO;
        }
    }}