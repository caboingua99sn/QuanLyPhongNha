using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.KhachHangService;
using GUI.PhieuKhamService;

namespace GUI
{
    public partial class frmTimKiemKhachHang : Form
    {
        private KhachHangWCFClient client;
        public PhieuKhamWCFClient clientPK;
        
        private BindingSource biding;
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
            clientPK = new PhieuKhamWCFClient();
            client = new KhachHangWCFClient();
            biding = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            biding.DataSource = client.GetKhachHangs().ToList();
            dgv_dsbenhnhan.DataSource = biding;
        }

        private void dgv_dsbenhnhan_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgv_dsbenhnhan.SelectedRows.Count > 0)
            {
                txtKB_maBN.DataBindings.Clear();
                txtKB_maBN.DataBindings.Add("Text", biding, "idKH");
                dgv_dsbenhan.DataSource = clientPK.getPhieuKham_theoNgay().Where(x =>x.idKH == Convert.ToInt32(txtKB_maBN.Text)).ToList();
                dgv_dsbenhan.Update();
                dgv_dsbenhan.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Theo ngày"))
            {
                List<eKhachHang> lst = new List<eKhachHang>();
                foreach (var item in clientPK.getPhieuKham_theoNgay())
                {
                    int result = DateTime.Compare(item.ngayDKKham, Convert.ToDateTime(dtp_tungay.Text));
                    int result1 = DateTime.Compare(item.ngayDKKham, Convert.ToDateTime(dtpKB_ngayketthuc.Text));
                    if (result >= 0 && result1 <= 0)
                    {
                        lst.Add(client.GetKhachHangs().Where(x => x.idKH == item.idKH).FirstOrDefault());
                    }
                }
                dgv_dsbenhnhan.DataSource = lst;
                dgv_dsbenhnhan.Update();
                dgv_dsbenhnhan.Refresh();
            }
            else
            {
                List<eKhachHang> lst = new List<eKhachHang>();
                foreach (var item in clientPK.getPhieuKham_theoNgay())
                {
                    lst.Add(client.GetKhachHangs().Where(x => x.tenKH.Contains(txtTenBN.Text)).FirstOrDefault());
                }
            }
            
        }
    }
}
