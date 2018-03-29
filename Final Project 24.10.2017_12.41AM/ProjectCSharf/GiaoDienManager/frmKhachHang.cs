using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienManager
{
    public partial class frmKhachHang : Form
    {
        public delegate void UpdateForm();
        public UpdateForm update;
        SqlDataAdapter adapt;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        //Code chỗ này phục vụ cho Tạo Hóa Đơn
        private string customerID;
        public string CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }


        public frmKhachHang()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adapt = new SqlDataAdapter("Select * from tblCustomer where status='true' ", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adapt);
        }

        public void LoadData()
        {
            if (dgvKhachHang.DataSource != null)
            {
                myds.Tables["CustomerData"].Clear();
                myds.Tables["CustomerData"].Columns.Clear();
            }
            try
            {
                adapt.Fill(myds, "CustomerData");
                dgvKhachHang.DataSource = myds.Tables["CustomerData"];

                //Việt Hóa Dữ liệu trên datagrid View
                myds.Tables["CustomerData"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
                myds.Tables["CustomerData"].Columns["CustomerName"].ColumnName = "Tên Khách Hàng";
                myds.Tables["CustomerData"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["CustomerData"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["CustomerData"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["CustomerData"].Columns["Type"].ColumnName = "Loại Tài Khoản";

                dgvKhachHang.Columns["Status"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n");
                dgvKhachHang.DataSource = null;
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {

            SqlDataAdapter adaptID = new SqlDataAdapter("Select * from tblCustomer ", constring);
            adaptID.Fill(myds, "ID4Customer");

            //Reset lai title tren datagridview
            if (dgvKhachHang.DataSource != null)
            {
                myds.Tables["CustomerData"].Clear();
                myds.Tables["CustomerData"].Columns.Clear();
            }
            adapt.Fill(myds, "CustomerData");
            dgvKhachHang.DataSource = myds.Tables["CustomerData"];

            //Sau đó thêm mới khách hàng như bình thường
            DataRow newCustomer = myds.Tables["CustomerData"].NewRow();
            newCustomer["CustomerID"] = "Cus" + (myds.Tables["ID4Customer"].Rows.Count + 1).ToString();
            myds.Tables["ID4Customer"].Clear();
            if (txtName.Text != "")
            {
                newCustomer["CustomerName"] = txtName.Text;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập tên khách hàng");
                return;
            }
            newCustomer["CustomerName"] = txtName.Text;
            newCustomer["BirthDay"] = datePickerNgaySinh.Value.ToShortDateString();
            newCustomer["Sex"] = cbSex.Text;
            newCustomer["Address"] = txtAddress.Text;
            if (chkType.Checked == true)
            {
                newCustomer["Type"] = "Khach hang than thiet";
            }
            else
            {
                newCustomer["Type"] = "Khach hang thuong";
            }
            newCustomer["Status"] = true;
            myds.Tables["CustomerData"].Rows.Add(newCustomer);
            try
            {
                adapt.Update(myds.Tables["CustomerData"]);
            }
            catch
            {
                MessageBox.Show("Xin lỗi ! Có lỗi xảy ra ! Vui lòng thử lại ");
            }
            LoadData();
  
        }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            datePickerNgaySinh.Value = DateTime.Today;
            cbSex.Select(1, 0);
            chkType.Checked = false;
            txtName.Focus();
            btnLuuMoi.Visible = true;
            btnXoa.Visible = false;
            btnChinhSua.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            update?.Invoke();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {     
            //
            if (dgvKhachHang.DataSource != null)
            {
                myds.Tables["CustomerData"].Clear();
                myds.Tables["CustomerData"].Columns.Clear();
            }
            adapt.Fill(myds, "CustomerData");
            dgvKhachHang.DataSource = myds.Tables["CustomerData"];

            //Sau đó chỉnh sửa dữ liệu như bình thường
            if (txtMaKhachHang.Text != "")
            {
                DataRow[] customerRowToUpdate = myds.Tables["CustomerData"].Select(string.Format("CustomerID = '{0}'", txtMaKhachHang.Text));
                customerRowToUpdate[0]["Status"] = false;               
                try
                {
                    adapt.Update(myds.Tables["CustomerData"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi! Đã xảy ra lỗi trong quá trình thực hiện!\nVui lòng thử lại sau!\n" + ex.Message);
                }
                LoadData();

                txtMaKhachHang.Text = "";
                txtAddress.Text = "";
                txtName.Text = "";
                btnLuuMoi.Visible = false;
                btnXoa.Visible = false;
                cbSex.Text = "Nam";
                datePickerNgaySinh.Value = DateTime.Today;
                chkType.Checked = false;
            }
            else
            {
                MessageBox.Show("Làm ơn chọn khách hàng để xóa!");
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSua.Visible = true;
            btnXoa.Visible = true;
            btnLuuMoi.Visible = false;

            int rowIndex = dgvKhachHang.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvKhachHang.Rows[rowIndex];

            


            try
            {
                txtMaKhachHang.Text = row.Cells["Mã Khách Hàng"].Value.ToString();
                txtName.Text = row.Cells["Tên Khách Hàng"].Value.ToString();
                try
                {
                    datePickerNgaySinh.Value = DateTime.Parse(row.Cells["Ngày Sinh"].Value.ToString());
                }
                catch
                {
                    btnLuuMoi.Visible = false;
                    btnChinhSua.Visible = false;
                    btnXoa.Visible = false;
                }
                txtAddress.Text = row.Cells["Địa Chỉ"].Value.ToString();
                cbSex.Text = row.Cells["Giới Tính"].Value.ToString();
                if ((row.Cells["Loại Tài Khoản"].Value.ToString()).Equals("Khach hang than thiet"))
                {
                    chkType.Checked = true;
                }
                else
                {
                    chkType.Checked = false;
                }
            }
            catch
            {
                btnLuuMoi.Visible = false;
                btnChinhSua.Visible = false;
                btnXoa.Visible = false;
            }
            

        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (txtTimKiemKH.Text == "")
            {
                LoadData();
            }
            else
            {
                if (myds.Tables["SearchCustomer"] != null)
                {
                    myds.Tables["SearchCustomer"].Clear();
                    myds.Tables["SearchCustomer"].Columns.Clear();
                }

                SqlCommand cmd = new SqlCommand("Select * from tblCustomer where status='true' and CustomerName like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTimKiemKH.Text + "%");
                SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
                adaptSearch.Fill(myds, "SearchCustomer");
                dgvKhachHang.DataSource = myds.Tables["SearchCustomer"];

                //Việt Hóa Dữ liệu trên datagrid View
                myds.Tables["SearchCustomer"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
                myds.Tables["SearchCustomer"].Columns["CustomerName"].ColumnName = "Tên Khách Hàng";
                myds.Tables["SearchCustomer"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["SearchCustomer"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["SearchCustomer"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["SearchCustomer"].Columns["Type"].ColumnName = "Loại Tài Khoản";
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvKhachHang.DataSource != null)
            {
                myds.Tables["CustomerData"].Clear();
                myds.Tables["CustomerData"].Columns.Clear();
            }
            adapt.Fill(myds, "CustomerData");
            dgvKhachHang.DataSource = myds.Tables["CustomerData"];

            //Sau đó chỉnh sửa dữ liệu như bình thường
            if (txtMaKhachHang.Text != "")
            {
                DataRow[] customerRowToUpdate = myds.Tables["CustomerData"].Select(string.Format("CustomerID = '{0}'", txtMaKhachHang.Text));
                customerRowToUpdate[0]["CustomerName"] = txtName.Text;
                customerRowToUpdate[0]["BirthDay"] = datePickerNgaySinh.Value;
                customerRowToUpdate[0]["Sex"] = cbSex.Text;
                customerRowToUpdate[0]["Address"] = txtAddress.Text;
                if (chkType.Checked == true)
                {
                    customerRowToUpdate[0]["Type"] = "Khach hang than thiet";
                }
                else
                {
                    customerRowToUpdate[0]["Type"] = "Khach hang thuong";
                }
                try
                {
                    adapt.Update(myds.Tables["CustomerData"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi! Đã xảy ra lỗi trong quá trình thực hiện!\nVui lòng thử lại sau!\n" + ex.Message);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Làm ơn chọn khách hàng để chỉnh sửa!");
            }
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
