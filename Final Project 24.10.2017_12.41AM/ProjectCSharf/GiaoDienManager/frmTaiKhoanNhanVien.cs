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
    public partial class frmTaiKhoanNhanVien : Form
    {
        SqlDataAdapter adapt;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;      
        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adapt = new SqlDataAdapter("Select * from tblAccount where Status='true'", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adapt);
        }

        public void LoadData()
        {
            if (dgvQuanLyNhanVien.DataSource != null)
            {
                myds.Tables["StaffData"].Clear();
                myds.Tables["StaffData"].Columns.Clear();
            }
            try
            {
                adapt.Fill(myds, "StaffData");
                dgvQuanLyNhanVien.DataSource = myds.Tables["StaffData"];
                myds.Tables["StaffData"].Columns["Username"].ColumnName = "Tên Tài Khoản";
                myds.Tables["StaffData"].Columns["Password"].ColumnName = "Mật Khẩu";
                myds.Tables["StaffData"].Columns["Role"].ColumnName = "Vai Trò";
                myds.Tables["StaffData"].Columns["Name"].ColumnName = "Họ Tên";
                myds.Tables["StaffData"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["StaffData"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["StaffData"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["StaffData"].Columns["Salary"].ColumnName = "Lương";
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n" + e.Message);
                dgvQuanLyNhanVien.DataSource = null;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoanNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvQuanLyNhanVien.Columns["Status"].Visible = false;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvQuanLyNhanVien.DataSource != null)
            {
                myds.Tables["StaffData"].Clear();
                myds.Tables["StaffData"].Columns.Clear();
            }           
            adapt.Fill(myds, "StaffData");
            dgvQuanLyNhanVien.DataSource = myds.Tables["StaffData"];

            //Sau đó thêm mới tài khoản như bình thường
            DataRow newStaff = myds.Tables["StaffData"].NewRow();
            if (txtTenTaiKhoan.Text != "")
            {
                newStaff["Username"] = txtTenTaiKhoan.Text;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập tên tài khoản");
                return;
            }
            if (txtMatKhau.Text != "")
            {
                newStaff["Password"] = txtMatKhau.Text;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập mật khẩu");
                return;
            }
            newStaff["Role"] = cbVaiTro.Text.ToString();
            
            if (txtHoTen.Text != "")
            {
                newStaff["Name"] = txtHoTen.Text;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập họ và tên");
                return;
            }

            try
            {
                if (datePickerNgaySinh.Value != null)
                {
                    newStaff["BirthDay"] = datePickerNgaySinh.Value.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Làm ơn chọn ngày sinh");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Làm ơn chọn ngày sinh");
                return;
            }
            newStaff["Sex"] = cbGioiTinh.Text.ToString();
            newStaff["Address"] = txtDiaChi.Text;
            newStaff["Salary"] = numLuong.Value;
            newStaff["Status"] = true;
            myds.Tables["StaffData"].Rows.Add(newStaff);
            try
            {
                adapt.Update(myds.Tables["StaffData"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xin lỗi ! Xảy ra lỗi trong quá trình thêm tài khoản\nTài khoản này có thể đã tồn tại !!!\nVui lòng thử lại sau !!!\n" + ex.Message);
                txtTenTaiKhoan.ReadOnly = false;
                LoadData();
                return;
            }
            LoadData();
            txtTenTaiKhoan.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvQuanLyNhanVien.DataSource != null)
            {
                myds.Tables["StaffData"].Clear();
                myds.Tables["StaffData"].Columns.Clear();
            }
            adapt.Fill(myds, "StaffData");
            dgvQuanLyNhanVien.DataSource = myds.Tables["StaffData"];

            //Sau đó chỉnh sửa dữ liệu như bình thường
            if (txtTenTaiKhoan.Text != "")
            {
                DataRow[] staffRowToUpdate = myds.Tables["StaffData"].Select(string.Format("Username = '{0}'", txtTenTaiKhoan.Text));
                staffRowToUpdate[0]["Password"] = txtMatKhau.Text;
                staffRowToUpdate[0]["Role"] = cbVaiTro.Text.ToString();
                staffRowToUpdate[0]["Name"] = txtHoTen.Text;
                staffRowToUpdate[0]["BirthDay"] = datePickerNgaySinh.Value;
                staffRowToUpdate[0]["Sex"] = cbGioiTinh.Text;
                staffRowToUpdate[0]["Address"] = txtDiaChi.Text;
                staffRowToUpdate[0]["Salary"] = numLuong.Value;     
                try
                {
                    adapt.Update(myds.Tables["StaffData"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi ! Đã xảy ra lỗi trong quá trình chỉnh sửa.\n" + ex.Message);
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Làm ơn chọn 1 nhân viên để chỉnh sửa !");
            }
        }

        private void groupThongTinNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvQuanLyNhanVien.DataSource != null)
            {
                myds.Tables["StaffData"].Clear();
                myds.Tables["StaffData"].Columns.Clear();
            }
            adapt.Fill(myds, "StaffData");
            dgvQuanLyNhanVien.DataSource = myds.Tables["StaffData"];

            //Sau đó xóa tài khoản như bình thường
            if (txtTenTaiKhoan.Text != "")
            {
                DataRow[] staffRowToUpdate = myds.Tables["StaffData"].Select(string.Format("Username = '{0}'", txtTenTaiKhoan.Text));
                staffRowToUpdate[0]["Status"] = false;
                try
                {
                    adapt.Update(myds.Tables["StaffData"]);
                }
                catch
                {
                    MessageBox.Show("Xin lỗi ! Đã xảy ra lỗi trong quá trình xóa. Vui lòng thử lại.\n");
                }
                LoadData();
                txtTenTaiKhoan.Text = "";

                txtTenTaiKhoan.ReadOnly = false;
                btnLuuChinhSua.Visible = false;
                btnXoa.Visible = false;

                txtTenTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                cbVaiTro.Text = "Staff";
                txtHoTen.Text = "";
                datePickerNgaySinh.Value = DateTime.Today;
                cbGioiTinh.Text = "Nam";
                txtDiaChi.Text = "";
                numLuong.Value = 0;
            }
            else
            {
                MessageBox.Show("Làm ơn chọn 1 tài khoản nhân viên muốn xóa !!!");
            }
        }

        private void dgvQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTaiKhoan.ReadOnly = true;
            btnLuuMoi.Visible = false;
            btnLuuChinhSua.Visible = true;
            btnXoa.Visible = true;
                       
            int rowIndex = dgvQuanLyNhanVien.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvQuanLyNhanVien.Rows[rowIndex];
            try
            {
                txtTenTaiKhoan.Text = row.Cells["Tên Tài Khoản"].Value.ToString();
                txtMatKhau.Text = row.Cells["Mật Khẩu"].Value.ToString();

                cbVaiTro.Text = row.Cells["Vai Trò"].Value.ToString();
                txtHoTen.Text = row.Cells["Họ Tên"].Value.ToString();

                cbGioiTinh.Text = row.Cells["Giới Tính"].Value.ToString();
                txtDiaChi.Text = row.Cells["Địa Chỉ"].Value.ToString();

                try
                {
                    datePickerNgaySinh.Value = DateTime.Parse(row.Cells["Ngày Sinh"].Value.ToString());
                    numLuong.Value = (int)row.Cells["Lương"].Value;
                }
                catch (Exception ex)
                {
                    btnXoa.Visible = false;
                    btnLuuChinhSua.Visible = false;
                    btnLuuMoi.Visible = false;
                }
            }
            catch
            {
                btnXoa.Visible = false;
                btnLuuChinhSua.Visible = false;
                btnLuuMoi.Visible = false;
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                if (myds.Tables["SearchStaff"] != null)
                {
                    myds.Tables["SearchStaff"].Clear();
                    myds.Tables["SearchStaff"].Columns.Clear();
                }
                SqlCommand cmd = new SqlCommand("Select * from tblAccount where Status = 'true' and Username like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTimKiem.Text + "%");
                SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
                adaptSearch.Fill(myds, "SearchStaff");
                dgvQuanLyNhanVien.DataSource = myds.Tables["SearchStaff"];
                myds.Tables["SearchStaff"].Columns["Username"].ColumnName = "Tên Tài Khoản";
                myds.Tables["SearchStaff"].Columns["Password"].ColumnName = "Mật Khẩu";
                myds.Tables["SearchStaff"].Columns["Role"].ColumnName = "Vai Trò";
                myds.Tables["SearchStaff"].Columns["Name"].ColumnName = "Họ Tên";
                myds.Tables["SearchStaff"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["SearchStaff"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["SearchStaff"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["SearchStaff"].Columns["Salary"].ColumnName = "Lương";
            }
            
        }

        private void cbVaiTro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.ReadOnly = false;
            btnLuuChinhSua.Visible = false;
            btnXoa.Visible = false;

            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbVaiTro.Text = "Staff";
            txtHoTen.Text = "";
            datePickerNgaySinh.Value = DateTime.Today;
            cbGioiTinh.Text = "Nam";
            txtDiaChi.Text = "";
            numLuong.Value = 0;
            btnLuuMoi.Visible = true;
        }

        private void dgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void cbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
