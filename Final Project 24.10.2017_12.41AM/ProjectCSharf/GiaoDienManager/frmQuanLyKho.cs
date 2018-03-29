using ProjectCSharp;
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
    public partial class frmQuanLyKho : Form
    {
        SqlDataAdapter adaptCameraData;
        SqlDataAdapter adaptKho;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public frmQuanLyKho()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adaptKho = new SqlDataAdapter("Select * from tblHistory", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adaptKho);
            adaptCameraData = new SqlDataAdapter("Select c.CameraID, c.CameraName, c.Quantity from tblCamera c where Status='true' ", constring);
            SqlCommandBuilder invBuilder2 = new SqlCommandBuilder(adaptCameraData);
        }

       
        public void LoadDataCamera()
        {
            if (dgvSearchCameraKho.DataSource != null)
            {
                myds.Tables["CameraKho"].Clear();
                myds.Tables["CameraKho"].Columns.Clear();
            }
            try
            {
                adaptCameraData.Fill(myds, "CameraKho");
                dgvSearchCameraKho.DataSource = myds.Tables["CameraKho"];               

                //Việt hóa dữ liệu table trên datagridview
                myds.Tables["CameraKho"].Columns[0].ColumnName = "Mã Camera";
                myds.Tables["CameraKho"].Columns[1].ColumnName = "Tên Camera";
                myds.Tables["CameraKho"].Columns[2].ColumnName = "Số Lượng";
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n" + e.Message);
                dgvSearchCameraKho.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSearchCameraKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQuanLyKho_Load(object sender, EventArgs e)
        {
            LoadDataCamera();
        }

        private void btnThemMoiCamera_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.update = new frmSanPham.UpdateForm(LoadDataCamera);
            frm.ShowDialog();
        }

        private void dgvSearchCameraKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvSearchCameraKho.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvSearchCameraKho.Rows[rowIndex];
            try
            {
                txtMaCamera.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDataCamera();
            }
            else
            {
                if (myds.Tables["SearchCameraKho"] != null)
                {
                    myds.Tables["SearchCameraKho"].Clear();
                    myds.Tables["SearchCameraKho"].Columns.Clear();
                }
                SqlCommand cmd = new SqlCommand("Select c.CameraID, c.CameraName, c.Quantity from tblCamera c where Status='true' and c.CameraName like @name ", new SqlConnection(constring));
                cmd.Parameters.AddWithValue("@name", "%" + txtTimKiem.Text + "%");
                SqlDataAdapter adaptSearch = new SqlDataAdapter(cmd);
                adaptSearch.Fill(myds, "SearchCameraKho");
                dgvSearchCameraKho.DataSource = myds.Tables["SearchCameraKho"];

                //Viet Hoa Du lieu tren datagrid
                myds.Tables["SearchCameraKho"].Columns["CameraID"].ColumnName = "Mã Camera";
                myds.Tables["SearchCameraKho"].Columns["CameraName"].ColumnName = "Tên Camera";
                myds.Tables["SearchCameraKho"].Columns["Quantity"].ColumnName = "Số Lượng";

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (myds.Tables["KhoData"] != null)
            {
                myds.Tables["KhoData"].Clear();
                myds.Tables["KhoData"].Columns.Clear();
            }
            adaptCameraData.Fill(myds, "KhoData");
            dgvSearchCameraKho.DataSource = myds.Tables["KhoData"];

            //Sau đó chỉnh sửa dữ liệu như bình thường
            try
            {
                if (txtMaCamera.Text != "")
                {
                    if (numSoLuong.Value != 0)
                    {
                        DataRow[] cameraRowToUpdate = myds.Tables["KhoData"].Select(string.Format("CameraID = '{0}'", txtMaCamera.Text));
                        cameraRowToUpdate[0]["Quantity"] = int.Parse(cameraRowToUpdate[0]["Quantity"].ToString()) + numSoLuong.Value;
                        try
                        {
                            adaptCameraData.Update(myds.Tables["KhoData"]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xin lỗi ! Đã xảy ra lỗi trong quá trình chỉnh sửa.\n" + ex.Message);
                        }
                        LoadDataCamera();
                    }
                    else
                    {
                        MessageBox.Show("Yêu Cầu Nhập Số Lượng !!!");
                        LoadDataCamera();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Làm ơn chọn Camera!!!");
                    LoadDataCamera();
                    return;
                }

            }
            catch
            {

            }
            

            //Sau khi cập nhật dữ liệu quantity trên camera thành công, sẽ lưu lại lịch sử thêm vào tblHistory
            SqlDataAdapter adaptHistory = new SqlDataAdapter("Select * from tblHistory", constring);
            adaptHistory.Fill(myds, "ID4History");

            adaptKho.Fill(myds, "HistoryData");
            DataRow newHistory = myds.Tables["HistoryData"].NewRow();
            string historyId = "History" + (myds.Tables["ID4History"].Rows.Count + 1).ToString();
            myds.Tables["ID4History"].Clear();

            newHistory[0] = historyId;
            newHistory[1] = txtMaCamera.Text;
            newHistory[2] = numSoLuong.Value;
            newHistory[3] = DateTime.Today;
            myds.Tables["HistoryData"].Rows.Add(newHistory);
            try
            {
                adaptKho.Update(myds.Tables["HistoryData"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin lỗi !!! Có lỗi Xảy ra. Vui lòng thử lại " + ex.ToString());
                numSoLuong.Value = 0;
            }

            //Sau khi nhập thành công thì thông báo rồi set giá trị số lượng về 0
            MessageBox.Show("Nhập Thành Công !!!");
            numSoLuong.Value = 0;


        }

        private void btnXemLichSu_Click(object sender, EventArgs e)
        {
            frmXemLichSu frm = new frmXemLichSu();
            frm.ShowDialog();
        }
    }
}
