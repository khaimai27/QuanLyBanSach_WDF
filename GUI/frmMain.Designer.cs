
namespace GUI
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.icbDangXuat = new FontAwesome.Sharp.IconButton();
            this.icbHoaDon = new FontAwesome.Sharp.IconButton();
            this.icbBanHang = new FontAwesome.Sharp.IconButton();
            this.icbTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.icbNhanVien = new FontAwesome.Sharp.IconButton();
            this.icbBangSach = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblQuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(162, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.lblChucVu);
            this.panel2.Controls.Add(this.lblTen);
            this.panel2.Controls.Add(this.lblMaNV);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(332, 9);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(64, 16);
            this.lblQuyen.TabIndex = 1;
            this.lblQuyen.Text = "lblQuyen";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(15, 37);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(62, 16);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "lblMaNV";
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(162, 100);
            this.PanelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.NenMain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.icbDangXuat);
            this.PanelMenu.Controls.Add(this.icbHoaDon);
            this.PanelMenu.Controls.Add(this.icbBanHang);
            this.PanelMenu.Controls.Add(this.icbTaiKhoan);
            this.PanelMenu.Controls.Add(this.icbNhanVien);
            this.PanelMenu.Controls.Add(this.icbBangSach);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(162, 585);
            this.PanelMenu.TabIndex = 0;
            // 
            // icbDangXuat
            // 
            this.icbDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbDangXuat.FlatAppearance.BorderSize = 0;
            this.icbDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbDangXuat.ForeColor = System.Drawing.Color.White;
            this.icbDangXuat.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.icbDangXuat.IconColor = System.Drawing.Color.White;
            this.icbDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbDangXuat.IconSize = 32;
            this.icbDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbDangXuat.Location = new System.Drawing.Point(0, 469);
            this.icbDangXuat.Name = "icbDangXuat";
            this.icbDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbDangXuat.Size = new System.Drawing.Size(162, 75);
            this.icbDangXuat.TabIndex = 6;
            this.icbDangXuat.Text = "Đăng Xuất";
            this.icbDangXuat.UseVisualStyleBackColor = false;
            this.icbDangXuat.Click += new System.EventHandler(this.icbDangXuat_Click);
            // 
            // icbHoaDon
            // 
            this.icbHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbHoaDon.FlatAppearance.BorderSize = 0;
            this.icbHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbHoaDon.ForeColor = System.Drawing.Color.White;
            this.icbHoaDon.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.icbHoaDon.IconColor = System.Drawing.Color.White;
            this.icbHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbHoaDon.IconSize = 32;
            this.icbHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbHoaDon.Location = new System.Drawing.Point(0, 400);
            this.icbHoaDon.Name = "icbHoaDon";
            this.icbHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbHoaDon.Size = new System.Drawing.Size(162, 69);
            this.icbHoaDon.TabIndex = 5;
            this.icbHoaDon.Text = "Hóa đơn";
            this.icbHoaDon.UseVisualStyleBackColor = false;
            this.icbHoaDon.Click += new System.EventHandler(this.icbHoaDon_Click);
            // 
            // icbBanHang
            // 
            this.icbBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbBanHang.FlatAppearance.BorderSize = 0;
            this.icbBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbBanHang.ForeColor = System.Drawing.Color.White;
            this.icbBanHang.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.icbBanHang.IconColor = System.Drawing.Color.White;
            this.icbBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbBanHang.IconSize = 32;
            this.icbBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbBanHang.Location = new System.Drawing.Point(0, 325);
            this.icbBanHang.Name = "icbBanHang";
            this.icbBanHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbBanHang.Size = new System.Drawing.Size(162, 75);
            this.icbBanHang.TabIndex = 4;
            this.icbBanHang.Text = "Bán hàng";
            this.icbBanHang.UseVisualStyleBackColor = false;
            this.icbBanHang.Click += new System.EventHandler(this.icbBanHang_Click);
            // 
            // icbTaiKhoan
            // 
            this.icbTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbTaiKhoan.FlatAppearance.BorderSize = 0;
            this.icbTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.icbTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icbTaiKhoan.IconColor = System.Drawing.Color.White;
            this.icbTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbTaiKhoan.IconSize = 32;
            this.icbTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbTaiKhoan.Location = new System.Drawing.Point(0, 250);
            this.icbTaiKhoan.Name = "icbTaiKhoan";
            this.icbTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbTaiKhoan.Size = new System.Drawing.Size(162, 75);
            this.icbTaiKhoan.TabIndex = 3;
            this.icbTaiKhoan.Text = "Bảng tài khoản";
            this.icbTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbTaiKhoan.UseVisualStyleBackColor = false;
            this.icbTaiKhoan.Click += new System.EventHandler(this.icbTaiKhoan_Click);
            // 
            // icbNhanVien
            // 
            this.icbNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbNhanVien.FlatAppearance.BorderSize = 0;
            this.icbNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbNhanVien.ForeColor = System.Drawing.Color.White;
            this.icbNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.icbNhanVien.IconColor = System.Drawing.Color.White;
            this.icbNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbNhanVien.IconSize = 32;
            this.icbNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbNhanVien.Location = new System.Drawing.Point(0, 175);
            this.icbNhanVien.Name = "icbNhanVien";
            this.icbNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbNhanVien.Size = new System.Drawing.Size(162, 75);
            this.icbNhanVien.TabIndex = 2;
            this.icbNhanVien.Text = "Bảng nhân viên";
            this.icbNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbNhanVien.UseVisualStyleBackColor = false;
            this.icbNhanVien.Click += new System.EventHandler(this.icbNhanVien_Click);
            // 
            // icbBangSach
            // 
            this.icbBangSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.icbBangSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.icbBangSach.FlatAppearance.BorderSize = 0;
            this.icbBangSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbBangSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbBangSach.ForeColor = System.Drawing.Color.White;
            this.icbBangSach.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.icbBangSach.IconColor = System.Drawing.Color.White;
            this.icbBangSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbBangSach.IconSize = 32;
            this.icbBangSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbBangSach.Location = new System.Drawing.Point(0, 100);
            this.icbBangSach.Name = "icbBangSach";
            this.icbBangSach.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.icbBangSach.Size = new System.Drawing.Size(162, 75);
            this.icbBangSach.TabIndex = 1;
            this.icbBangSach.Text = "Bảng Sách";
            this.icbBangSach.UseVisualStyleBackColor = false;
            this.icbBangSach.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelDesktop.BackgroundImage = global::GUI.Properties.Resources.NenMain;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(162, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(673, 485);
            this.panelDesktop.TabIndex = 2;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(15, 9);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(47, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "lblTen";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(15, 71);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(71, 16);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "lblChucVu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 585);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton icbBangSach;
        private FontAwesome.Sharp.IconButton icbNhanVien;
        private FontAwesome.Sharp.IconButton icbTaiKhoan;
        private FontAwesome.Sharp.IconButton icbBanHang;
        private FontAwesome.Sharp.IconButton icbHoaDon;
        private FontAwesome.Sharp.IconButton icbDangXuat;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblChucVu;
    }
}