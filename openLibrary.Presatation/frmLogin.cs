using OpenLibrary.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openLibrary.Presatation
{
    public partial class frmLogin : Form
    {
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtUsername, (txtUsername.Text == "") ? "Please enter username  " : "");
            errorProvider2.SetError(txtMK, (txtMK.Text == "") ? "Please enter Password  " : "");
            return (txtUsername.Text != "" && txtMK.Text != "");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            bool isAutherticated = ctrDangNhap.login(txtUsername.Text, txtMK.Text);
            if (isAutherticated)
            {
                var f = (FrmMain)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }

            else
                MessageBox.Show("Wrong username and password", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
