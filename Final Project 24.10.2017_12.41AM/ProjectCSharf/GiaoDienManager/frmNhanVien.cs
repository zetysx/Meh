using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienManager
{
    public partial class frmNhanVien : Form
    {
        
        public frmNhanVien()
        {
            InitializeComponent();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.ShowDialog();
        }

        private void btCamera_Click(object sender, EventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
