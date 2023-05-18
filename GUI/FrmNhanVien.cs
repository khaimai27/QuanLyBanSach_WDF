using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmNhanVien : Form
    {
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private ChucVuBUS chucVuBUS = new ChucVuBUS();
        private void LoadDataGridView()
        {
            dgvNhanVien.DataSource = nhanVienBUS.LayDanhSachNhanVien();
        }
        private void LoadComboBoxChucVu()
        {
            List<ChucVuDTO> listChucVu = chucVuBUS.LayDanhSachChucVu();
            cboChucVu.DataSource = listChucVu;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";
        }

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxChucVu();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                    radNam.Checked = true;
                if (row.Cells["GioiTinh"].Value.ToString() == "Nữ")
                    radNu.Checked = true;
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dtpNgayVaoLam.Text = row.Cells["NgayVaoLam"].Value.ToString();
                txtLuong.Text = row.Cells["Luong"].Value.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                cboChucVu.SelectedValue = int.Parse(row.Cells["MaChucVu"].Value.ToString());
                cboTrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
                try
                {
                    ptbHinhAnh.Image = Image.FromFile(@"hinhanh/" + row.Cells["HinhAnh"].Value.ToString());
                }
                catch (Exception ex)
                {
                    ptbHinhAnh.Image = Image.FromFile(@"hinhanh/warning.jpg");
                }
            }

        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvNhanVien.Columns[e.ColumnIndex].Name == "MaChucVu")
            {
                int maChucVu = Convert.ToInt32(e.Value); // Lấy mã chức vụ từ giá trị của ô
                                                         // Sử dụng BUS để lấy thông tin tên chức vụ
                 ChucVuDTO chucVu = chucVuBUS.LayChucVuTheoMa(maChucVu);
                if (chucVu != null)
                {
                    e.Value = chucVu.TenChucVu; // Gán giá trị tên thể loại vào ô
                    e.FormattingApplied = true; // Đã xử lý xong, không cần DataGridView format lại ô
                }
            }
            if (e.ColumnIndex == 10 && e.Value != null)
            {
                int trangThai = (int)e.Value;
                if (trangThai == 1)
                {
                    e.Value = "Hoạt động";
                }
                else if (trangThai == 0)
                {
                    e.Value = "Không hoạt động";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();

            nhanVien.TenNhanVien = txtTenNhanVien.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked == true)
                nhanVien.GioiTinh = "Nam";
            if (radNu.Checked == true)
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.DiaChi = txtDiaChi.Text;
            nhanVien.NgayVaoLam = dtpNgayVaoLam.Value;
            nhanVien.Luong = float.Parse(txtLuong.Text);
            nhanVien.HinhAnh = txtHinhAnh.Text;
            nhanVien.MaChucVu = int.Parse(cboChucVu.SelectedValue.ToString());
            nhanVien.TrangThai = cboTrangThai.SelectedIndex;
            string path = @"hinhanh\" + txtHinhAnh.Text;
            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show("Hình đã tồn tại", "Xác nhận",
               MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            if (nhanVienBUS.ThemNhanVien(nhanVien))
            {
                ptbHinhAnh.Image.Save(@"hinhanh/" + txtHinhAnh.Text);
                MessageBox.Show("Thêm Nhân Viên thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm Nhân Viên thất bại");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int maNhanVien = int.Parse(txtMaNhanVien.Text);

            if (nhanVienBUS.XoaNhanVien(maNhanVien))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            nhanVien.MaNhanVien = int.Parse(txtMaNhanVien.Text);
            nhanVien.TenNhanVien = txtTenNhanVien.Text;
            nhanVien.NgaySinh = dtpNgaySinh.Value;
            if (radNam.Checked == true)
                nhanVien.GioiTinh = "Nam";
            if (radNu.Checked == true)
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.DiaChi = txtDiaChi.Text;
            nhanVien.NgayVaoLam = dtpNgayVaoLam.Value;
            nhanVien.Luong = float.Parse(txtLuong.Text);
            nhanVien.HinhAnh = txtHinhAnh.Text;
            nhanVien.MaChucVu = int.Parse(cboChucVu.SelectedValue.ToString());
            nhanVien.TrangThai = cboTrangThai.SelectedIndex;
            string path = @"hinhanh\" + txtHinhAnh.Text;
            if (File.Exists(path))
            {
                Image img = null;
                using (Image image = Image.FromFile(path))
                {
                    ptbHinhAnh.Image?.Dispose();
                    ptbHinhAnh.Image = new Bitmap(image);
                    img = new Bitmap(image);
                }
                File.Delete(path);
                img.Save(path);
            }
            else ptbHinhAnh.Image.Save(path);
            if (nhanVienBUS.CapNhatNhanVien(nhanVien))
            {
                MessageBox.Show("Sửa Nhân Viên thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Sửa Nhân Viên thất bại");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files  (*.*) | *.* ";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin ảnh được chọn
                string filePath = openFileDialog.FileName;
                // Hiển thị tên tập tin ảnh lên textbox txtTenHinh
                txtHinhAnh.Text = Path.GetFileName(filePath);
                // Hiển thị ảnh lên pictureBox ptbHinh
                ptbHinhAnh.Image = Image.FromFile(filePath);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTim.Text;
            dgvNhanVien.DataSource = nhanVienBUS.TimKiemNhanVien(tenNhanVien);
        }
    }
}
