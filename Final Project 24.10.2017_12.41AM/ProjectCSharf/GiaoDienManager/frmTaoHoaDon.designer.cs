namespace ProjectCSharp
{
    partial class frmTaoHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuanity = new System.Windows.Forms.NumericUpDown();
            this.dgvIDCamera = new System.Windows.Forms.DataGridView();
            this.cmnSanPham = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quảnLíSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddOrder = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtIDCamera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearchID = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmnKhachHang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quảnLíKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIDCustomer = new System.Windows.Forms.DataGridView();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.txtCustomerNameSearch = new System.Windows.Forms.TextBox();
            this.btNameSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTExit = new System.Windows.Forms.Button();
            this.BtNewOrder = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.cmnDeleteOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdsdfsdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCustomerNameOrder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDCamera)).BeginInit();
            this.cmnSanPham.SuspendLayout();
            this.cmnKhachHang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.cmnDeleteOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuanity);
            this.groupBox1.Controls.Add(this.dgvIDCamera);
            this.groupBox1.Controls.Add(this.txtAddOrder);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtIDCamera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btSearchID);
            this.groupBox1.Controls.Add(this.txtSearchID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Camera ID theo tên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(341, 198);
            this.txtQuanity.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(108, 20);
            this.txtQuanity.TabIndex = 11;
            this.txtQuanity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuanity_KeyPress);
            // 
            // dgvIDCamera
            // 
            this.dgvIDCamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDCamera.ContextMenuStrip = this.cmnSanPham;
            this.dgvIDCamera.Location = new System.Drawing.Point(22, 62);
            this.dgvIDCamera.MultiSelect = false;
            this.dgvIDCamera.Name = "dgvIDCamera";
            this.dgvIDCamera.ReadOnly = true;
            this.dgvIDCamera.Size = new System.Drawing.Size(427, 120);
            this.dgvIDCamera.TabIndex = 10;
            this.dgvIDCamera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIDCamera_CellClick);
            // 
            // cmnSanPham
            // 
            this.cmnSanPham.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíSảnPhẩmToolStripMenuItem});
            this.cmnSanPham.Name = "cmnSanPham";
            this.cmnSanPham.Size = new System.Drawing.Size(168, 26);
            // 
            // quảnLíSảnPhẩmToolStripMenuItem
            // 
            this.quảnLíSảnPhẩmToolStripMenuItem.Name = "quảnLíSảnPhẩmToolStripMenuItem";
            this.quảnLíSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLíSảnPhẩmToolStripMenuItem.Text = "Quản lí sản phẩm";
            this.quảnLíSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLíSảnPhẩmToolStripMenuItem_Click);
            // 
            // txtAddOrder
            // 
            this.txtAddOrder.Location = new System.Drawing.Point(336, 250);
            this.txtAddOrder.Name = "txtAddOrder";
            this.txtAddOrder.Size = new System.Drawing.Size(113, 23);
            this.txtAddOrder.TabIndex = 9;
            this.txtAddOrder.Text = "Thêm vào giỏ hảng";
            this.txtAddOrder.UseVisualStyleBackColor = true;
            this.txtAddOrder.Click += new System.EventHandler(this.txtAddOrder_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(72, 253);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(242, 20);
            this.txtNote.TabIndex = 8;
            // 
            // txtIDCamera
            // 
            this.txtIDCamera.Location = new System.Drawing.Point(85, 197);
            this.txtIDCamera.Name = "txtIDCamera";
            this.txtIDCamera.ReadOnly = true;
            this.txtIDCamera.Size = new System.Drawing.Size(179, 20);
            this.txtIDCamera.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Camera:";
            // 
            // btSearchID
            // 
            this.btSearchID.Location = new System.Drawing.Point(374, 25);
            this.btSearchID.Name = "btSearchID";
            this.btSearchID.Size = new System.Drawing.Size(75, 23);
            this.btSearchID.TabIndex = 2;
            this.btSearchID.Text = "Tìm kiếm";
            this.btSearchID.UseVisualStyleBackColor = true;
            this.btSearchID.Click += new System.EventHandler(this.btSearchID_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(103, 27);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(265, 20);
            this.txtSearchID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // cmnKhachHang
            // 
            this.cmnKhachHang.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnKhachHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíKháchHàngToolStripMenuItem});
            this.cmnKhachHang.Name = "cmnKhachHang";
            this.cmnKhachHang.Size = new System.Drawing.Size(178, 26);
            // 
            // quảnLíKháchHàngToolStripMenuItem
            // 
            this.quảnLíKháchHàngToolStripMenuItem.Name = "quảnLíKháchHàngToolStripMenuItem";
            this.quảnLíKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.quảnLíKháchHàngToolStripMenuItem.Text = "Quản lí khách hàng";
            this.quảnLíKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíKháchHàngToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvIDCustomer);
            this.groupBox2.Controls.Add(this.txtIDCustomer);
            this.groupBox2.Controls.Add(this.txtCustomerNameSearch);
            this.groupBox2.Controls.Add(this.btNameSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 279);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm ID khách hàng theo tên";
            // 
            // dgvIDCustomer
            // 
            this.dgvIDCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDCustomer.ContextMenuStrip = this.cmnKhachHang;
            this.dgvIDCustomer.Location = new System.Drawing.Point(30, 81);
            this.dgvIDCustomer.MultiSelect = false;
            this.dgvIDCustomer.Name = "dgvIDCustomer";
            this.dgvIDCustomer.ReadOnly = true;
            this.dgvIDCustomer.Size = new System.Drawing.Size(419, 158);
            this.dgvIDCustomer.TabIndex = 6;
            this.dgvIDCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIDCustomer_CellClick);
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Location = new System.Drawing.Point(121, 245);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.ReadOnly = true;
            this.txtIDCustomer.Size = new System.Drawing.Size(328, 20);
            this.txtIDCustomer.TabIndex = 5;
            // 
            // txtCustomerNameSearch
            // 
            this.txtCustomerNameSearch.Location = new System.Drawing.Point(112, 51);
            this.txtCustomerNameSearch.Name = "txtCustomerNameSearch";
            this.txtCustomerNameSearch.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerNameSearch.TabIndex = 4;
            // 
            // btNameSearch
            // 
            this.btNameSearch.Location = new System.Drawing.Point(374, 49);
            this.btNameSearch.Name = "btNameSearch";
            this.btNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btNameSearch.TabIndex = 3;
            this.btNameSearch.Text = "Tìm kiếm";
            this.btNameSearch.UseVisualStyleBackColor = true;
            this.btNameSearch.Click += new System.EventHandler(this.btNameSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên khách hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.BTExit);
            this.groupBox3.Controls.Add(this.BtNewOrder);
            this.groupBox3.Controls.Add(this.dgvOrderDetail);
            this.groupBox3.Controls.Add(this.txtCustomerNameOrder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(481, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 586);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mua hàng";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(73, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(13, 13);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tổng tiền:";
            // 
            // BTExit
            // 
            this.BTExit.Location = new System.Drawing.Point(227, 538);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(130, 40);
            this.BTExit.TabIndex = 4;
            this.BTExit.Text = "Thoát";
            this.BTExit.UseVisualStyleBackColor = true;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // BtNewOrder
            // 
            this.BtNewOrder.Location = new System.Drawing.Point(6, 538);
            this.BtNewOrder.Name = "BtNewOrder";
            this.BtNewOrder.Size = new System.Drawing.Size(130, 40);
            this.BtNewOrder.TabIndex = 3;
            this.BtNewOrder.Text = "Tạo hóa đơn mới";
            this.BtNewOrder.UseVisualStyleBackColor = true;
            this.BtNewOrder.Click += new System.EventHandler(this.BtNewOrder_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.ContextMenuStrip = this.cmnDeleteOrder;
            this.dgvOrderDetail.Location = new System.Drawing.Point(15, 63);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.Size = new System.Drawing.Size(342, 448);
            this.dgvOrderDetail.TabIndex = 2;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            // 
            // cmnDeleteOrder
            // 
            this.cmnDeleteOrder.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnDeleteOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdsdfsdfToolStripMenuItem});
            this.cmnDeleteOrder.Name = "cmnDeleteOrder";
            this.cmnDeleteOrder.Size = new System.Drawing.Size(223, 26);
            // 
            // fdsdfsdfToolStripMenuItem
            // 
            this.fdsdfsdfToolStripMenuItem.Name = "fdsdfsdfToolStripMenuItem";
            this.fdsdfsdfToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.fdsdfsdfToolStripMenuItem.Text = "Xóa sản phẩm khỏi hóa đơn";
            this.fdsdfsdfToolStripMenuItem.Click += new System.EventHandler(this.fdsdfsdfToolStripMenuItem_Click);
            // 
            // txtCustomerNameOrder
            // 
            this.txtCustomerNameOrder.AutoSize = true;
            this.txtCustomerNameOrder.Location = new System.Drawing.Point(107, 16);
            this.txtCustomerNameOrder.Name = "txtCustomerNameOrder";
            this.txtCustomerNameOrder.Size = new System.Drawing.Size(25, 13);
            this.txtCustomerNameOrder.TabIndex = 1;
            this.txtCustomerNameOrder.Text = "......";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaoHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaoHoaDon";
            this.Load += new System.EventHandler(this.frmTaoHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDCamera)).EndInit();
            this.cmnSanPham.ResumeLayout(false);
            this.cmnKhachHang.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.cmnDeleteOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtQuanity;
        private System.Windows.Forms.DataGridView dgvIDCamera;
        private System.Windows.Forms.Button txtAddOrder;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtIDCamera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearchID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvIDCustomer;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.TextBox txtCustomerNameSearch;
        private System.Windows.Forms.Button btNameSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Button BtNewOrder;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Label txtCustomerNameOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip cmnSanPham;
        private System.Windows.Forms.ToolStripMenuItem quảnLíSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem quảnLíKháchHàngToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.ContextMenuStrip cmnDeleteOrder;
        private System.Windows.Forms.ToolStripMenuItem fdsdfsdfToolStripMenuItem;
    }
}