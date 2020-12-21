namespace GUI
{
    partial class frmDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonThuoc));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsDV = new System.Windows.Forms.DataGridView();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDsThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSChiTiet = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDsDV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 227);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách dịch vụ";
            // 
            // dgvDsDV
            // 
            this.dgvDsDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add});
            this.dgvDsDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsDV.Location = new System.Drawing.Point(3, 19);
            this.dgvDsDV.Name = "dgvDsDV";
            this.dgvDsDV.RowHeadersVisible = false;
            this.dgvDsDV.RowTemplate.Height = 24;
            this.dgvDsDV.Size = new System.Drawing.Size(532, 205);
            this.dgvDsDV.TabIndex = 0;
            this.dgvDsDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsDV_CellContentClick);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.AutoSize = true;
            this.btnTaoDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDon.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoDon.Image")));
            this.btnTaoDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoDon.Location = new System.Drawing.Point(486, 520);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(141, 43);
            this.btnTaoDon.TabIndex = 23;
            this.btnTaoDon.Text = "Tạo đơn thuốc";
            this.btnTaoDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDon.UseVisualStyleBackColor = true;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDsThuoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(545, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 227);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc";
            // 
            // dgvDsThuoc
            // 
            this.dgvDsThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.them});
            this.dgvDsThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsThuoc.Location = new System.Drawing.Point(3, 19);
            this.dgvDsThuoc.Name = "dgvDsThuoc";
            this.dgvDsThuoc.RowHeadersVisible = false;
            this.dgvDsThuoc.RowTemplate.Height = 24;
            this.dgvDsThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDsThuoc.Size = new System.Drawing.Size(664, 205);
            this.dgvDsThuoc.TabIndex = 0;
            this.dgvDsThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsThuoc_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSChiTiet);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 279);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết đơn thuốc";
            // 
            // dgvDSChiTiet
            // 
            this.dgvDSChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.remove});
            this.dgvDSChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSChiTiet.Location = new System.Drawing.Point(3, 19);
            this.dgvDSChiTiet.Name = "dgvDSChiTiet";
            this.dgvDSChiTiet.RowHeadersVisible = false;
            this.dgvDSChiTiet.RowTemplate.Height = 24;
            this.dgvDSChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDSChiTiet.Size = new System.Drawing.Size(1202, 257);
            this.dgvDSChiTiet.TabIndex = 0;
            this.dgvDSChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSChiTiet_CellContentClick);
            // 
            // them
            // 
            this.them.HeaderText = "Thêm";
            this.them.Name = "them";
            this.them.Width = 50;
            // 
            // add
            // 
            this.add.HeaderText = "Thêm";
            this.add.Name = "add";
            this.add.Text = "";
            this.add.Width = 50;
            // 
            // remove
            // 
            this.remove.HeaderText = "Xoá";
            this.remove.Name = "remove";
            this.remove.Width = 50;
            // 
            // frmDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTaoDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn thuốc";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDsDV;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDsThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSChiTiet;
        private System.Windows.Forms.DataGridViewButtonColumn them;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}