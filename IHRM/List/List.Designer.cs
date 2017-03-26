namespace IHRM.List
{
    partial class List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.list_menu = new System.Windows.Forms.Panel();
            this.login_exit = new ns1.BunifuImageButton();
            this.list_navigation = new System.Windows.Forms.Panel();
            this.list_logo = new ns1.BunifuCustomLabel();
            this.list_home = new System.Windows.Forms.Panel();
            this.list_add = new ns1.BunifuThinButton2();
            this.list_delete = new ns1.BunifuThinButton2();
            this.list_modify = new ns1.BunifuThinButton2();
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.login_username = new ns1.BunifuMaterialTextbox();
            this.list_search = new ns1.BunifuImageButton();
            this.btn_home = new ns1.BunifuFlatButton();
            this.list_contract = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid2 = new ns1.BunifuCustomDataGrid();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.bunifuThinButton23 = new ns1.BunifuThinButton2();
            this.btn_contract = new ns1.BunifuFlatButton();
            this.list_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_exit)).BeginInit();
            this.list_navigation.SuspendLayout();
            this.list_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_search)).BeginInit();
            this.list_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // list_menu
            // 
            this.list_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.list_menu.Controls.Add(this.login_exit);
            this.list_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_menu.Location = new System.Drawing.Point(0, 0);
            this.list_menu.Name = "list_menu";
            this.list_menu.Size = new System.Drawing.Size(941, 33);
            this.list_menu.TabIndex = 0;
            // 
            // login_exit
            // 
            this.login_exit.BackColor = System.Drawing.Color.SeaGreen;
            this.login_exit.Image = ((System.Drawing.Image)(resources.GetObject("login_exit.Image")));
            this.login_exit.ImageActive = null;
            this.login_exit.Location = new System.Drawing.Point(913, 5);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(25, 22);
            this.login_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_exit.TabIndex = 7;
            this.login_exit.TabStop = false;
            this.login_exit.Zoom = 10;
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click_1);
            // 
            // list_navigation
            // 
            this.list_navigation.BackColor = System.Drawing.Color.White;
            this.list_navigation.Controls.Add(this.btn_contract);
            this.list_navigation.Controls.Add(this.btn_home);
            this.list_navigation.Controls.Add(this.list_logo);
            this.list_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_navigation.Location = new System.Drawing.Point(0, 33);
            this.list_navigation.Name = "list_navigation";
            this.list_navigation.Size = new System.Drawing.Size(204, 451);
            this.list_navigation.TabIndex = 1;
            this.list_navigation.Paint += new System.Windows.Forms.PaintEventHandler(this.list_navigation_Paint);
            // 
            // list_logo
            // 
            this.list_logo.AutoSize = true;
            this.list_logo.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_logo.Location = new System.Drawing.Point(29, 3);
            this.list_logo.Name = "list_logo";
            this.list_logo.Size = new System.Drawing.Size(144, 61);
            this.list_logo.TabIndex = 0;
            this.list_logo.Text = "IHRM";
            // 
            // list_home
            // 
            this.list_home.BackColor = System.Drawing.Color.White;
            this.list_home.Controls.Add(this.list_contract);
            this.list_home.Controls.Add(this.list_search);
            this.list_home.Controls.Add(this.login_username);
            this.list_home.Controls.Add(this.bunifuCustomDataGrid1);
            this.list_home.Controls.Add(this.list_modify);
            this.list_home.Controls.Add(this.list_delete);
            this.list_home.Controls.Add(this.list_add);
            this.list_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.list_home.Location = new System.Drawing.Point(204, 33);
            this.list_home.Name = "list_home";
            this.list_home.Size = new System.Drawing.Size(737, 451);
            this.list_home.TabIndex = 0;
            this.list_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // list_add
            // 
            this.list_add.ActiveBorderThickness = 1;
            this.list_add.ActiveCornerRadius = 20;
            this.list_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.list_add.ActiveForecolor = System.Drawing.Color.White;
            this.list_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.list_add.BackColor = System.Drawing.Color.White;
            this.list_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("list_add.BackgroundImage")));
            this.list_add.ButtonText = "Add";
            this.list_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.list_add.IdleBorderThickness = 1;
            this.list_add.IdleCornerRadius = 20;
            this.list_add.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.list_add.IdleForecolor = System.Drawing.Color.White;
            this.list_add.IdleLineColor = System.Drawing.Color.White;
            this.list_add.Location = new System.Drawing.Point(5, 8);
            this.list_add.Margin = new System.Windows.Forms.Padding(5);
            this.list_add.Name = "list_add";
            this.list_add.Size = new System.Drawing.Size(98, 49);
            this.list_add.TabIndex = 3;
            this.list_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_delete
            // 
            this.list_delete.ActiveBorderThickness = 1;
            this.list_delete.ActiveCornerRadius = 20;
            this.list_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.list_delete.ActiveForecolor = System.Drawing.Color.White;
            this.list_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.list_delete.BackColor = System.Drawing.Color.White;
            this.list_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("list_delete.BackgroundImage")));
            this.list_delete.ButtonText = "Delete";
            this.list_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.list_delete.IdleBorderThickness = 1;
            this.list_delete.IdleCornerRadius = 20;
            this.list_delete.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.list_delete.IdleForecolor = System.Drawing.Color.White;
            this.list_delete.IdleLineColor = System.Drawing.Color.White;
            this.list_delete.Location = new System.Drawing.Point(113, 8);
            this.list_delete.Margin = new System.Windows.Forms.Padding(5);
            this.list_delete.Name = "list_delete";
            this.list_delete.Size = new System.Drawing.Size(98, 49);
            this.list_delete.TabIndex = 4;
            this.list_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_modify
            // 
            this.list_modify.ActiveBorderThickness = 1;
            this.list_modify.ActiveCornerRadius = 20;
            this.list_modify.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.list_modify.ActiveForecolor = System.Drawing.Color.White;
            this.list_modify.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.list_modify.BackColor = System.Drawing.Color.White;
            this.list_modify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("list_modify.BackgroundImage")));
            this.list_modify.ButtonText = "Modify";
            this.list_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_modify.ForeColor = System.Drawing.Color.SeaGreen;
            this.list_modify.IdleBorderThickness = 1;
            this.list_modify.IdleCornerRadius = 20;
            this.list_modify.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.list_modify.IdleForecolor = System.Drawing.Color.White;
            this.list_modify.IdleLineColor = System.Drawing.Color.White;
            this.list_modify.Location = new System.Drawing.Point(221, 8);
            this.list_modify.Margin = new System.Windows.Forms.Padding(5);
            this.list_modify.Name = "list_modify";
            this.list_modify.Size = new System.Drawing.Size(98, 49);
            this.list_modify.TabIndex = 5;
            this.list_modify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(7, 65);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(719, 374);
            this.bunifuCustomDataGrid1.TabIndex = 6;
            // 
            // login_username
            // 
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_username.HintForeColor = System.Drawing.Color.Empty;
            this.login_username.HintText = "Enter Site Id to Search";
            this.login_username.isPassword = false;
            this.login_username.LineFocusedColor = System.Drawing.Color.Green;
            this.login_username.LineIdleColor = System.Drawing.Color.Gray;
            this.login_username.LineMouseHoverColor = System.Drawing.Color.Green;
            this.login_username.LineThickness = 3;
            this.login_username.Location = new System.Drawing.Point(393, 17);
            this.login_username.Margin = new System.Windows.Forms.Padding(4);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(268, 31);
            this.login_username.TabIndex = 7;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // list_search
            // 
            this.list_search.BackColor = System.Drawing.Color.Transparent;
            this.list_search.Image = global::IHRM.Properties.Resources.search;
            this.list_search.ImageActive = null;
            this.list_search.Location = new System.Drawing.Point(668, 8);
            this.list_search.Name = "list_search";
            this.list_search.Size = new System.Drawing.Size(34, 40);
            this.list_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.list_search.TabIndex = 8;
            this.list_search.TabStop = false;
            this.list_search.Zoom = 10;
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "bunifuFlatButton1";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 90D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(3, 94);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = false;
            this.btn_home.Size = new System.Drawing.Size(201, 48);
            this.btn_home.TabIndex = 9;
            this.btn_home.Text = "bunifuFlatButton1";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.White;
            this.btn_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // list_contract
            // 
            this.list_contract.BackColor = System.Drawing.Color.White;
            this.list_contract.Controls.Add(this.bunifuImageButton1);
            this.list_contract.Controls.Add(this.bunifuMaterialTextbox1);
            this.list_contract.Controls.Add(this.bunifuCustomDataGrid2);
            this.list_contract.Controls.Add(this.bunifuThinButton21);
            this.list_contract.Controls.Add(this.bunifuThinButton22);
            this.list_contract.Controls.Add(this.bunifuThinButton23);
            this.list_contract.Dock = System.Windows.Forms.DockStyle.Right;
            this.list_contract.Location = new System.Drawing.Point(0, 0);
            this.list_contract.Name = "list_contract";
            this.list_contract.Size = new System.Drawing.Size(737, 451);
            this.list_contract.TabIndex = 9;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::IHRM.Properties.Resources.search;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(668, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Enter Site Id to Search";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Green;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(393, 17);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(268, 31);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(6, 65);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(719, 374);
            this.bunifuCustomDataGrid2.TabIndex = 6;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Modify";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(286, 8);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(98, 49);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Delete";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.Location = new System.Drawing.Point(113, 8);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(98, 49);
            this.bunifuThinButton22.TabIndex = 4;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Add";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(7, 8);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(98, 49);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_contract
            // 
            this.btn_contract.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_contract.BorderRadius = 0;
            this.btn_contract.ButtonText = "bunifuFlatButton2";
            this.btn_contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contract.DisabledColor = System.Drawing.Color.Gray;
            this.btn_contract.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_contract.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_contract.Iconimage")));
            this.btn_contract.Iconimage_right = null;
            this.btn_contract.Iconimage_right_Selected = null;
            this.btn_contract.Iconimage_Selected = null;
            this.btn_contract.IconMarginLeft = 0;
            this.btn_contract.IconMarginRight = 0;
            this.btn_contract.IconRightVisible = true;
            this.btn_contract.IconRightZoom = 0D;
            this.btn_contract.IconVisible = true;
            this.btn_contract.IconZoom = 90D;
            this.btn_contract.IsTab = false;
            this.btn_contract.Location = new System.Drawing.Point(3, 148);
            this.btn_contract.Name = "btn_contract";
            this.btn_contract.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_contract.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_contract.selected = false;
            this.btn_contract.Size = new System.Drawing.Size(201, 48);
            this.btn_contract.TabIndex = 10;
            this.btn_contract.Text = "bunifuFlatButton2";
            this.btn_contract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contract.Textcolor = System.Drawing.Color.White;
            this.btn_contract.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contract.Click += new System.EventHandler(this.btn_contract_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.list_home);
            this.Controls.Add(this.list_navigation);
            this.Controls.Add(this.list_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.list_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.login_exit)).EndInit();
            this.list_navigation.ResumeLayout(false);
            this.list_navigation.PerformLayout();
            this.list_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_search)).EndInit();
            this.list_contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel list_menu;
        private System.Windows.Forms.Panel list_navigation;
        private System.Windows.Forms.Panel list_home;
        private ns1.BunifuImageButton login_exit;
        private ns1.BunifuCustomLabel list_logo;
        private ns1.BunifuThinButton2 list_add;
        private ns1.BunifuThinButton2 list_modify;
        private ns1.BunifuThinButton2 list_delete;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private ns1.BunifuMaterialTextbox login_username;
        private ns1.BunifuImageButton list_search;
        private ns1.BunifuFlatButton btn_home;
        private System.Windows.Forms.Panel list_contract;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuThinButton2 bunifuThinButton23;
        private ns1.BunifuFlatButton btn_contract;
    }
}