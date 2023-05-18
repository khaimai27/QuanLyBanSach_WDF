using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmMain : Form
    {
        private Form currentChildForm;
        private TaiKhoanDTO taiKhoanDTO;
        private NhanVienDTO nhanVien;
        private int maNhanVien;
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        public frmMain(TaiKhoanDTO taiKhoanDTO)
        {
            InitializeComponent();
            this.taiKhoanDTO = taiKhoanDTO;
            this.maNhanVien = maNhanVien;
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }
        void phanquyen()
        {
            //Hiển thị lên Label
            nhanVien = nhanVienBUS.LayThongTinNhanVien(taiKhoanDTO.MaNhanVien);
            lblTen.Text = "Chào mừng "+nhanVien.TenNhanVien.ToString();
            lblTen.ForeColor = Color.White;
            lblMaNV.Text = "Mã nhân viên: " + taiKhoanDTO.MaNhanVien;
            lblMaNV.ForeColor = Color.White;
            lblChucVu.ForeColor = Color.White;
            string s = "Trạng thái:";
            if(nhanVien.MaChucVu==1)
            {
                lblChucVu.Text = "Chức vụ: Quản Lý";
            }    
            else
            {
                if(nhanVien.MaChucVu == 0)
                {
                    lblChucVu.Text = "Chức vụ: Nhân viên";
                }    
            }
            if (taiKhoanDTO.TrangThai == 1)
            {
                lblQuyen.Text =s+" Được phép hoạt động";
                lblQuyen.ForeColor = Color.BlueViolet;
            }   
            else
            if (taiKhoanDTO.TrangThai == 0)
            {
                lblQuyen.Text =s+" Không được phép hoạt động";
                lblQuyen.ForeColor = Color.Red;
             
            }    
            //Nếu tài khoản có quyền nhân viên thì ẩn 
            //các button mà nhân viên không được phép sử dụng
            if (taiKhoanDTO.TrangThai == 0)
            {
                //btnLuong.Visible = false;
                //btnBangTaiKhoan.Visible = false;
                //btnBangSach.Visible = false;
                //btnBanHang.Visible = false;

            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO.TrangThai == 0|| nhanVien.MaChucVu == 0)
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền hạn để truy cập","Thông báo");

            }
            else
            {
                OpenChildForm(new frmBangSach());
            }    
            
        }

        private void icbNhanVien_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO.TrangThai == 0|| nhanVien.MaChucVu == 0)
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền hạn để truy cập","Thông báo");

            }
            else
            {
                OpenChildForm(new FrmNhanVien());
            }
            
        }

        private void icbTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO.TrangThai == 0|| nhanVien.MaChucVu == 0)
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền hạn để truy cập", "Thông báo");

            }
            else
            {
                OpenChildForm(new frmBangTaiKhoan());
            }
        }

        private void icbBanHang_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO.TrangThai == 0)
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền hạn để truy cập", "Thông báo");

            }
            else
            {
                OpenChildForm(new frmBanHang());
            }
        }

        private void icbHoaDon_Click(object sender, EventArgs e)
        {
            if (taiKhoanDTO.TrangThai == 0)
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền hạn để truy cập", "Thông báo");

            }
            else
            {
                OpenChildForm(new frmHoaDon());
            }
        }

        private void icbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            phanquyen();
        }
    }
}
