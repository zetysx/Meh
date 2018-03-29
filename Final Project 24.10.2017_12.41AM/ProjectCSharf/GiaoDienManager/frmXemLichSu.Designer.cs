namespace ProjectCSharp
{
    partial class frmXemLichSu
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLichSuNhapKho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemToanBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(12, 110);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTuNgay.Location = new System.Drawing.Point(82, 25);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(113, 20);
            this.dateTuNgay.TabIndex = 1;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenNgay.Location = new System.Drawing.Point(82, 69);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(113, 20);
            this.dateDenNgay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ Ngày :";
            // 
            // dgvLichSuNhapKho
            // 
            this.dgvLichSuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuNhapKho.Location = new System.Drawing.Point(217, 69);
            this.dgvLichSuNhapKho.MultiSelect = false;
            this.dgvLichSuNhapKho.Name = "dgvLichSuNhapKho";
            this.dgvLichSuNhapKho.ReadOnly = true;
            this.dgvLichSuNhapKho.Size = new System.Drawing.Size(609, 526);
            this.dgvLichSuNhapKho.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến Ngày :";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(120, 110);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lịch Sử Nhập Kho";
            // 
            // btnXemToanBo
            // 
            this.btnXemToanBo.Location = new System.Drawing.Point(217, 40);
            this.btnXemToanBo.Name = "btnXemToanBo";
            this.btnXemToanBo.Size = new System.Drawing.Size(126, 23);
            this.btnXemToanBo.TabIndex = 8;
            this.btnXemToanBo.Text = "Xem Toàn Bộ";
            this.btnXemToanBo.UseVisualStyleBackColor = true;
            this.btnXemToanBo.Click += new System.EventHandler(this.btnXemToanBo_Click);
            // 
            // frmXemLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(838, 607);
            this.Controls.Add(this.btnXemToanBo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLichSuNhapKho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.btnTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemLichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemLichSu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.btnTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichSuNhapKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXemToanBo;
    }
}