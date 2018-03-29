namespace GiaoDienManager
{
    partial class frmTaiKhoanNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.dgvQuanLyNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.datePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.numLuong = new System.Windows.Forms.NumericUpDown();
            this.cbVaiTro = new System.Windows.Forms.ComboBox();
            this.lbVaiTro = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuuChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).BeginInit();
            this.groupThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(186, 85);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(630, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.Location = new System.Drawing.Point(1083, 601);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(105, 62);
            this.btnLuuMoi.TabIndex = 2;
            this.btnLuuMoi.Text = "Lưu";
            this.btnLuuMoi.UseVisualStyleBackColor = true;
            this.btnLuuMoi.Visible = false;
            this.btnLuuMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dgvQuanLyNhanVien
            // 
            this.dgvQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNhanVien.Location = new System.Drawing.Point(40, 135);
            this.dgvQuanLyNhanVien.MultiSelect = false;
            this.dgvQuanLyNhanVien.Name = "dgvQuanLyNhanVien";
            this.dgvQuanLyNhanVien.ReadOnly = true;
            this.dgvQuanLyNhanVien.RowTemplate.Height = 28;
            this.dgvQuanLyNhanVien.Size = new System.Drawing.Size(896, 528);
            this.dgvQuanLyNhanVien.TabIndex = 3;
            this.dgvQuanLyNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNhanVien_CellClick);
            this.dgvQuanLyNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyNhanVien_CellContentClick);
            this.dgvQuanLyNhanVien.Click += new System.EventHandler(this.dgvQuanLyNhanVien_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quản Lý Tài Khoản Nhân Viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(824, 82);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 35);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(148, 32);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(415, 26);
            this.txtTenTaiKhoan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Tài Khoản :";
            // 
            // groupThongTinNhanVien
            // 
            this.groupThongTinNhanVien.Controls.Add(this.datePickerNgaySinh);
            this.groupThongTinNhanVien.Controls.Add(this.numLuong);
            this.groupThongTinNhanVien.Controls.Add(this.cbVaiTro);
            this.groupThongTinNhanVien.Controls.Add(this.lbVaiTro);
            this.groupThongTinNhanVien.Controls.Add(this.cbGioiTinh);
            this.groupThongTinNhanVien.Controls.Add(this.label9);
            this.groupThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.groupThongTinNhanVien.Controls.Add(this.label8);
            this.groupThongTinNhanVien.Controls.Add(this.label7);
            this.groupThongTinNhanVien.Controls.Add(this.label6);
            this.groupThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.groupThongTinNhanVien.Controls.Add(this.label5);
            this.groupThongTinNhanVien.Controls.Add(this.txtMatKhau);
            this.groupThongTinNhanVien.Controls.Add(this.label4);
            this.groupThongTinNhanVien.Controls.Add(this.txtTenTaiKhoan);
            this.groupThongTinNhanVien.Controls.Add(this.label3);
            this.groupThongTinNhanVien.Location = new System.Drawing.Point(966, 85);
            this.groupThongTinNhanVien.Name = "groupThongTinNhanVien";
            this.groupThongTinNhanVien.Size = new System.Drawing.Size(580, 491);
            this.groupThongTinNhanVien.TabIndex = 8;
            this.groupThongTinNhanVien.TabStop = false;
            this.groupThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            this.groupThongTinNhanVien.Enter += new System.EventHandler(this.groupThongTinNhanVien_Enter);
            // 
            // datePickerNgaySinh
            // 
            this.datePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerNgaySinh.Location = new System.Drawing.Point(148, 242);
            this.datePickerNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerNgaySinh.Name = "datePickerNgaySinh";
            this.datePickerNgaySinh.Size = new System.Drawing.Size(298, 26);
            this.datePickerNgaySinh.TabIndex = 27;
            // 
            // numLuong
            // 
            this.numLuong.Location = new System.Drawing.Point(148, 432);
            this.numLuong.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numLuong.Name = "numLuong";
            this.numLuong.Size = new System.Drawing.Size(195, 26);
            this.numLuong.TabIndex = 26;
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.FormattingEnabled = true;
            this.cbVaiTro.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cbVaiTro.Location = new System.Drawing.Point(148, 132);
            this.cbVaiTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(158, 28);
            this.cbVaiTro.TabIndex = 23;
            this.cbVaiTro.Text = "Staff";
            this.cbVaiTro.SelectedIndexChanged += new System.EventHandler(this.cbVaiTro_SelectedIndexChanged);
            this.cbVaiTro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbVaiTro_KeyPress);
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.AutoSize = true;
            this.lbVaiTro.Location = new System.Drawing.Point(12, 146);
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(67, 20);
            this.lbVaiTro.TabIndex = 22;
            this.lbVaiTro.Text = "Vai Trò :";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioiTinh.Location = new System.Drawing.Point(148, 288);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(158, 28);
            this.cbGioiTinh.TabIndex = 20;
            this.cbGioiTinh.Text = "Nam";
            this.cbGioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGioiTinh_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lương :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(148, 332);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(415, 81);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Địa Chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giới Tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Sinh :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(148, 192);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(415, 26);
            this.txtHoTen.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Họ Và Tên :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(148, 85);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(415, 26);
            this.txtMatKhau.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật Khẩu :";
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.Location = new System.Drawing.Point(1209, 601);
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.Size = new System.Drawing.Size(104, 62);
            this.btnLuuChinhSua.TabIndex = 9;
            this.btnLuuChinhSua.Text = "Chỉnh Sửa";
            this.btnLuuChinhSua.UseVisualStyleBackColor = true;
            this.btnLuuChinhSua.Visible = false;
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1325, 601);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 62);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1451, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 62);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(969, 601);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(98, 62);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Tạo Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmTaiKhoanNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1567, 686);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuChinhSua);
            this.Controls.Add(this.groupThongTinNhanVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQuanLyNhanVien);
            this.Controls.Add(this.btnLuuMoi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoanNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản Nhân Viên";
            this.Load += new System.EventHandler(this.frmTaiKhoanNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNhanVien)).EndInit();
            this.groupThongTinNhanVien.ResumeLayout(false);
            this.groupThongTinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.DataGridView dgvQuanLyNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupThongTinNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btnLuuChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbVaiTro;
        private System.Windows.Forms.ComboBox cbVaiTro;
        private System.Windows.Forms.NumericUpDown numLuong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker datePickerNgaySinh;
    }
}