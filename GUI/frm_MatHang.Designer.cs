namespace GUI
{
    partial class frm_MatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb_header = new System.Windows.Forms.Label();
            this.pane_control = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_search_key = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pane_add_update = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_product_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product_unit = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_product_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.ecl_btn_add = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grv_pane = new Guna.UI2.WinForms.Guna2Panel();
            this.grv_mat_hang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MSMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_TON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pane_control.SuspendLayout();
            this.pane_add_update.SuspendLayout();
            this.grv_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_mat_hang)).BeginInit();
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
            this.lb_header.Size = new System.Drawing.Size(1344, 74);
            this.lb_header.TabIndex = 10;
            this.lb_header.Text = "QUẢN LÝ MẶT HÀNG";
            this.lb_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pane_control
            // 
            this.pane_control.BackColor = System.Drawing.Color.White;
            this.pane_control.Controls.Add(this.txt_search_key);
            this.pane_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_control.Location = new System.Drawing.Point(0, 74);
            this.pane_control.Name = "pane_control";
            this.pane_control.ShadowDecoration.Parent = this.pane_control;
            this.pane_control.Size = new System.Drawing.Size(1344, 74);
            this.pane_control.TabIndex = 11;
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
            this.txt_search_key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_key.FocusedState.Parent = this.txt_search_key;
            this.txt_search_key.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_key.HoverState.Parent = this.txt_search_key;
            this.txt_search_key.IconLeft = global::GUI.Properties.Resources.magnifying_glass;
            this.txt_search_key.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_search_key.Location = new System.Drawing.Point(50, 12);
            this.txt_search_key.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_search_key.Name = "txt_search_key";
            this.txt_search_key.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.txt_search_key.PasswordChar = '\0';
            this.txt_search_key.PlaceholderText = "Tìm kiếm";
            this.txt_search_key.SelectedText = "";
            this.txt_search_key.ShadowDecoration.Parent = this.txt_search_key;
            this.txt_search_key.Size = new System.Drawing.Size(896, 49);
            this.txt_search_key.TabIndex = 3;
            this.txt_search_key.TextChanged += new System.EventHandler(this.txt_search_key_TextChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lb_header;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1287, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // pane_add_update
            // 
            this.pane_add_update.Controls.Add(this.btn_update);
            this.pane_add_update.Controls.Add(this.btn_delete);
            this.pane_add_update.Controls.Add(this.btn_clear);
            this.pane_add_update.Controls.Add(this.btn_add);
            this.pane_add_update.Controls.Add(this.txt_product_price);
            this.pane_add_update.Controls.Add(this.txt_product_amount);
            this.pane_add_update.Controls.Add(this.txt_product_unit);
            this.pane_add_update.Controls.Add(this.txt_product_name);
            this.pane_add_update.Controls.Add(this.txt_product_id);
            this.pane_add_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_add_update.Location = new System.Drawing.Point(0, 148);
            this.pane_add_update.Name = "pane_add_update";
            this.pane_add_update.ShadowDecoration.Parent = this.pane_add_update;
            this.pane_add_update.Size = new System.Drawing.Size(1344, 80);
            this.pane_add_update.TabIndex = 18;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 6;
            this.btn_update.CheckedState.Parent = this.btn_update;
            this.btn_update.CustomImages.Parent = this.btn_update;
            this.btn_update.FillColor = System.Drawing.SystemColors.Control;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.HoverState.Parent = this.btn_update;
            this.btn_update.Image = global::GUI.Properties.Resources.pencil_drawing_64px;
            this.btn_update.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_update.Location = new System.Drawing.Point(1169, 24);
            this.btn_update.Name = "btn_update";
            this.btn_update.PressedColor = System.Drawing.Color.LightGray;
            this.btn_update.ShadowDecoration.Parent = this.btn_update;
            this.btn_update.Size = new System.Drawing.Size(32, 32);
            this.btn_update.TabIndex = 4;
            this.btn_update.UseTransparentBackground = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 6;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Image = global::GUI.Properties.Resources.delete_bin_64px;
            this.btn_delete.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_delete.Location = new System.Drawing.Point(1125, 24);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedColor = System.Drawing.Color.LightGray;
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(32, 32);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.UseTransparentBackground = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 6;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Image = global::GUI.Properties.Resources.clear_symbol_64px;
            this.btn_clear.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_clear.Location = new System.Drawing.Point(1037, 24);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.PressedColor = System.Drawing.Color.LightGray;
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(32, 32);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.UseTransparentBackground = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 6;
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.SystemColors.Control;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Image = global::GUI.Properties.Resources.plus_math_64px;
            this.btn_add.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_add.Location = new System.Drawing.Point(1081, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.PressedColor = System.Drawing.Color.LightGray;
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(32, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.UseTransparentBackground = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_product_price
            // 
            this.txt_product_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_price.DefaultText = "";
            this.txt_product_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_price.DisabledState.Parent = this.txt_product_price;
            this.txt_product_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_price.FocusedState.Parent = this.txt_product_price;
            this.txt_product_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txt_product_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_price.HoverState.Parent = this.txt_product_price;
            this.txt_product_price.Location = new System.Drawing.Point(847, 17);
            this.txt_product_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.PasswordChar = '\0';
            this.txt_product_price.PlaceholderText = "Nhập Giá Tiền";
            this.txt_product_price.SelectedText = "";
            this.txt_product_price.ShadowDecoration.Parent = this.txt_product_price;
            this.txt_product_price.Size = new System.Drawing.Size(184, 44);
            this.txt_product_price.TabIndex = 0;
            // 
            // txt_product_amount
            // 
            this.txt_product_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_amount.DefaultText = "";
            this.txt_product_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_amount.DisabledState.Parent = this.txt_product_amount;
            this.txt_product_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_amount.FocusedState.Parent = this.txt_product_amount;
            this.txt_product_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txt_product_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_amount.HoverState.Parent = this.txt_product_amount;
            this.txt_product_amount.Location = new System.Drawing.Point(690, 17);
            this.txt_product_amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_amount.Name = "txt_product_amount";
            this.txt_product_amount.PasswordChar = '\0';
            this.txt_product_amount.PlaceholderText = "Nhập Số Lượng";
            this.txt_product_amount.SelectedText = "";
            this.txt_product_amount.ShadowDecoration.Parent = this.txt_product_amount;
            this.txt_product_amount.Size = new System.Drawing.Size(138, 44);
            this.txt_product_amount.TabIndex = 0;
            // 
            // txt_product_unit
            // 
            this.txt_product_unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_unit.DefaultText = "";
            this.txt_product_unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_unit.DisabledState.Parent = this.txt_product_unit;
            this.txt_product_unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_unit.FocusedState.Parent = this.txt_product_unit;
            this.txt_product_unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txt_product_unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_unit.HoverState.Parent = this.txt_product_unit;
            this.txt_product_unit.Location = new System.Drawing.Point(533, 17);
            this.txt_product_unit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_unit.Name = "txt_product_unit";
            this.txt_product_unit.PasswordChar = '\0';
            this.txt_product_unit.PlaceholderText = "Nhập Đơn Vị ";
            this.txt_product_unit.SelectedText = "";
            this.txt_product_unit.ShadowDecoration.Parent = this.txt_product_unit;
            this.txt_product_unit.Size = new System.Drawing.Size(138, 44);
            this.txt_product_unit.TabIndex = 0;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_name.DefaultText = "";
            this.txt_product_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_name.DisabledState.Parent = this.txt_product_name;
            this.txt_product_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_name.FocusedState.Parent = this.txt_product_name;
            this.txt_product_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txt_product_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_name.HoverState.Parent = this.txt_product_name;
            this.txt_product_name.Location = new System.Drawing.Point(246, 17);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.PasswordChar = '\0';
            this.txt_product_name.PlaceholderText = "Nhập Tên Hàng";
            this.txt_product_name.SelectedText = "";
            this.txt_product_name.ShadowDecoration.Parent = this.txt_product_name;
            this.txt_product_name.Size = new System.Drawing.Size(268, 44);
            this.txt_product_name.TabIndex = 0;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_id.DefaultText = "";
            this.txt_product_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_product_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_product_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_id.DisabledState.Parent = this.txt_product_id;
            this.txt_product_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_product_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_id.FocusedState.Parent = this.txt_product_id;
            this.txt_product_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.txt_product_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_product_id.HoverState.Parent = this.txt_product_id;
            this.txt_product_id.Location = new System.Drawing.Point(50, 17);
            this.txt_product_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.PasswordChar = '\0';
            this.txt_product_id.PlaceholderText = "Nhập Mã Hàng";
            this.txt_product_id.SelectedText = "";
            this.txt_product_id.ShadowDecoration.Parent = this.txt_product_id;
            this.txt_product_id.Size = new System.Drawing.Size(174, 44);
            this.txt_product_id.TabIndex = 0;
            // 
            // ecl_btn_add
            // 
            this.ecl_btn_add.BorderRadius = 20;
            // 
            // grv_pane
            // 
            this.grv_pane.BackColor = System.Drawing.Color.White;
            this.grv_pane.Controls.Add(this.grv_mat_hang);
            this.grv_pane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_pane.Location = new System.Drawing.Point(0, 228);
            this.grv_pane.Name = "grv_pane";
            this.grv_pane.Padding = new System.Windows.Forms.Padding(50, 50, 50, 10);
            this.grv_pane.ShadowDecoration.Parent = this.grv_pane;
            this.grv_pane.Size = new System.Drawing.Size(1344, 492);
            this.grv_pane.TabIndex = 19;
            // 
            // grv_mat_hang
            // 
            this.grv_mat_hang.AllowUserToAddRows = false;
            this.grv_mat_hang.AllowUserToDeleteRows = false;
            this.grv_mat_hang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_mat_hang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_mat_hang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_mat_hang.BackgroundColor = System.Drawing.Color.White;
            this.grv_mat_hang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_mat_hang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_mat_hang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_mat_hang.ColumnHeadersHeight = 40;
            this.grv_mat_hang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSMH,
            this.TENMH,
            this.DONVITINH,
            this.SL_TON,
            this.DONGIA});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_mat_hang.DefaultCellStyle = dataGridViewCellStyle7;
            this.grv_mat_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grv_mat_hang.EnableHeadersVisualStyles = false;
            this.grv_mat_hang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_mat_hang.Location = new System.Drawing.Point(50, 50);
            this.grv_mat_hang.MultiSelect = false;
            this.grv_mat_hang.Name = "grv_mat_hang";
            this.grv_mat_hang.ReadOnly = true;
            this.grv_mat_hang.RowHeadersVisible = false;
            this.grv_mat_hang.RowHeadersWidth = 51;
            this.grv_mat_hang.RowTemplate.Height = 32;
            this.grv_mat_hang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_mat_hang.Size = new System.Drawing.Size(1244, 432);
            this.grv_mat_hang.TabIndex = 11;
            this.grv_mat_hang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grv_mat_hang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_mat_hang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_mat_hang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_mat_hang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_mat_hang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_mat_hang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_mat_hang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_mat_hang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.grv_mat_hang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_mat_hang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grv_mat_hang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.grv_mat_hang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_mat_hang.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_mat_hang.ThemeStyle.ReadOnly = true;
            this.grv_mat_hang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_mat_hang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.grv_mat_hang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_mat_hang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.grv_mat_hang.ThemeStyle.RowsStyle.Height = 32;
            this.grv_mat_hang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.grv_mat_hang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.grv_mat_hang.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_mat_hang_CellEnter);
            this.grv_mat_hang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grv_mat_hang_KeyPress);
            // 
            // MSMH
            // 
            this.MSMH.DataPropertyName = "MSMH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MSMH.DefaultCellStyle = dataGridViewCellStyle3;
            this.MSMH.HeaderText = "Mã hàng";
            this.MSMH.MinimumWidth = 6;
            this.MSMH.Name = "MSMH";
            this.MSMH.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên Mặt Hàng";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // DONVITINH
            // 
            this.DONVITINH.DataPropertyName = "DONVITINH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DONVITINH.DefaultCellStyle = dataGridViewCellStyle4;
            this.DONVITINH.HeaderText = "Đơn Vị Tính";
            this.DONVITINH.MinimumWidth = 6;
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.ReadOnly = true;
            // 
            // SL_TON
            // 
            this.SL_TON.DataPropertyName = "SL_TON";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SL_TON.DefaultCellStyle = dataGridViewCellStyle5;
            this.SL_TON.HeaderText = "Số Lượng Tồn";
            this.SL_TON.MinimumWidth = 6;
            this.SL_TON.Name = "SL_TON";
            this.SL_TON.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,## VNĐ";
            dataGridViewCellStyle6.NullValue = null;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // frm_MatHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 720);
            this.Controls.Add(this.grv_pane);
            this.Controls.Add(this.pane_add_update);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pane_control);
            this.Controls.Add(this.lb_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MatHang_Load);
            this.pane_control.ResumeLayout(false);
            this.pane_add_update.ResumeLayout(false);
            this.grv_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_mat_hang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_header;
        private Guna.UI2.WinForms.Guna2Panel pane_control;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_key;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pane_add_update;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_price;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_amount;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_unit;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_product_id;
        private Guna.UI2.WinForms.Guna2Elipse ecl_btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Panel grv_pane;
        private Guna.UI2.WinForms.Guna2DataGridView grv_mat_hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_TON;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
    }
}