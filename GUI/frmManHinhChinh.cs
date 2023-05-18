using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManHinhChinh : Form
    {
        private TaiKhoanDTO taiKhoanDTO;

        public frmManHinhChinh(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            this.taiKhoanDTO = taiKhoanDTO;
            
        }
        void phanquyen()
        {
            //Hiển thị lên Label
            lblTen.Text = "Mã nhân viên: " + taiKhoanDTO.MaNhanVien;
            if (taiKhoanDTO.TrangThai == 1)
                lblQuyen.Text = "Trạng thái: Đang hoạt động";
            else
            if (taiKhoanDTO.TrangThai == 0)
                lblQuyen.Text = "Trạng thái: Không được phép hoạt động";
            //Nếu tài khoản có quyền nhân viên thì ẩn 
            //các button mà nhân viên không được phép sử dụng
            if (taiKhoanDTO.TrangThai == 0)
            {
                btnLuong.Visible = false;
                btnBangTaiKhoan.Visible = false;
                btnBangSach.Visible = false;
                btnBanHang.Visible = false;
         
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            phanquyen();
        }

        private void btnBangTaiKhoan_Click(object sender, EventArgs e)
        {
            
            frmBangTaiKhoan taikhoan = new frmBangTaiKhoan();
            taikhoan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmBangSach sach = new frmBangSach();
            sach.ShowDialog();
        }
    }
}
