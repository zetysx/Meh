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
    public partial class frmSanPham : Form
    {
        public delegate void UpdateForm();
        public UpdateForm update;
        SqlDataAdapter adapt;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public frmSanPham()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adapt = new SqlDataAdapter("Select * from tblCamera where status='true' ", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adapt);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            update?.Invoke();
            this.Close();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();           
            dgvCameraData.Columns["Status"].Visible = false;
        }

       
        public void LoadData()
        {
            if (dgvCameraData.DataSource != null)
            {
                myds.Tables["CameraData"].Clear();
                myds.Tables["CameraData"].Columns.Clear();
            }
            try
            {
                adapt.Fill(myds, "CameraData");
                dgvCameraData.DataSource = myds.Tables["CameraData"];

                //Việt Hóa Dữ liệu trên datagrid View
                myds.Tables["CameraData"].Columns["CameraID"].ColumnName = "Mã Camera";
                myds.Tables["CameraData"].Columns["CameraName"].ColumnName = "Tên Camera";
                myds.Tables["CameraData"].Columns["Price"].ColumnName = "Giá";
                myds.Tables["CameraData"].Columns["CamBienHinhAnh"].ColumnName = "Cảm Biến Hình Ảnh";
                myds.Tables["CameraData"].Columns["DoPhanGiai"].ColumnName = "Độ Phân Giải";
                myds.Tables["CameraData"].Columns["KhoangCach"].ColumnName = "Khoảng Cách";
                myds.Tables["CameraData"].Columns["OngKinh"].ColumnName = "Ống Kính";
                myds.Tables["CameraData"].Columns["TamXaHongNgoai"].ColumnName = "Tầm Xa Hồng Ngoại";
                myds.Tables["CameraData"].Columns["Nguon"].ColumnName = "Nguồn";
                myds.Tables["CameraData"].Columns["NhietDo"].ColumnName = "Nhiệt Độ";
                myds.Tables["CameraData"].Columns["ChatLieu"].ColumnName = "Chất Liệu";
                myds.Tables["CameraData"].Columns["HoTro"].ColumnName = "Hỗ Trợ";


            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n" + e.Message);
                dgvCameraData.DataSource = null;
            }

        }

        private void btNew_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter adaptID = new SqlDataAdapter("Select * from tblCamera", constring);          
            adaptID.Fill(myds, "ID4Camera");

            //Reset lai title tren datagridview
            if (dgvCameraData.DataSource != null)
            {
                myds.Tables["CameraData"].Clear();
                myds.Tables["CameraData"].Columns.Clear();
            }
            adapt.Fill(myds, "CameraData");
            dgvCameraData.DataSource = myds.Tables["CameraData"];

            //Sau đó thêm mới sản phẩm như bình thường          
            DataRow newCamera = myds.Tables["CameraData"].NewRow();
            string idCam = "Cam" + (myds.Tables["ID4Camera"].Rows.Count + 1).ToString();
            newCamera["CameraID"] = idCam;
            myds.Tables["ID4Camera"].Clear();            

            //Rồi nhập tiếp dữ liệu của Camera 
            if (txtTenSP.Text != "")
            {
                newCamera["CameraName"] = txtTenSP.Text;
            }
            else
            {
                MessageBox.Show("Làm ơn nhập tên Camera");
                return;
            }
            try
            {
                if (txtGia.Value > 0)
                {
                    newCamera["Price"] = txtGia.Value;
                }
                else
                {
                    MessageBox.Show("Làm ơn nhập giá lớn hơn 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Làm ơn nhập giá");
                return;
            }

            newCamera["CamBienHinhAnh"] = txtCambien.Text;
            newCamera["DoPhanGiai"] = txtDoPGiai.Text;
            newCamera["KhoangCach"] = txtKhoangCach.Text;
            newCamera["OngKinh"] = txtOngKinh.Text;
            newCamera["TamXaHongNgoai"] = txtTamXa.Text;
            newCamera["Nguon"] = txtNguon.Text;
            newCamera["NhietDo"] = txtNhietDo.Text;
            newCamera["ChatLieu"] = txtChatLieu.Text;
            newCamera["HoTro"] = txtHoTro.Text;
            newCamera["Status"] = true;
            newCamera["Quantity"] = 0;
            myds.Tables["CameraData"].Rows.Add(newCamera);

            try
            {
                adapt.Update(myds.Tables["CameraData"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin lỗi ! Có lỗi xảy ra !\nVui Lòng thử lại!\n " + ex.Message);
            }
            LoadData();       
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvCameraData.DataSource != null)
            {
                myds.Tables["CameraData"].Clear();
                myds.Tables["CameraData"].Columns.Clear();
            }
            adapt.Fill(myds, "CameraData");
            dgvCameraData.DataSource = myds.Tables["CameraData"];

            //Chỉnh Sửa Như Bình Thường
            if (txtID.Text != "")
            {
                DataRow[] cameraRowToUpdate = myds.Tables["CameraData"].Select(string.Format("CameraID = '{0}'", txtID.Text));
                cameraRowToUpdate[0]["CameraName"] = txtTenSP.Text;
                cameraRowToUpdate[0]["Price"] = txtGia.Value;
                cameraRowToUpdate[0]["CamBienHinhAnh"] = txtCambien.Text;
                cameraRowToUpdate[0]["DoPhanGiai"] = txtDoPGiai.Text;
                cameraRowToUpdate[0]["KhoangCach"] = txtKhoangCach.Text;
                cameraRowToUpdate[0]["OngKinh"] = txtOngKinh.Text;
                cameraRowToUpdate[0]["TamXaHongNgoai"] = txtTamXa.Text;
                cameraRowToUpdate[0]["Nguon"] = txtNguon.Text;
                cameraRowToUpdate[0]["NhietDo"] = txtNhietDo.Text;
                cameraRowToUpdate[0]["ChatLieu"] = txtChatLieu.Text;
                cameraRowToUpdate[0]["HoTro"] = txtHoTro.Text;
                try
                {
                    adapt.Update(myds.Tables["CameraData"]);
                }
                catch
                {
                    MessageBox.Show("Xin lỗi ! Có lỗi xảy ra ! Hủy Thao Tác");
                }
                LoadData();
            }
            else
            {
                MessageBox.Show("Làm ơn chọn Camera để chỉnh sửa");
            }
        }

        private void btDel_Click_1(object sender, EventArgs e)
        {
            //Khởi tạo lại bảng table (dataset) có giống cấu trúc của cơ sở dữ liệu
            if (dgvCameraData.DataSource != null)
            {
                myds.Tables["CameraData"].Clear();
                myds.Tables["CameraData"].Columns.Clear();
            }
            adapt.Fill(myds, "CameraData");
            dgvCameraData.DataSource = myds.Tables["CameraData"];


            //Xóa Camera
            if (txtID.Text != "")
            {
                DataRow[] cameraRowToUpdate = myds.Tables["CameraData"].Select(string.Format("CameraID = '{0}'", txtID.Text));
                cameraRowToUpdate[0]["Status"] = false;
                try
                {
                    adapt.Update(myds.Tables["CameraData"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi! Lỗi xảy ra trong quá trình xóa !\nVui Lòng Thử Lại!\n" + ex.Message);
                }
                LoadData();

                txtID.Text = "";
                txtTenSP.Text = "";
                txtTenSP.Focus();
                btnLuuChinhSua.Visible = false;
                btnXoa.Visible = false;
                txtGia.Text = "0";
                txtCambien.Text = "";
                txtDoPGiai.Text = "";
                txtKhoangCach.Text = "";
                txtOngKinh.Text = "";
                txtTamXa.Text = "";
                txtNguon.Text = "";
                txtNhietDo.Text = "";
                txtChatLieu.Text = "";
                txtHoTro.Text = "";
            }
            else
            {
                MessageBox.Show("Làm ơn chọn Camera để xóa!");
            }
        }

        private void dgvCameraData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCameraData_Click_1(object sender, EventArgs e)
        {
          
        }

        private void dgvCameraData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnLuuMoi.Visible = false;
            btnLuuChinhSua.Visible = true;
            btnXoa.Visible = true;           

            int rowIndex = dgvCameraData.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvCameraData.Rows[rowIndex];
            try
            {
                txtID.Text = row.Cells["Mã Camera"].Value.ToString();
                txtTenSP.Text = row.Cells["Tên Camera"].Value.ToString();
                try
                {
                    txtGia.Value = (int)row.Cells["Giá"].Value;
                }
                catch 
                {
                    btnLuuMoi.Visible = false;
                    btnLuuChinhSua.Visible = false;
                    btnXoa.Visible = false;
                }
                txtCambien.Text = row.Cells["Cảm Biến Hình Ảnh"].Value.ToString();
                txtDoPGiai.Text = row.Cells["Độ Phân Giải"].Value.ToString();
                txtKhoangCach.Text = row.Cells["Khoảng Cách"].Value.ToString();
                txtOngKinh.Text = row.Cells["Ống Kính"].Value.ToString();
                txtTamXa.Text = row.Cells["Tầm Xa Hồng Ngoại"].Value.ToString();
                txtNguon.Text = row.Cells["Nguồn"].Value.ToString();
                txtNhietDo.Text = row.Cells["Nhiệt Độ"].Value.ToString();
                txtChatLieu.Text = row.Cells["Chất Liệu"].Value.ToString();
                txtHoTro.Text = row.Cells["Hỗ Trợ"].Value.ToString();               
            }
            catch
            {
                btnLuuMoi.Visible = false;
                btnLuuChinhSua.Visible = false;
                btnXoa.Visible = false;
            }          
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadData();
            }
            else
            {
                if (myds.Tables["SearchCamera"] != null)
                {
                    myds.Tables["SearchCamera"].Clear();
                    myds.Tables["SearchCamera"].Columns.Clear();
                }
                SqlCommand cmd = new SqlCommand("Select * from tblCamera where status='true' and CameraName like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTimKiem.Text + "%");
                SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
                adaptSearch.Fill(myds, "SearchCamera");
                dgvCameraData.DataSource = myds.Tables["SearchCamera"];

                //Viet Hoa Du lieu tren datagrid
                myds.Tables["SearchCamera"].Columns["CameraID"].ColumnName = "Mã Camera";
                myds.Tables["SearchCamera"].Columns["CameraName"].ColumnName = "Tên Camera";
                myds.Tables["SearchCamera"].Columns["Price"].ColumnName = "Giá";
                myds.Tables["SearchCamera"].Columns["CamBienHinhAnh"].ColumnName = "Cảm Biến Hình Ảnh";
                myds.Tables["SearchCamera"].Columns["DoPhanGiai"].ColumnName = "Độ Phân Giải";
                myds.Tables["SearchCamera"].Columns["KhoangCach"].ColumnName = "Khoảng Cách";
                myds.Tables["SearchCamera"].Columns["OngKinh"].ColumnName = "Ống Kính";
                myds.Tables["SearchCamera"].Columns["TamXaHongNgoai"].ColumnName = "Tầm Xa Hồng Ngoại";
                myds.Tables["SearchCamera"].Columns["Nguon"].ColumnName = "Nguồn";
                myds.Tables["SearchCamera"].Columns["NhietDo"].ColumnName = "Nhiệt Độ";
                myds.Tables["SearchCamera"].Columns["ChatLieu"].ColumnName = "Chất Liệu";
                myds.Tables["SearchCamera"].Columns["HoTro"].ColumnName = "Hỗ Trợ";
            }
            
        }

        private void btn_Click_1(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenSP.Text = "";
            txtTenSP.Focus();
            btnLuuChinhSua.Visible = false;
            btnXoa.Visible = false;

            txtGia.Text = "0";
            txtCambien.Text = "";
            txtDoPGiai.Text = "";
            txtKhoangCach.Text = "";
            txtOngKinh.Text = "";
            txtTamXa.Text = "";
            txtNguon.Text = "";
            txtNhietDo.Text = "";
            txtChatLieu.Text = "";
            txtHoTro.Text = "";
            btnLuuMoi.Visible = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
