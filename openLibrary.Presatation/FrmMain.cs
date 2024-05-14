using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.Bussiness;

namespace openLibrary.Presatation
{
    public partial class FrmMain : Form
    {
        
        CtrMain ctrMain = new CtrMain();
        public FrmMain()
        {
            InitializeComponent();
        }
        public void xuLyLogin()
        {
            this.Text = (LoginInfo.HoTenNV != "") ? "OpenLibrary" : "Open Library – Xin Chao " + LoginInfo.HoTenNV;
            btnDangNhap.Caption = LoginInfo.MaNV == -1 ? "DangNhap" : "DangXuat";
            btnDangNhap.ImageOptions.LargeImage = (LoginInfo.MaNV != -1) ? Properties.Resources.cancel_32x32 : Properties.Resources.prev_32x32;
            barButtonItem2.Enabled = LoginInfo.MaNV == 1;
            barButtonItem3.Enabled = LoginInfo.MaNV == 1;
            rbQLTaiNguyen.Visible = LoginInfo.MaLoaiNV == 1;
            rbQLMuonTraSach.Visible = LoginInfo.MaLoaiNV == 1;
            rbPhanQuyen.Visible = LoginInfo.MaLoaiNV == 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            xuLyLogin();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQLChuyenNganh f = (FrmQLChuyenNganh)this.MdiChildren.FirstOrDefault(k =>  k  is FrmQLChuyenNganh);
            if (f == null)
            {
                f = new FrmQLChuyenNganh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhanBoSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LoginInfo.MaNV == -1)
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                ctrMain.logout();
                xuLyLogin();
            }
        }
        
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}
