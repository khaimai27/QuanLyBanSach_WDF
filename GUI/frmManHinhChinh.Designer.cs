namespace GUI
{
    partial class frmManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBangTaiKhoan = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnBangSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBangTaiKhoan
            // 
            this.btnBangTaiKhoan.Location = new System.Drawing.Point(228, 152);
            this.btnBangTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBangTaiKhoan.Name = "btnBangTaiKhoan";
            this.btnBangTaiKhoan.Size = new System.Drawing.Size(152, 72);
            this.btnBangTaiKhoan.TabIndex = 8;
            this.btnBangTaiKhoan.Text = "Bảng Tài Khoản";
            this.btnBangTaiKhoan.UseVisualStyleBackColor = true;
            this.btnBangTaiKhoan.Click += new System.EventHandler(this.btnBangTaiKhoan_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(34, 152);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(152, 72);
            this.btnBanHang.TabIndex = 6;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnLuong
            // 
            this.btnLuong.Location = new System.Drawing.Point(228, 41);
            this.btnLuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(152, 72);
            this.btnLuong.TabIndex = 7;
            this.btnLuong.Text = "Bảng Lương";
            this.btnLuong.UseVisualStyleBackColor = true;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Location = new System.Drawing.Point(412, 61);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(44, 13);
            this.lblQuyen.TabIndex = 5;
            this.lblQuyen.Text = "Quyền :";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(412, 25);
            this.lblTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(35, 13);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên : ";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(476, 98);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(91, 28);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnBangSach
            // 
            this.btnBangSach.Location = new System.Drawing.Point(34, 41);
            this.btnBangSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnBangSach.Name = "btnBangSach";
            this.btnBangSach.Size = new System.Drawing.Size(152, 72);
            this.btnBangSach.TabIndex = 10;
            this.btnBangSach.Text = "Bảng sách";
            this.btnBangSach.UseVisualStyleBackColor = true;
            this.btnBangSach.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.btnBangSach);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBangTaiKhoan);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnLuong);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.lblTen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManHinhChinh";
            this.Text = "frmManHinhChinh";
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBangTaiKhoan;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnBangSach;
    }
}