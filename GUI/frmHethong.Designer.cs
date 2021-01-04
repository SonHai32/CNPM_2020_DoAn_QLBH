using System;
using System.Windows.Forms;

namespace GUI
{

    internal class CustomTabControl : TabControl
    {
        /// <summary>
        /// The WndProc.
        /// </summary>
        /// <param name="m">The m<see cref="Message"/>.</param>
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }

    }
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
            this.components = new System.ComponentModel.Container();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainTabControl = new GUI.CustomTabControl();
            this.tabPageUserLogin = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn7 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton3 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton4 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton5 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton6 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton7 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton8 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton9 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton10 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnLogin2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_user_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_role_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sell = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_open_work_shift = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_close_work_shift = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton11 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton14 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton15 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuHethong.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageUserLogin.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1051, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.menuHethong;
            // 
            // menuHethong
            // 
            this.menuHethong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuHethong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDM,
            this.mnuHD,
            this.mnuBC,
            this.mnuTC,
            this.mnuTG});
            this.menuHethong.Location = new System.Drawing.Point(0, 0);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Size = new System.Drawing.Size(1096, 28);
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
            this.mnuHT.Size = new System.Drawing.Size(85, 24);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(223, 26);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuHKN
            // 
            this.mnuHKN.Name = "mnuHKN";
            this.mnuHKN.Size = new System.Drawing.Size(223, 26);
            this.mnuHKN.Text = "Hủy kết nối";
            this.mnuHKN.Click += new System.EventHandler(this.mnuHKN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuBR
            // 
            this.mnuBR.Name = "mnuBR";
            this.mnuBR.Size = new System.Drawing.Size(223, 26);
            this.mnuBR.Text = "Backup and Restore";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(223, 26);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMMH,
            this.mnuDMNV,
            this.mnuDMKH});
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(90, 24);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDMMH
            // 
            this.mnuDMMH.Name = "mnuDMMH";
            this.mnuDMMH.Size = new System.Drawing.Size(169, 26);
            this.mnuDMMH.Text = "Mặt hàng";
            // 
            // mnuDMNV
            // 
            this.mnuDMNV.Name = "mnuDMNV";
            this.mnuDMNV.Size = new System.Drawing.Size(169, 26);
            this.mnuDMNV.Text = "Nhân viên";
            // 
            // mnuDMKH
            // 
            this.mnuDMKH.Name = "mnuDMKH";
            this.mnuDMKH.Size = new System.Drawing.Size(169, 26);
            this.mnuDMKH.Text = "Khách hàng";
            this.mnuDMKH.Click += new System.EventHandler(this.mnuDMKH_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLHD});
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(81, 24);
            this.mnuHD.Text = "Hóa đơn";
            // 
            // mnuLHD
            // 
            this.mnuLHD.Name = "mnuLHD";
            this.mnuLHD.Size = new System.Drawing.Size(175, 26);
            this.mnuLHD.Text = "Lập hóa đơn";
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInHD,
            this.mnuTKDT});
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(77, 24);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuInHD
            // 
            this.mnuInHD.Name = "mnuInHD";
            this.mnuInHD.Size = new System.Drawing.Size(290, 26);
            this.mnuInHD.Text = "In hóa đơn";
            // 
            // mnuTKDT
            // 
            this.mnuTKDT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBCDTNV,
            this.mnuBCDTMH});
            this.mnuTKDT.Name = "mnuTKDT";
            this.mnuTKDT.Size = new System.Drawing.Size(290, 26);
            this.mnuTKDT.Text = "Thống kê doanh thu bán hàng";
            // 
            // mnuBCDTNV
            // 
            this.mnuBCDTNV.Name = "mnuBCDTNV";
            this.mnuBCDTNV.Size = new System.Drawing.Size(291, 26);
            this.mnuBCDTNV.Text = "Doanh thu cho từng nhân viên";
            // 
            // mnuBCDTMH
            // 
            this.mnuBCDTMH.Name = "mnuBCDTMH";
            this.mnuBCDTMH.Size = new System.Drawing.Size(291, 26);
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
            this.mnuTC.Size = new System.Drawing.Size(71, 24);
            this.mnuTC.Text = "Tra cứu";
            // 
            // mnuTCMH
            // 
            this.mnuTCMH.Name = "mnuTCMH";
            this.mnuTCMH.Size = new System.Drawing.Size(169, 26);
            this.mnuTCMH.Text = "Mặt hàng";
            // 
            // mnuTCNV
            // 
            this.mnuTCNV.Name = "mnuTCNV";
            this.mnuTCNV.Size = new System.Drawing.Size(169, 26);
            this.mnuTCNV.Text = "Nhân viên";
            // 
            // mnuTCKH
            // 
            this.mnuTCKH.Name = "mnuTCKH";
            this.mnuTCKH.Size = new System.Drawing.Size(169, 26);
            this.mnuTCKH.Text = "Khách hàng";
            // 
            // mnuTCHD
            // 
            this.mnuTCHD.Name = "mnuTCHD";
            this.mnuTCHD.Size = new System.Drawing.Size(169, 26);
            this.mnuTCHD.Text = "Hóa đơn";
            // 
            // mnuTG
            // 
            this.mnuTG.Name = "mnuTG";
            this.mnuTG.Size = new System.Drawing.Size(78, 24);
            this.mnuTG.Text = "Trợ giúp";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageUserLogin);
            this.mainTabControl.Controls.Add(this.tabPageMain);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 28);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1096, 682);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainTabControl_KeyPress);
            // 
            // tabPageUserLogin
            // 
            this.tabPageUserLogin.Controls.Add(this.guna2GradientPanel1);
            this.tabPageUserLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserLogin.Name = "tabPageUserLogin";
            this.tabPageUserLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserLogin.Size = new System.Drawing.Size(1088, 653);
            this.tabPageUserLogin.TabIndex = 0;
            this.tabPageUserLogin.Text = "tabPageUserLogin";
            this.tabPageUserLogin.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1082, 647);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 87);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1082, 560);
            this.guna2Panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn7);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton2);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton3);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton4);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton5);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton6);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton7);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton8);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton9);
            this.flowLayoutPanel1.Controls.Add(this.guna2GradientTileButton10);
            this.flowLayoutPanel1.Controls.Add(this.btnLogin2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(668, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(259, 341);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btn7
            // 
            this.btn7.CheckedState.Parent = this.btn7;
            this.btn7.CustomImages.Parent = this.btn7;
            this.btn7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.HoverState.Parent = this.btn7;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.ShadowDecoration.Parent = this.btn7;
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 2;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.CheckedState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.CustomImages.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.HoverState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(89, 3);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.ShadowDecoration.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton2.TabIndex = 3;
            this.guna2GradientTileButton2.TabStop = false;
            this.guna2GradientTileButton2.Text = "8";
            // 
            // guna2GradientTileButton3
            // 
            this.guna2GradientTileButton3.CheckedState.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.CustomImages.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton3.HoverState.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.Location = new System.Drawing.Point(175, 3);
            this.guna2GradientTileButton3.Name = "guna2GradientTileButton3";
            this.guna2GradientTileButton3.ShadowDecoration.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton3.TabIndex = 4;
            this.guna2GradientTileButton3.TabStop = false;
            this.guna2GradientTileButton3.Text = "9";
            // 
            // guna2GradientTileButton4
            // 
            this.guna2GradientTileButton4.CheckedState.Parent = this.guna2GradientTileButton4;
            this.guna2GradientTileButton4.CustomImages.Parent = this.guna2GradientTileButton4;
            this.guna2GradientTileButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton4.HoverState.Parent = this.guna2GradientTileButton4;
            this.guna2GradientTileButton4.Location = new System.Drawing.Point(3, 89);
            this.guna2GradientTileButton4.Name = "guna2GradientTileButton4";
            this.guna2GradientTileButton4.ShadowDecoration.Parent = this.guna2GradientTileButton4;
            this.guna2GradientTileButton4.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton4.TabIndex = 5;
            this.guna2GradientTileButton4.TabStop = false;
            this.guna2GradientTileButton4.Text = "4";
            // 
            // guna2GradientTileButton5
            // 
            this.guna2GradientTileButton5.CheckedState.Parent = this.guna2GradientTileButton5;
            this.guna2GradientTileButton5.CustomImages.Parent = this.guna2GradientTileButton5;
            this.guna2GradientTileButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton5.HoverState.Parent = this.guna2GradientTileButton5;
            this.guna2GradientTileButton5.Location = new System.Drawing.Point(89, 89);
            this.guna2GradientTileButton5.Name = "guna2GradientTileButton5";
            this.guna2GradientTileButton5.ShadowDecoration.Parent = this.guna2GradientTileButton5;
            this.guna2GradientTileButton5.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton5.TabIndex = 4;
            this.guna2GradientTileButton5.TabStop = false;
            this.guna2GradientTileButton5.Text = "5";
            // 
            // guna2GradientTileButton6
            // 
            this.guna2GradientTileButton6.CheckedState.Parent = this.guna2GradientTileButton6;
            this.guna2GradientTileButton6.CustomImages.Parent = this.guna2GradientTileButton6;
            this.guna2GradientTileButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton6.HoverState.Parent = this.guna2GradientTileButton6;
            this.guna2GradientTileButton6.Location = new System.Drawing.Point(175, 89);
            this.guna2GradientTileButton6.Name = "guna2GradientTileButton6";
            this.guna2GradientTileButton6.ShadowDecoration.Parent = this.guna2GradientTileButton6;
            this.guna2GradientTileButton6.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton6.TabIndex = 5;
            this.guna2GradientTileButton6.TabStop = false;
            this.guna2GradientTileButton6.Text = "6";
            // 
            // guna2GradientTileButton7
            // 
            this.guna2GradientTileButton7.CheckedState.Parent = this.guna2GradientTileButton7;
            this.guna2GradientTileButton7.CustomImages.Parent = this.guna2GradientTileButton7;
            this.guna2GradientTileButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton7.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton7.HoverState.Parent = this.guna2GradientTileButton7;
            this.guna2GradientTileButton7.Location = new System.Drawing.Point(3, 175);
            this.guna2GradientTileButton7.Name = "guna2GradientTileButton7";
            this.guna2GradientTileButton7.ShadowDecoration.Parent = this.guna2GradientTileButton7;
            this.guna2GradientTileButton7.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton7.TabIndex = 6;
            this.guna2GradientTileButton7.TabStop = false;
            this.guna2GradientTileButton7.Text = "1";
            // 
            // guna2GradientTileButton8
            // 
            this.guna2GradientTileButton8.CheckedState.Parent = this.guna2GradientTileButton8;
            this.guna2GradientTileButton8.CustomImages.Parent = this.guna2GradientTileButton8;
            this.guna2GradientTileButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton8.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton8.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton8.HoverState.Parent = this.guna2GradientTileButton8;
            this.guna2GradientTileButton8.Location = new System.Drawing.Point(89, 175);
            this.guna2GradientTileButton8.Name = "guna2GradientTileButton8";
            this.guna2GradientTileButton8.ShadowDecoration.Parent = this.guna2GradientTileButton8;
            this.guna2GradientTileButton8.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton8.TabIndex = 7;
            this.guna2GradientTileButton8.TabStop = false;
            this.guna2GradientTileButton8.Text = "2";
            // 
            // guna2GradientTileButton9
            // 
            this.guna2GradientTileButton9.CheckedState.Parent = this.guna2GradientTileButton9;
            this.guna2GradientTileButton9.CustomImages.Parent = this.guna2GradientTileButton9;
            this.guna2GradientTileButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton9.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton9.HoverState.Parent = this.guna2GradientTileButton9;
            this.guna2GradientTileButton9.Location = new System.Drawing.Point(175, 175);
            this.guna2GradientTileButton9.Name = "guna2GradientTileButton9";
            this.guna2GradientTileButton9.ShadowDecoration.Parent = this.guna2GradientTileButton9;
            this.guna2GradientTileButton9.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton9.TabIndex = 8;
            this.guna2GradientTileButton9.TabStop = false;
            this.guna2GradientTileButton9.Text = "3";
            // 
            // guna2GradientTileButton10
            // 
            this.guna2GradientTileButton10.CheckedState.Parent = this.guna2GradientTileButton10;
            this.guna2GradientTileButton10.CustomImages.Parent = this.guna2GradientTileButton10;
            this.guna2GradientTileButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton10.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton10.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton10.HoverState.Parent = this.guna2GradientTileButton10;
            this.guna2GradientTileButton10.Location = new System.Drawing.Point(3, 261);
            this.guna2GradientTileButton10.Name = "guna2GradientTileButton10";
            this.guna2GradientTileButton10.ShadowDecoration.Parent = this.guna2GradientTileButton10;
            this.guna2GradientTileButton10.Size = new System.Drawing.Size(80, 80);
            this.guna2GradientTileButton10.TabIndex = 9;
            this.guna2GradientTileButton10.TabStop = false;
            this.guna2GradientTileButton10.Text = "0";
            // 
            // btnLogin2
            // 
            this.btnLogin2.CheckedState.Parent = this.btnLogin2;
            this.btnLogin2.CustomImages.Parent = this.btnLogin2;
            this.btnLogin2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btnLogin2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnLogin2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin2.ForeColor = System.Drawing.Color.White;
            this.btnLogin2.HoverState.Parent = this.btnLogin2;
            this.btnLogin2.Location = new System.Drawing.Point(89, 261);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.ShadowDecoration.Parent = this.btnLogin2;
            this.btnLogin2.Size = new System.Drawing.Size(166, 80);
            this.btnLogin2.TabIndex = 10;
            this.btnLogin2.TabStop = false;
            this.btnLogin2.Text = "OK";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 200;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnLogin);
            this.guna2Panel2.Controls.Add(this.txtUsername);
            this.guna2Panel2.Controls.Add(this.txtPassword);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Location = new System.Drawing.Point(5, 44);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(642, 341);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(226, 282);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(304, 66);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(314, 44);
            this.txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(304, 191);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Nhập mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(314, 44);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(83, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(186, 31);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Tên Đăng Nhập";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(83, 200);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(107, 31);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Mật khẩu";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1082, 87);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.guna2Panel3);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1088, 653);
            this.tabPageMain.TabIndex = 1;
            this.tabPageMain.Text = "tabPageMain";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackgroundImage = global::GUI.Properties.Resources.UIBackground;
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Controls.Add(this.lb_user_id);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel3.Controls.Add(this.lb_username);
            this.guna2Panel3.Controls.Add(this.lb_role_name);
            this.guna2Panel3.Controls.Add(this.flowLayoutPanel2);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1082, 647);
            this.guna2Panel3.TabIndex = 3;
            // 
            // lb_user_id
            // 
            this.lb_user_id.BackColor = System.Drawing.Color.Transparent;
            this.lb_user_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lb_user_id.Location = new System.Drawing.Point(156, 576);
            this.lb_user_id.Name = "lb_user_id";
            this.lb_user_id.Size = new System.Drawing.Size(24, 30);
            this.lb_user_id.TabIndex = 6;
            this.lb_user_id.Text = "ID";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 576);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(35, 30);
            this.guna2HtmlLabel5.TabIndex = 6;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "ID :";
            // 
            // lb_username
            // 
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lb_username.Location = new System.Drawing.Point(156, 540);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(57, 30);
            this.lb_username.TabIndex = 6;
            this.lb_username.Text = "Name";
            // 
            // lb_role_name
            // 
            this.lb_role_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_role_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role_name.Location = new System.Drawing.Point(21, 540);
            this.lb_role_name.Name = "lb_role_name";
            this.lb_role_name.Size = new System.Drawing.Size(106, 30);
            this.lb_role_name.TabIndex = 6;
            this.lb_role_name.TabStop = false;
            this.lb_role_name.Text = "RoleName: ";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_sell);
            this.flowLayoutPanel2.Controls.Add(this.btn_open_work_shift);
            this.flowLayoutPanel2.Controls.Add(this.btn_close_work_shift);
            this.flowLayoutPanel2.Controls.Add(this.guna2GradientTileButton11);
            this.flowLayoutPanel2.Controls.Add(this.guna2GradientTileButton14);
            this.flowLayoutPanel2.Controls.Add(this.guna2GradientTileButton15);
            this.flowLayoutPanel2.Controls.Add(this.guna2ImageButton1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(518, 222);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(559, 374);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btn_sell
            // 
            this.btn_sell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_sell.BorderRadius = 10;
            this.btn_sell.BorderThickness = 1;
            this.btn_sell.CheckedState.Parent = this.btn_sell;
            this.btn_sell.CustomImages.Parent = this.btn_sell;
            this.btn_sell.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn_sell.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_sell.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.ForeColor = System.Drawing.Color.White;
            this.btn_sell.HoverState.Parent = this.btn_sell;
            this.btn_sell.Image = global::GUI.Properties.Resources.online_shopping;
            this.btn_sell.ImageOffset = new System.Drawing.Point(0, -10);
            this.btn_sell.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_sell.Location = new System.Drawing.Point(3, 3);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btn_sell.ShadowDecoration.Parent = this.btn_sell;
            this.btn_sell.Size = new System.Drawing.Size(180, 180);
            this.btn_sell.TabIndex = 3;
            this.btn_sell.Text = "Bán Hàng";
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_open_work_shift
            // 
            this.btn_open_work_shift.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_open_work_shift.BorderRadius = 10;
            this.btn_open_work_shift.BorderThickness = 1;
            this.btn_open_work_shift.CheckedState.Parent = this.btn_open_work_shift;
            this.btn_open_work_shift.CustomImages.Parent = this.btn_open_work_shift;
            this.btn_open_work_shift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn_open_work_shift.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_open_work_shift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_work_shift.ForeColor = System.Drawing.Color.White;
            this.btn_open_work_shift.HoverState.Parent = this.btn_open_work_shift;
            this.btn_open_work_shift.Image = global::GUI.Properties.Resources.open;
            this.btn_open_work_shift.ImageOffset = new System.Drawing.Point(0, -10);
            this.btn_open_work_shift.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_open_work_shift.Location = new System.Drawing.Point(189, 3);
            this.btn_open_work_shift.Name = "btn_open_work_shift";
            this.btn_open_work_shift.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btn_open_work_shift.ShadowDecoration.Parent = this.btn_open_work_shift;
            this.btn_open_work_shift.Size = new System.Drawing.Size(180, 180);
            this.btn_open_work_shift.TabIndex = 5;
            this.btn_open_work_shift.Text = "Mở Ca";
            this.btn_open_work_shift.Click += new System.EventHandler(this.btn_open_work_shift_Click);
            // 
            // btn_close_work_shift
            // 
            this.btn_close_work_shift.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btn_close_work_shift.BorderRadius = 10;
            this.btn_close_work_shift.BorderThickness = 1;
            this.btn_close_work_shift.CheckedState.Parent = this.btn_close_work_shift;
            this.btn_close_work_shift.CustomImages.Parent = this.btn_close_work_shift;
            this.btn_close_work_shift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btn_close_work_shift.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_close_work_shift.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_work_shift.ForeColor = System.Drawing.Color.White;
            this.btn_close_work_shift.HoverState.Parent = this.btn_close_work_shift;
            this.btn_close_work_shift.Image = global::GUI.Properties.Resources.waiter;
            this.btn_close_work_shift.ImageOffset = new System.Drawing.Point(0, -10);
            this.btn_close_work_shift.ImageSize = new System.Drawing.Size(48, 48);
            this.btn_close_work_shift.Location = new System.Drawing.Point(375, 3);
            this.btn_close_work_shift.Name = "btn_close_work_shift";
            this.btn_close_work_shift.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btn_close_work_shift.ShadowDecoration.Parent = this.btn_close_work_shift;
            this.btn_close_work_shift.Size = new System.Drawing.Size(180, 180);
            this.btn_close_work_shift.TabIndex = 6;
            this.btn_close_work_shift.Text = "Đóng Ca";
            this.btn_close_work_shift.Click += new System.EventHandler(this.btn_close_work_shift_Click);
            // 
            // guna2GradientTileButton11
            // 
            this.guna2GradientTileButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.guna2GradientTileButton11.BorderRadius = 10;
            this.guna2GradientTileButton11.BorderThickness = 1;
            this.guna2GradientTileButton11.CheckedState.Parent = this.guna2GradientTileButton11;
            this.guna2GradientTileButton11.CustomImages.Parent = this.guna2GradientTileButton11;
            this.guna2GradientTileButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton11.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2GradientTileButton11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton11.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton11.HoverState.Parent = this.guna2GradientTileButton11;
            this.guna2GradientTileButton11.Image = global::GUI.Properties.Resources.waiter;
            this.guna2GradientTileButton11.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2GradientTileButton11.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientTileButton11.Location = new System.Drawing.Point(3, 189);
            this.guna2GradientTileButton11.Name = "guna2GradientTileButton11";
            this.guna2GradientTileButton11.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton11.ShadowDecoration.Parent = this.guna2GradientTileButton11;
            this.guna2GradientTileButton11.Size = new System.Drawing.Size(180, 180);
            this.guna2GradientTileButton11.TabIndex = 4;
            this.guna2GradientTileButton11.Text = "Rút Tiền";
            // 
            // guna2GradientTileButton14
            // 
            this.guna2GradientTileButton14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.guna2GradientTileButton14.BorderRadius = 10;
            this.guna2GradientTileButton14.BorderThickness = 1;
            this.guna2GradientTileButton14.CheckedState.Parent = this.guna2GradientTileButton14;
            this.guna2GradientTileButton14.CustomImages.Parent = this.guna2GradientTileButton14;
            this.guna2GradientTileButton14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton14.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2GradientTileButton14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton14.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton14.HoverState.Parent = this.guna2GradientTileButton14;
            this.guna2GradientTileButton14.Image = global::GUI.Properties.Resources.waiter;
            this.guna2GradientTileButton14.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2GradientTileButton14.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientTileButton14.Location = new System.Drawing.Point(189, 189);
            this.guna2GradientTileButton14.Name = "guna2GradientTileButton14";
            this.guna2GradientTileButton14.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton14.ShadowDecoration.Parent = this.guna2GradientTileButton14;
            this.guna2GradientTileButton14.Size = new System.Drawing.Size(180, 180);
            this.guna2GradientTileButton14.TabIndex = 7;
            this.guna2GradientTileButton14.Text = "Lịch Sử GD";
            // 
            // guna2GradientTileButton15
            // 
            this.guna2GradientTileButton15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.guna2GradientTileButton15.BorderRadius = 10;
            this.guna2GradientTileButton15.BorderThickness = 1;
            this.guna2GradientTileButton15.CheckedState.Parent = this.guna2GradientTileButton15;
            this.guna2GradientTileButton15.CustomImages.Parent = this.guna2GradientTileButton15;
            this.guna2GradientTileButton15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2GradientTileButton15.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.guna2GradientTileButton15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton15.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton15.HoverState.Parent = this.guna2GradientTileButton15;
            this.guna2GradientTileButton15.Image = global::GUI.Properties.Resources.waiter;
            this.guna2GradientTileButton15.ImageOffset = new System.Drawing.Point(0, -10);
            this.guna2GradientTileButton15.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientTileButton15.Location = new System.Drawing.Point(375, 189);
            this.guna2GradientTileButton15.Name = "guna2GradientTileButton15";
            this.guna2GradientTileButton15.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.guna2GradientTileButton15.ShadowDecoration.Parent = this.guna2GradientTileButton15;
            this.guna2GradientTileButton15.Size = new System.Drawing.Size(180, 180);
            this.guna2GradientTileButton15.TabIndex = 8;
            this.guna2GradientTileButton15.Text = "Thống Kế";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Location = new System.Drawing.Point(3, 375);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(100, 100);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AutoRoundedCorners = true;
            this.guna2PictureBox1.BackgroundImage = global::GUI.Properties.Resources.waiter;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.BorderRadius = 124;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.ImageLocation = "";
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 265);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(1082, 136);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "<h3>HỆ THỐNG QUẢN LÝ BÁN HÀNG CỬA HÀNG TIỆN LỢI ABC</h3>";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHethong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1096, 710);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuHethong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHethong;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHethong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHethong_Load);
            this.menuHethong.ResumeLayout(false);
            this.menuHethong.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageUserLogin.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tabPageMain.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTabControl mainTabControl;
        private TabPage tabPageUserLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn7;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton3;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton4;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton5;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton6;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton7;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton8;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton9;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton10;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnLogin2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TabPage tabPageMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private MenuStrip menuHethong;
        private ToolStripMenuItem mnuHT;
        public ToolStripMenuItem mnuDN;
        private ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem mnuHKN;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStripMenuItem mnuBR;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDM;
        public ToolStripMenuItem mnuDMMH;
        public ToolStripMenuItem mnuDMNV;
        public ToolStripMenuItem mnuDMKH;
        private ToolStripMenuItem mnuHD;
        public ToolStripMenuItem mnuLHD;
        private ToolStripMenuItem mnuBC;
        public ToolStripMenuItem mnuInHD;
        private ToolStripMenuItem mnuTKDT;
        public ToolStripMenuItem mnuBCDTNV;
        public ToolStripMenuItem mnuBCDTMH;
        private ToolStripMenuItem mnuTC;
        public ToolStripMenuItem mnuTCMH;
        public ToolStripMenuItem mnuTCNV;
        public ToolStripMenuItem mnuTCKH;
        public ToolStripMenuItem mnuTCHD;
        private ToolStripMenuItem mnuTG;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_sell;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_open_work_shift;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_close_work_shift;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton11;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton14;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton15;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_username;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_role_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_user_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

