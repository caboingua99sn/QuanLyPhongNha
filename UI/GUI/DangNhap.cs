using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.LeTanService;
using GUI.NhaSiService;

namespace GUI
{
    public partial class frmLogin : Form
    {
        LeTanWCFClient leTanClient = new LeTanWCFClient();
        NhaSiWCFClient nhaSiWCFClient = new NhaSiWCFClient();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            eLeTan tempLeTan = leTanClient.getLeTanByUse(txtUseName.Text.Trim(), txtPass.Text.Trim());
            eNhaSi tempNhaSi = nhaSiWCFClient.getNhaSiByUseName(txtUseName.Text.Trim(), txtPass.Text.Trim());
            if (tempNhaSi.useName == null && tempLeTan.useName != null)
            {
                Form frm = new frmHome(2, tempLeTan.idNV);
                frm.ShowDialog();
                return;
            }
            else if (tempLeTan.useName == null && tempNhaSi.useName != null)
            {
                Form frm = new frmHome(3, tempNhaSi.idNhaSi);
                frm.ShowDialog();
                return;
            }
            if (txtPass.Text.Equals("admin") && txtUseName.Text.Equals("admin"))
            {
                Form frm = new frmHome(1, 0);
                frm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Bạn không nhập đúng tài khoản mật khẩu");
                return;
            }
            
        }
    }
}
