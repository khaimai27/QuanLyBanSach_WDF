using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using DTO;
namespace DAL
{
    public class NhanVienDAL
    {
        public List<NhanVienDTO> TimKiemNhanVien(string nhanVien)
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE TenNhanVien LIKE @TenNhanVien", connection);
                command.Parameters.AddWithValue("@TenNhanVien", "%" + nhanVien + "%");
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.MaNhanVien = reader.GetInt32(0);
                    nhanVienDTO.TenNhanVien = reader.GetString(1);
                    nhanVienDTO.NgaySinh = reader.GetDateTime(2);
                    nhanVienDTO.GioiTinh = reader.GetString(3);
                    nhanVienDTO.SoDienThoai = reader.GetString(4);
                    nhanVienDTO.DiaChi = reader.GetString(5);
                    nhanVienDTO.NgayVaoLam = reader.GetDateTime(6);
                    nhanVienDTO.Luong = (float)reader.GetDouble(7);
                    nhanVienDTO.HinhAnh = reader.GetString(8);
                    nhanVienDTO.MaChucVu = reader.GetInt32(9);
                    nhanVienDTO.TrangThai = reader.GetInt32(10);
                    dsNhanVien.Add(nhanVienDTO);
                }

                reader.Close();
            }

            return dsNhanVien;
        }
        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NhanVienDTO nhanVienDTO = new NhanVienDTO();
                    nhanVienDTO.MaNhanVien = reader.GetInt32(0);
                    nhanVienDTO.TenNhanVien = reader.GetString(1);
                    nhanVienDTO.NgaySinh = reader.GetDateTime(2);
                    nhanVienDTO.GioiTinh = reader.GetString(3);
                    nhanVienDTO.SoDienThoai = reader.GetString(4);
                    nhanVienDTO.DiaChi = reader.GetString(5);
                    nhanVienDTO.NgayVaoLam = reader.GetDateTime(6);
                    nhanVienDTO.Luong = (float)reader.GetDouble(7);
                    nhanVienDTO.HinhAnh = reader.GetString(8);
                    nhanVienDTO.MaChucVu = reader.GetInt32(9);
                    nhanVienDTO.TrangThai = reader.GetInt32(10);
                    dsNhanVien.Add(nhanVienDTO);
                }

                reader.Close();
            }

            return dsNhanVien;
        }
        //Thêm nhân viên
        public bool ThemNhanVien(NhanVienDTO nhanVien)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO NHANVIEN(MaNhanVien,TenNhanVien, NgaySinh, GioiTinh, SoDienThoai, DiaChi, NgayVaoLam, Luong, HinhAnh, MaChucVu, TrangThai) VALUES(@MaNhanVien,@TenNhanVien, @NgaySinh, @GioiTinh, @SoDienThoai, @DiaChi, @NgayVaoLam, @Luong, @HinhAnh, @MaChucVu, @TrangThai)", connection);
                command.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
                command.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
                command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", nhanVien.SoDienThoai);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@NgayVaoLam", nhanVien.NgayVaoLam);
                command.Parameters.AddWithValue("@Luong", nhanVien.Luong);
                command.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
                command.Parameters.AddWithValue("@MaChucVu", nhanVien.MaChucVu);
                command.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Cập nhật nhân viên
        public bool CapNhatNhanVien(NhanVienDTO nhanVien)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET TenNhanVien=@TenNhanVien, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, SoDienThoai=@SoDienThoai, DiaChi=@DiaChi, NgayVaoLam=@NgayVaoLam, Luong=@Luong, HinhAnh=@HinhAnh, MaChucVu=@MaChucVu, TrangThai=@TrangThai Where MaNhanVien=@MaNhanVien", connection);
                command.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
                command.Parameters.AddWithValue("@TenNhanVien", nhanVien.TenNhanVien);
                command.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", nhanVien.SoDienThoai);
                command.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                command.Parameters.AddWithValue("@NgayVaoLam", nhanVien.NgayVaoLam);
                command.Parameters.AddWithValue("@Luong", nhanVien.Luong);
                command.Parameters.AddWithValue("@HinhAnh", nhanVien.HinhAnh);
                command.Parameters.AddWithValue("@MaChucVu", nhanVien.MaChucVu);
                command.Parameters.AddWithValue("@TrangThai", nhanVien.TrangThai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Xóa nhân viên
        public bool XoaNhanVien(int maNhanVien)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE NHANVIEN SET TrangThai= 0 WHERE MaNhanVien=@MaNhanVien", connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Thêm thông tin 1 nhân viên
        public NhanVienDTO LayThongTinNhanVien(int maNhanVien)
        {
            NhanVienDTO nhanVien = null;

            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NHANVIEN WHERE MaNhanVien = @MaNhanVien", connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nhanVien = new NhanVienDTO();
                    nhanVien.MaNhanVien = reader.GetInt32(0);
                    nhanVien.TenNhanVien = reader.GetString(1);
                    nhanVien.NgaySinh = reader.GetDateTime(2);
                    nhanVien.GioiTinh = reader.GetString(3);
                    nhanVien.SoDienThoai = reader.GetString(4);
                    nhanVien.DiaChi = reader.GetString(5);
                    nhanVien.NgayVaoLam = reader.GetDateTime(6);
                    nhanVien.Luong = (float)reader.GetDouble(7);
                    nhanVien.HinhAnh = reader.GetString(8);
                    nhanVien.MaChucVu = reader.GetInt32(9);
                    nhanVien.TrangThai = reader.GetInt32(10);
                }

                reader.Close();
            }
            return nhanVien;
        }



    }
}

