namespace GiaoDienManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThongTinSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTaoMoiHoaDonQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTaiKhoanKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTaiKhoanNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripQuanLyKho = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripQuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTaoMoiHoaDonNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTaoMoiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGiupDo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripHeThong,
            this.toolStripQuanLy,
            this.toolStripNhanVien,
            this.toolStripGiupDo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripHeThong
            // 
            this.toolStripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDangNhap,
            this.toolStripDangXuat,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripHeThong.Name = "toolStripHeThong";
            this.toolStripHeThong.Size = new System.Drawing.Size(72, 22);
            this.toolStripHeThong.Text = "Hệ Thống";
            this.toolStripHeThong.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripDangNhap
            // 
            this.toolStripDangNhap.Name = "toolStripDangNhap";
            this.toolStripDangNhap.Size = new System.Drawing.Size(134, 22);
            this.toolStripDangNhap.Text = "Đăng Nhập";
            this.toolStripDangNhap.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripDangXuat
            // 
            this.toolStripDangXuat.Name = "toolStripDangXuat";
            this.toolStripDangXuat.Size = new System.Drawing.Size(134, 22);
            this.toolStripDangXuat.Text = "Đăng Xuất";
            this.toolStripDangXuat.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripQuanLy
            // 
            this.toolStripQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThongTinSanPham,
            this.toolStripTaoMoiHoaDonQuanLy,
            this.toolStripTaiKhoanKhachHang,
            this.toolStripTaiKhoanNhanVien,
            this.toolStripThongKe,
            this.toolStripQuanLyKho});
            this.toolStripQuanLy.Name = "toolStripQuanLy";
            this.toolStripQuanLy.Size = new System.Drawing.Size(62, 22);
            this.toolStripQuanLy.Text = "Quản Lý";
            this.toolStripQuanLy.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // toolStripThongTinSanPham
            // 
            this.toolStripThongTinSanPham.Name = "toolStripThongTinSanPham";
            this.toolStripThongTinSanPham.Size = new System.Drawing.Size(194, 22);
            this.toolStripThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            this.toolStripThongTinSanPham.Click += new System.EventHandler(this.thôngTinSảnPhẩmToolStripMenuItem_Click);
            // 
            // toolStripTaoMoiHoaDonQuanLy
            // 
            this.toolStripTaoMoiHoaDonQuanLy.Name = "toolStripTaoMoiHoaDonQuanLy";
            this.toolStripTaoMoiHoaDonQuanLy.Size = new System.Drawing.Size(194, 22);
            this.toolStripTaoMoiHoaDonQuanLy.Text = "Tạo Mới Hóa Đơn";
            this.toolStripTaoMoiHoaDonQuanLy.Click += new System.EventHandler(this.toolStripTaoMoiHoaDonQuanLy_Click);
            // 
            // toolStripTaiKhoanKhachHang
            // 
            this.toolStripTaiKhoanKhachHang.Name = "toolStripTaiKhoanKhachHang";
            this.toolStripTaiKhoanKhachHang.Size = new System.Drawing.Size(194, 22);
            this.toolStripTaiKhoanKhachHang.Text = "Tài Khoản Khách Hàng";
            this.toolStripTaiKhoanKhachHang.Click += new System.EventHandler(this.tàiKhoảnKháchHàngToolStripMenuItem_Click);
            // 
            // toolStripTaiKhoanNhanVien
            // 
            this.toolStripTaiKhoanNhanVien.Name = "toolStripTaiKhoanNhanVien";
            this.toolStripTaiKhoanNhanVien.Size = new System.Drawing.Size(194, 22);
            this.toolStripTaiKhoanNhanVien.Text = "Tài Khoản Nhân Viên";
            this.toolStripTaiKhoanNhanVien.Click += new System.EventHandler(this.tàiKhoảnNhânViênToolStripMenuItem_Click);
            // 
            // toolStripThongKe
            // 
            this.toolStripThongKe.Name = "toolStripThongKe";
            this.toolStripThongKe.Size = new System.Drawing.Size(194, 22);
            this.toolStripThongKe.Text = "Thống Kê";
            this.toolStripThongKe.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // toolStripQuanLyKho
            // 
            this.toolStripQuanLyKho.Name = "toolStripQuanLyKho";
            this.toolStripQuanLyKho.Size = new System.Drawing.Size(194, 22);
            this.toolStripQuanLyKho.Text = "Quản Lý Kho";
            this.toolStripQuanLyKho.Click += new System.EventHandler(this.quảnLýKhoToolStripMenuItem_Click);
            // 
            // toolStripNhanVien
            // 
            this.toolStripNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripQuanLySanPham,
            this.toolStripTaoMoiHoaDonNhanVien,
            this.toolStripTaoMoiKhachHang});
            this.toolStripNhanVien.Name = "toolStripNhanVien";
            this.toolStripNhanVien.Size = new System.Drawing.Size(74, 22);
            this.toolStripNhanVien.Text = "Nhân Viên";
            // 
            // toolStripQuanLySanPham
            // 
            this.toolStripQuanLySanPham.Name = "toolStripQuanLySanPham";
            this.toolStripQuanLySanPham.Size = new System.Drawing.Size(186, 22);
            this.toolStripQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.toolStripQuanLySanPham.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // toolStripTaoMoiHoaDonNhanVien
            // 
            this.toolStripTaoMoiHoaDonNhanVien.Name = "toolStripTaoMoiHoaDonNhanVien";
            this.toolStripTaoMoiHoaDonNhanVien.Size = new System.Drawing.Size(186, 22);
            this.toolStripTaoMoiHoaDonNhanVien.Text = "Tạo Mới Hóa Đơn";
            this.toolStripTaoMoiHoaDonNhanVien.Click += new System.EventHandler(this.tạoMớiHóaĐơnToolStripMenuItem_Click);
            // 
            // toolStripTaoMoiKhachHang
            // 
            this.toolStripTaoMoiKhachHang.Name = "toolStripTaoMoiKhachHang";
            this.toolStripTaoMoiKhachHang.Size = new System.Drawing.Size(186, 22);
            this.toolStripTaoMoiKhachHang.Text = "Tạo Mới Khách Hàng";
            this.toolStripTaoMoiKhachHang.Click += new System.EventHandler(this.tạoMớiKháchHàngToolStripMenuItem_Click);
            // 
            // toolStripGiupDo
            // 
            this.toolStripGiupDo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBanQuyen});
            this.toolStripGiupDo.Name = "toolStripGiupDo";
            this.toolStripGiupDo.Size = new System.Drawing.Size(62, 22);
            this.toolStripGiupDo.Text = "Giúp Đỡ";
            // 
            // toolStripBanQuyen
            // 
            this.toolStripBanQuyen.Name = "toolStripBanQuyen";
            this.toolStripBanQuyen.Size = new System.Drawing.Size(132, 22);
            this.toolStripBanQuyen.Text = "Bản Quyền";
            this.toolStripBanQuyen.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cửa Hàng Bán Camera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripDangNhap;
        private System.Windows.Forms.ToolStripMenuItem toolStripDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuanLy;
        private System.Windows.Forms.ToolStripMenuItem toolStripNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolStripGiupDo;
        private System.Windows.Forms.ToolStripMenuItem toolStripBanQuyen;
        private System.Windows.Forms.ToolStripMenuItem toolStripTaiKhoanNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolStripThongKe;
        private System.Windows.Forms.ToolStripMenuItem toolStripTaiKhoanKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripThongTinSanPham;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuanLyKho;
        private System.Windows.Forms.ToolStripMenuItem toolStripQuanLySanPham;
        private System.Windows.Forms.ToolStripMenuItem toolStripTaoMoiHoaDonNhanVien;
        private System.Windows.Forms.ToolStripMenuItem toolStripTaoMoiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripTaoMoiHoaDonQuanLy;
    }
}