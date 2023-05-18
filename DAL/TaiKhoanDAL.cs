using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public TaiKhoanDTO DangNhap(string taiKhoan, string matKhau)
        {
            TaiKhoanDTO taiKhoanDTO = null;

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau", connection);
                command.Parameters.AddWithValue("@TenDangNhap", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.TenDangNhap = reader.GetString(1);
                    taiKhoanDTO.MatKhau = reader.GetString(2);
                    taiKhoanDTO.MaNhanVien = reader.GetInt32(3);
                    taiKhoanDTO.TrangThai = reader.GetInt32(4);
                }

                reader.Close();
            }

            return taiKhoanDTO;
        }
        public List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.TenDangNhap = reader.GetString(1);
                    
                    taiKhoanDTO.MatKhau = reader.GetString(2);
                    taiKhoanDTO.MaNhanVien = reader.GetInt32(3);
                    taiKhoanDTO.TrangThai = reader.GetInt32(4);
                    dsTaiKhoan.Add(taiKhoanDTO);
                }

                reader.Close();
            }

            return dsTaiKhoan;
        }
        public bool ThemTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO TAIKHOAN(MaTaiKhoan,TenDangNhap,MatKhau,MaNhanVien,TrangThai) VALUES(@MaTaiKhoan,@TenDangNhap, @MatKhau,@MaNhanVien, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", taiKhoan.MaTaiKhoan);
                command.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@MaNhanVien", taiKhoan.MaNhanVien);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Hàm cập nhật tài khoản
        public bool CapNhatTaiKhoan(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE TAIKHOAN SET TenDangNhap=@TenDangNhap,MatKhau=@MatKhau,MaNhanVien=@MaNhanVien,TrangThai=@TrangThai WHERE MaTaiKhoan=@MaTaiKhoan", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", taiKhoan.MaTaiKhoan);
                command.Parameters.AddWithValue("@TenDangNhap", taiKhoan.TenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", taiKhoan.MatKhau);
                command.Parameters.AddWithValue("@MaNhanVien", taiKhoan.MaNhanVien);
                command.Parameters.AddWithValue("@TrangThai", taiKhoan.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool XoaTaiKhoan(int maTaiKhoan)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM TAIKHOAN WHERE MaTaiKhoan=@MaTaiKhoan", connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public List<TaiKhoanDTO> TimKiemTaiKhoan(string taiKhoan)
        {
            List<TaiKhoanDTO> dsTaiKhoan = new List<TaiKhoanDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN WHERE TenDangNhap LIKE @TenDangNhap", connection);
                command.Parameters.AddWithValue("@TenDangNhap", "%" + taiKhoan + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTaiKhoan = reader.GetInt32(0);
                    taiKhoanDTO.TenDangNhap = reader.GetString(1);

                    taiKhoanDTO.MatKhau = reader.GetString(2);
                    taiKhoanDTO.MaNhanVien = reader.GetInt32(3);
                    taiKhoanDTO.TrangThai = reader.GetInt32(4);
                    dsTaiKhoan.Add(taiKhoanDTO);
                }

                reader.Close();
            }

            return dsTaiKhoan;
        }

    }
}
