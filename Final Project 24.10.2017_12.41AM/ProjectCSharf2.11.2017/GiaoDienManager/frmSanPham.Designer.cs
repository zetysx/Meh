namespace GiaoDienManager
{
    partial class frmSanPham
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
            this.txtGia = new System.Windows.Forms.NumericUpDown();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuuChinhSua = new System.Windows.Forms.Button();
            this.btnLuuMoi = new System.Windows.Forms.Button();
            this.txtHoTro = new System.Windows.Forms.TextBox();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.txtNguon = new System.Windows.Forms.TextBox();
            this.txtTamXa = new System.Windows.Forms.TextBox();
            this.txtOngKinh = new System.Windows.Forms.TextBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.txtDoPGiai = new System.Windows.Forms.TextBox();
            this.txtCambien = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvCameraData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameraData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(178, 111);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(134, 26);
            this.txtGia.TabIndex = 28;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(429, 482);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 35);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(345, 482);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btDel_Click_1);
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.Location = new System.Drawing.Point(242, 482);
            this.btnLuuChinhSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.Size = new System.Drawing.Size(94, 35);
            this.btnLuuChinhSua.TabIndex = 25;
            this.btnLuuChinhSua.Text = "Chỉnh sửa";
            this.btnLuuChinhSua.UseVisualStyleBackColor = true;
            this.btnLuuChinhSua.Visible = false;
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // btnLuuMoi
            // 
            this.btnLuuMoi.Location = new System.Drawing.Point(128, 482);
            this.btnLuuMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuMoi.Name = "btnLuuMoi";
            this.btnLuuMoi.Size = new System.Drawing.Size(105, 35);
            this.btnLuuMoi.TabIndex = 24;
            this.btnLuuMoi.Text = "Lưu Mới";
            this.btnLuuMoi.UseVisualStyleBackColor = true;
            this.btnLuuMoi.Visible = false;
            this.btnLuuMoi.Click += new System.EventHandler(this.btNew_Click_1);
            // 
            // txtHoTro
            // 
            this.txtHoTro.Location = new System.Drawing.Point(178, 440);
            this.txtHoTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTro.Name = "txtHoTro";
            this.txtHoTro.Size = new System.Drawing.Size(337, 26);
            this.txtHoTro.TabIndex = 22;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Location = new System.Drawing.Point(178, 405);
            this.txtChatLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(337, 26);
            this.txtChatLieu.TabIndex = 21;
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(178, 368);
            this.txtNhietDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(337, 26);
            this.txtNhietDo.TabIndex = 20;
            // 
            // txtNguon
            // 
            this.txtNguon.Location = new System.Drawing.Point(178, 332);
            this.txtNguon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.Size = new System.Drawing.Size(337, 26);
            this.txtNguon.TabIndex = 19;
            // 
            // txtTamXa
            // 
            this.txtTamXa.Location = new System.Drawing.Point(178, 295);
            this.txtTamXa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTamXa.Name = "txtTamXa";
            this.txtTamXa.Size = new System.Drawing.Size(337, 26);
            this.txtTamXa.TabIndex = 18;
            // 
            // txtOngKinh
            // 
            this.txtOngKinh.Location = new System.Drawing.Point(178, 260);
            this.txtOngKinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOngKinh.Name = "txtOngKinh";
            this.txtOngKinh.Size = new System.Drawing.Size(337, 26);
            this.txtOngKinh.TabIndex = 17;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.Location = new System.Drawing.Point(178, 225);
            this.txtKhoangCach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(337, 26);
            this.txtKhoangCach.TabIndex = 16;
            // 
            // txtDoPGiai
            // 
            this.txtDoPGiai.Location = new System.Drawing.Point(178, 188);
            this.txtDoPGiai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDoPGiai.Name = "txtDoPGiai";
            this.txtDoPGiai.Size = new System.Drawing.Size(337, 26);
            this.txtDoPGiai.TabIndex = 15;
            // 
            // txtCambien
            // 
            this.txtCambien.Location = new System.Drawing.Point(178, 152);
            this.txtCambien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCambien.Name = "txtCambien";
            this.txtCambien.Size = new System.Drawing.Size(337, 26);
            this.txtCambien.TabIndex = 14;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(178, 72);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(337, 26);
            this.txtTenSP.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 446);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Hỗ trợ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Chất liệu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 374);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nhiệt độ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nguồn điện:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tầm xa hồng ngoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ống kính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoảng cách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Độ phân giải:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cảm biến hình ảnh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuuChinhSua);
            this.groupBox1.Controls.Add(this.btnLuuMoi);
            this.groupBox1.Controls.Add(this.txtHoTro);
            this.groupBox1.Controls.Add(this.txtChatLieu);
            this.groupBox1.Controls.Add(this.txtNhietDo);
            this.groupBox1.Controls.Add(this.txtNguon);
            this.groupBox1.Controls.Add(this.txtTamXa);
            this.groupBox1.Controls.Add(this.txtOngKinh);
            this.groupBox1.Controls.Add(this.txtKhoangCach);
            this.groupBox1.Controls.Add(this.txtDoPGiai);
            this.groupBox1.Controls.Add(this.txtCambien);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(738, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(526, 549);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(32, 482);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(87, 35);
            this.btnTaoMoi.TabIndex = 31;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btn_Click_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 35);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(337, 26);
            this.txtID.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Mã Sản Phẩm :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(573, 15);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 35);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.txtSearch_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(152, 18);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(410, 26);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvCameraData
            // 
            this.dgvCameraData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCameraData.Location = new System.Drawing.Point(18, 60);
            this.dgvCameraData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCameraData.MultiSelect = false;
            this.dgvCameraData.Name = "dgvCameraData";
            this.dgvCameraData.ReadOnly = true;
            this.dgvCameraData.Size = new System.Drawing.Size(680, 508);
            this.dgvCameraData.TabIndex = 6;
            this.dgvCameraData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCameraData_CellClick_1);
            this.dgvCameraData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCameraData_CellContentClick);
            this.dgvCameraData.Click += new System.EventHandler(this.dgvCameraData_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên SP cần tìm:";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvCameraData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCameraData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtGia;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuuChinhSua;
        private System.Windows.Forms.Button btnLuuMoi;
        private System.Windows.Forms.TextBox txtHoTro;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.TextBox txtNguon;
        private System.Windows.Forms.TextBox txtTamXa;
        private System.Windows.Forms.TextBox txtOngKinh;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.TextBox txtDoPGiai;
        private System.Windows.Forms.TextBox txtCambien;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvCameraData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTaoMoi;
    }
}