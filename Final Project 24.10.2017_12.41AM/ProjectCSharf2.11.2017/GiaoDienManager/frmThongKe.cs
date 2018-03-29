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
    public partial class frmThongKe : Form
    {
        SqlDataAdapter adaptCameraData;
        SqlDataAdapter adaptCustomerData;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        
        public frmThongKe()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adaptCameraData = new SqlDataAdapter("Select * from tblCamera where status='true' ", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adaptCameraData);

            adaptCustomerData = new SqlDataAdapter("Select * from tblCustomer where status='true' ", constring);
            SqlCommandBuilder invBuilder2 = new SqlCommandBuilder(adaptCustomerData);
        }

        public void LoadDataCamera()
        {
            if (dgvCameraSearch.DataSource != null)
            {
                myds.Tables["CameraData"].Clear();
                myds.Tables["CameraData"].Columns.Clear();
            }
            try
            {
                
                adaptCameraData.Fill(myds, "CameraData");
                dgvCameraSearch.DataSource = myds.Tables["CameraData"];
                dgvCameraSearch.Columns["Status"].Visible = false;

                //Viet hoa du lieu table tren datagridview
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
                dgvCameraSearch.DataSource = null;
            }

        }

        public void LoadDataCustomer()
        {
            if (dgvKhachHang.DataSource != null)
            {
                myds.Tables["CustomerData"].Clear();
                myds.Tables["CustomerData"].Columns.Clear();
            }
            try
            {

                adaptCustomerData.Fill(myds, "CustomerData");
                dgvKhachHang.DataSource = myds.Tables["CustomerData"];
                dgvKhachHang.Columns["Status"].Visible = false;

                //Viet hoa du lieu table tren datagridview
                myds.Tables["CustomerData"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
                myds.Tables["CustomerData"].Columns["CustomerName"].ColumnName = "Tên Khách Hàng";
                myds.Tables["CustomerData"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["CustomerData"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["CustomerData"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["CustomerData"].Columns["Type"].ColumnName = "Loại Tài Khoản";

            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n" + e.Message);
                dgvKhachHang.DataSource = null;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKe_ThuNhap_Click(object sender, EventArgs e)
        {
            //Xoa du lieu thong ke truoc do 
            if (myds.Tables["ThongKeThuNhap"] != null)
            {
                myds.Tables["ThongKeThuNhap"].Clear();
                myds.Tables["ThongKeThuNhap"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select ox.OrderListID,ox.CustomerID,ox.[Date],ox.UsernameID,t.Tong " +
                                            "From tblOrderList ox , (Select l.OrderListID, Tong = sum(Price * Quantity) " +
                                                                    "From tblOrderDetail o, tblCamera c, tblOrderList l " +
                                                                    "Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID " +
                                                                    "Group by l.OrderListID) t " +
                                            "Where Date >= @fromDate and Date <= @toDate and ox.OrderListID = t.OrderListID", new SqlConnection(constring));            
            cmd.Parameters.AddWithValue("@fromDate", dateTuNgay.Value);
            cmd.Parameters.AddWithValue("@toDate", dateDenNgay.Value);

            SqlDataAdapter adaptThongKeThuNhap = new SqlDataAdapter(cmd);
            adaptThongKeThuNhap.Fill(myds, "ThongKeThuNhap");
            dgvThongKe_ThuNhap.DataSource = myds.Tables["ThongKeThuNhap"];

            //Xử lý tổng số hóa đơn từ ngày x -> ngày y
            txtSoHoaDon_ThuNhap.Text = (myds.Tables["ThongKeThuNhap"].Rows.Count).ToString();

            //Xử Lý Tổng Thu Nhập
            //Lấy số lượng hóa đơn, thực hiện vòng lặp
            int numberOfOrder = Int32.Parse(txtSoHoaDon_ThuNhap.Text);
            int TongTienHoaDonThuNhap = 0;
            for (int i = 0; i < numberOfOrder; i++)
            {
                DataGridViewRow rowDataGridView = dgvThongKe_ThuNhap.Rows[i];
                TongTienHoaDonThuNhap += Int32.Parse(rowDataGridView.Cells["Tong"].Value.ToString());
            }

            txtTongTien_ThuNhap.Text = TongTienHoaDonThuNhap.ToString();

            //Viet hoa table tren datagridview
            myds.Tables["ThongKeThuNhap"].Columns["OrderListID"].ColumnName = "Mã Hóa Đơn";
            myds.Tables["ThongKeThuNhap"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
            myds.Tables["ThongKeThuNhap"].Columns["Date"].ColumnName = "Ngày Tạo Hóa Đơn";
            myds.Tables["ThongKeThuNhap"].Columns["UsernameID"].ColumnName = "Tài Khoản Thực Hiện";
            myds.Tables["ThongKeThuNhap"].Columns["Tong"].ColumnName = "Tổng Hóa Đơn";

            
        }

        private void btnTimCamera_Click(object sender, EventArgs e)
        {
            if (txtTenCamera.Text == "")
            {
                LoadDataCamera();
            }
            else
            {
                if (myds.Tables["SearchCamera"] != null)
                {
                    myds.Tables["SearchCamera"].Clear();
                    myds.Tables["SearchCamera"].Columns.Clear();
                }

                SqlCommand cmd = new SqlCommand("Select * from tblCamera where status='true' and CameraName like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTenCamera.Text + "%");
                SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
                adaptSearch.Fill(myds, "SearchCamera");
                dgvCameraSearch.DataSource = myds.Tables["SearchCamera"];

                //Viet hoa du lieu table tren datagridview
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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadDataCamera();
            LoadDataCustomer();
        }

        private void dgvCameraSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = dgvCameraSearch.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvCameraSearch.Rows[rowIndex];
            try
            {
                txtMaCamera.Text = row.Cells["Mã Camera"].Value.ToString();                
            }
            catch
            {

            }
        }

        private void btnThongKe_MatHang_Click(object sender, EventArgs e)
        {
            //Xoa du lieu thong ke truoc do 
            if (myds.Tables["ThongKeMatHang"] != null)
            {
                myds.Tables["ThongKeMatHang"].Clear();
                myds.Tables["ThongKeMatHang"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select a.OrderListID, a.CustomerID , a.[Date] , a.UsernameID , b.CameraID , b.Quantity , c.Price , Tong = b.Quantity*c.Price, b.Note " +
                                            "From tblOrderList a, tblOrderDetail b, tblCamera c " +
                                            "Where a.OrderListID = b.OrderListID and b.CameraID = @CameraID and c.CameraID = b.CameraID", new SqlConnection(constring));
            cmd.Parameters.AddWithValue("@CameraID", txtMaCamera.Text);

            SqlDataAdapter adaptThongKeMatHang = new SqlDataAdapter(cmd);
            adaptThongKeMatHang.Fill(myds, "ThongKeMatHang");
            dgThongKe_MatHang.DataSource = myds.Tables["ThongKeMatHang"];
            

            //Xử lý tổng số hóa đơn 
            txtSoHoaDon_MatHang.Text = (myds.Tables["ThongKeMatHang"].Rows.Count).ToString();

            //Xử Lý Tổng Tien Mat hang
            //Lấy số lượng hóa đơn, thực hiện vòng lặp
            int numberOfOrder2 = Int32.Parse(txtSoHoaDon_MatHang.Text);
            int TongTienHoaDonMatHang = 0;
            for (int i = 0; i < numberOfOrder2; i++)
            {
                DataGridViewRow rowDataGridView = dgThongKe_MatHang.Rows[i];
                TongTienHoaDonMatHang += Int32.Parse(rowDataGridView.Cells["Tong"].Value.ToString());
            }
            txtTongTien_MatHang.Text = TongTienHoaDonMatHang.ToString();

            //Viet hoa du lieu table tren datagridview
            myds.Tables["ThongKeMatHang"].Columns["OrderListID"].ColumnName = "Mã Hóa Đơn";
            myds.Tables["ThongKeMatHang"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
            myds.Tables["ThongKeMatHang"].Columns["Date"].ColumnName = "Ngày";
            myds.Tables["ThongKeMatHang"].Columns["UsernameID"].ColumnName = "Tài Khoản Thực Hiện";
            myds.Tables["ThongKeMatHang"].Columns["CameraID"].ColumnName = "Mã Camera";
            myds.Tables["ThongKeMatHang"].Columns["Quantity"].ColumnName = "Số Lượng";
            myds.Tables["ThongKeMatHang"].Columns["Price"].ColumnName = "Giá";
            myds.Tables["ThongKeMatHang"].Columns["Tong"].ColumnName = "Tổng";
            myds.Tables["ThongKeMatHang"].Columns["Note"].ColumnName = "Ghi Chú";

        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "")
            {
                LoadDataCustomer();
            }
            else
            {
                if (myds.Tables["SearchCustomer"] != null)
                {
                    myds.Tables["SearchCustomer"].Clear();
                    myds.Tables["SearchCustomer"].Columns.Clear();

                }
                SqlCommand cmd = new SqlCommand("Select * from tblCustomer where status='true' and CustomerName like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTenKhachHang.Text + "%");
                SqlDataAdapter adaptSearchCustomer = new SqlDataAdapter(cmd);
                adaptSearchCustomer.Fill(myds, "SearchCustomer");
                dgvKhachHang.DataSource = myds.Tables["SearchCustomer"];

                //Viet hoa du lieu table tren datagridview
                myds.Tables["SearchCustomer"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
                myds.Tables["SearchCustomer"].Columns["CustomerName"].ColumnName = "Tên Khách Hàng";
                myds.Tables["SearchCustomer"].Columns["BirthDay"].ColumnName = "Ngày Sinh";
                myds.Tables["SearchCustomer"].Columns["Sex"].ColumnName = "Giới Tính";
                myds.Tables["SearchCustomer"].Columns["Address"].ColumnName = "Địa Chỉ";
                myds.Tables["SearchCustomer"].Columns["Type"].ColumnName = "Loại Tài Khoản";
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvKhachHang.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvKhachHang.Rows[rowIndex];
            try
            {
                txtMaKhachHang.Text = row.Cells["Mã Khách Hàng"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThongKe_KhachHang_Click(object sender, EventArgs e)
        {
            //Xoa du lieu thong ke truoc do 
            if (myds.Tables["ThongKeKhachHang"] != null)
            {
                myds.Tables["ThongKeKhachHang"].Clear();
                myds.Tables["ThongKeKhachHang"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select a.OrderListID, a.CustomerID , a.[Date] , a.UsernameID , b.CameraID , b.Quantity , c.Price , Tong = b.Quantity*c.Price, b.Note " +
                                            "From tblOrderList a, tblOrderDetail b, tblCamera c " +
                                            "Where CustomerID = @CustomerID and a.OrderListID = b.OrderListID and c.CameraID = b.CameraID", new SqlConnection(constring));
            cmd.Parameters.AddWithValue("@CustomerID", txtMaKhachHang.Text);

            SqlDataAdapter adaptThongKeKhachHang = new SqlDataAdapter(cmd);
            adaptThongKeKhachHang.Fill(myds, "ThongKeKhachHang");
            dgvThongKe_KhachHang.DataSource = myds.Tables["ThongKeKhachHang"];

            //Xử lý tổng số hóa đơn từ ngày x -> ngày y
            txtSoHoaDon_KhachHang.Text = (myds.Tables["ThongKeKhachHang"].Rows.Count).ToString();

            //Xử Lý Tổng Tien Khach Hang
            //Lấy số lượng hóa đơn, thực hiện vòng lặp
            int numberOfOrder3 = Int32.Parse(txtSoHoaDon_KhachHang.Text);
            int TongTienHoaDonKhachHang = 0;
            for (int i = 0; i < numberOfOrder3; i++)
            {
                DataGridViewRow rowDataGridView = dgvThongKe_KhachHang.Rows[i];
                TongTienHoaDonKhachHang += Int32.Parse(rowDataGridView.Cells["Tong"].Value.ToString());
            }
            txtTongTien_KhachHang.Text = TongTienHoaDonKhachHang.ToString();

            //Viet hoa table tren datagridview
            myds.Tables["ThongKeKhachHang"].Columns["OrderListID"].ColumnName = "Mã Hóa Đơn";
            myds.Tables["ThongKeKhachHang"].Columns["CustomerID"].ColumnName = "Mã Khách Hàng";
            myds.Tables["ThongKeKhachHang"].Columns["Date"].ColumnName = "Ngày";
            myds.Tables["ThongKeKhachHang"].Columns["UsernameID"].ColumnName = "Tài Khoản Thực Hiện";
            myds.Tables["ThongKeKhachHang"].Columns["CameraID"].ColumnName = "Mã Camera";
            myds.Tables["ThongKeKhachHang"].Columns["Quantity"].ColumnName = "Số Lượng";
            myds.Tables["ThongKeKhachHang"].Columns["Price"].ColumnName = "Giá";
            myds.Tables["ThongKeKhachHang"].Columns["Tong"].ColumnName = "Tổng";
            myds.Tables["ThongKeKhachHang"].Columns["Note"].ColumnName = "Ghi Chú";



        }

        private void tabPageThuNhap_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageMatHang_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Khac_Click(object sender, EventArgs e)
        {
            //Xử Lý Sản Phẩm Bán Chạy Nhất ------------------------
            if (myds.Tables["SanPhamBanChayNhat"] != null)
            {
                myds.Tables["SanPhamBanChayNhat"].Clear();
                myds.Tables["SanPhamBanChayNhat"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select t.CameraID, c.CameraName , t.Tong " +
                                            "From tblCamera c, (Select c.CameraID, Tong = sum(b.Quantity * c.Price) " +
                                                                "From tblOrderList a, tblOrderDetail b, tblCamera c " +
                                                                "Where a.OrderListID = b.OrderListID and c.CameraID = b.CameraID " +
                                                                 "Group By c.CameraID) t " +
                                            "Where c.CameraID = t.CameraID", new SqlConnection(constring));
            SqlDataAdapter adaptSanPhamBanChayNhat = new SqlDataAdapter(cmd);
            adaptSanPhamBanChayNhat.Fill(myds, "SanPhamBanChayNhat");

            //Xử lý tổng số hóa đơn 
            int numberOfSanPhamBanChayNhat = Int32.Parse((myds.Tables["SanPhamBanChayNhat"].Rows.Count).ToString());
            int MaxSanPhamBanChayNhat = 0;
            string strSanPhamBanChayNhat = "";
            for (int i = 0; i < numberOfSanPhamBanChayNhat; i++)
            {
                DataRow row = myds.Tables["SanPhamBanChayNhat"].Rows[i];
                int temp = Int32.Parse(row["Tong"].ToString());
                if ( temp >= MaxSanPhamBanChayNhat)
                {
                    MaxSanPhamBanChayNhat = temp;
                    strSanPhamBanChayNhat = row["CameraName"].ToString();
                }
            }
            txtSanPhamBanChay.Text = strSanPhamBanChayNhat;

            //Xử Lý Khách Hàng Mua Nhiều Nhất -----------------------------
            if (myds.Tables["KhachHangMuaNhieuNhat"] != null)
            {
                myds.Tables["KhachHangMuaNhieuNhat"].Clear();
                myds.Tables["KhachHangMuaNhieuNhat"].Columns.Clear();
            }
            SqlCommand cmd2 = new SqlCommand("Select c.CustomerID , c.CustomerName , t.Tong "+
                                                "From tblCustomer c, (Select cus.CustomerID, Tong = sum(b.Quantity * cam.Price) " +
                                                                    "From tblOrderList a, tblOrderDetail b, tblCamera cam, tblCustomer cus " +
                                                                    "Where cus.CustomerID = a.CustomerID and a.OrderListID = b.OrderListID and cam.CameraID = b.CameraID " +
                                                                    "Group By cus.CustomerID) t " +
                                                "Where c.CustomerID = t.CustomerID", new SqlConnection(constring));
            SqlDataAdapter adaptKhachHangMuaNhieuNhat = new SqlDataAdapter(cmd2);
            adaptKhachHangMuaNhieuNhat.Fill(myds, "KhachHangMuaNhieuNhat");

            //Xử lý tổng số hóa đơn 
            int numberOfKhachHangMuaNhieu = Int32.Parse((myds.Tables["KhachHangMuaNhieuNhat"].Rows.Count).ToString());
            int MaxKhachHangMuaNhieu = 0;
            string strKhachHangMuaNhieu = "";
            for (int i = 0; i < numberOfKhachHangMuaNhieu; i++)
            {
                DataRow row = myds.Tables["KhachHangMuaNhieuNhat"].Rows[i];
                int temp = Int32.Parse(row["Tong"].ToString());
                if (temp >= MaxKhachHangMuaNhieu)
                {
                    MaxKhachHangMuaNhieu = temp;
                    strKhachHangMuaNhieu = row["CustomerName"].ToString();
                }
            }
            txtKhachHangMuaNhieuNhat.Text = strKhachHangMuaNhieu;

            //Xử Lý Tổng Số Hóa Đơn ---------------------------------
            if (myds.Tables["TongSoHoaDon"] != null)
            {
                myds.Tables["TongSoHoaDon"].Clear();
                myds.Tables["TongSoHoaDon"].Columns.Clear();
            }
            SqlCommand cmd3 = new SqlCommand("Select ox.OrderListID,ox.CustomerID,ox.[Date],ox.UsernameID,t.Tong " +
                                            "From tblOrderList ox , (Select l.OrderListID, Tong = sum(Price * Quantity) " +
                                                                    "From tblOrderDetail o, tblCamera c, tblOrderList l " +
                                                                    "Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID " +
                                                                    "Group by l.OrderListID) t " + 
                                            "Where ox.OrderListID = t.OrderListID", new SqlConnection(constring));
            SqlDataAdapter adaptTongSoHoaDon = new SqlDataAdapter(cmd3);
            adaptTongSoHoaDon.Fill(myds, "TongSoHoaDon");

            //Tổng số hóa đơn 
            txtSoHoaDon_Khac.Text = (myds.Tables["TongSoHoaDon"].Rows.Count).ToString();

            //Xử Lý Tổng Tiền Thu Về -------------------------
            int tongTienThuVe = 0;
            for (int i = 0; i < Int32.Parse(txtSoHoaDon_Khac.Text); i++)
            {
                DataRow row = myds.Tables["TongSoHoaDon"].Rows[i];
                tongTienThuVe += Int32.Parse(row["Tong"].ToString());
            }
            txtTongTienThuVe_Khac.Text = tongTienThuVe.ToString();
        }
    }
}
