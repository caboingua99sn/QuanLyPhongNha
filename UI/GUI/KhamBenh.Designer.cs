namespace GUI
{
    partial class frmKhamBenh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhamBenh));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pnl_KhamBenh = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_donthuoc = new System.Windows.Forms.Button();
            this.btn_GoiKham = new System.Windows.Forms.Button();
            this.dtpKB_ngaytaikham = new System.Windows.Forms.DateTimePicker();
            this.txtKB_maBN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpKB_ngaykham = new System.Windows.Forms.DateTimePicker();
            this.txtKB_tenBS = new System.Windows.Forms.TextBox();
            this.txtKB_mota = new System.Windows.Forms.TextBox();
            this.txtKB_hoten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_ChoKham = new System.Windows.Forms.ListBox();
            this.Pnl_KhamBenh.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Pnl_KhamBenh
            // 
            this.Pnl_KhamBenh.Controls.Add(this.groupBox2);
            this.Pnl_KhamBenh.Controls.Add(this.groupBox1);
            this.Pnl_KhamBenh.Location = new System.Drawing.Point(2, 0);
            this.Pnl_KhamBenh.Name = "Pnl_KhamBenh";
            this.Pnl_KhamBenh.Size = new System.Drawing.Size(1121, 332);
            this.Pnl_KhamBenh.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPhieu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_donthuoc);
            this.groupBox2.Controls.Add(this.btn_GoiKham);
            this.groupBox2.Controls.Add(this.dtpKB_ngaytaikham);
            this.groupBox2.Controls.Add(this.txtKB_maBN);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtpKB_ngaykham);
            this.groupBox2.Controls.Add(this.txtKB_tenBS);
            this.groupBox2.Controls.Add(this.txtKB_mota);
            this.groupBox2.Controls.Add(this.txtKB_hoten);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 314);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN BỆNH ÁN";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(689, 48);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(112, 27);
            this.txtMaPhieu.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã phiếu:";
            // 
            // btn_donthuoc
            // 
            this.btn_donthuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_donthuoc.Image")));
            this.btn_donthuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_donthuoc.Location = new System.Drawing.Point(438, 204);
            this.btn_donthuoc.Name = "btn_donthuoc";
            this.btn_donthuoc.Size = new System.Drawing.Size(199, 52);
            this.btn_donthuoc.TabIndex = 26;
            this.btn_donthuoc.Text = "Thêm dịch vụ";
            this.btn_donthuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_donthuoc.UseVisualStyleBackColor = true;
            this.btn_donthuoc.Click += new System.EventHandler(this.btn_donthuoc_Click);
            // 
            // btn_GoiKham
            // 
            this.btn_GoiKham.AutoSize = true;
            this.btn_GoiKham.Image = ((System.Drawing.Image)(resources.GetObject("btn_GoiKham.Image")));
            this.btn_GoiKham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GoiKham.Location = new System.Drawing.Point(267, 204);
            this.btn_GoiKham.Name = "btn_GoiKham";
            this.btn_GoiKham.Size = new System.Drawing.Size(110, 52);
            this.btn_GoiKham.TabIndex = 2;
            this.btn_GoiKham.Text = "Gọi khám";
            this.btn_GoiKham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GoiKham.UseVisualStyleBackColor = true;
            this.btn_GoiKham.Click += new System.EventHandler(this.btn_GoiKham_Click);
            // 
            // dtpKB_ngaytaikham
            // 
            this.dtpKB_ngaytaikham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKB_ngaytaikham.Location = new System.Drawing.Point(582, 134);
            this.dtpKB_ngaytaikham.Name = "dtpKB_ngaytaikham";
            this.dtpKB_ngaytaikham.Size = new System.Drawing.Size(242, 27);
            this.dtpKB_ngaytaikham.TabIndex = 24;
            // 
            // txtKB_maBN
            // 
            this.txtKB_maBN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKB_maBN.Location = new System.Drawing.Point(508, 48);
            this.txtKB_maBN.Name = "txtKB_maBN";
            this.txtKB_maBN.Size = new System.Drawing.Size(76, 27);
            this.txtKB_maBN.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày tái khám:";
            // 
            // dtpKB_ngaykham
            // 
            this.dtpKB_ngaykham.Enabled = false;
            this.dtpKB_ngaykham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKB_ngaykham.Location = new System.Drawing.Point(132, 133);
            this.dtpKB_ngaykham.Name = "dtpKB_ngaykham";
            this.dtpKB_ngaykham.Size = new System.Drawing.Size(295, 27);
            this.dtpKB_ngaykham.TabIndex = 19;
            // 
            // txtKB_tenBS
            // 
            this.txtKB_tenBS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKB_tenBS.Location = new System.Drawing.Point(565, 89);
            this.txtKB_tenBS.Name = "txtKB_tenBS";
            this.txtKB_tenBS.Size = new System.Drawing.Size(257, 27);
            this.txtKB_tenBS.TabIndex = 14;
            // 
            // txtKB_mota
            // 
            this.txtKB_mota.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKB_mota.Location = new System.Drawing.Point(132, 89);
            this.txtKB_mota.Name = "txtKB_mota";
            this.txtKB_mota.Size = new System.Drawing.Size(295, 27);
            this.txtKB_mota.TabIndex = 13;
            // 
            // txtKB_hoten
            // 
            this.txtKB_hoten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKB_hoten.Location = new System.Drawing.Point(132, 48);
            this.txtKB_hoten.Name = "txtKB_hoten";
            this.txtKB_hoten.Size = new System.Drawing.Size(295, 27);
            this.txtKB_hoten.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày khám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bác sỹ khám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả bệnh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã BN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_ChoKham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BỆNH NHÂN CHỜ KHÁM";
            // 
            // lst_ChoKham
            // 
            this.lst_ChoKham.FormattingEnabled = true;
            this.lst_ChoKham.ItemHeight = 19;
            this.lst_ChoKham.Location = new System.Drawing.Point(6, 26);
            this.lst_ChoKham.Name = "lst_ChoKham";
            this.lst_ChoKham.Size = new System.Drawing.Size(253, 270);
            this.lst_ChoKham.TabIndex = 0;
            this.lst_ChoKham.SelectedIndexChanged += new System.EventHandler(this.lst_ChoKham_SelectedIndexChanged);
            // 
            // frmKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 335);
            this.Controls.Add(this.Pnl_KhamBenh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhamBenh";
            this.Text = "Khám bệnh";
            this.Load += new System.EventHandler(this.frmKhamBenh_Load);
            this.Pnl_KhamBenh.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel Pnl_KhamBenh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKB_ngaytaikham;
        private System.Windows.Forms.TextBox txtKB_maBN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpKB_ngaykham;
        private System.Windows.Forms.TextBox txtKB_tenBS;
        private System.Windows.Forms.TextBox txtKB_mota;
        private System.Windows.Forms.TextBox txtKB_hoten;
        private System.Windows.Forms.Button btn_donthuoc;
        private System.Windows.Forms.Button btn_GoiKham;
        private System.Windows.Forms.ListBox lst_ChoKham;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
    }
}

