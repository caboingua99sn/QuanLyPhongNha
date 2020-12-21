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
    public partial class ThemKhachHang : Form
    {
        int idKH = 0;
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        KhachHangWCFClient khwcf = new KhachHangWCFClient();
        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            eKhachHang k = new eKhachHang();
            if (dtpns.Value < DateTime.Today)
            {
                k.ngaySinh = Convert.ToDateTime(dtpns.Text.ToString());
                k.diaChi = txtDiaChi.Text.Trim();
                if (radNam.Checked == true)
                    k.gioiTinh = true;
                else
                    k.gioiTinh = false;
                k.soDienThoai = txtSodt.Text.Trim();
                k.tenKH = txtTenBN.Text.Trim();
                idKH = khwcf.add_getIDKhachHang_Cuoi(k);
                if (idKH != -1)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.Close();

                }
                else return;
            }
            else
            {
                MessageBox.Show("Chọn ngày sinh < ngày hiện tại!");
                return;
            }           
        }

        private void ThemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idKH != -1)
            {
                frmNhanKham.DiaChi = txtDiaChi.Text.Trim();
                frmNhanKham.NgaySinh = dtpns.Value;
                frmNhanKham.MaKhachHang = idKH.ToString();
                frmNhanKham.HoTen = txtTenBN.Text.Trim();
                frmNhanKham.SoDienThoai = txtSodt.Text.Trim();
                if (radNam.Checked)
                {
                    frmNhanKham.GioiTinh = true;
                }
                else
                {
                    frmNhanKham.GioiTinh = false;
                }
            }
        }
    }
}
