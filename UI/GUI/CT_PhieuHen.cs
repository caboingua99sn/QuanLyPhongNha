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
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using XML;

namespace GUI
{
    public partial class CT_PhieuHen : Form
    {
        int idPhieuKham = 0;
        int idKhachHang = 0;
        frmLichHen frm;
        public CT_PhieuHen()
        {
            InitializeComponent();
            btnGoiPhieuHen.Enabled = false;
        }
        KhachHangWCFClient wcf_kh = new KhachHangWCFClient();
        PhieuKhamWCFClient wcf_phieu = new PhieuKhamWCFClient();

        public CT_PhieuHen(frmLichHen frmLichHen)
        {
            InitializeComponent();
            frm = frmLichHen;
            btnGoiPhieuHen.Enabled = false;
        }

        public CT_PhieuHen(int idPhieu, int idKH)
        {
            InitializeComponent();
            idPhieuKham = idPhieu;
            idKhachHang = idKH;
            btnTaoPhieuHen.Enabled = false;
            btnThemKH.Enabled = false;
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //cập nhật thông tin phiếu khám trong  lịch hẹn

            ePhieuKham pk = new ePhieuKham();
            pk.idPhieuKham = idPhieuKham;
            pk.moTa = txtmota.Text.Trim();
            pk.ngayDKKham = dtpngayhen.Value;
            if (pk.ngayDKKham > DateTime.Now)
            {
                wcf_phieu.UpdatePhieuKham(pk);
            }
            else
            {
                MessageBox.Show("Ngày hẹn khám phải >= ngày hiện tại");
                return;
            }

            //cập nhật thông tin khách hàng trong  lịch hẹn
            eKhachHang k = new eKhachHang();
            k.idKH = idKhachHang;
            k.ngaySinh = dtpns.Value;
            k.tenKH = txttenkh.Text.ToString();
            k.soDienThoai = txtsodt.Text.ToString();
            k.diaChi = txtdiachi.Text.ToString();
            if (radnam.Checked == true)
            {
                k.gioiTinh = true;
            }
            else
                k.gioiTinh = false;
            int tuoi = DateTime.Now.Year - k.ngaySinh.Year;
            if (k.ngaySinh < DateTime.Now)
            {
                if ((tuoi > 1))
                {

                    wcf_kh.UpdateKhachHang(k);

                }
                else
                {
                    MessageBox.Show("Khách hàng phải > 1 tuổi");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Ngày sinh của khách hàng phải < ngày hiện tại");
                return;
            }
        }

        private void CT_PhieuHen_Load(object sender, EventArgs e)
        {
            if (idKhachHang != 0)
            {
                eKhachHang k = wcf_kh.GetKhachHangs_byID(idKhachHang);
                txtidkh.Text = k.idKH.ToString();
                dtpns.Text = k.ngaySinh.ToString();
                txttenkh.Text = k.tenKH;
                txtdiachi.Text = k.diaChi;
                txtsodt.Text = k.soDienThoai;
                if (k.gioiTinh == true) radnam.Checked = true;
                else
                    radnam.Checked = true;
                ePhieuKham p = wcf_phieu.getPhieuKham_byID(idPhieuKham);
                txtmota.Text = p.moTa;
                dtpngayhen.Text = p.ngayDKKham.ToString();
            }
            txtsodt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtsodt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKhachHang frm = new ThemKhachHang();
            frm.ShowDialog();
        }
        private void TruyenData()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQTopic destination = new ActiveMQTopic("PhongKhamNhaKhoa");
            IMessageProducer producer = session.CreateProducer(destination);

            ePhieuKham p = new ePhieuKham();
            p.idPhieuKham = idPhieuKham;
            p.idNV = 1;
            p.ngayDKKham = DateTime.Today;
            p.tinhTrang = 1;
            p.moTa = txtmota.Text.Trim();
            p.idKH = Convert.ToInt32(idKhachHang);

            string xml = new ObjectToXml<ePhieuKham>().object2XML(p);
            IMessage msg = new ActiveMQTextMessage(xml);
            producer.Send(msg);
            session.Close();
            con.Close();
        }
        private void btnGoiPhieuHen_Click(object sender, EventArgs e)
        {
            try
            {
                //ePhieuKham epk = new ePhieuKham();
                int idphieu = idPhieuKham;
                ePhieuKham epk = wcf_phieu.getPhieuKham_byID(idphieu);
                epk.ngayDKKham = DateTime.Now;
               int kq= wcf_phieu.UpdateTinhTrang_PhieuKham(epk,1);
                //int kq=wcf_phieu.AddPhieuKham(epk);
                if (kq == 1)
                {
                    MessageBox.Show("Goi phiếu khám phiếu hẹn thành công");
                    TruyenData();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnTaoPhieuHen_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuKham epk = new ePhieuKham();
                epk.idKH = Convert.ToInt32(txtidkh.Text.Trim());
                epk.idNV = 1;
                epk.moTa = txtmota.Text.Trim();
                epk.ngayDKKham = dtpngayhen.Value;
                epk.tinhTrang = 2; // tinh trang cua phieu hen
                wcf_phieu.AddPhieuKham(epk);
                MessageBox.Show("Thêm phiếu hen thành công");
                //  loaddatagridview_dsphieukham_trongngay(dvwDSBNKham, wcf_phieu.getPhieuKham_theoNgay().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        void XuLyHoTroAutocomlet()
        {
            txtsodt.AutoCompleteCustomSource.Clear();
            foreach (eKhachHang k in wcf_kh.GetKhachHangs())
            {
                txtsodt.AutoCompleteCustomSource.Add(k.soDienThoai);
            }
        }

        private void txtsodt_TextChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
            if (txtsodt.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 ký tự số!");
                Clear();
                txtsodt.Focus();
                return;
            }
            eKhachHang k = wcf_kh.TimKiemKH_theosoDT_equals(txtsodt.Text.Trim());
            if (k != null)
            {
                txtidkh.Text = k.idKH.ToString();
                txtdiachi.Text = k.diaChi;
                txttenkh.Text = k.tenKH;
                dtpns.Text = (k.ngaySinh.ToString());
                if (k.gioiTinh == true) radnam.Checked = true;
                else
                    radnu.Checked = true;
            }
            else
            {
                return;
            }
        }
        
        void Clear()
        {
            txtdiachi.Text = "";
            txtidkh.Text = "";
            txtmota.Text = "";
            txtsodt.Text = "";
            txttenkh.Text = "";
            dtpns.Text = "";
        }

        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            eKhachHang k = wcf_kh.TimKiemKH_theosoDT_equals(txtsodt.Text.Trim());
            if (k != null)
            {
                txtidkh.Text = k.idKH.ToString();
                txtdiachi.Text = k.diaChi;
                txttenkh.Text = k.tenKH;
                dtpns.Text = (k.ngaySinh.ToString());
                if (k.gioiTinh == true) radnam.Checked = true;
                else
                    radnu.Checked = true;
            }
            else
            {
                return;
            }
        }

        private void btnThemKH_Click_1(object sender, EventArgs e)
        {
            ThemKhachHang frm = new ThemKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void CT_PhieuHen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnTaoPhieuHen.Enabled == false && !btnThemKH.Enabled == false)
            {
                frm.LoadFormClosing();
            }
        }

        private void txtsodt_MouseLeave(object sender, EventArgs e)
        {
            txtsodt.Clear();
        }
    }
}
