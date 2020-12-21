using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMainLeTan : Form
    {
        public frmMainLeTan()
        {
            InitializeComponent();
        }

        private void lậpPhiếuKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanKham frm = new frmNhanKham();
            frm.ShowDialog();
        }

        private void quảnLíLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen frm = new frmLichHen();
            frm.ShowDialog();
        }

        private void quảnLíBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLBenhNhan frm = new frmQLBenhNhan();
            frm.ShowDialog();
        }
    }
}
