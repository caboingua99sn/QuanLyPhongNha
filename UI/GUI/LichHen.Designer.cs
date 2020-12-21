namespace GUI
{
    partial class frmLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichHen));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemLichHen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvwDSCuocHen = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSCuocHen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // dtpNgayTo
            // 
            this.dtpNgayTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTo.Location = new System.Drawing.Point(459, 23);
            this.dtpNgayTo.Name = "dtpNgayTo";
            this.dtpNgayTo.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày";
            // 
            // dtpNgayFrom
            // 
            this.dtpNgayFrom.CustomFormat = "";
            this.dtpNgayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayFrom.Location = new System.Drawing.Point(120, 22);
            this.dtpNgayFrom.Name = "dtpNgayFrom";
            this.dtpNgayFrom.Size = new System.Drawing.Size(213, 30);
            this.dtpNgayFrom.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayTo);
            this.groupBox1.Controls.Add(this.dtpNgayFrom);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm lịch hẹn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(680, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(135, 39);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemLichHen
            // 
            this.btnThemLichHen.BackColor = System.Drawing.Color.White;
            this.btnThemLichHen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLichHen.Image")));
            this.btnThemLichHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLichHen.Location = new System.Drawing.Point(876, 31);
            this.btnThemLichHen.Name = "btnThemLichHen";
            this.btnThemLichHen.Size = new System.Drawing.Size(134, 36);
            this.btnThemLichHen.TabIndex = 4;
            this.btnThemLichHen.Text = "Thêm hẹn";
            this.btnThemLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLichHen.UseVisualStyleBackColor = false;
            this.btnThemLichHen.Click += new System.EventHandler(this.btnThemLichHen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvwDSCuocHen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 353);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách cuộc hẹn trong ngày";
            // 
            // dvwDSCuocHen
            // 
            this.dvwDSCuocHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvwDSCuocHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvwDSCuocHen.Location = new System.Drawing.Point(3, 26);
            this.dvwDSCuocHen.Name = "dvwDSCuocHen";
            this.dvwDSCuocHen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvwDSCuocHen.Size = new System.Drawing.Size(1031, 324);
            this.dvwDSCuocHen.TabIndex = 0;
            this.dvwDSCuocHen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvwDSCuocHen_CellDoubleClick);
            // 
            // frmLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemLichHen);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLichHen";
            this.Text = "Lịch hẹn";
            this.Load += new System.EventHandler(this.frmLichHen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvwDSCuocHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemLichHen;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvwDSCuocHen;
    }
}