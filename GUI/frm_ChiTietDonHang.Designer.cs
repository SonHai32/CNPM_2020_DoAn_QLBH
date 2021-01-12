namespace GUI
{
    partial class frm_ChiTietDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lb_header = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_DonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MSHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_pane = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_bill_detail = new Guna.UI2.WinForms.Guna2Button();
            this.pane_control = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonHang)).BeginInit();
            this.grv_pane.SuspendLayout();
            this.pane_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(399, 526);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(259, 45);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "Đóng";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lb_header;
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
            this.lb_header.TabIndex = 15;
            this.lb_header.Text = "LỊCH SỬ GIAO DỊCH";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1256, -108);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // NGAYHD
            // 
            this.NGAYHD.DataPropertyName = "NGAYHD";
            this.NGAYHD.HeaderText = "Ngày giao dịch";
            this.NGAYHD.MinimumWidth = 6;
            this.NGAYHD.Name = "NGAYHD";
            this.NGAYHD.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Nhân viên bán hàng";
            this.TENNV.MinimumWidth = 6;
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV ";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DonHang.DefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // MSHD
            // 
            this.MSHD.DataPropertyName = "MSHD";
            this.MSHD.HeaderText = "Mã Hóa Đơn";
            this.MSHD.MinimumWidth = 6;
            this.MSHD.Name = "MSHD";
            this.MSHD.ReadOnly = true;
            // 
            // grv_pane
            // 
            this.grv_pane.BackColor = System.Drawing.Color.White;
            this.grv_pane.Controls.Add(this.grv_DonHang);
            this.grv_pane.Dock = System.Windows.Forms.DockStyle.Top;
            this.grv_pane.Location = new System.Drawing.Point(0, 148);
            this.grv_pane.Name = "grv_pane";
            this.grv_pane.Padding = new System.Windows.Forms.Padding(50, 50, 50, 10);
            this.grv_pane.ShadowDecoration.Parent = this.grv_pane;
            this.grv_pane.Size = new System.Drawing.Size(1138, 483);
            this.grv_pane.TabIndex = 18;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_bill_detail
            // 
            this.btn_bill_detail.CheckedState.Parent = this.btn_bill_detail;
            this.btn_bill_detail.CustomImages.Parent = this.btn_bill_detail;
            this.btn_bill_detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btn_bill_detail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill_detail.ForeColor = System.Drawing.Color.White;
            this.btn_bill_detail.HoverState.Parent = this.btn_bill_detail;
            this.btn_bill_detail.Location = new System.Drawing.Point(99, 526);
            this.btn_bill_detail.Name = "btn_bill_detail";
            this.btn_bill_detail.ShadowDecoration.Parent = this.btn_bill_detail;
            this.btn_bill_detail.Size = new System.Drawing.Size(259, 45);
            this.btn_bill_detail.TabIndex = 20;
            this.btn_bill_detail.Text = "Xem chi tiết";
            // 
            // pane_control
            // 
            this.pane_control.BackColor = System.Drawing.Color.White;
            this.pane_control.Controls.Add(this.label1);
            this.pane_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_control.Location = new System.Drawing.Point(0, 74);
            this.pane_control.Name = "pane_control";
            this.pane_control.ShadowDecoration.Parent = this.pane_control;
            this.pane_control.Size = new System.Drawing.Size(1138, 74);
            this.pane_control.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1138, 74);
            this.label1.TabIndex = 16;
            this.label1.Text = "GIAO DỊCH SỐ : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 709);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.grv_pane);
            this.Controls.Add(this.pane_control);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.btn_bill_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChiTietDonHang";
            this.Text = "frm_ChiTietDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.grv_DonHang)).EndInit();
            this.grv_pane.ResumeLayout(false);
            this.pane_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lb_header;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private Guna.UI2.WinForms.Guna2DataGridView grv_DonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHD;
        private Guna.UI2.WinForms.Guna2Panel grv_pane;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_bill_detail;
        private Guna.UI2.WinForms.Guna2Panel pane_control;
        private System.Windows.Forms.Label label1;
    }
}