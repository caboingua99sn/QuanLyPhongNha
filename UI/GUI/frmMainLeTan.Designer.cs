namespace GUI
{
    partial class frmMainLeTan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lậpPhiếuKhámToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuKhámToolStripMenuItem,
            this.quảnLíLịchHẹnToolStripMenuItem,
            this.quảnLíBệnhNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lậpPhiếuKhámToolStripMenuItem
            // 
            this.lậpPhiếuKhámToolStripMenuItem.Name = "lậpPhiếuKhámToolStripMenuItem";
            this.lậpPhiếuKhámToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.lậpPhiếuKhámToolStripMenuItem.Text = "Lập phiếu khám";
            this.lậpPhiếuKhámToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuKhámToolStripMenuItem_Click);
            // 
            // quảnLíLịchHẹnToolStripMenuItem
            // 
            this.quảnLíLịchHẹnToolStripMenuItem.Name = "quảnLíLịchHẹnToolStripMenuItem";
            this.quảnLíLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.quảnLíLịchHẹnToolStripMenuItem.Text = "Quản lí lịch hẹn";
            this.quảnLíLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíLịchHẹnToolStripMenuItem_Click);
            // 
            // quảnLíBệnhNhânToolStripMenuItem
            // 
            this.quảnLíBệnhNhânToolStripMenuItem.Name = "quảnLíBệnhNhânToolStripMenuItem";
            this.quảnLíBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLíBệnhNhânToolStripMenuItem.Text = "Quản lí bệnh nhân";
            this.quảnLíBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.quảnLíBệnhNhânToolStripMenuItem_Click);
            // 
            // frmMainLeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainLeTan";
            this.Text = "frmMainLeTan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuKhámToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíLịchHẹnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíBệnhNhânToolStripMenuItem;
    }
}