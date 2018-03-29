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
        bool exist = false;//cái này dùng để báo hiệu đã tạo hay chưa orderlist   
        SqlDataAdapter adaptDetail;
        DataGridViewCell selectedCell;//dùng cho chặn lỗi khi chỉnh su73aa quanity order detail
        int curPrice = 0;//giá của cái camera đang được chọn để nhân với quantity thêm vào tổng tiền
        bool isVIP = false;

        static string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        public frmTaoHoaDon()
        {
            InitializeComponent();
            txtCustomerNameOrder.Text = "";
            txtTotal.Text = "0 VNĐ";
        }


        private void LoadCamera()
        {
            if (myds.Tables["SearchCamera"] != null) myds.Tables["SearchCamera"].Clear();
            SqlCommand cmd = new SqlCommand("Select * from tblCamera where status='true' and CameraName like @name ", con);
            cmd.Parameters.AddWithValue("@name", "%" + txtSearchID.Text + "%");
            SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
            adaptSearch.Fill(myds, "SearchCamera");
            dgvIDCamera.DataSource = myds.Tables["SearchCamera"];
            dgvIDCamera.Columns["Status"].Visible = false;
            dgvIDCamera.Columns["CameraID"].Visible = false;
        }
        private void LoadCustomer()
        {
            if (myds.Tables["SearchCustomer"] != null) myds.Tables["SearchCustomer"].Clear();
            SqlCommand cmd = new SqlCommand("Select * from tblCustomer where status='true' and CustomerName like @name ", con);
            cmd.Parameters.AddWithValue("@name", "%" + txtCustomerNameSearch.Text + "%");
            SqlDataAdapter adaptSearchCustomer = new SqlDataAdapter(cmd);
            adaptSearchCustomer.Fill(myds, "SearchCustomer");
            dgvIDCustomer.DataSource = myds.Tables["SearchCustomer"];
            dgvIDCustomer.Columns["Status"].Visible = false;
            dgvIDCustomer.Columns["CustomerID"].Visible = false;
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
                if (listID == null)
                {
                    //Khởi tạo 1 mã hóa đơn
                    listID = Guid.NewGuid().ToString();

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
                    newOrderList["OrderListID"] = listID;
                    newOrderList["CustomerID"] = txtIDCustomer.Text;
                    newOrderList["Date"] = DateTime.Today;
                    newOrderList["UsernameID"] = "manager";
                    myds.Tables["OrderList"].Rows.Add(newOrderList);
                    try
                    {
                        adaptList.Update(myds.Tables["OrderList"]);
                        exist = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sorry! Error! Canceling Request!Error adding list" + ex.ToString());
                    }
                }
                if (exist)
                {
                    SqlCommand cmd = new SqlCommand("Select * from tblOrderDetail where OrderListID=@listID ", con);
                    cmd.Parameters.AddWithValue("@listID", listID);
                    adaptDetail = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder2 = new SqlCommandBuilder(adaptDetail);
                    adaptDetail.Fill(myds, "OrderDetail");
                    DataRow newOrderList = myds.Tables["OrderDetail"].NewRow();
                    newOrderList["OrderListID"] = listID;
                    newOrderList["CameraID"] = txtIDCamera.Text;
                    newOrderList["Quantity"] = txtQuanity.Value;
                    newOrderList["Note"] = txtNote.Text;
                    myds.Tables["OrderDetail"].Rows.Add(newOrderList);
                    try
                    {
                        adaptDetail.Update(myds.Tables["OrderDetail"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Product already in the order!");
                    }
                    //đống này để add detail vào orderlist

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
            int rowIndex = dgvIDCamera.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvIDCamera.Rows[rowIndex];
            txtIDCamera.Text = row.Cells[0].Value.ToString();
            curPrice= (int)row.Cells[2].Value;
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
                if (selectedCell != null)
                {
                    int rowDelete = int.Parse(selectedCell.RowIndex.ToString());
                    foreach (TempOrder temp in tmp.ToList())
                    {
                        if (temp.CameraID.Equals(dgvOrderDetail.Rows[selectedCell.RowIndex].Cells[1].Value.ToString()))
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
            }
            txtTotal.Text = (CountTotal() * ((isVIP) ? 0.9 : 1)).ToString() + "VNĐ";
        }

        private void cmnSanPham_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = true;
        }

        private void txtCustomerNameOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
