using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBangTaiKhoan : Form
    {
        private TaiKhoanBUS taiKhoanBUS;
        public frmBangTaiKhoan()
        {
            InitializeComponent();
            taiKhoanBUS = new TaiKhoanBUS();
        }
        private void LoadDataGridView()
        {
            dgvTaiKhoan.DataSource = taiKhoanBUS.LayDanhSachTaiKhoan();
        }
        private void frmBangTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                //cboQuyen.SelectedItem = (row.Cells["Quyen"].Value.ToString() == "1") ? "Quản Lý" : "Nhân Viên";
                cboTrangThai.Text = (row.Cells["TrangThai"].Value.ToString() == "1") ? "Hoạt động" : "Không hoạt động";
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
            taiKhoan.MaTaiKhoan = int.Parse(txtMaTaiKhoan.Text);
            taiKhoan.TenDangNhap = txtTaiKhoan.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            //taiKhoan.Quyen = cboQuyen.SelectedIndex + 1;
            taiKhoan.TrangThai = cboTrangThai.SelectedIndex;

            if (taiKhoanBUS.ThemTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();
            taiKhoan.MaTaiKhoan = int.Parse(txtMaTaiKhoan.Text);
            taiKhoan.TenDangNhap = txtTaiKhoan.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoan.MaNhanVien = int.Parse(txtMaNhanVien.Text);
            //taiKhoan.Quyen = cboQuyen.SelectedIndex + 1;
            taiKhoan.TrangThai = cboTrangThai.SelectedIndex;

            if (taiKhoanBUS.CapNhatTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maTaiKhoan = int.Parse(txtMaTaiKhoan.Text);

            if (taiKhoanBUS.XoaTaiKhoan(maTaiKhoan))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTimKiem.Text;
            dgvTaiKhoan.DataSource = taiKhoanBUS.TimKiemTaiKhoan(taiKhoan);
        }


        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 4 && e.Value != null)
            //{
            //    int quyen = (int)e.Value;
            //    if (quyen == 1)
            //    {
            //        e.Value = "Quản Lý";
            //    }
            //    else if (quyen == 2)
            //    {
            //        e.Value = "Nhân Viên";
            //    }
            //}
            if (e.ColumnIndex == 4 && e.Value != null)
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

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
