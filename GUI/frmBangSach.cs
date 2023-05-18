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
    public partial class frmBangSach : Form
    {

        private SachBUS sachBUS = new SachBUS();
        private TheLoaiBUS theLoaiBUS = new TheLoaiBUS();

        private void LoadDataGridView()
        {
            dgvSach.DataSource = sachBUS.LayDanhSachSach();
        }
        public frmBangSach()
        {
            InitializeComponent();
        }

        private void frmBangSach_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxTheLoai();
        }
        private void LoadComboBoxTheLoai()
        {
            List<TheLoaiDTO> listTheLoai = theLoaiBUS.LayDanhSachTheLoai();
            cboTheLoai.DataSource = listTheLoai;
            cboTheLoai.DisplayMember = "TenTheLoai";
            cboTheLoai.ValueMember = "MaTheLoai";
        }
        private void dgvSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvSach.Columns[e.ColumnIndex].Name == "TheLoai")
            {
                int maTheLoai = Convert.ToInt32(e.Value); // Lấy mã thể loại từ giá trị của ô
                                                          // Sử dụng BUS để lấy thông tin tên thể loại
                TheLoaiDTO theLoai = theLoaiBUS.LayTheLoaiTheoMa(maTheLoai);
                if (theLoai != null)
                {
                    e.Value = theLoai.TenTheLoai; // Gán giá trị tên thể loại vào ô
                    e.FormattingApplied = true; // Đã xử lý xong, không cần DataGridView format lại ô
                }
            }
            if (e.ColumnIndex == 7 && e.Value != null)
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
        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtNhaXuatBan.Text = row.Cells["NhaXuatBan"].Value.ToString();
                txtGia.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();
                txtHinh.Text = row.Cells["HinhAnh"].Value.ToString();
                cboTheLoai.SelectedIndex = int.Parse(row.Cells["TheLoai"].Value.ToString()) - 1;
                //cboTheLoai.SelectedValue = int.Parse(row.Cells["TheLoai"].Value.ToString());
                cboTrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
            try
                {
                    ptbHinh.Image = Image.FromFile(@"hinhanh/" + row.Cells["HinhAnh"].Value.ToString());
                }
                catch (Exception ex)
                {
                    ptbHinh.Image = Image.FromFile(@"hinhanh/warning.jpg");
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files(*.*) | *.* ";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin ảnh được chọn
                string filePath = openFileDialog.FileName;
                // Hiển thị tên tập tin ảnh lên textbox txtTenHinh
                txtHinh.Text = Path.GetFileName(filePath);
                // Hiển thị ảnh lên pictureBox ptbHinh
                ptbHinh.Image = Image.FromFile(filePath);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try { 
                SachDTO Sach = new SachDTO();
            Sach.MaSach = int.Parse(txtMaSach.Text);
            Sach.TenSach = txtTenSach.Text;
            Sach.TacGia = txtTacGia.Text;
            Sach.NamXuatBan = txtNamXuatBan.Text;
            Sach.NhaXuatBan = txtNhaXuatBan.Text;
            Sach.GiaBan = int.Parse(txtGia.Text);
            Sach.SoLuongTon = int.Parse(txtSoLuong.Text);
            Sach.HinhAnh = txtHinh.Text;
            Sach.TheLoai = int.Parse(cboTheLoai.SelectedValue.ToString());
            Sach.TrangThai = cboTrangThai.SelectedIndex;
            string path = @"hinhanh/" + txtHinh.Text;
                if (File.Exists(path))
                {
                    DialogResult result = MessageBox.Show("Hình đã tồn tại", "Xác nhận",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                if (sachBUS.ThemSach(Sach))
            {
                
                ptbHinh.Image.Save(path);
                MessageBox.Show("Thêm Sách thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm Sách thất bại");
            } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SachDTO Sach = new SachDTO();
            Sach.MaSach = int.Parse(txtMaSach.Text);
            Sach.TenSach = txtTenSach.Text;
            Sach.TacGia = txtTacGia.Text;
            Sach.NamXuatBan = txtNamXuatBan.Text;
            Sach.NhaXuatBan = txtNhaXuatBan.Text;
            Sach.GiaBan = int.Parse(txtGia.Text);
            Sach.SoLuongTon = int.Parse(txtSoLuong.Text);
            Sach.HinhAnh = txtHinh.Text;
            Sach.TheLoai = int.Parse(cboTheLoai.SelectedValue.ToString());
            Sach.TrangThai = cboTrangThai.SelectedIndex;
            string path = @"hinhanh\" + txtHinh.Text;
            if (File.Exists(path))
            {
                Image img = null;
                using (Image image = Image.FromFile(path))
                {
                    ptbHinh.Image?.Dispose();
                    ptbHinh.Image = new Bitmap(image);
                    img = new Bitmap(image);
                }
                File.Delete(path);
                img.Save(path);
            }
            else
                ptbHinh.Image.Save(path);
            if (sachBUS.CapNhatSach(Sach))
            {
                MessageBox.Show("Sữa Sách thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Sữa Sách thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSach = int.Parse(txtMaSach.Text);
            string path = @"hinhanh\" + txtHinh.Text;
            if (File.Exists(path))
            {
                
                using (Image image = Image.FromFile(path))
                {
                    ptbHinh.Image?.Dispose();
                    ptbHinh.Image = new Bitmap(image);
                }
                File.Delete(path);
            }
            if (sachBUS.XoaSach(maSach))
            {
                MessageBox.Show("Xóa Sách thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa Sách thất bại");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenSach = txtTimKiem.Text;
            dgvSach.DataSource = sachBUS.TimKiemSach(tenSach);
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
