using GiaoDienManager;
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

namespace ProjectCSharp
{
    public partial class frmTaoHoaDon : Form
    {
        DataSet myds = new DataSet();
        string listID = null;
        List<TempOrder> tmp = new List<TempOrder>();//list những mặt hàng với giá tương ứng đã add vào hóa đơn
        //Data Source=ZETYSX;Initial Catalog = CameraShop;Integrated Security=true
        bool exist = false;//cái này dùng để báo hiệu đã tạo hay chưa orderlist   
        SqlDataAdapter adaptDetail;
        SqlDataAdapter adaptSearch;//dùng để load và chỉnh sửa quantity khi tạo order cho camera
        DataGridViewCell selectedCell;//dùng cho chặn lỗi khi chỉnh su73aa quanity order detail
        int curPrice = 0;//giá của cái camera đang được chọn để nhân với quantity thêm vào tổng tiền
        bool isVIP = false;//khách hàng thân thiết

        static string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public frmTaoHoaDon()
        {
            InitializeComponent();
            txtCustomerNameOrder.Text = "";
            txtTotal.Text = "0 VNĐ";
        }

        private void VietHoa()
        {
            myds.Tables["SearchCamera"].Columns[1].ColumnName = "Tên Camera";
            myds.Tables["SearchCamera"].Columns[2].ColumnName = "Giá";
            myds.Tables["SearchCamera"].Columns[3].ColumnName = "Cảm Biến Hình Ảnh";
            myds.Tables["SearchCamera"].Columns[4].ColumnName = "Độ Phân Giải";
            myds.Tables["SearchCamera"].Columns[5].ColumnName = "Khoảng Cách";
            myds.Tables["SearchCamera"].Columns[6].ColumnName = "Ống Kính";
            myds.Tables["SearchCamera"].Columns[7].ColumnName = "Tầm Xa Hồng Ngoại";
            myds.Tables["SearchCamera"].Columns[8].ColumnName = "Nguồn";
            myds.Tables["SearchCamera"].Columns[9].ColumnName = "Nhiệt Độ";
            myds.Tables["SearchCamera"].Columns[10].ColumnName = "Chất Liệu";
            myds.Tables["SearchCamera"].Columns[11].ColumnName = "Hỗ Trợ";
        }


        private void LoadCamera()
        {
            if (myds.Tables["SearchCamera"] != null)
            {
                myds.Tables["SearchCamera"].Clear();
                myds.Tables["SearchCamera"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select * from tblCamera where Status='true' and CameraName like @name and Quantity>0 ", con);
            cmd.Parameters.AddWithValue("@name", "%" + txtSearchID.Text + "%");
            adaptSearch = new SqlDataAdapter(cmd);
            
            adaptSearch.Fill(myds, "SearchCamera");
            dgvIDCamera.DataSource = myds.Tables["SearchCamera"];

            //Việt Hóa Dữ liệu trên datagrid View
            VietHoa();

            dgvIDCamera.Columns[12].Visible = false;
            dgvIDCamera.Columns[13].Visible = false;
            dgvIDCamera.Columns[0].Visible = false;
        }
        private void LoadCustomer()
        {
            if (myds.Tables["SearchCustomer"] != null)
            {
                myds.Tables["SearchCustomer"].Clear();
                myds.Tables["SearchCustomer"].Columns.Clear();
            }

            SqlCommand cmd = new SqlCommand("Select * from tblCustomer where status='true' and CustomerName like @name ", con);
            cmd.Parameters.AddWithValue("@name", "%" + txtCustomerNameSearch.Text + "%");
            SqlDataAdapter adaptSearchCustomer = new SqlDataAdapter(cmd);
            adaptSearchCustomer.Fill(myds, "SearchCustomer");
            dgvIDCustomer.DataSource = myds.Tables["SearchCustomer"];

            //Việt Hóa Dữ liệu trên datagrid View
            myds.Tables["SearchCustomer"].Columns[1].ColumnName = "Tên Khách Hàng";
            myds.Tables["SearchCustomer"].Columns[2].ColumnName = "Ngày Sinh";
            myds.Tables["SearchCustomer"].Columns[3].ColumnName = "Giới Tính";
            myds.Tables["SearchCustomer"].Columns[4].ColumnName = "Địa Chỉ";
            myds.Tables["SearchCustomer"].Columns[5].ColumnName = "Loại Tài Khoản";
            
            dgvIDCustomer.Columns[6].Visible = false;
            dgvIDCustomer.Columns[0].Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadCamera();
            LoadCustomer();
        }

        private void btSearchID_Click(object sender, EventArgs e)
        {
            LoadCamera();
        }

        private void ResetAll()
        {
            exist = false;
            txtCustomerNameOrder.Text = "";
            txtCustomerNameSearch.Text = "";
            txtSearchID.Text = "";
            txtIDCamera.Text = "";
            txtIDCustomer.Text = "";
            LoadCamera();
            LoadCustomer();
            listID = null;
            txtNote.Text = "";
            isVIP = false;
            txtQuanity.Value = 0;
            dgvOrderDetail.DataSource = null;
            curPrice = 0;
            tmp.Clear();
            selectedCell = null;
            txtTotal.Text = "0 VNĐ";
            txtQuanity.Maximum = 100000000;
        }

        private void txtAddOrder_Click(object sender, EventArgs e)
        {
            
            if (txtIDCamera.Text != "" && txtIDCustomer.Text != "" && txtQuanity.Value != 0)
            {
                if (myds.Tables["OrderDetail"] != null)
                {
                    myds.Tables["OrderDetail"].Clear();
                    myds.Tables["OrderDetail"].Columns.Clear();
                    
                }
                //clear orderdetail trước khi tạo orderlist mới
                
                if (listID == null)
                {
                    //Khởi tạo 1 mã hóa đơn

                    SqlDataAdapter adaptCreateListOrderID = new SqlDataAdapter("Select * from tblOrderList ", constring);
                    adaptCreateListOrderID.Fill(myds, "ID4ListOrder");
                    DataRow newOrderList = myds.Tables["ID4ListOrder"].NewRow();
                    listID = "OrderList" + (myds.Tables["ID4ListOrder"].Rows.Count + 1).ToString();                    
                    myds.Tables["ID4ListOrder"].Clear();
                }
                if (!exist)
                {                 
                    SqlDataAdapter adaptList = new SqlDataAdapter("Select * from tblOrderList", con);
                    SqlCommandBuilder builder1 = new SqlCommandBuilder(adaptList);
                    adaptList.Fill(myds, "OrderList");
                    DataRow newOrderList = myds.Tables["OrderList"].NewRow();
                    newOrderList[0] = listID;
                    newOrderList[1] = txtIDCustomer.Text;
                    newOrderList[2] = DateTime.Today;
                    newOrderList[3] = RoleForFrom.Username;
                    myds.Tables["OrderList"].Rows.Add(newOrderList);
                    try
                    {
                        adaptList.Update(myds.Tables["OrderList"]);
                        exist = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xin Lỗi! Có Lỗi khi thêm vào list\n" + ex.ToString());
                        return;
                    }
                    
                }
                //khởi tạo orderlist

                if (exist)
                {
                    SqlCommand cmd = new SqlCommand("Select * from tblOrderDetail where OrderListID=@listID ", con);
                    cmd.Parameters.AddWithValue("@listID", listID);
                    adaptDetail = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder2 = new SqlCommandBuilder(adaptDetail);
                    adaptDetail.Fill(myds, "OrderDetail");
                    DataRow newOrderList = myds.Tables["OrderDetail"].NewRow();
                    newOrderList[0] = listID;
                    newOrderList[1] = txtIDCamera.Text;
                    newOrderList[2] = txtQuanity.Value;
                    newOrderList[3] = txtNote.Text;
                    myds.Tables["OrderDetail"].Rows.Add(newOrderList);
                    try
                    {
                        adaptDetail.Update(myds.Tables["OrderDetail"]);
                        SqlCommandBuilder builder3 = new SqlCommandBuilder(adaptSearch);

                        //Reset lại dữ liệu bằng tiếng anh, để xử lý, trước đó đang là tiếng việt
                        if (myds.Tables["SearchCamera"] != null)
                        {
                            myds.Tables["SearchCamera"].Clear();
                            myds.Tables["SearchCamera"].Columns.Clear();
                        }
                        adaptSearch.Fill(myds, "SearchCamera");
                        DataRow[] cameraRowToUpdate = myds.Tables["SearchCamera"].Select(string.Format("CameraID = '{0}'", txtIDCamera.Text));
                        cameraRowToUpdate[0][13] = int.Parse(cameraRowToUpdate[0][13].ToString()) - txtQuanity.Value;
                        try
                        {
                            adaptSearch.Update(myds.Tables["SearchCamera"]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xin lỗi ! Có lỗi xảy ra ! Hủy Thao Tác" + ex.Message);
                            return;
                        }
                        // trừ quantity trong kho khi thêm vào order
                    }
                    catch (Exception ex)
                    {
                        myds.Tables["OrderDetail"].Clear();
                        adaptDetail.Fill(myds, "OrderDetail");
                        
                        dgvOrderDetail.DataSource = myds.Tables["OrderDetail"];
                        dgvOrderDetail.Columns[0].Visible = false;
                        //refresh lại detail khi có duplicate
                        MessageBox.Show("Sản phẩm đã có trong hóa đơn!");
                        return;
                    }
                    //đống này để add detail vào orderlist 

                    dgvOrderDetail.Refresh();
                    dgvOrderDetail.DataSource = myds.Tables["OrderDetail"];
                    dgvOrderDetail.Columns[0].Visible = false;
                    dgvOrderDetail.Columns[1].ReadOnly = true;

                    //đống này để chỉnh cái grid view

                    tmp.Add(new TempOrder(txtIDCamera.Text,curPrice,(int)txtQuanity.Value));
                   // total +=(double) txtQuanity.Value*curPrice*((isVIP)?0.9:1);
                    txtTotal.Text = (CountTotal()* ((isVIP) ? 0.9 : 1)).ToString() + "VNĐ";
                    //update tổng tiển trên form


                    txtSearchID.Text = "";
                    txtIDCamera.Text = "";
                    txtNote.Text = "";
                    txtQuanity.Value = 0;
                }

                //Việt Hóa Dữ liệu trên datagrid View của sản phẩm sau khi đã order được 1 sản phẩm 
                VietHoa();

                dgvIDCamera.Columns[0].Visible = false;
                dgvIDCamera.Columns[12].Visible = false;
                dgvIDCamera.Columns[13].Visible = false;

            }           
        }
        private int CountTotal()
        {
            int total = 0;
            foreach (TempOrder temp in tmp)
            {
                total += temp.Price * temp.Quanity;
            }
            return total;
        }

        private void btNameSearch_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void BtNewOrder_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvIDCamera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = dgvIDCamera.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvIDCamera.Rows[rowIndex];
                txtIDCamera.Text = row.Cells[0].Value.ToString();
                curPrice = (int)row.Cells[2].Value;
                txtQuanity.Maximum = (int)row.Cells[13].Value;
            }
            catch
            {

            }
        }

        private void dgvIDCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listID == null)
            {
                int rowIndex = dgvIDCustomer.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvIDCustomer.Rows[rowIndex];
                txtIDCustomer.Text = row.Cells[0].Value.ToString();
                txtCustomerNameOrder.Text = row.Cells[1].Value.ToString();
                isVIP = (row.Cells[1].Value.ToString().Equals("Khach hang thuong") ? false : true);
            }
        }


        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.update = new frmSanPham.UpdateForm(LoadCamera);
            sp.ShowDialog();


        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.update = new frmKhachHang.UpdateForm(LoadCustomer);
            kh.ShowDialog();
        }


        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCell = dgvOrderDetail.SelectedCells[0];
           // cmnDeleteOrder.Enabled = true;
            
        }

        private void fdsdfsdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Trước khi xử lý chỗ này, phải reset dữ liệu trên datagridview thành tiếng việt
                if (myds.Tables["SearchCamera"] != null)
                {
                    myds.Tables["SearchCamera"].Clear();
                    myds.Tables["SearchCamera"].Columns.Clear();
                }
                adaptSearch.Fill(myds, "SearchCamera");

                //cell 1 là cameraID,cell 2 là quantity
                string cameraID = dgvOrderDetail.Rows[selectedCell.RowIndex].Cells[1].Value.ToString();
                DataRow[] cameraRowToUpdate = myds.Tables["SearchCamera"].Select(string.Format("CameraID = '{0}'", cameraID));
                cameraRowToUpdate[0][13] = int.Parse(cameraRowToUpdate[0][13].ToString()) + int.Parse(dgvOrderDetail.Rows[selectedCell.RowIndex].Cells[2].Value.ToString());

                dgvIDCustomer.Columns[0].Visible = false;
                dgvIDCustomer.Columns[6].Visible = false;



                //Tiếp tục công đoạn xóa, khi đã có dữ liệu
                try
                {
                    adaptSearch.Update(myds.Tables["SearchCamera"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xin lỗi ! Có lỗi xảy ra ! Hủy Thao Tác" + ex.Message);
                    return;
                }
                try
                {
                    if (selectedCell != null)
                    {
                        int rowDelete = int.Parse(selectedCell.RowIndex.ToString());
                        foreach (TempOrder temp in tmp.ToList())
                        {
                            if (temp.CameraID.Equals(cameraID))
                            {
                                tmp.Remove(temp);
                            }
                        }
                        myds.Tables["OrderDetail"].Rows[rowDelete].Delete();
                        adaptDetail.Update(myds.Tables["OrderDetail"]);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cần chọn sẩn phẩm trong hóa đơn trước khi xóa");
                    return;
                }

                //Sau khi có dữ liệu thì việt hóa trở lại
                dgvIDCamera.DataSource = myds.Tables["SearchCamera"];

                //Việt Hóa Dữ liệu trên datagrid View
                VietHoa();

                dgvIDCamera.Columns[0].Visible = false;
                dgvIDCamera.Columns[12].Visible = false;
                dgvIDCamera.Columns[13].Visible = false;

                txtTotal.Text = (CountTotal() * ((isVIP) ? 0.9 : 1)).ToString() + "VNĐ";
            }
            catch
            {
                //Việt Hóa Dữ liệu trên datagrid View
                VietHoa();

                dgvIDCamera.Columns[0].Visible = false;
                dgvIDCamera.Columns[12].Visible = false;
                dgvIDCamera.Columns[13].Visible = false;
            }

            
        }

        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
