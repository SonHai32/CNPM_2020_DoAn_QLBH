namespace GUI
{
    partial class frmHethong
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
            this.menuHethong = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHKN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCDTMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHethong
            // 
            this.menuHethong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDM,
            this.mnuHD,
            this.mnuBC,
            this.mnuTC,
            this.mnuTG});
            this.menuHethong.Location = new System.Drawing.Point(0, 0);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Size = new System.Drawing.Size(800, 24);
            this.menuHethong.TabIndex = 0;
            this.menuHethong.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.toolStripSeparator1,
            this.mnuHKN,
            this.toolStripSeparator2,
            this.mnuBR,
            this.toolStripSeparator3,
            this.mnuThoat});
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(69, 20);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(180, 22);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuHKN
            // 
            this.mnuHKN.Name = "mnuHKN";
            this.mnuHKN.Size = new System.Drawing.Size(180, 22);
            this.mnuHKN.Text = "Hủy kết nối";
            this.mnuHKN.Click += new System.EventHandler(this.mnuHKN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuBR
            // 
            this.mnuBR.Name = "mnuBR";
            this.mnuBR.Size = new System.Drawing.Size(180, 22);
            this.mnuBR.Text = "Backup and Restore";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(180, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMMH,
            this.mnuDMNV,
            this.mnuDMKH});
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(74, 20);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDMMH
            // 
            this.mnuDMMH.Name = "mnuDMMH";
            this.mnuDMMH.Size = new System.Drawing.Size(137, 22);
            this.mnuDMMH.Text = "Mặt hàng";
            // 
            // mnuDMNV
            // 
            this.mnuDMNV.Name = "mnuDMNV";
            this.mnuDMNV.Size = new System.Drawing.Size(137, 22);
            this.mnuDMNV.Text = "Nhân viên";
            // 
            // mnuDMKH
            // 
            this.mnuDMKH.Name = "mnuDMKH";
            this.mnuDMKH.Size = new System.Drawing.Size(137, 22);
            this.mnuDMKH.Text = "Khách hàng";
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLHD});
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(65, 20);
            this.mnuHD.Text = "Hóa đơn";
            // 
            // mnuLHD
            // 
            this.mnuLHD.Name = "mnuLHD";
            this.mnuLHD.Size = new System.Drawing.Size(140, 22);
            this.mnuLHD.Text = "Lập hóa đơn";
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInHD,
            this.mnuTKDT});
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(61, 20);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuInHD
            // 
            this.mnuInHD.Name = "mnuInHD";
            this.mnuInHD.Size = new System.Drawing.Size(234, 22);
            this.mnuInHD.Text = "In hóa đơn";
            // 
            // mnuTKDT
            // 
            this.mnuTKDT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCDTNV,
            this.mnuBCDTMH});
            this.mnuTKDT.Name = "mnuTKDT";
            this.mnuTKDT.Size = new System.Drawing.Size(234, 22);
            this.mnuTKDT.Text = "Thống kê doanh thu bán hàng";
            // 
            // mnuBCDTNV
            // 
            this.mnuBCDTNV.Name = "mnuBCDTNV";
            this.mnuBCDTNV.Size = new System.Drawing.Size(236, 22);
            this.mnuBCDTNV.Text = "Doanh thu cho từng nhân viên";
            // 
            // mnuBCDTMH
            // 
            this.mnuBCDTMH.Name = "mnuBCDTMH";
            this.mnuBCDTMH.Size = new System.Drawing.Size(236, 22);
            this.mnuBCDTMH.Text = "Doanh thu cho từng mặt hàng";
            // 
            // mnuTC
            // 
            this.mnuTC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCMH,
            this.mnuTCNV,
            this.mnuTCKH,
            this.mnuTCHD});
            this.mnuTC.Name = "mnuTC";
            this.mnuTC.Size = new System.Drawing.Size(57, 20);
            this.mnuTC.Text = "Tra cứu";
            // 
            // mnuTCMH
            // 
            this.mnuTCMH.Name = "mnuTCMH";
            this.mnuTCMH.Size = new System.Drawing.Size(137, 22);
            this.mnuTCMH.Text = "Mặt hàng";
            // 
            // mnuTCNV
            // 
            this.mnuTCNV.Name = "mnuTCNV";
            this.mnuTCNV.Size = new System.Drawing.Size(137, 22);
            this.mnuTCNV.Text = "Nhân viên";
            // 
            // mnuTCKH
            // 
            this.mnuTCKH.Name = "mnuTCKH";
            this.mnuTCKH.Size = new System.Drawing.Size(137, 22);
            this.mnuTCKH.Text = "Khách hàng";
            // 
            // mnuTCHD
            // 
            this.mnuTCHD.Name = "mnuTCHD";
            this.mnuTCHD.Size = new System.Drawing.Size(137, 22);
            this.mnuTCHD.Text = "Hóa đơn";
            // 
            // mnuTG
            // 
            this.mnuTG.Name = "mnuTG";
            this.mnuTG.Size = new System.Drawing.Size(62, 20);
            this.mnuTG.Text = "Trợ giúp";
            // 
            // frmHethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuHethong);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHethong;
            this.Name = "frmHethong";
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHethong_Load);
            this.menuHethong.ResumeLayout(false);
            this.menuHethong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHethong;
        private System.Windows.Forms.ToolStripMenuItem mnuHT;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuDM;
        private System.Windows.Forms.ToolStripMenuItem mnuHD;
        private System.Windows.Forms.ToolStripMenuItem mnuBC;
        private System.Windows.Forms.ToolStripMenuItem mnuTKDT;
        private System.Windows.Forms.ToolStripMenuItem mnuTC;
        private System.Windows.Forms.ToolStripMenuItem mnuTG;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuHKN;
        public System.Windows.Forms.ToolStripMenuItem mnuBR;
        public System.Windows.Forms.ToolStripMenuItem mnuDMMH;
        public System.Windows.Forms.ToolStripMenuItem mnuDMNV;
        public System.Windows.Forms.ToolStripMenuItem mnuDMKH;
        public System.Windows.Forms.ToolStripMenuItem mnuLHD;
        public System.Windows.Forms.ToolStripMenuItem mnuInHD;
        public System.Windows.Forms.ToolStripMenuItem mnuBCDTNV;
        public System.Windows.Forms.ToolStripMenuItem mnuBCDTMH;
        public System.Windows.Forms.ToolStripMenuItem mnuTCMH;
        public System.Windows.Forms.ToolStripMenuItem mnuTCNV;
        public System.Windows.Forms.ToolStripMenuItem mnuTCKH;
        public System.Windows.Forms.ToolStripMenuItem mnuTCHD;
    }
}

