namespace GUI
{
    partial class frm_LichSuGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_header = new System.Windows.Forms.Label();
            this.pane_control = new Guna.UI2.WinForms.Guna2Panel();
            this.check_Date = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dayEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dayStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.grv_DonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MSHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.grv_pane = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_bill_detail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.txt_search_key = new Guna.UI2.WinForms.Guna2TextBox();
            this.pane_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonHang)).BeginInit();
            this.grv_pane.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb_header
            // 
            this.lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.White;
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(1138, 74);
            this.lb_header.TabIndex = 9;
            this.lb_header.Text = "LỊCH SỬ GIAO DỊCH";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pane_control
            // 
            this.pane_control.Controls.Add(this.check_Date);
            this.pane_control.Controls.Add(this.guna2HtmlLabel2);
            this.pane_control.Controls.Add(this.guna2HtmlLabel1);
            this.pane_control.Controls.Add(this.dayEnd);
            this.pane_control.Controls.Add(this.dayStart);
            this.pane_control.Controls.Add(this.txt_search_key);
            this.pane_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_control.Location = new System.Drawing.Point(0, 74);
            this.pane_control.Name = "pane_control";
            this.pane_control.ShadowDecoration.Parent = this.pane_control;
            this.pane_control.Size = new System.Drawing.Size(1138, 74);
            this.pane_control.TabIndex = 10;
            // 
            // check_Date
            // 
            this.check_Date.AutoSize = true;
            this.check_Date.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_Date.CheckedState.BorderRadius = 2;
            this.check_Date.CheckedState.BorderThickness = 0;
            this.check_Date.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.check_Date.Location = new System.Drawing.Point(480, 28);
            this.check_Date.Name = "check_Date";
            this.check_Date.Size = new System.Drawing.Size(98, 21);
            this.check_Date.TabIndex = 6;
            this.check_Date.Text = "Theo ngày";
            this.check_Date.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_Date.UncheckedState.BorderRadius = 2;
            this.check_Date.UncheckedState.BorderThickness = 0;
            this.check_Date.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_Date.UseVisualStyleBackColor = true;
            this.check_Date.CheckedChanged += new System.EventHandler(this.check_Date_CheckedChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(876, 24);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(64, 25);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = "Đến";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(601, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(96, 25);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Từ ngày";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayEnd
            // 
            this.dayEnd.CheckedState.Parent = this.dayEnd;
            this.dayEnd.CustomFormat = "dd/MM/yyyy";
            this.dayEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.dayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayEnd.HoverState.Parent = this.dayEnd;
            this.dayEnd.Location = new System.Drawing.Point(972, 24);
            this.dayEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayEnd.Name = "dayEnd";
            this.dayEnd.ShadowDecoration.Parent = this.dayEnd;
            this.dayEnd.Size = new System.Drawing.Size(139, 25);
            this.dayEnd.TabIndex = 4;
            this.dayEnd.Value = new System.DateTime(2021, 1, 12, 2, 50, 31, 193);
            this.dayEnd.ValueChanged += new System.EventHandler(this.dateValueChanged);
            // 
            // dayStart
            // 
            this.dayStart.CheckedState.Parent = this.dayStart;
            this.dayStart.CustomFormat = "dd/MM/yyyy";
            this.dayStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.dayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dayStart.HoverState.Parent = this.dayStart;
            this.dayStart.Location = new System.Drawing.Point(728, 24);
            this.dayStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayStart.Name = "dayStart";
            this.dayStart.ShadowDecoration.Parent = this.dayStart;
            this.dayStart.Size = new System.Drawing.Size(139, 25);
            this.dayStart.TabIndex = 4;
            this.dayStart.Value = new System.DateTime(2021, 1, 12, 2, 50, 31, 193);
            this.dayStart.ValueChanged += new System.EventHandler(this.dateValueChanged);
            // 
            // grv_DonHang
            // 
            this.grv_DonHang.AllowUserToAddRows = false;
            this.grv_DonHang.AllowUserToDeleteRows = false;
            this.grv_DonHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_DonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_DonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_DonHang.BackgroundColor = System.Drawing.Color.White;
            this.grv_DonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_DonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_DonHang.ColumnHeadersHeight = 40;
            this.grv_DonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHD,
            this.MANV,
            this.TENNV,
            this.NGAYHD,
            this.TONGTIEN});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DonHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.grv_DonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_DonHang.EnableHeadersVisualStyles = false;
            this.grv_DonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DonHang.Location = new System.Drawing.Point(50, 50);
            this.grv_DonHang.MultiSelect = false;
            this.grv_DonHang.Name = "grv_DonHang";
            this.grv_DonHang.ReadOnly = true;
            this.grv_DonHang.RowHeadersVisible = false;
            this.grv_DonHang.RowHeadersWidth = 51;
            this.grv_DonHang.RowTemplate.Height = 24;
            this.grv_DonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_DonHang.Size = new System.Drawing.Size(1038, 423);
            this.grv_DonHang.TabIndex = 11;
            this.grv_DonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grv_DonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_DonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_DonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_DonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_DonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_DonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grv_DonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DonHang.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_DonHang.ThemeStyle.ReadOnly = true;
            this.grv_DonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grv_DonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DonHang.ThemeStyle.RowsStyle.Height = 24;
            this.grv_DonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_DonHang_CellContentClick);
            // 
            // MSHD
            // 
            this.MSHD.DataPropertyName = "MSHD";
            this.MSHD.HeaderText = "Mã Hóa Đơn";
            this.MSHD.MinimumWidth = 6;
            this.MSHD.Name = "MSHD";
            this.MSHD.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV ";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Nhân viên bán hàng";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // NGAYHD
            // 
            this.NGAYHD.DataPropertyName = "NGAYHD";
            this.NGAYHD.HeaderText = "Ngày giao dịch";
            this.NGAYHD.MinimumWidth = 6;
            this.NGAYHD.Name = "NGAYHD";
            this.NGAYHD.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,## VND";
            dataGridViewCellStyle3.NullValue = null;
            this.TONGTIEN.DefaultCellStyle = dataGridViewCellStyle3;
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1081, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lb_header;
            // 
            // grv_pane
            // 
            this.grv_pane.Controls.Add(this.grv_DonHang);
            this.grv_pane.Dock = System.Windows.Forms.DockStyle.Top;
            this.grv_pane.Location = new System.Drawing.Point(0, 148);
            this.grv_pane.Name = "grv_pane";
            this.grv_pane.Padding = new System.Windows.Forms.Padding(50, 50, 50, 10);
            this.grv_pane.ShadowDecoration.Parent = this.grv_pane;
            this.grv_pane.Size = new System.Drawing.Size(1138, 483);
            this.grv_pane.TabIndex = 13;
            // 
            // btn_bill_detail
            // 
            this.btn_bill_detail.CheckedState.Parent = this.btn_bill_detail;
            this.btn_bill_detail.CustomImages.Parent = this.btn_bill_detail;
            this.btn_bill_detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btn_bill_detail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill_detail.ForeColor = System.Drawing.Color.White;
            this.btn_bill_detail.HoverState.Parent = this.btn_bill_detail;
            this.btn_bill_detail.Location = new System.Drawing.Point(262, 646);
            this.btn_bill_detail.Name = "btn_bill_detail";
            this.btn_bill_detail.ShadowDecoration.Parent = this.btn_bill_detail;
            this.btn_bill_detail.Size = new System.Drawing.Size(259, 45);
            this.btn_bill_detail.TabIndex = 14;
            this.btn_bill_detail.Text = "Xem chi tiết";
            this.btn_bill_detail.Click += new System.EventHandler(this.btn_bill_detail_Click);
            // 
            // btn_close
            // 
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(562, 646);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(259, 45);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Đóng";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_search_key
            // 
            this.txt_search_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_key.DefaultText = "";
            this.txt_search_key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_key.DisabledState.Parent = this.txt_search_key;
            this.txt_search_key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_key.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_search_key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_key.FocusedState.Parent = this.txt_search_key;
            this.txt_search_key.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_key.HoverState.Parent = this.txt_search_key;
            this.txt_search_key.IconLeft = global::GUI.Properties.Resources.magnifying_glass;
            this.txt_search_key.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_search_key.Location = new System.Drawing.Point(0, 0);
            this.txt_search_key.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search_key.Name = "txt_search_key";
            this.txt_search_key.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.txt_search_key.PasswordChar = '\0';
            this.txt_search_key.PlaceholderText = "Nội dung tìm kiếm(Mã HD, Giá tiền...)";
            this.txt_search_key.SelectedText = "";
            this.txt_search_key.ShadowDecoration.Parent = this.txt_search_key;
            this.txt_search_key.Size = new System.Drawing.Size(457, 74);
            this.txt_search_key.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_search_key.TabIndex = 3;
            this.txt_search_key.TextChanged += new System.EventHandler(this.txt_search_key_TextChanged);
            // 
            // frm_LichSuGiaoDich
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 709);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_bill_detail);
            this.Controls.Add(this.grv_pane);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pane_control);
            this.Controls.Add(this.lb_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LichSuGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "d";
            this.Load += new System.EventHandler(this.frm_LichSuGiaoDich_Load);
            this.pane_control.ResumeLayout(false);
            this.pane_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonHang)).EndInit();
            this.grv_pane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pane_control;
        private System.Windows.Forms.Label lb_header;
        private Guna.UI2.WinForms.Guna2DataGridView grv_DonHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dayStart;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_key;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox check_Date;
        private Guna.UI2.WinForms.Guna2DateTimePicker dayEnd;
        private Guna.UI2.WinForms.Guna2Panel grv_pane;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2Button btn_bill_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
    }
}