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
    public partial class frmNhanKham : Form
    {
        public static string MaKhachHang = string.Empty;
        public static string HoTen = string.Empty;
        public static string SoDienThoai = string.Empty;
        public static bool GioiTinh = true;
        public static DateTime NgaySinh = DateTime.Now;
        public static string DiaChi = string.Empty;

        public frmNhanKham()
        {
            InitializeComponent();
        }
        KhachHangWCFClient wcf = new KhachHangWCFClient();
        PhieuKhamWCFClient wcf_phieu = new PhieuKhamWCFClient()
;        
        private void button5_Click(object sender, EventArgs e)
        {
            ThemKhachHang frm = new ThemKhachHang();
            frm.ShowDialog();
            loaddatagridview_dskh(dvwDSBN, wcf.GetKhachHangs().ToList());
            txtDiaChi.Text = DiaChi;
            txtSodt.Text = SoDienThoai;
            txtMaKH.Text = MaKhachHang;
            dtpNgayKham.Value = NgaySinh;
            txtTenBN.Text = HoTen;
            if (GioiTinh)
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = false;
            }
        }

        private void frmNhanKham_Load(object sender, EventArgs e)
        {
            loaddatagridview_dskh(dvwDSBN, wcf.GetKhachHangs().ToList());
            loaddatagridview_dsphieukham_trongngay(dvwDSBNKham, wcf_phieu.getPhieuKham_theoNgay().ToList());
            this.dtpNgayKham.Enabled = false;

        }
        void FormatLaiDataGridviewDSBN(DataGridView dgv)
        {
            dgv.Columns["diaChi"].HeaderText = "Địa chỉ";
            //dgv.Columns["idKH"].HeaderText = "Mã khách";
            dgv.Columns["idKH"].Visible = false;
            dgv.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dgv.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dgv.Columns["tenKH"].HeaderText = "Tên";
            dgv.Columns["tenKH"].DisplayIndex = 0;
            dgv.Columns["soDienThoai"].DisplayIndex = 1;
            //dgv.Columns["idKH"].Width = 50;

        }
        void FormatLaiDataGridviewDSKham(DataGridView dgv)
        {
            dgv.Columns["idPhieuKham"].HeaderText = "Mã phiếu khám";
            dgv.Columns["idKH"].HeaderText = "Mã khách";
            dgv.Columns["ngayDKKHam"].HeaderText = "Ngày khám";          
            dgv.Columns["moTa"].HeaderText = "Mô tả";
            dgv.Columns["tinhTrang"].HeaderText = "Tình trạng";
            //set kích thước cột
            dgv.Columns["idKH"].Width = 200;
            dgv.Columns["ngayDKKham"].Width = 200;
            dgv.Columns["moTa"].Width = 300;
            dgv.Columns["tinhTrang"].Width = 200;
            //set thứ tự cột
            dgv.Columns["idPhieuKham"].DisplayIndex = 0;
            dgv.Columns["idKH"].DisplayIndex = 1;
            dgv.Columns["moTa"].DisplayIndex = 2;
            dgv.Columns["ngayDKKham"].DisplayIndex = 3;
            dgv.Columns["tinhTrang"].DisplayIndex = 4;
            //ẩn các cột
            dgv.Columns["idNV"].Visible = false;
        }
        void loaddatagridview_dskh(DataGridView dgv, List<eKhachHang> l)
        {
            dvwDSBN.DataSource = l;
            FormatLaiDataGridviewDSBN(dvwDSBN);
        }
        void loaddatagridview_dsphieukham_trongngay(DataGridView dgv, List<ePhieuKham> l)
        {
            dvwDSBNKham.DataSource = l;
            FormatLaiDataGridviewDSKham(dvwDSBNKham);
        }
        private void txttim_ten_TextChanged(object sender, EventArgs e)
        {
            txttim_sdt.Text = "";
            loaddatagridview_dskh(dvwDSBN,wcf.TimKiemKH_theoTen(txttim_ten.Text.ToString()).ToList());
        }

        private void txttim_cmnd_TextChanged(object sender, EventArgs e)
        {
            txttim_ten.Text = "";
            loaddatagridview_dskh(dvwDSBN, wcf.TimKiemKH_theosoDT(txttim_sdt.Text.ToString()).ToList());
        }

        private void dvwDSBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dvwDSBN.CurrentCell.RowIndex;
            txtMaKH.Text = dvwDSBN.Rows[vt].Cells["idKH"].Value.ToString();
            txtDiaChi.Text = dvwDSBN.Rows[vt].Cells["diaChi"].Value.ToString();
            txtSodt.Text = dvwDSBN.Rows[vt].Cells["soDienThoai"].Value.ToString();
            if (Convert.ToBoolean(dvwDSBN.Rows[vt].Cells["gioiTinh"].Value.ToString()) == true)
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtTenBN.Text = dvwDSBN.Rows[vt].Cells["tenKH"].Value.ToString();
            
            dtpns.Text = dvwDSBN.Rows[vt].Cells["ngaySinh"].Value.ToString();
        }

        private void btnCapNhatBN_Click(object sender, EventArgs e)
        {
            eKhachHang kh = new eKhachHang();
            int vt = dvwDSBN.CurrentCell.RowIndex;
            kh.idKH = Convert.ToInt32(dvwDSBN.Rows[vt].Cells["idKH"].Value.ToString());
            kh.tenKH = txtTenBN.Text.Trim();
            kh.soDienThoai = txtSodt.Text.Trim();
            kh.ngaySinh = Convert.ToDateTime(dtpns.Text.ToString());
            kh.diaChi = txtDiaChi.Text.Trim();
            if (radNam.Checked == true)
                kh.gioiTinh = true;
            else
                kh.gioiTinh = false;
            int kq = wcf.UpdateKhachHang(kh);
            if (kq == 1)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                loaddatagridview_dskh(dvwDSBN, wcf.GetKhachHangs().ToList());
            }
            else return;                    
        }

        private void TruyenData()
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQTopic destination = new ActiveMQTopic("phieuKham");
            IMessageProducer producer = session.CreateProducer(destination);

            ePhieuKham p = new ePhieuKham();
            p.idNV = 1;
            p.ngayDKKham = DateTime.Today;
            p.tinhTrang = 1;
            p.moTa = txtLyDoKham.Text.Trim();
            p.idKH=Convert.ToInt32(txtMaKH.Text.Trim());
            p.idPhieuKham = wcf_phieu.getIdLast();
            string xml = new ObjectToXml<ePhieuKham>().object2XML(p);
            IMessage msg = new ActiveMQTextMessage(xml);
            producer.Send(msg);
            session.Close();
            con.Close();
        }
        private void btnThemKham_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuKham epk = new ePhieuKham();
                epk.idKH = Convert.ToInt32(txtMaKH.Text.Trim());
                epk.idNV = 1;
                epk.moTa = txtLyDoKham.Text.Trim();
                epk.ngayDKKham = DateTime.Today;
                epk.tinhTrang = 1;
                wcf_phieu.AddPhieuKham(epk);
                MessageBox.Show("Thêm phiếu khám thành công");
                TruyenData();
                loaddatagridview_dsphieukham_trongngay(dvwDSBNKham, wcf_phieu.getPhieuKham_theoNgay().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
