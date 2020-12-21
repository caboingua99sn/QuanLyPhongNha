using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using GUI.ChiTietDonThuocService;
using GUI.DichVuService;
using GUI.DonThuocService;
using GUI.KhachHangService;
using GUI.NhaSiService;
using GUI.PhieuKhamService;
using GUI.ThuocService;
using XML;

namespace GUI
{
    public partial class frmHome : Form
    {
        KhachHangWCFClient khachHangWCFClient = new KhachHangWCFClient();
        PhieuKhamWCFClient phieuKhamWCFClient = new PhieuKhamWCFClient();
        NhaSiWCFClient nhaSiWCFClient = new NhaSiWCFClient();
        ChiTietDonThuocWCFClient chiTietDonThuocWCF = new ChiTietDonThuocWCFClient();
        ThuocWCFClient thuocWCFClient = new ThuocWCFClient();
        DichVuWCFClient dichVuWCFClient = new DichVuWCFClient();
        DonThuocWCFClient donthuocwcf = new DonThuocWCFClient();
        int maNV = 0;
        public frmHome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1. Adim
        /// 2. Lễ tân
        /// 3. Nha sĩ
        /// </summary>
        public frmHome(int id, int idNV)
        {
            InitializeComponent();
            if (id == 1)
            {
                mnuNghiepVu.Visible = false;
                mnuThanhToan.Visible = false;
                panel1.Visible = false;
            }
            else if (id == 2)
            {
                mnuNghiepVu_Kham.Visible = false;
                mnuQuanLy.Visible = false;
            }
            else
            {
                mnuNghiepVu_TiepNhan.Visible = false;
                mnuQuanLy.Visible = false;
            }
            maNV = idNV;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination = new ActiveMQQueue("donThuoc");
            IMessageConsumer consumer = session.CreateConsumer(destination);
            consumer.Listener += Consumer_Listener;
        }

        private void Consumer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                eDonThuoc dt = new XmlToObject<eDonThuoc>().XML2object(msg.Text);
                AddItem(lstDsDonThuoc, dt);
            }
        }

        public void AddItem(ListBox box, eDonThuoc item)
        {
            MethodInvoker miAddItem = delegate
            {
                item.mom = khachHangWCFClient.GetKhachHangs_byID(phieuKhamWCFClient.getPhieuKham_byID(item.idPhieuKham).idKH).tenKH;
                box.Items.Add(item);
                box.DisplayMember = "mom";
                box.ValueMember = "idDonThuoc";
            };

            if (box.InvokeRequired)
            {
                box.Invoke(miAddItem);
            }
            else
            {
                miAddItem();
            }
        }

        private void mnuNghiepVu_Kham_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhamBenh();
            frm.ShowDialog();
        }

        private void mnuNghiepVu_TiepNhan_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanKham();
            frm.ShowDialog();
        }

        private void mnuNghiepVu_Hen_Click(object sender, EventArgs e)
        {
            Form frm = new frmLichHen();
            frm.ShowDialog();
        }

        private void mnuQuanLy_NhanVien_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanlyNhanVien();
            frm.ShowDialog();
        }

        private void mnuQuanLy_DichVuPhamKham_Click(object sender, EventArgs e)
        {
            Form frm = new frmDonThuoc();
            frm.ShowDialog();
        }

        private void mnuQuanLy_Thuoc_Click(object sender, EventArgs e)
        {
            Form frm = new frmDonThuoc();
            frm.ShowDialog();
        }

        private void mnuQuanLy_KhachHang_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuanLyKhachHang();
            frm.ShowDialog();
        }

        private void lstDsDonThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstDsDonThuoc.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            eDonThuoc dt = new eDonThuoc();
            dt = (eDonThuoc)lstDsDonThuoc.Items[i];
            lblMaDon.Text = dt.idDonThuoc.ToString();
            lblKH.Text = khachHangWCFClient.GetKhachHangs_byID(phieuKhamWCFClient.getPhieuKham_byID(dt.idPhieuKham).idKH).tenKH;
            lblNhaSi.Text = nhaSiWCFClient.getNhabyID(dt.idNhaSi).tenNhaSi;
            lblNgayLap.Text = dt.ngayLap.ToShortDateString();

            DataTable tableThuoc = new DataTable();
            tableThuoc.Columns.Add("Tên thuốc");
            tableThuoc.Columns.Add("Số lượng");
            tableThuoc.Columns.Add("Đơn vị");
            tableThuoc.Columns.Add("Đơn giá");

            DataTable tableDichVu = new DataTable();
            tableDichVu.Columns.Add("Tên dịch vụ");
            tableDichVu.Columns.Add("Số lượng");
            tableDichVu.Columns.Add("Đơn giá");

            foreach (var item in chiTietDonThuocWCF.getChiTietDonThuocbyID(dt.idDonThuoc))
            {
                eThuoc thuoc = thuocWCFClient.getThuocbyID(item.idThuoc);
                eDichVuPhongKham dv = dichVuWCFClient.getDVbyID(item.idDV);
                if (thuoc != null)
                {
                    tableThuoc.Rows.Add(thuoc.tenThuoc, item.soLuong, thuoc.donVi, thuoc.donGia);
                }
                tableDichVu.Rows.Add(dv.tenDV, item.soLuong, dv.donGia);
            }
            dgvDonThuoc.DataSource = tableThuoc;
            dgvDichVu.DataSource = tableDichVu;
            long tienThuoc = 0;
            long tienDichVu = 0;
            for (int x = 0; x < tableThuoc.Rows.Count; x++)
            {
                tienThuoc += (int)tableThuoc.Rows[x]["Số lượng"] * (int)tableThuoc.Rows[x]["Đơn giá"];
            }
            for (int y = 0; y < tableDichVu.Rows.Count; y++)
            {
                tienDichVu += Convert.ToInt32(tableDichVu.Rows[y]["Số lượng"]) * Convert.ToInt32(tableDichVu.Rows[y]["Đơn giá"]);
            }
            lblTien.Text = (tienDichVu + tienThuoc).ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            eDonThuoc dt = new eDonThuoc();
            dt.idDonThuoc = Convert.ToInt32(lblMaDon.Text.Trim());
            dt.tinhTrang = true;
            int i = donthuocwcf.UpdateDonThuoc(dt);
            if (i == 1)
            {
                MessageBox.Show("Đã thanh toán thành công");
            }
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
