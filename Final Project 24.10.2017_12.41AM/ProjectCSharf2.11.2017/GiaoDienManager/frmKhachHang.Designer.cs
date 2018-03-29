namespace GiaoDienManager
{
    partial class frmKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.chkType = new System.Windows.Forms.CheckBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.txtTimKiemKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChinhSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(18, 72);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(938, 592);
            this.dgvKhachHang.TabIndex = 26;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChinhSua);
            this.groupBox1.Controls.Add(this.datePickerNgaySinh);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuuMoi);
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.chkType);
            this.groupBox1.Controls.Add(this.cbSex);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(976, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 637);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datePickerNgaySinh
            // 
            this.datePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerNgaySinh.Location = new System.Drawing.Point(165, 154);
            this.datePickerNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePickerNgaySinh.Name = "datePickerNgaySinh";
            this.datePickerNgaySinh.Size = new System.Drawing.Size(162, 26);
            this.datePickerNgaySinh.TabIndex = 46;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(325, 375);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 60);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(165, 55);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(272, 26);
            this.txtMaKhachHang.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã Khách Hàng :";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(325, 474);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 60);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.Location = new System.Drawing.Point(38, 375);
            this.btnLuuMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(112, 60);
            this.btnLuuMoi.TabIndex = 40;
            this.btnLuuMoi.Text = "Lưu Mới";
            this.btnLuuMoi.UseVisualStyleBackColor = true;
            this.btnLuuMoi.Visible = false;
            this.btnLuuMoi.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(38, 474);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(112, 60);
            this.btnTaoMoi.TabIndex = 39;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btReset_Click_1);
            // 
            // chkType
            // 
            this.chkType.AutoSize = true;
            this.chkType.Location = new System.Drawing.Point(40, 308);
            this.chkType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(191, 24);
            this.chkType.TabIndex = 38;
            this.chkType.Text = "Khách hàng thân thiết";
            this.chkType.UseVisualStyleBackColor = true;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(165, 246);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(122, 28);
            this.cbSex.TabIndex = 37;
            this.cbSex.SelectedIndexChanged += new System.EventHandler(this.cbSex_SelectedIndexChanged);
            this.cbSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSex_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(165, 198);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(272, 26);
            this.txtAddress.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 26);
            this.txtName.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ngày Sinh :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên :";
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(843, 29);
            this.btnTimKiemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(112, 35);
            this.btnTimKiemKH.TabIndex = 33;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.Location = new System.Drawing.Point(156, 31);
            this.txtTimKiemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.Size = new System.Drawing.Size(676, 26);
            this.txtTimKiemKH.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên Khách Hàng:";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(185, 375);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(112, 60);
            this.btnChinhSua.TabIndex = 47;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Visible = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1468, 683);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.CheckBox chkType;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.TextBox txtTimKiemKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker datePickerNgaySinh;
        private System.Windows.Forms.Button btnChinhSua;
    }
}