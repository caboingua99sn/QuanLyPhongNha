using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.LeTanService;
using GUI.NhaSiService;

namespace GUI
{
    public partial class frmQuanlyNhanVien : Form
    {
        NhaSiWCFClient nhaSiWCFClient = new NhaSiWCFClient();
        LeTanWCFClient leTanWCFClient = new LeTanWCFClient();
        public frmQuanlyNhanVien()
        {
            InitializeComponent();
        }

        void LoadDSNhaSi(DataGridView dgv, List<eNhaSi> nhaSis)
        {

            dgv.DataSource = nhaSis;
            dgv.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgv.Columns["idNhaSi"].HeaderText = "Mã nhân viên";
            dgv.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dgv.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dgv.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgv.Columns["soCMND"].HeaderText = "Số CMND";
            dgv.Columns["useName"].HeaderText = "Usename";
            dgv.Columns["passWord"].HeaderText = "Password";
            dgv.Columns["tenNhaSi"].HeaderText = "Họ tên";
            dgv.Columns["idNhaSi"].Width = 130;
            dgv.Columns["ngaySinh"].Width = 150;
            dgv.Columns["soDienThoai"].Width = 170;
            dgv.Columns["soCMND"].Width = 150;
            dgv.Columns["diaChi"].Width = 210;
            dgv.Columns["useName"].Width = 150;
            dgv.Columns["tenNhaSi"].Width = 160;
            dgv.Columns["diaChi"].DisplayIndex = 6;
            dgv.Columns["idNhaSi"].DisplayIndex = 0;
            dgv.Columns["ngaySinh"].DisplayIndex = 2;
            dgv.Columns["soDienThoai"].DisplayIndex = 5;
            dgv.Columns["gioiTinh"].DisplayIndex = 3;
            dgv.Columns["soCMND"].DisplayIndex = 4;
            dgv.Columns["useName"].DisplayIndex = 7;
            dgv.Columns["passWord"].DisplayIndex = 8;
            dgv.Columns["tenNhaSi"].DisplayIndex = 1;
        }

        void LoadDSLeTan(DataGridView dgv, List<eLeTan> leTans)
        {

            dgv.DataSource = leTans;
            dgv.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgv.Columns["idNV"].HeaderText = "Mã nhân viên";
            dgv.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dgv.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dgv.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgv.Columns["soCMND"].HeaderText = "Số CMND";
            dgv.Columns["useName"].HeaderText = "Usename";
            dgv.Columns["passWord"].HeaderText = "Password";
            dgv.Columns["tenNV"].HeaderText = "Họ tên";
            dgv.Columns["idNV"].Width = 130;
            dgv.Columns["ngaySinh"].Width = 150;
            dgv.Columns["soDienThoai"].Width = 170;
            dgv.Columns["soCMND"].Width = 150;
            dgv.Columns["diaChi"].Width = 210;
            dgv.Columns["useName"].Width = 150;
            dgv.Columns["tenNV"].Width = 160;
            dgv.Columns["diaChi"].DisplayIndex = 6;
            dgv.Columns["idNV"].DisplayIndex = 0;
            dgv.Columns["ngaySinh"].DisplayIndex = 2;
            dgv.Columns["soDienThoai"].DisplayIndex = 5;
            dgv.Columns["gioiTinh"].DisplayIndex = 3;
            dgv.Columns["soCMND"].DisplayIndex = 4;
            dgv.Columns["useName"].DisplayIndex = 7;
            dgv.Columns["passWord"].DisplayIndex = 8;
            dgv.Columns["tenNV"].DisplayIndex = 1;
        }

        private void frmQuanlyNhasy_Load(object sender, EventArgs e)
        {
            LoadDSNhaSi(dvwDSNV,nhaSiWCFClient.getAllNhaSi().ToList());
            radLeTan.Checked = true;
            cboLuaChon.SelectedIndex = 0;
        }

        private void btnThemNS_Click(object sender, EventArgs e)
        {      
            int i = 0;
            if (radLeTan.Checked)
            {
                eLeTan leTan = new eLeTan();
                leTan.tenNV = txtTenNV.Text.Trim();
                leTan.ngaySinh = DateTime.Parse(dateTimeNS.Text);
                leTan.soCMND = txtSocmnd.Text.Trim();
                leTan.soDienThoai = txtSodt.Text.Trim();
                leTan.diaChi = txtDiaChi.Text.Trim();
                if (radNam.Checked)
                {
                    leTan.gioiTinh = true;
                }
                if (radNu.Checked)
                {
                    leTan.gioiTinh = false;
                }
                leTan.passWord = txtPass.Text.Trim();
                leTan.useName = txtUse.Text.Trim();
                i = leTanWCFClient.AddLeTan(leTan);
            }
            if (radNhaSi.Checked)
            {
                eNhaSi nhaSi = new eNhaSi();
                nhaSi.tenNhaSi = txtTenNV.Text.Trim();
                nhaSi.ngaySinh = DateTime.Parse(dateTimeNS.Text);
                nhaSi.soCMND = txtSocmnd.Text.Trim();
                nhaSi.soDienThoai = txtSodt.Text.Trim();
                nhaSi.diaChi = txtDiaChi.Text.Trim();
                if (radNam.Checked)
                {
                    nhaSi.gioiTinh = true;
                }
                if (radNu.Checked)
                {
                    nhaSi.gioiTinh = false;
                }
                nhaSi.passWord = txtPass.Text.Trim();
                nhaSi.useName = txtUse.Text.Trim();
                i = nhaSiWCFClient.AddNhaSi(nhaSi);
            }          
            if (i == 1)
            {
                MessageBox.Show("Thêm thành công");
                if (cboLuaChon.SelectedIndex == 0)
                {
                    LoadDSLeTan(dvwDSNV, leTanWCFClient.getAllLeTan().ToList());
                }
                else
                {
                    LoadDSNhaSi(dvwDSNV, nhaSiWCFClient.getAllNhaSi().ToList());
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
        }

        private void btnCapNhatNS_Click(object sender, EventArgs e)
        {
            int vt = dvwDSNV.CurrentCell.RowIndex;
            if (cboLuaChon.SelectedIndex == 0)
            {
                eLeTan leTan = new eLeTan();
                leTan.idNV = Convert.ToInt32(dvwDSNV.Rows[vt].Cells["idNhaSi"].Value);
                leTan.ngaySinh = dateTimeNS.Value;
                leTan.passWord = txtPass.Text.Trim();
                leTan.soCMND = txtSocmnd.Text.Trim();
                leTan.soDienThoai = txtSodt.Text.Trim();
                leTan.tenNV = txtTenNV.Text.Trim();
                leTan.useName = txtUse.Text.Trim();
                leTan.diaChi = txtDiaChi.Text.Trim();
                if (radNam.Checked)
                {
                    leTan.gioiTinh = true;
                }
                else
                {
                    leTan.gioiTinh = false;
                }
                leTanWCFClient.UpdateLeTan(leTan);
                LoadDSLeTan(dvwDSNV, leTanWCFClient.getAllLeTan().ToList());
            }
            else
            {
                eNhaSi nhaSi = new eNhaSi();
                nhaSi.idNhaSi = Convert.ToInt32(dvwDSNV.Rows[vt].Cells["idNhaSi"].Value);
                nhaSi.tenNhaSi = txtTenNV.Text.Trim();
                nhaSi.ngaySinh = dateTimeNS.Value;
                nhaSi.passWord = txtPass.Text.Trim();
                nhaSi.soCMND = txtSocmnd.Text.Trim();
                nhaSi.soDienThoai = txtSodt.Text.Trim();
                nhaSi.useName = txtUse.Text.Trim();
                nhaSi.diaChi = txtDiaChi.Text.Trim();
                if (radNam.Checked)
                {
                    nhaSi.gioiTinh = true;
                }
                else
                {
                    nhaSi.gioiTinh = false;
                }
                nhaSiWCFClient.UpdateNhaSi(nhaSi);
                LoadDSNhaSi(dvwDSNV, nhaSiWCFClient.getAllNhaSi().ToList());
            }                       
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedIndex == 0)
            {
                LoadDSLeTan(dvwDSNV, leTanWCFClient.getAllLeTan().ToList());
            }
            else
            {
                LoadDSNhaSi(dvwDSNV, nhaSiWCFClient.getAllNhaSi().ToList());
            }
        }

        private void dvwDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dvwDSNV.CurrentCell.RowIndex;
            if (cboLuaChon.SelectedIndex == 0)
            {
                txtTenNV.Text = dvwDSNV.Rows[vt].Cells["tenNV"].Value.ToString();
            }
            else
            {
                txtTenNV.Text = dvwDSNV.Rows[vt].Cells["tenNhaSi"].Value.ToString();
            }
            txtDiaChi.Text = dvwDSNV.Rows[vt].Cells["diaChi"].Value.ToString();
            txtPass.Text = dvwDSNV.Rows[vt].Cells["passWord"].Value.ToString();
            txtSocmnd.Text = dvwDSNV.Rows[vt].Cells["soCMND"].Value.ToString();
            txtSodt.Text = dvwDSNV.Rows[vt].Cells["soDienThoai"].Value.ToString();
            txtUse.Text = dvwDSNV.Rows[vt].Cells["useName"].Value.ToString();
            dateTimeNS.Text = dvwDSNV.Rows[vt].Cells["ngaySinh"].Value.ToString();
            if (bool.Parse(dvwDSNV.Rows[vt].Cells["gioiTinh"].Value.ToString()))
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int vt = dvwDSNV.CurrentCell.RowIndex;
            if (cboLuaChon.SelectedIndex == 0)
            {
                int a = leTanWCFClient.RemoveLeTan(Convert.ToInt32(dvwDSNV.Rows[vt].Cells["idNV"].Value));
                if (a == 1)
                {
                    MessageBox.Show("Xoá thành công");
                    LoadDSLeTan(dvwDSNV, leTanWCFClient.getAllLeTan().ToList());
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                int a = nhaSiWCFClient.RemoveNhaSi(Convert.ToInt32(dvwDSNV.Rows[vt].Cells["idNhaSi"].Value));
                if (a == 1)
                {
                    MessageBox.Show("Xoá thành công");
                    LoadDSNhaSi(dvwDSNV, nhaSiWCFClient.getAllNhaSi().ToList());
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
        }
    }
}
