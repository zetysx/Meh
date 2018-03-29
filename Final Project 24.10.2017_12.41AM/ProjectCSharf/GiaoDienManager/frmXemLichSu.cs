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
    public partial class frmXemLichSu : Form
    {
        SqlDataAdapter adaptKho;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public frmXemLichSu()
        {
            InitializeComponent();
            InitDataset();
        }

        public void InitDataset()
        {
            adaptKho = new SqlDataAdapter("Select * from tblHistory", constring);
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(adaptKho);
        }

        public void LoadKho()
        {
            if (dgvLichSuNhapKho.DataSource != null)
            {
                myds.Tables["DataKho"].Clear();
                myds.Tables["DataKho"].Columns.Clear();
            }
            try
            {
                adaptKho.Fill(myds, "DataKho");
                dgvLichSuNhapKho.DataSource = myds.Tables["DataKho"];

                //Việt hóa dữ liệu table trên datagridview
                myds.Tables["DataKho"].Columns[0].ColumnName = "Mã Nhập Kho";
                myds.Tables["DataKho"].Columns[1].ColumnName = "Mã Camera";
                myds.Tables["DataKho"].Columns[2].ColumnName = "Số Lượng";
                myds.Tables["DataKho"].Columns[3].ColumnName = "Ngày Nhập";
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể tải dữ liệu !!!\n" + e.Message);
                dgvLichSuNhapKho.DataSource = null;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Load(object sender, EventArgs e)
        {
            LoadKho();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myds.Tables["DataKho"] != null)
            {
                myds.Tables["DataKho"].Clear();
                myds.Tables["DataKho"].Columns.Clear();
            }
            SqlCommand cmd = new SqlCommand("Select * From tblHistory Where ([DateAdd] between @fromDate and @toDate) ", new SqlConnection(constring));
            cmd.Parameters.AddWithValue("@fromDate", dateTuNgay.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@toDate", dateDenNgay.Value.ToString("yyyy-MM-dd"));

            SqlDataAdapter adaptKhoSearch = new SqlDataAdapter(cmd);
            adaptKhoSearch.Fill(myds, "DataKho");
            dgvLichSuNhapKho.DataSource = myds.Tables["DataKho"];

            //Viet hoa table tren datagridview
            myds.Tables["DataKho"].Columns[0].ColumnName = "Mã Nhập Kho";
            myds.Tables["DataKho"].Columns[1].ColumnName = "Mã Camera";
            myds.Tables["DataKho"].Columns[2].ColumnName = "Số Lượng";
            myds.Tables["DataKho"].Columns[3].ColumnName = "Ngày Nhập";

        }

        private void btnXemToanBo_Click(object sender, EventArgs e)
        {
            LoadKho();
        }
    }
}
