namespace GiaoDienManager
{
    partial class frmQuanLy
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbQuyen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTaiKhoanKhachHang = new System.Windows.Forms.Button();
            this.btnThongTinSanPham = new System.Windows.Forms.Button();
            this.btnQuanLyKho = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Người Dùng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(142, 52);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(72, 20);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.Text = "manager";
            this.lbTaiKhoan.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQuyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbTenNguoiDung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbQuyen
            // 
            this.lbQuyen.AutoSize = true;
            this.lbQuyen.Location = new System.Drawing.Point(117, 138);
            this.lbQuyen.Name = "lbQuyen";
            this.lbQuyen.Size = new System.Drawing.Size(72, 20);
            this.lbQuyen.TabIndex = 5;
            this.lbQuyen.Text = "Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quyền :";
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(186, 93);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(76, 20);
            this.lbTenNguoiDung.TabIndex = 3;
            this.lbTenNguoiDung.Text = "Hải Đăng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài Khoản :";
            // 
            // btnTaiKhoanNhanVien
            // 
            this.btnTaiKhoanNhanVien.Location = new System.Drawing.Point(12, 204);
            this.btnTaiKhoanNhanVien.Name = "btnTaiKhoanNhanVien";
            this.btnTaiKhoanNhanVien.Size = new System.Drawing.Size(130, 64);
            this.btnTaiKhoanNhanVien.TabIndex = 3;
            this.btnTaiKhoanNhanVien.Text = "Tài Khoản Nhân Viên";
            this.btnTaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.btnTaiKhoanNhanVien.Click += new System.EventHandler(this.btnTaiKhoanNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(171, 204);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 64);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thông Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTaiKhoanKhachHang
            // 
            this.btnTaiKhoanKhachHang.Location = new System.Drawing.Point(328, 204);
            this.btnTaiKhoanKhachHang.Name = "btnTaiKhoanKhachHang";
            this.btnTaiKhoanKhachHang.Size = new System.Drawing.Size(130, 64);
            this.btnTaiKhoanKhachHang.TabIndex = 5;
            this.btnTaiKhoanKhachHang.Text = "Tài Khoản Khách Hàng";
            this.btnTaiKhoanKhachHang.UseVisualStyleBackColor = true;
            this.btnTaiKhoanKhachHang.Click += new System.EventHandler(this.btnTaiKhoanKhachHang_Click);
            // 
            // btnThongTinSanPham
            // 
            this.btnThongTinSanPham.Location = new System.Drawing.Point(486, 204);
            this.btnThongTinSanPham.Name = "btnThongTinSanPham";
            this.btnThongTinSanPham.Size = new System.Drawing.Size(130, 64);
            this.btnThongTinSanPham.TabIndex = 6;
            this.btnThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            this.btnThongTinSanPham.UseVisualStyleBackColor = true;
            this.btnThongTinSanPham.Click += new System.EventHandler(this.btnThongTinSanPham_Click);
            // 
            // btnQuanLyKho
            // 
            this.btnQuanLyKho.Location = new System.Drawing.Point(642, 204);
            this.btnQuanLyKho.Name = "btnQuanLyKho";
            this.btnQuanLyKho.Size = new System.Drawing.Size(130, 64);
            this.btnQuanLyKho.TabIndex = 7;
            this.btnQuanLyKho.Text = "Quản Lý Kho";
            this.btnQuanLyKho.UseVisualStyleBackColor = true;
            this.btnQuanLyKho.Click += new System.EventHandler(this.btnQuanLyKho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(328, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 64);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 541);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuanLyKho);
            this.Controls.Add(this.btnThongTinSanPham);
            this.Controls.Add(this.btnTaiKhoanKhachHang);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnTaiKhoanNhanVien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.Label lbQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiKhoanNhanVien;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaiKhoanKhachHang;
        private System.Windows.Forms.Button btnThongTinSanPham;
        private System.Windows.Forms.Button btnQuanLyKho;
        private System.Windows.Forms.Button btnThoat;
    }
}

