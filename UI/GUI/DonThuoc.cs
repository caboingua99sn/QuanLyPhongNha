using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DichVuService;
using GUI.ThuocService;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using GUI.DonThuocService;
using XML;
using GUI.ChiTietDonThuocService;

namespace GUI
{
    public partial class frmDonThuoc : Form
    {
        DataTable table = new DataTable();
        private DichVuWCFClient dv;
        private List<eDichVuPhongKham> lstDV;
        private List<eThuoc> lstThuoc;
        public int[] lsint;
        private int str;
        ThuocWCFClient thuocWCFClient = new ThuocWCFClient();
        DonThuocWCFClient donThuocWCFClient = new DonThuocWCFClient();
        ChiTietDonThuocWCFClient chiTietDonThuocWCF = new ChiTietDonThuocWCFClient();
        int idNV = 0;

        public frmDonThuoc()
        {
            InitializeComponent();
            dv = new DichVuWCFClient();
            lstDV = new List<eDichVuPhongKham>();
            lstThuoc = new List<eThuoc>();
            lsint = new int[7];    
        }
        public frmDonThuoc(int id, int maNV) 
        {
            InitializeComponent();
            dv = new DichVuWCFClient();
            lstDV = new List<eDichVuPhongKham>();
            lstThuoc = new List<eThuoc>();
            lsint = new int[7];
            str = id;
            idNV = maNV;
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dgvDsDV.DataSource = dv.GetDichVu().ToList();
            dgvDsThuoc.DataSource = thuocWCFClient.GetThuocs().ToList();
        }
      
        private void TruyenData()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQQueue destination = new ActiveMQQueue("donThuoc");
            IMessageProducer producer = session.CreateProducer(destination);
            eDonThuoc dt = new eDonThuoc();
            dt.idNhaSi = idNV; ;
            dt.ngayLap = DateTime.Today;
            dt.idPhieuKham = str;
            dt.idDonThuoc = donThuocWCFClient.getIdLast();
            dt.tinhTrang = false;
            string xml = new ObjectToXml<eDonThuoc>().object2XML(dt);
            IMessage msg = new ActiveMQTextMessage(xml);
            producer.Send(msg);
            session.Close();
            con.Close();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgvDSChiTiet.Rows.Count - 1; x++)
            {
                if (dgvDSChiTiet.Rows[x].IsNewRow) continue;
                string tmp = dgvDSChiTiet.Rows[x].Cells["Tên"].Value.ToString();
                for (int j = dgvDSChiTiet.Rows.Count - 1; j > x; j--)
                {
                    if (dgvDSChiTiet.Rows[j].IsNewRow) continue;
                    if (tmp == dgvDSChiTiet.Rows[j].Cells["Tên"].Value.ToString())
                    {
                        dgvDSChiTiet.Rows.RemoveAt(j);
                    }
                }
            }
            eDonThuoc donThuoc = new eDonThuoc();
            donThuoc.idPhieuKham = str;
            donThuoc.idNhaSi = 1;
            donThuoc.ngayLap = DateTime.Today;
            donThuoc.tinhTrang = false;
            int i = donThuocWCFClient.AddDonThuoc(donThuoc);
            for (int x = 0; x < dgvDSChiTiet.Rows.Count - 1; x++)
            {
                eChiTietDonThuoc ctdt = new eChiTietDonThuoc();
                ctdt.idDonThuoc = 2;
                if (String.IsNullOrEmpty(dgvDSChiTiet.Rows[x].Cells["IDThuoc"].Value as String))
                {
                    ctdt.idDV = Convert.ToInt32(dgvDSChiTiet.Rows[x].Cells["IDDV"].Value.ToString());
                }
                else
                {
                    ctdt.idThuoc = Convert.ToInt32(dgvDSChiTiet.Rows[x].Cells["IDThuoc"].Value.ToString());
                }
                ctdt.soLuong = Convert.ToInt32(dgvDSChiTiet.Rows[x].Cells["Số lượng"].Value.ToString());
                chiTietDonThuocWCF.AddChiTietDonThuoc(ctdt);

            }
            if (i == 1)
            {
                MessageBox.Show("Đã tạo được đơn thuốc");
                TruyenData();
            }
            else
            {
                MessageBox.Show("Tạo đơn thất bại");
                return;
            }
        }

        private void dgvDsDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                table.Columns.Add("Tên");
                table.Columns.Add("Số lượng");
                table.Columns.Add("Đơn vị");
                table.Columns.Add("Đơn giá");
                table.Columns.Add("IDDV");
                table.Columns.Add("IDThuoc");
            }
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int vt = dgvDsDV.CurrentCell.RowIndex;
                table.Rows.Add(dgvDsDV.Rows[vt].Cells["tenDV"].Value.ToString(), 1, "Gói", dgvDsDV.Rows[vt].Cells["donGia"].Value.ToString(), dgvDsDV.Rows[vt].Cells["idDV"].Value.ToString(), null);
            }
            dgvDSChiTiet.DataSource = table;
            dgvDSChiTiet.Columns["IDDV"].Visible = false;
            dgvDSChiTiet.Columns["IDThuoc"].Visible = false;
        }

        private void dgvDsThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows.Count == 0)
            {
                table.Columns.Add("Tên");
                table.Columns.Add("Số lượng");
                table.Columns.Add("Đơn vị");
                table.Columns.Add("Đơn giá");
                table.Columns.Add("IDDV");
                table.Columns.Add("IDThuoc");
            }
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int vt = dgvDsThuoc.CurrentCell.RowIndex;
                table.Rows.Add(dgvDsThuoc.Rows[vt].Cells["tenThuoc"].Value.ToString(), null, dgvDsThuoc.Rows[vt].Cells["donVi"].Value.ToString(), dgvDsThuoc.Rows[vt].Cells["donGia"].Value.ToString(), null, dgvDsThuoc.Rows[vt].Cells["idThuoc"].Value.ToString());
            }
            dgvDSChiTiet.DataSource = table;
            dgvDSChiTiet.Columns["IDDV"].Visible = false;
            dgvDSChiTiet.Columns["IDThuoc"].Visible = false;
        }

        private void dgvDSChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int vt = dgvDSChiTiet.CurrentCell.RowIndex;
                dgvDSChiTiet.Rows.RemoveAt(vt);
            }
        }
    }
}
