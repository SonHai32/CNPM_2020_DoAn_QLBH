namespace GUI
{
    partial class frmDangnhap
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pane_main = new Guna.UI2.WinForms.Guna2Panel();
            this.txtServername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDatabase = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.btThoat = new Guna.UI2.WinForms.Guna2Button();
            this.pane_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pane_main
            // 
            this.pane_main.Controls.Add(this.btThoat);
            this.pane_main.Controls.Add(this.btDangNhap);
            this.pane_main.Controls.Add(this.pictureBox1);
            this.pane_main.Controls.Add(this.guna2HtmlLabel4);
            this.pane_main.Controls.Add(this.guna2HtmlLabel5);
            this.pane_main.Controls.Add(this.guna2HtmlLabel3);
            this.pane_main.Controls.Add(this.guna2HtmlLabel2);
            this.pane_main.Controls.Add(this.guna2HtmlLabel1);
            this.pane_main.Controls.Add(this.txtPassword);
            this.pane_main.Controls.Add(this.txtUserID);
            this.pane_main.Controls.Add(this.txtDatabase);
            this.pane_main.Controls.Add(this.txtServername);
            this.pane_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane_main.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.pane_main.Location = new System.Drawing.Point(0, 0);
            this.pane_main.Name = "pane_main";
            this.pane_main.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.pane_main.ShadowDecoration.Enabled = true;
            this.pane_main.ShadowDecoration.Parent = this.pane_main;
            this.pane_main.Size = new System.Drawing.Size(617, 421);
            this.pane_main.TabIndex = 0;
            // 
            // txtServername
            // 
            this.txtServername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServername.DefaultText = "LAPTOP-HENIB6EN\\SQLEXPRESS";
            this.txtServername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServername.DisabledState.Parent = this.txtServername;
            this.txtServername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServername.FocusedState.Parent = this.txtServername;
            this.txtServername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServername.HoverState.Parent = this.txtServername;
            this.txtServername.Location = new System.Drawing.Point(256, 103);
            this.txtServername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServername.Name = "txtServername";
            this.txtServername.PasswordChar = '\0';
            this.txtServername.PlaceholderText = "";
            this.txtServername.SelectedText = "";
            this.txtServername.SelectionStart = 26;
            this.txtServername.ShadowDecoration.Parent = this.txtServername;
            this.txtServername.Size = new System.Drawing.Size(267, 44);
            this.txtServername.TabIndex = 1;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.DefaultText = "QL_Banhang2";
            this.txtDatabase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDatabase.DisabledState.Parent = this.txtDatabase;
            this.txtDatabase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDatabase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDatabase.FocusedState.Parent = this.txtDatabase;
            this.txtDatabase.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDatabase.HoverState.Parent = this.txtDatabase;
            this.txtDatabase.Location = new System.Drawing.Point(256, 155);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PlaceholderText = "";
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.ShadowDecoration.Parent = this.txtDatabase;
            this.txtDatabase.Size = new System.Drawing.Size(267, 44);
            this.txtDatabase.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "hhsh";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.Parent = this.txtUserID;
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.FocusedState.Parent = this.txtUserID;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.HoverState.Parent = this.txtUserID;
            this.txtUserID.Location = new System.Drawing.Point(256, 207);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.SelectedText = "";
            this.txtUserID.ShadowDecoration.Parent = this.txtUserID;
            this.txtUserID.Size = new System.Drawing.Size(267, 44);
            this.txtUserID.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "123";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(256, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(267, 44);
            this.txtPassword.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(93, 111);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 25);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "SERVER";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(93, 164);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(139, 25);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "DATABASE NAME";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(93, 216);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(66, 25);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "USER ID";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(93, 269);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(94, 25);
            this.guna2HtmlLabel4.TabIndex = 4;
            this.guna2HtmlLabel4.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI.Properties.Resources.login_64px;
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(238, 23);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(219, 43);
            this.guna2HtmlLabel5.TabIndex = 4;
            this.guna2HtmlLabel5.Text = "SYSTEM LOGIN";
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btDangNhap.BorderRadius = 10;
            this.btDangNhap.CheckedState.Parent = this.btDangNhap;
            this.btDangNhap.CustomImages.Parent = this.btDangNhap;
            this.btDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btDangNhap.HoverState.Parent = this.btDangNhap;
            this.btDangNhap.Location = new System.Drawing.Point(115, 353);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.ShadowDecoration.Parent = this.btDangNhap;
            this.btDangNhap.Size = new System.Drawing.Size(180, 45);
            this.btDangNhap.TabIndex = 6;
            this.btDangNhap.Text = "ĐĂNG NHẬP";
            this.btDangNhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.BorderRadius = 10;
            this.btThoat.CheckedState.Parent = this.btThoat;
            this.btThoat.CustomImages.Parent = this.btThoat;
            this.btThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.btThoat.HoverState.Parent = this.btThoat;
            this.btThoat.Location = new System.Drawing.Point(314, 353);
            this.btThoat.Name = "btThoat";
            this.btThoat.ShadowDecoration.Parent = this.btThoat;
            this.btThoat.Size = new System.Drawing.Size(180, 45);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "THOÁT";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmDangnhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 421);
            this.Controls.Add(this.pane_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangnhap_FormClosing);
            this.pane_main.ResumeLayout(false);
            this.pane_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pane_main;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtDatabase;
        private Guna.UI2.WinForms.Guna2TextBox txtServername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btThoat;
        private Guna.UI2.WinForms.Guna2Button btDangNhap;
    }
}