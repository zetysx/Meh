using ProjectCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienManager
{    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CloseAll()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.loginrole = new frmDangNhap.Login(LoadGiaoDien);
            //frmDangNhap.Show();
            frmTienDo tiendo = new frmTienDo();
            tiendo.show = new frmTienDo.ShowLogin(frmDangNhap.Show);
            tiendo.ShowDialog();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.loginrole = new frmDangNhap.Login(LoadGiaoDien);
            frmDangNhap.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.loginrole = new frmDangNhap.Login(LoadGiaoDien);
            toolStripQuanLy.Enabled = false;
            toolStripNhanVien.Enabled = false;
            RoleForFrom.Role = "";
            frmDangNhap.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmTaiKhoanNhanVien frmTaiKhoanNhanVien = new frmTaiKhoanNhanVien();
            frmTaiKhoanNhanVien.MdiParent = this;
            frmTaiKhoanNhanVien.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.MdiParent = this;
            frmThongKe.Show();
        }

        private void tàiKhoảnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();

        }

        private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.MdiParent = this;
            frmSanPham.Show();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmQuanLyKho frmQuanLyKho = new frmQuanLyKho();
            frmQuanLyKho.MdiParent = this;
            frmQuanLyKho.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.MdiParent = this;
            frmSanPham.Show();
        }

        private void tạoMớiHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmTaoHoaDon frmTaoHoaDon = new frmTaoHoaDon();
            frmTaoHoaDon.MdiParent = this;
            frmTaoHoaDon.Show();
        }

        private void tạoMớiKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmBanQuyen frmBanQuyen = new frmBanQuyen();
            frmBanQuyen.MdiParent = this;
            frmBanQuyen.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void LoadGiaoDien(string role)
        {
            if (role.Equals(""))
            {
                //Giao dien chua Dang nhap
                toolStripDangNhap.Enabled = true;
                toolStripDangXuat.Enabled = false;
                toolStripNhanVien.Enabled = false;
                toolStripQuanLy.Enabled = false;
            }
            else
            {
                if (role.Equals("Staff"))
                {
                    //Giao Dien cua Staff
                    toolStripDangNhap.Enabled = false;
                    toolStripDangXuat.Enabled = true;
                    toolStripQuanLy.Enabled = false;
                    toolStripNhanVien.Enabled = true;
                }
                else
                {
                    //Giao Dien cua Manager
                    toolStripDangNhap.Enabled = false;
                    toolStripDangXuat.Enabled = true;
                    toolStripNhanVien.Enabled = false;
                    toolStripQuanLy.Enabled = true;
                }
            }

        }

        private void toolStripTaoMoiHoaDonQuanLy_Click(object sender, EventArgs e)
        {
            CloseAll();
            frmTaoHoaDon frmTaoHoaDon = new frmTaoHoaDon();
            frmTaoHoaDon.MdiParent = this;
            frmTaoHoaDon.Show();
        }
    }
}
