using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using GUI.PhieuKhamService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.DonThuocService;
using GUI.KhachHangService;
using XML;
using GUI.NhaSiService;

namespace GUI
{
    public partial class frmKhamBenh : Form
    {
        private KhachHangWCFClient khachHangWCFClient = new KhachHangWCFClient();
        NhaSiWCFClient nhaSiWCFClient = new NhaSiWCFClient();
        public int iddonthuoc;
        int idNV = 0;

        public frmKhamBenh()
        {
            InitializeComponent();     
        }

        public frmKhamBenh(int id)
        {
            InitializeComponent();
            idNV = id;
        }

        private void frmKhamBenh_Load(object sender, EventArgs e)
        {
            txtKB_tenBS.Text = nhaSiWCFClient.getNhabyID(idNV).tenNhaSi;
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQTopic destination = new ActiveMQTopic("phieuKham");
            IMessageConsumer consumer = session.CreateConsumer(destination);
            consumer.Listener += Consumer_Listener;

            ActiveMQTopic kiemTra = new ActiveMQTopic("topicKiemTra");
            IMessageConsumer consumerkt = session.CreateConsumer(kiemTra);
            consumerkt.Listener += Consumerkt_Listener;
        }

        private void Consumerkt_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                foreach (var item in lst_ChoKham.Items)
                {
                    ePhieuKham bn = (ePhieuKham)item;
                    if (bn.idPhieuKham.Equals(msg.Text))
                    {
                        lst_ChoKham.Items.Remove(item);
                    }
                }
            }
        }

        public void AddItem(ListBox box, ePhieuKham item)
        {
            item.truyenMa = khachHangWCFClient.GetKhachHangs_byID(item.idKH).tenKH + "_" + item.idKH;
            MethodInvoker miAddItem = delegate
            {
                box.Items.Add(item);
                box.DisplayMember = "truyenMa";
                box.ValueMember = "idPhieuKham";
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

        private void Consumer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                ePhieuKham bn = new XmlToObject<ePhieuKham>().XML2object(msg.Text);
                AddItem(lst_ChoKham, bn);
            }
        }
        private void lst_ChoKham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lst_ChoKham.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            ePhieuKham bn = new ePhieuKham();
            bn = (ePhieuKham)lst_ChoKham.Items[i];
            eKhachHang kh = khachHangWCFClient.GetKhachHangs_byID(bn.idKH);
            txtKB_maBN.Text = bn.idKH.ToString();
            txtKB_hoten.Text = kh.tenKH;
            txtKB_mota.Text = bn.moTa;
            txtMaPhieu.Text = bn.idPhieuKham.ToString();
            
        }
        private void btn_donthuoc_Click(object sender, EventArgs e)
        {
            frmDonThuoc fr = new frmDonThuoc(Convert.ToInt32(txtMaPhieu.Text.Trim()), idNV);
            fr.ShowDialog();
        }

        private void btn_GoiKham_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lst_ChoKham.SelectedIndex;
                ePhieuKham bn = new ePhieuKham();
                bn = (ePhieuKham)lst_ChoKham.Items[i];
                MessageBox.Show("Đã gọi thành công");
                lst_ChoKham.Items.RemoveAt(lst_ChoKham.SelectedIndex);
                IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
                IConnection con = factory.CreateConnection("admin", "admin");
                con.Start();

                ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
                ActiveMQTopic destination = new ActiveMQTopic("topicKiemTra");
                IMessageProducer producer = session.CreateProducer(destination);
                IMessage msg = new ActiveMQTextMessage(txtMaPhieu.Text.Trim());
                producer.Send(msg);
                session.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
