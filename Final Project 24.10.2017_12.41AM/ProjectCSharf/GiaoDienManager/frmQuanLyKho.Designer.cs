namespace GiaoDienManager
{
    partial class frmQuanLyKho
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchCameraKho = new System.Windows.Forms.DataGridView();
            this.groupNhapKho = new System.Windows.Forms.GroupBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaCamera = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemMoiCamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCameraKho)).BeginInit();
            this.groupNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản Lý Kho";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(265, 64);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 21);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(104, 65);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(159, 20);
            this.txtTimKiem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Camera :";
            // 
            // dgvSearchCameraKho
            // 
            this.dgvSearchCameraKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCameraKho.Location = new System.Drawing.Point(360, 67);
            this.dgvSearchCameraKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSearchCameraKho.MultiSelect = false;
            this.dgvSearchCameraKho.Name = "dgvSearchCameraKho";
            this.dgvSearchCameraKho.RowTemplate.Height = 28;
            this.dgvSearchCameraKho.Size = new System.Drawing.Size(457, 425);
            this.dgvSearchCameraKho.TabIndex = 9;
            this.dgvSearchCameraKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchCameraKho_CellClick);
            this.dgvSearchCameraKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchCameraKho_CellContentClick);
            // 
            // groupNhapKho
            // 
            this.groupNhapKho.Controls.Add(this.numSoLuong);
            this.groupNhapKho.Controls.Add(this.label5);
            this.groupNhapKho.Controls.Add(this.btnThoat);
            this.groupNhapKho.Controls.Add(this.txtMaCamera);
            this.groupNhapKho.Controls.Add(this.btnLuu);
            this.groupNhapKho.Controls.Add(this.label3);
            this.groupNhapKho.Location = new System.Drawing.Point(21, 160);
            this.groupNhapKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupNhapKho.Name = "groupNhapKho";
            this.groupNhapKho.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupNhapKho.Size = new System.Drawing.Size(318, 185);
            this.groupNhapKho.TabIndex = 10;
            this.groupNhapKho.TabStop = false;
            this.groupNhapKho.Text = "Nhập Kho";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(99, 63);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(67, 20);
            this.numSoLuong.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Lượng :";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(228, 138);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMaCamera
            // 
            this.txtMaCamera.Location = new System.Drawing.Point(99, 21);
            this.txtMaCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaCamera.Name = "txtMaCamera";
            this.txtMaCamera.ReadOnly = true;
            this.txtMaCamera.Size = new System.Drawing.Size(204, 20);
            this.txtMaCamera.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(121, 138);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã Camera";
            // 
            // btnThemMoiCamera
            // 
            this.btnThemMoiCamera.Location = new System.Drawing.Point(21, 106);
            this.btnThemMoiCamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMoiCamera.Name = "btnThemMoiCamera";
            this.btnThemMoiCamera.Size = new System.Drawing.Size(318, 31);
            this.btnThemMoiCamera.TabIndex = 13;
            this.btnThemMoiCamera.Text = "Thêm Mới Camera";
            this.btnThemMoiCamera.UseVisualStyleBackColor = true;
            this.btnThemMoiCamera.Click += new System.EventHandler(this.btnThemMoiCamera_Click);
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(828, 519);
            this.Controls.Add(this.btnThemMoiCamera);
            this.Controls.Add(this.groupNhapKho);
            this.Controls.Add(this.dgvSearchCameraKho);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCameraKho)).EndInit();
            this.groupNhapKho.ResumeLayout(false);
            this.groupNhapKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchCameraKho;
        private System.Windows.Forms.GroupBox groupNhapKho;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemMoiCamera;
    }
}