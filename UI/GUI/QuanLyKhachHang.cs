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

namespace GUI
{
    public partial class frmQuanLyKhachHang : Form
    {
        KhachHangWCFClient khwcf = new KhachHangWCFClient();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang(dvwDSBN, khwcf.GetKhachHangs().ToList());
        }

        private void LoadDSKhachHang(DataGridView dgv, List<eKhachHang> list)
        {
            dgv.DataSource = list;
            dgv.Columns["tenKH"].HeaderText = "Tên khách hàng";
            dgv.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgv.Columns["idKH"].HeaderText = "Mã khách hàng";
            dgv.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dgv.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dgv.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgv.Columns["tenKH"].Width = 150;
            dgv.Columns["idKH"].Width = 180;
            dgv.Columns["ngaySinh"].Width = 150;
            dgv.Columns["soDienThoai"].Width = 170;
            dgv.Columns["diaChi"].Width = 250;
            dgv.Columns["diaChi"].DisplayIndex = 5;
            dgv.Columns["idKH"].DisplayIndex = 0;
            dgv.Columns["ngaySinh"].DisplayIndex = 3;
            dgv.Columns["soDienThoai"].DisplayIndex = 4;
            dgv.Columns["gioiTinh"].DisplayIndex = 2;
            dgv.Columns["tenKH"].DisplayIndex = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            eKhachHang kh = new eKhachHang();
            kh.tenKH = txtTenKH.Text.Trim();
            kh.soDienThoai = txtSodt.Text.Trim();
            kh.ngaySinh = Convert.ToDateTime(dateTimeNgaySinh.Text);
            kh.diaChi = txtDiaChi.Text.Trim();
            if (radNam.Checked)
            {
                kh.gioiTinh = true;
            }
            else
            {
                kh.gioiTinh = false;
            }
            int i = khwcf.AddKhachHang(kh);
            if (i == 1)
            {
                MessageBox.Show("Thêm thành công");
                LoadDSKhachHang(dvwDSBN, khwcf.GetKhachHangs().ToList());
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            int vt = dvwDSBN.CurrentCell.RowIndex;
            eKhachHang kh = new eKhachHang();
            kh.idKH = Convert.ToInt32(dvwDSBN.Rows[vt].Cells["idKH"].Value);
            kh.tenKH = txtTenKH.Text.Trim();
            kh.soDienThoai = txtSodt.Text.Trim();
            kh.ngaySinh = Convert.ToDateTime(dateTimeNgaySinh.Text);
            kh.diaChi = txtDiaChi.Text.Trim();
            if (radNam.Checked)
            {
                kh.gioiTinh = true;
            }
            else
            {
                kh.gioiTinh = false;
            }
            khwcf.UpdateKhachHang(kh);
            LoadDSKhachHang(dvwDSBN, khwcf.GetKhachHangs().ToList());
        }

        private void dvwDSBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dvwDSBN.CurrentCell.RowIndex;
            txtDiaChi.Text = dvwDSBN.Rows[vt].Cells["diaChi"].Value.ToString();
            txtTenKH.Text = dvwDSBN.Rows[vt].Cells["tenKH"].Value.ToString();
            txtSodt.Text = dvwDSBN.Rows[vt].Cells["soDienThoai"].Value.ToString();
            dateTimeNgaySinh.Text = dvwDSBN.Rows[vt].Cells["ngaySinh"].Value.ToString();
            if (bool.Parse(dvwDSBN.Rows[vt].Cells["gioiTinh"].Value.ToString()))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }
    }
}
