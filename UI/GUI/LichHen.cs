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
    public partial class frmLichHen : Form
    {

        public frmLichHen()
        {
            InitializeComponent();
        }

        KhachHangWCFClient wcf_kh = new KhachHangWCFClient();
        PhieuKhamWCFClient wcf_phieu = new PhieuKhamWCFClient();
        void loaddatagridview_dsphieuhen(DataGridView dgv, List<ePhieuKham> l)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã phiếu");
            table.Columns.Add("idKH");
            table.Columns.Add("Tên khách hàng");
            table.Columns.Add("Số điện thoại");
            table.Columns.Add("Giới tính");
            table.Columns.Add("Ngày sinh");
            table.Columns.Add("Ngày khám");
            table.Columns.Add("Tình trạng");
            table.Columns.Add("Mô tả");
            foreach (var item in l)
            {
                string a = "";
                eKhachHang kh = wcf_kh.GetKhachHangs_byID(item.idKH);
                if (item.tinhTrang == 2)
                {
                    a = "Hẹn khám";
                }
                table.Rows.Add(item.idPhieuKham, kh.idKH, kh.tenKH, kh.soDienThoai, kh.gioiTinh, kh.ngaySinh, item.ngayDKKham, a, item.moTa);
            }
            dgv.DataSource = table;
            dgv.Columns["idKH"].Visible = false;
        }

        public void LoadFormClosing()
        {
            loaddatagridview_dsphieuhen(dvwDSCuocHen, wcf_phieu.getPhieuhen_TimKiem(Convert.ToDateTime(dtpNgayFrom.Text.ToString()), Convert.ToDateTime(dtpNgayTo.Text.ToString())).ToList());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtpNgayFrom.Text.ToString()) < Convert.ToDateTime(dtpNgayTo.Text.ToString()))
            {
                loaddatagridview_dsphieuhen(dvwDSCuocHen, wcf_phieu.getPhieuhen_TimKiem(Convert.ToDateTime(dtpNgayFrom.Text.ToString()), Convert.ToDateTime(dtpNgayTo.Text.ToString())).ToList());
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu lọc phải < ngày kết thúc lọc");
                return;
            }

        }

        private void btnThemLichHen_Click(object sender, EventArgs e)
        {
            try
            {
                CT_PhieuHen frm = new CT_PhieuHen(this);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loaddatagridview_dsphieuhen(dvwDSCuocHen, wcf_phieu.getPhieuhen_TrongNgay().ToList());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }



        private void frmLichHen_Load(object sender, EventArgs e)
        {
            loaddatagridview_dsphieuhen(dvwDSCuocHen, wcf_phieu.getPhieuhen_TrongNgay().ToList());
        }

        private void dvwDSCuocHen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dvwDSCuocHen.CurrentCell.RowIndex;
            int maphieu = Convert.ToInt32(dvwDSCuocHen.Rows[vt].Cells["Mã phiếu"].Value.ToString());
            int makh = Convert.ToInt32(dvwDSCuocHen.Rows[vt].Cells["idKH"].Value.ToString());
            CT_PhieuHen frm = new CT_PhieuHen(maphieu, makh);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loaddatagridview_dsphieuhen(dvwDSCuocHen, wcf_phieu.getPhieuhen_TrongNgay().ToList());

            }
        }
    }
}
