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
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public frmQuanLyKho()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adaptCameraData = new SqlDataAdapter("Select c.CameraID, c.CameraName, c.Quantity from tblCamera c where Status='true' ", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adaptCameraData);
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
                myds.Tables["CameraKho"].Columns["CameraID"].ColumnName = "Mã Camera";
                myds.Tables["CameraKho"].Columns["CameraName"].ColumnName = "Tên Camera";
                myds.Tables["CameraKho"].Columns["Quantity"].ColumnName = "Số Lượng";
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

        }
    }
}
