namespace GUI
{
    partial class frmNhanKham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanKham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvwDSBN = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.txttim_sdt = new System.Windows.Forms.TextBox();
            this.txttim_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLyDoKham = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dvwDSBNKham = new System.Windows.Forms.DataGridView();
            this.btnThemKham = new System.Windows.Forms.Button();
            this.btnCapNhatBN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSBN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSBNKham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvwDSBN);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txttim_sdt);
            this.groupBox1.Controls.Add(this.txttim_ten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(457, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm bệnh nhân";
            // 
            // dvwDSBN
            // 
            this.dvwDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwDSBN.Location = new System.Drawing.Point(8, 88);
            this.dvwDSBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvwDSBN.Name = "dvwDSBN";
            this.dvwDSBN.ReadOnly = true;
            this.dvwDSBN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvwDSBN.Size = new System.Drawing.Size(441, 171);
            this.dvwDSBN.TabIndex = 3;
            this.dvwDSBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvwDSBN_CellClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(280, 22);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 43);
            this.button5.TabIndex = 2;
            this.button5.Text = "Thêm khách hàng";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txttim_sdt
            // 
            this.txttim_sdt.Location = new System.Drawing.Point(107, 50);
            this.txttim_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttim_sdt.Name = "txttim_sdt";
            this.txttim_sdt.Size = new System.Drawing.Size(163, 30);
            this.txttim_sdt.TabIndex = 1;
            this.txttim_sdt.TextChanged += new System.EventHandler(this.txttim_cmnd_TextChanged);
            // 
            // txttim_ten
            // 
            this.txttim_ten.Location = new System.Drawing.Point(108, 18);
            this.txttim_ten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttim_ten.Name = "txttim_ten";
            this.txttim_ten.Size = new System.Drawing.Size(164, 30);
            this.txttim_ten.TabIndex = 1;
            this.txttim_ten.TextChanged += new System.EventHandler(this.txttim_ten_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radNu);
            this.groupBox2.Controls.Add(this.radNam);
            this.groupBox2.Controls.Add(this.dtpns);
            this.groupBox2.Controls.Add(this.txtSodt);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.txtTenBN);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(467, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(614, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bệnh nhân";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(241, 119);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(57, 27);
            this.radNu.TabIndex = 8;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(165, 119);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(70, 27);
            this.radNam.TabIndex = 7;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtpns
            // 
            this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpns.Location = new System.Drawing.Point(476, 115);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(119, 30);
            this.dtpns.TabIndex = 3;
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(165, 84);
            this.txtSodt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(430, 30);
            this.txtSodt.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(165, 153);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(430, 30);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(165, 21);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(430, 30);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(165, 51);
            this.txtTenBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(430, 30);
            this.txtTenBN.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ và tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayKham);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtLyDoKham);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(467, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(614, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khám";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.Location = new System.Drawing.Point(177, 81);
            this.dtpNgayKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(136, 30);
            this.dtpNgayKham.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày khám:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lý do khám:";
            // 
            // txtLyDoKham
            // 
            this.txtLyDoKham.Location = new System.Drawing.Point(177, 18);
            this.txtLyDoKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDoKham.Multiline = true;
            this.txtLyDoKham.Name = "txtLyDoKham";
            this.txtLyDoKham.Size = new System.Drawing.Size(418, 60);
            this.txtLyDoKham.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.dvwDSBNKham);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(2, 326);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1087, 225);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách bệnh nhân khám trong ngày";
            // 
            // dvwDSBNKham
            // 
            this.dvwDSBNKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwDSBNKham.Location = new System.Drawing.Point(8, 29);
            this.dvwDSBNKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvwDSBNKham.Name = "dvwDSBNKham";
            this.dvwDSBNKham.ReadOnly = true;
            this.dvwDSBNKham.Size = new System.Drawing.Size(1087, 186);
            this.dvwDSBNKham.TabIndex = 0;
            // 
            // btnThemKham
            // 
            this.btnThemKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKham.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKham.ForeColor = System.Drawing.Color.Red;
            this.btnThemKham.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKham.Image")));
            this.btnThemKham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKham.Location = new System.Drawing.Point(10, 273);
            this.btnThemKham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKham.Name = "btnThemKham";
            this.btnThemKham.Size = new System.Drawing.Size(218, 35);
            this.btnThemKham.TabIndex = 4;
            this.btnThemKham.Text = "Thêm khám";
            this.btnThemKham.UseVisualStyleBackColor = false;
            this.btnThemKham.Click += new System.EventHandler(this.btnThemKham_Click);
            // 
            // btnCapNhatBN
            // 
            this.btnCapNhatBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhatBN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCapNhatBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatBN.ForeColor = System.Drawing.Color.Red;
            this.btnCapNhatBN.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatBN.Image")));
            this.btnCapNhatBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatBN.Location = new System.Drawing.Point(236, 273);
            this.btnCapNhatBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhatBN.Name = "btnCapNhatBN";
            this.btnCapNhatBN.Size = new System.Drawing.Size(215, 35);
            this.btnCapNhatBN.TabIndex = 4;
            this.btnCapNhatBN.Text = "Cập nhật bệnh nhân";
            this.btnCapNhatBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatBN.UseVisualStyleBackColor = false;
            this.btnCapNhatBN.Click += new System.EventHandler(this.btnCapNhatBN_Click);
            // 
            // frmNhanKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 546);
            this.Controls.Add(this.btnCapNhatBN);
            this.Controls.Add(this.btnThemKham);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmNhanKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận khám";
            this.Load += new System.EventHandler(this.frmNhanKham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSBN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSBNKham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvwDSBN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txttim_sdt;
        private System.Windows.Forms.TextBox txttim_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThemKham;
        private System.Windows.Forms.Button btnCapNhatBN;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLyDoKham;
        private System.Windows.Forms.DataGridView dvwDSBNKham;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
    }
}

