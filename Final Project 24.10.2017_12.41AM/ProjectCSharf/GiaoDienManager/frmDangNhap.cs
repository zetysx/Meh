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
 
    public partial class frmDangNhap : Form
    {
        public delegate void Login(string role);

        public Login loginrole;

        SqlDataAdapter adapt;
        DataSet myds = new DataSet();
        string constring = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constring);
                string queryString = "Select * from tblAccount where Username = @Username and Password= @Password";
                myds = new DataSet();
                adapt = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd = new SqlCommand(queryString, con);
                cmd.Parameters.Add(new SqlParameter("Username", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("Password", txtPass.Text));
                adapt.SelectCommand = cmd;
                adapt.Fill(myds, "Account");
                dt = myds.Tables["Account"];
                if (dt.Rows.Count != 0)
                {
                    DataRow[] loginAccount = myds.Tables["Account"].Select(string.Format("Username = '{0}'", txtName.Text));
                    RoleForFrom.Role = loginAccount[0]["Role"].ToString();                   
                    MessageBox.Show("Đăng nhập thành công với tài khoản : "+ txtName.Text +
                        "\nTruy cập với quyền : " + RoleForFrom.Role);
                    loginrole(RoleForFrom.Role);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại vui lòng thử lại");
                    loginrole("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myds.Clear();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //Form vua load len , thi set mac dinh LoginRole = "", nham chan loi
            loginrole("");
        }

        
    }
}
