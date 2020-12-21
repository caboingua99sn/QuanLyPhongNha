namespace GUI
{
    partial class CT_PhieuHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CT_PhieuHen));
            this.btnGoiPhieuHen = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.dtpngayhen = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidkh = new System.Windows.Forms.TextBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaoPhieuHen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsodt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoiPhieuHen
            // 
            this.btnGoiPhieuHen.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiPhieuHen.Image")));
            this.btnGoiPhieuHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoiPhieuHen.Location = new System.Drawing.Point(387, 498);
            this.btnGoiPhieuHen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGoiPhieuHen.Name = "btnGoiPhieuHen";
            this.btnGoiPhieuHen.Size = new System.Drawing.Size(152, 58);
            this.btnGoiPhieuHen.TabIndex = 0;
            this.btnGoiPhieuHen.Text = "Gọi Phiếu";
            this.btnGoiPhieuHen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoiPhieuHen.UseVisualStyleBackColor = true;
            this.btnGoiPhieuHen.Click += new System.EventHandler(this.btnGoiPhieuHen_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(227, 497);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(152, 58);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(557, 498);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 58);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết Phiếu Hẹn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày hẹn khám:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lý do khám:";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(249, 74);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(264, 22);
            this.txtmota.TabIndex = 3;
            // 
            // dtpngayhen
            // 
            this.dtpngayhen.CustomFormat = "dd/MM/yyyy";
            this.dtpngayhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngayhen.Location = new System.Drawing.Point(249, 27);
            this.dtpngayhen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpngayhen.Name = "dtpngayhen";
            this.dtpngayhen.Size = new System.Drawing.Size(132, 22);
            this.dtpngayhen.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidkh);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtpns);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Location = new System.Drawing.Point(24, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã khách hàng:";
            // 
            // txtidkh
            // 
            this.txtidkh.Location = new System.Drawing.Point(255, 23);
            this.txtidkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidkh.Name = "txtidkh";
            this.txtidkh.ReadOnly = true;
            this.txtidkh.Size = new System.Drawing.Size(253, 22);
            this.txtidkh.TabIndex = 18;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(533, 25);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(100, 38);
            this.btnThemKH.TabIndex = 17;
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radnu);
            this.groupBox3.Controls.Add(this.radnam);
            this.groupBox3.Location = new System.Drawing.Point(525, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(145, 52);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giới tính:";
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(8, 23);
            this.radnu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(47, 21);
            this.radnu.TabIndex = 5;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nữ";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(68, 23);
            this.radnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(58, 21);
            this.radnam.TabIndex = 5;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // dtpns
            // 
            this.dtpns.CustomFormat = "dd/MM/yyyy";
            this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpns.Location = new System.Drawing.Point(255, 153);
            this.dtpns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(132, 22);
            this.dtpns.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên khách hàng:";
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(255, 60);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(253, 22);
            this.txttenkh.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(255, 121);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(253, 22);
            this.txtdiachi.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpngayhen);
            this.groupBox2.Controls.Add(this.txtmota);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(24, 350);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(705, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khám:";
            // 
            // btnTaoPhieuHen
            // 
            this.btnTaoPhieuHen.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuHen.Image")));
            this.btnTaoPhieuHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuHen.Location = new System.Drawing.Point(41, 498);
            this.btnTaoPhieuHen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTaoPhieuHen.Name = "btnTaoPhieuHen";
            this.btnTaoPhieuHen.Size = new System.Drawing.Size(160, 57);
            this.btnTaoPhieuHen.TabIndex = 8;
            this.btnTaoPhieuHen.Tag = "";
            this.btnTaoPhieuHen.Text = "Tạo phiếu hẹn";
            this.btnTaoPhieuHen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPhieuHen.UseVisualStyleBackColor = true;
            this.btnTaoPhieuHen.Click += new System.EventHandler(this.btnTaoPhieuHen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tìm kiếm theo số điện thoại";
            // 
            // txtsodt
            // 
            this.txtsodt.Location = new System.Drawing.Point(305, 86);
            this.txtsodt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsodt.Name = "txtsodt";
            this.txtsodt.Size = new System.Drawing.Size(255, 22);
            this.txtsodt.TabIndex = 10;
            // 
            // CT_PhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsodt);
            this.Controls.Add(this.btnTaoPhieuHen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnGoiPhieuHen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CT_PhieuHen";
            this.Text = "CT_PhieuHen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CT_PhieuHen_FormClosing);
            this.Load += new System.EventHandler(this.CT_PhieuHen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoiPhieuHen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.DateTimePicker dtpngayhen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaoPhieuHen;
        private System.Windows.Forms.TextBox txtidkh;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsodt;
    }
}