using System.Collections.Generic;using System.Data.SqlClient;
using System.Text.RegularExpressions;using DTO;
namespace DAL{
    public class SachDAL
    {
        public List<SachDTO> LayDanhSachSach()
        {
            List<SachDTO> dsSach = new List<SachDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SACH", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SachDTO sachDTO = new SachDTO();
                    sachDTO.MaSach = reader.GetInt32(0);
                    sachDTO.TenSach = reader.GetString(1);
                    sachDTO.TacGia = reader.GetString(2);
                    sachDTO.NhaXuatBan = reader.GetString(3);
                    sachDTO.NamXuatBan = reader.GetString(4);
                    sachDTO.GiaBan = reader.GetInt32(5);
                    sachDTO.HinhAnh = reader.GetString(6);
                    sachDTO.SoLuongTon = reader.GetInt32(7);
                    sachDTO.TrangThai = reader.GetInt32(8);
                    sachDTO.TheLoai = reader.GetInt32(9);
                    dsSach.Add(sachDTO);
                }
                reader.Close();
            }
            return dsSach;
        }
        // Xóa sách
        public bool XoaSach(int maSach)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE SACH SET TrangThai = 0  WHERE MaSach=@MaSach", connection);
                command.Parameters.AddWithValue("@MaSach", maSach);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Thêm Sách
        public bool ThemSach(SachDTO sach)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO SACH(MaSach ,TenSach,TacGia,NhaXuatBan,NamXuatBan,GiaBan,HinhAnh,SoLuongTon,TrangThai,TheLoai) VALUES(@MaSach, @TenSach, @TacGia, @NhaXuatBan, @NamXuatBan, @GiaBan, @HinhAnh,@SoLuongTon,@TrangThai,@TheLoai)", connection);
                command.Parameters.AddWithValue("@MaSach", sach.MaSach);
                command.Parameters.AddWithValue("@TenSach", sach.TenSach);
                command.Parameters.AddWithValue("@TacGia", sach.TacGia);
                command.Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan);
                command.Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan);
                command.Parameters.AddWithValue("@GiaBan", sach.GiaBan);
                command.Parameters.AddWithValue("@HinhAnh", sach.HinhAnh);
                command.Parameters.AddWithValue("@SoLuongTon", sach.SoLuongTon);
                command.Parameters.AddWithValue("@TrangThai", sach.TrangThai);
                command.Parameters.AddWithValue("@TheLoai", sach.TheLoai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Cập nhật sách
        public bool CapNhatSach(SachDTO sach)
        {
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE SACH SET TenSach=@TenSach, TacGia=@TacGia,NhaXuatBan = @NhaXuatBan, NamXuatBan = @NamXuatBan, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon, HinhAnh=@HinhAnh,TrangThai = @TrangThai,TheLoai=@TheLoai WHERE MaSach = @MaSach",connection);
                command.Parameters.AddWithValue("@MaSach", sach.MaSach);
                command.Parameters.AddWithValue("@TenSach", sach.TenSach);
                command.Parameters.AddWithValue("@TacGia", sach.TacGia);
                command.Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan);
                command.Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan);
                command.Parameters.AddWithValue("@GiaBan", sach.GiaBan);
                command.Parameters.AddWithValue("@HinhAnh", sach.HinhAnh);
                command.Parameters.AddWithValue("@SoLuongTon", sach.SoLuongTon);
                command.Parameters.AddWithValue("@TrangThai", sach.TrangThai);
                command.Parameters.AddWithValue("@TheLoai", sach.TheLoai);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Tìm kiếm sách
        public List<SachDTO> TimKiemSach(string tenSach)
        {
            List<SachDTO> dsSach = new List<SachDTO>();
            using (SqlConnection connection = DBHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM SACH WHERE TenSach LIKE @TenSach",
                connection);
                command.Parameters.AddWithValue("@TenSach", "%" + tenSach + "%");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SachDTO sachDTO = new SachDTO();
                    sachDTO.MaSach = reader.GetInt32(0);
                    sachDTO.TenSach = reader.GetString(1);
                    sachDTO.TacGia = reader.GetString(2);
                    sachDTO.NhaXuatBan = reader.GetString(3);
                    sachDTO.NamXuatBan = reader.GetString(4);
                    sachDTO.GiaBan = reader.GetInt32(5);
                    sachDTO.HinhAnh = reader.GetString(6);
                    sachDTO.SoLuongTon = reader.GetInt32(7);
                    sachDTO.TrangThai = reader.GetInt32(8);
                    sachDTO.TheLoai = reader.GetInt32(9);
                    dsSach.Add(sachDTO);
                }
                reader.Close();
            }
            return dsSach;
        }

    }}