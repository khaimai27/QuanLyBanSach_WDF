using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public frmDangNhap()
        {
            InitializeComponent();
            // Ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            TaiKhoanDTO taiKhoanDTO = taiKhoanBUS.DangNhap(taiKhoan, matKhau);
            if (taiKhoanDTO != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frmMain main = new frmMain(taiKhoanDTO);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ","Thông báo");
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                // Hiện mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
