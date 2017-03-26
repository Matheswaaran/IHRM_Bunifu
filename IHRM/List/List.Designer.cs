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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.list_exit = new ns1.BunifuImageButton();
            this.panel_navigation = new System.Windows.Forms.Panel();
            this.btn_site = new ns1.BunifuFlatButton();
            this.btn_setting = new ns1.BunifuFlatButton();
            this.btn_empVerification = new ns1.BunifuFlatButton();
            this.btn_employee = new ns1.BunifuFlatButton();
            this.btn_supervisour = new ns1.BunifuFlatButton();
            this.btn_contract = new ns1.BunifuFlatButton();
            this.btn_home = new ns1.BunifuFlatButton();
            this.list_logo = new ns1.BunifuCustomLabel();
            this.panel_home = new System.Windows.Forms.Panel();
            this.panel_contract = new System.Windows.Forms.Panel();
            this.contract_searchBtn = new ns1.BunifuImageButton();
            this.contract_search = new ns1.BunifuMaterialTextbox();
            this.contract_Datagrid = new ns1.BunifuCustomDataGrid();
            this.contract_modify = new ns1.BunifuThinButton2();
            this.contract_delete = new ns1.BunifuThinButton2();
            this.contract_add = new ns1.BunifuThinButton2();
            this.site_searchBtn = new ns1.BunifuImageButton();
            this.site_search = new ns1.BunifuMaterialTextbox();
            this.site_Datagrid = new ns1.BunifuCustomDataGrid();
            this.site_modify = new ns1.BunifuThinButton2();
            this.site_delete = new ns1.BunifuThinButton2();
            this.site_add = new ns1.BunifuThinButton2();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_exit)).BeginInit();
            this.panel_navigation.SuspendLayout();
            this.panel_home.SuspendLayout();
            this.panel_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contract_searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_searchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_menu.Controls.Add(this.list_exit);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(941, 33);
            this.panel_menu.TabIndex = 0;
            // 
            // list_exit
            // 
            this.list_exit.BackColor = System.Drawing.Color.SeaGreen;
            this.list_exit.Image = ((System.Drawing.Image)(resources.GetObject("list_exit.Image")));
            this.list_exit.ImageActive = null;
            this.list_exit.Location = new System.Drawing.Point(913, 5);
            this.list_exit.Name = "list_exit";
            this.list_exit.Size = new System.Drawing.Size(25, 22);
            this.list_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.list_exit.TabIndex = 7;
            this.list_exit.TabStop = false;
            this.list_exit.Zoom = 10;
            this.list_exit.Click += new System.EventHandler(this.list_exit_Click);
            // 
            // panel_navigation
            // 
            this.panel_navigation.BackColor = System.Drawing.Color.White;
            this.panel_navigation.Controls.Add(this.btn_site);
            this.panel_navigation.Controls.Add(this.btn_setting);
            this.panel_navigation.Controls.Add(this.btn_empVerification);
            this.panel_navigation.Controls.Add(this.btn_employee);
            this.panel_navigation.Controls.Add(this.btn_supervisour);
            this.panel_navigation.Controls.Add(this.btn_contract);
            this.panel_navigation.Controls.Add(this.btn_home);
            this.panel_navigation.Controls.Add(this.list_logo);
            this.panel_navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navigation.Location = new System.Drawing.Point(0, 33);
            this.panel_navigation.Name = "panel_navigation";
            this.panel_navigation.Size = new System.Drawing.Size(204, 451);
            this.panel_navigation.TabIndex = 1;
            this.panel_navigation.Paint += new System.Windows.Forms.PaintEventHandler(this.list_navigation_Paint);
            // 
            // btn_site
            // 
            this.btn_site.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_site.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_site.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_site.BorderRadius = 0;
            this.btn_site.ButtonText = " Logout";
            this.btn_site.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_site.DisabledColor = System.Drawing.Color.Gray;
            this.btn_site.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_site.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_site.Iconimage")));
            this.btn_site.Iconimage_right = null;
            this.btn_site.Iconimage_right_Selected = null;
            this.btn_site.Iconimage_Selected = null;
            this.btn_site.IconMarginLeft = 0;
            this.btn_site.IconMarginRight = 0;
            this.btn_site.IconRightVisible = true;
            this.btn_site.IconRightZoom = 0D;
            this.btn_site.IconVisible = true;
            this.btn_site.IconZoom = 90D;
            this.btn_site.IsTab = false;
            this.btn_site.Location = new System.Drawing.Point(2, 400);
            this.btn_site.Name = "btn_site";
            this.btn_site.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_site.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_site.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_site.selected = false;
            this.btn_site.Size = new System.Drawing.Size(201, 48);
            this.btn_site.TabIndex = 15;
            this.btn_site.Text = " Logout";
            this.btn_site.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_site.Textcolor = System.Drawing.Color.White;
            this.btn_site.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_setting
            // 
            this.btn_setting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_setting.BorderRadius = 0;
            this.btn_setting.ButtonText = " Settings";
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.DisabledColor = System.Drawing.Color.Gray;
            this.btn_setting.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_setting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_setting.Iconimage")));
            this.btn_setting.Iconimage_right = null;
            this.btn_setting.Iconimage_right_Selected = null;
            this.btn_setting.Iconimage_Selected = null;
            this.btn_setting.IconMarginLeft = 0;
            this.btn_setting.IconMarginRight = 0;
            this.btn_setting.IconRightVisible = true;
            this.btn_setting.IconRightZoom = 0D;
            this.btn_setting.IconVisible = true;
            this.btn_setting.IconZoom = 90D;
            this.btn_setting.IsTab = false;
            this.btn_setting.Location = new System.Drawing.Point(2, 350);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_setting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_setting.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_setting.selected = false;
            this.btn_setting.Size = new System.Drawing.Size(201, 48);
            this.btn_setting.TabIndex = 14;
            this.btn_setting.Text = " Settings";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Textcolor = System.Drawing.Color.White;
            this.btn_setting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_empVerification
            // 
            this.btn_empVerification.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_empVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_empVerification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_empVerification.BorderRadius = 0;
            this.btn_empVerification.ButtonText = " Employee Verfication";
            this.btn_empVerification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empVerification.DisabledColor = System.Drawing.Color.Gray;
            this.btn_empVerification.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_empVerification.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_empVerification.Iconimage")));
            this.btn_empVerification.Iconimage_right = null;
            this.btn_empVerification.Iconimage_right_Selected = null;
            this.btn_empVerification.Iconimage_Selected = null;
            this.btn_empVerification.IconMarginLeft = 0;
            this.btn_empVerification.IconMarginRight = 0;
            this.btn_empVerification.IconRightVisible = true;
            this.btn_empVerification.IconRightZoom = 0D;
            this.btn_empVerification.IconVisible = true;
            this.btn_empVerification.IconZoom = 90D;
            this.btn_empVerification.IsTab = false;
            this.btn_empVerification.Location = new System.Drawing.Point(3, 300);
            this.btn_empVerification.Name = "btn_empVerification";
            this.btn_empVerification.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_empVerification.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_empVerification.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_empVerification.selected = false;
            this.btn_empVerification.Size = new System.Drawing.Size(201, 48);
            this.btn_empVerification.TabIndex = 13;
            this.btn_empVerification.Text = " Employee Verfication";
            this.btn_empVerification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empVerification.Textcolor = System.Drawing.Color.White;
            this.btn_empVerification.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_employee
            // 
            this.btn_employee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_employee.BorderRadius = 0;
            this.btn_employee.ButtonText = " Employee List";
            this.btn_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_employee.DisabledColor = System.Drawing.Color.Gray;
            this.btn_employee.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_employee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_employee.Iconimage")));
            this.btn_employee.Iconimage_right = null;
            this.btn_employee.Iconimage_right_Selected = null;
            this.btn_employee.Iconimage_Selected = null;
            this.btn_employee.IconMarginLeft = 0;
            this.btn_employee.IconMarginRight = 0;
            this.btn_employee.IconRightVisible = true;
            this.btn_employee.IconRightZoom = 0D;
            this.btn_employee.IconVisible = true;
            this.btn_employee.IconZoom = 90D;
            this.btn_employee.IsTab = false;
            this.btn_employee.Location = new System.Drawing.Point(2, 250);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_employee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_employee.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_employee.selected = false;
            this.btn_employee.Size = new System.Drawing.Size(201, 48);
            this.btn_employee.TabIndex = 12;
            this.btn_employee.Text = " Employee List";
            this.btn_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee.Textcolor = System.Drawing.Color.White;
            this.btn_employee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_supervisour
            // 
            this.btn_supervisour.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_supervisour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_supervisour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supervisour.BorderRadius = 0;
            this.btn_supervisour.ButtonText = "Sipervisor List";
            this.btn_supervisour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supervisour.DisabledColor = System.Drawing.Color.Gray;
            this.btn_supervisour.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_supervisour.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_supervisour.Iconimage")));
            this.btn_supervisour.Iconimage_right = null;
            this.btn_supervisour.Iconimage_right_Selected = null;
            this.btn_supervisour.Iconimage_Selected = null;
            this.btn_supervisour.IconMarginLeft = 0;
            this.btn_supervisour.IconMarginRight = 0;
            this.btn_supervisour.IconRightVisible = true;
            this.btn_supervisour.IconRightZoom = 0D;
            this.btn_supervisour.IconVisible = true;
            this.btn_supervisour.IconZoom = 90D;
            this.btn_supervisour.IsTab = false;
            this.btn_supervisour.Location = new System.Drawing.Point(2, 200);
            this.btn_supervisour.Name = "btn_supervisour";
            this.btn_supervisour.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_supervisour.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_supervisour.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supervisour.selected = false;
            this.btn_supervisour.Size = new System.Drawing.Size(201, 48);
            this.btn_supervisour.TabIndex = 11;
            this.btn_supervisour.Text = "Sipervisor List";
            this.btn_supervisour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supervisour.Textcolor = System.Drawing.Color.White;
            this.btn_supervisour.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_contract
            // 
            this.btn_contract.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_contract.BorderRadius = 0;
            this.btn_contract.ButtonText = "Contractor List";
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
            this.btn_contract.Location = new System.Drawing.Point(3, 150);
            this.btn_contract.Name = "btn_contract";
            this.btn_contract.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_contract.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_contract.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_contract.selected = false;
            this.btn_contract.Size = new System.Drawing.Size(201, 48);
            this.btn_contract.TabIndex = 10;
            this.btn_contract.Text = "Contractor List";
            this.btn_contract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contract.Textcolor = System.Drawing.Color.White;
            this.btn_contract.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contract.Click += new System.EventHandler(this.btn_contract_Click);
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "Site List";
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
            this.btn_home.Location = new System.Drawing.Point(3, 100);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_home.selected = false;
            this.btn_home.Size = new System.Drawing.Size(200, 48);
            this.btn_home.TabIndex = 9;
            this.btn_home.Text = "Site List";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.White;
            this.btn_home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // list_logo
            // 
            this.list_logo.AutoSize = true;
            this.list_logo.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_logo.Location = new System.Drawing.Point(29, 18);
            this.list_logo.Name = "list_logo";
            this.list_logo.Size = new System.Drawing.Size(144, 61);
            this.list_logo.TabIndex = 0;
            this.list_logo.Text = "IHRM";
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.White;
            this.panel_home.Controls.Add(this.panel_contract);
            this.panel_home.Controls.Add(this.site_searchBtn);
            this.panel_home.Controls.Add(this.site_search);
            this.panel_home.Controls.Add(this.site_Datagrid);
            this.panel_home.Controls.Add(this.site_modify);
            this.panel_home.Controls.Add(this.site_delete);
            this.panel_home.Controls.Add(this.site_add);
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_home.Location = new System.Drawing.Point(201, 33);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(740, 451);
            this.panel_home.TabIndex = 0;
            this.panel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel_contract
            // 
            this.panel_contract.BackColor = System.Drawing.Color.White;
            this.panel_contract.Controls.Add(this.contract_searchBtn);
            this.panel_contract.Controls.Add(this.contract_search);
            this.panel_contract.Controls.Add(this.contract_Datagrid);
            this.panel_contract.Controls.Add(this.contract_modify);
            this.panel_contract.Controls.Add(this.contract_delete);
            this.panel_contract.Controls.Add(this.contract_add);
            this.panel_contract.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_contract.Location = new System.Drawing.Point(0, 0);
            this.panel_contract.Name = "panel_contract";
            this.panel_contract.Size = new System.Drawing.Size(740, 451);
            this.panel_contract.TabIndex = 9;
            // 
            // contract_searchBtn
            // 
            this.contract_searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.contract_searchBtn.Image = global::IHRM.Properties.Resources.search;
            this.contract_searchBtn.ImageActive = null;
            this.contract_searchBtn.Location = new System.Drawing.Point(668, 8);
            this.contract_searchBtn.Name = "contract_searchBtn";
            this.contract_searchBtn.Size = new System.Drawing.Size(34, 40);
            this.contract_searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contract_searchBtn.TabIndex = 8;
            this.contract_searchBtn.TabStop = false;
            this.contract_searchBtn.Zoom = 10;
            // 
            // contract_search
            // 
            this.contract_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contract_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.contract_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contract_search.HintForeColor = System.Drawing.Color.Empty;
            this.contract_search.HintText = "Enter Contractor Id to Search";
            this.contract_search.isPassword = false;
            this.contract_search.LineFocusedColor = System.Drawing.Color.Green;
            this.contract_search.LineIdleColor = System.Drawing.Color.Gray;
            this.contract_search.LineMouseHoverColor = System.Drawing.Color.Green;
            this.contract_search.LineThickness = 3;
            this.contract_search.Location = new System.Drawing.Point(393, 17);
            this.contract_search.Margin = new System.Windows.Forms.Padding(4);
            this.contract_search.Name = "contract_search";
            this.contract_search.Size = new System.Drawing.Size(268, 31);
            this.contract_search.TabIndex = 7;
            this.contract_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contract_Datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contract_Datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contract_Datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.contract_Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contract_Datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contract_Datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contract_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contract_Datagrid.DoubleBuffered = true;
            this.contract_Datagrid.EnableHeadersVisualStyles = false;
            this.contract_Datagrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.contract_Datagrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.contract_Datagrid.Location = new System.Drawing.Point(6, 65);
            this.contract_Datagrid.Name = "contract_Datagrid";
            this.contract_Datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.contract_Datagrid.Size = new System.Drawing.Size(716, 374);
            this.contract_Datagrid.TabIndex = 6;
            // 
            // contract_modify
            // 
            this.contract_modify.ActiveBorderThickness = 1;
            this.contract_modify.ActiveCornerRadius = 20;
            this.contract_modify.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.contract_modify.ActiveForecolor = System.Drawing.Color.White;
            this.contract_modify.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.contract_modify.BackColor = System.Drawing.Color.White;
            this.contract_modify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contract_modify.BackgroundImage")));
            this.contract_modify.ButtonText = "Modify";
            this.contract_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contract_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_modify.ForeColor = System.Drawing.Color.SeaGreen;
            this.contract_modify.IdleBorderThickness = 1;
            this.contract_modify.IdleCornerRadius = 20;
            this.contract_modify.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.contract_modify.IdleForecolor = System.Drawing.Color.White;
            this.contract_modify.IdleLineColor = System.Drawing.Color.White;
            this.contract_modify.Location = new System.Drawing.Point(221, 8);
            this.contract_modify.Margin = new System.Windows.Forms.Padding(5);
            this.contract_modify.Name = "contract_modify";
            this.contract_modify.Size = new System.Drawing.Size(98, 49);
            this.contract_modify.TabIndex = 5;
            this.contract_modify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contract_delete
            // 
            this.contract_delete.ActiveBorderThickness = 1;
            this.contract_delete.ActiveCornerRadius = 20;
            this.contract_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.contract_delete.ActiveForecolor = System.Drawing.Color.White;
            this.contract_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.contract_delete.BackColor = System.Drawing.Color.White;
            this.contract_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contract_delete.BackgroundImage")));
            this.contract_delete.ButtonText = "Delete";
            this.contract_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contract_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.contract_delete.IdleBorderThickness = 1;
            this.contract_delete.IdleCornerRadius = 20;
            this.contract_delete.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.contract_delete.IdleForecolor = System.Drawing.Color.White;
            this.contract_delete.IdleLineColor = System.Drawing.Color.White;
            this.contract_delete.Location = new System.Drawing.Point(113, 8);
            this.contract_delete.Margin = new System.Windows.Forms.Padding(5);
            this.contract_delete.Name = "contract_delete";
            this.contract_delete.Size = new System.Drawing.Size(98, 49);
            this.contract_delete.TabIndex = 4;
            this.contract_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contract_add
            // 
            this.contract_add.ActiveBorderThickness = 1;
            this.contract_add.ActiveCornerRadius = 20;
            this.contract_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.contract_add.ActiveForecolor = System.Drawing.Color.White;
            this.contract_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.contract_add.BackColor = System.Drawing.Color.White;
            this.contract_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contract_add.BackgroundImage")));
            this.contract_add.ButtonText = "Add";
            this.contract_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contract_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contract_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.contract_add.IdleBorderThickness = 1;
            this.contract_add.IdleCornerRadius = 20;
            this.contract_add.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.contract_add.IdleForecolor = System.Drawing.Color.White;
            this.contract_add.IdleLineColor = System.Drawing.Color.White;
            this.contract_add.Location = new System.Drawing.Point(7, 8);
            this.contract_add.Margin = new System.Windows.Forms.Padding(5);
            this.contract_add.Name = "contract_add";
            this.contract_add.Size = new System.Drawing.Size(98, 49);
            this.contract_add.TabIndex = 3;
            this.contract_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // site_searchBtn
            // 
            this.site_searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.site_searchBtn.Image = global::IHRM.Properties.Resources.search;
            this.site_searchBtn.ImageActive = null;
            this.site_searchBtn.Location = new System.Drawing.Point(668, 8);
            this.site_searchBtn.Name = "site_searchBtn";
            this.site_searchBtn.Size = new System.Drawing.Size(34, 40);
            this.site_searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.site_searchBtn.TabIndex = 8;
            this.site_searchBtn.TabStop = false;
            this.site_searchBtn.Zoom = 10;
            // 
            // site_search
            // 
            this.site_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.site_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.site_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.site_search.HintForeColor = System.Drawing.Color.Empty;
            this.site_search.HintText = "Enter Site Id to Search";
            this.site_search.isPassword = false;
            this.site_search.LineFocusedColor = System.Drawing.Color.Green;
            this.site_search.LineIdleColor = System.Drawing.Color.Gray;
            this.site_search.LineMouseHoverColor = System.Drawing.Color.Green;
            this.site_search.LineThickness = 3;
            this.site_search.Location = new System.Drawing.Point(393, 17);
            this.site_search.Margin = new System.Windows.Forms.Padding(4);
            this.site_search.Name = "site_search";
            this.site_search.Size = new System.Drawing.Size(268, 31);
            this.site_search.TabIndex = 7;
            this.site_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.site_search.OnValueChanged += new System.EventHandler(this.login_username_OnValueChanged);
            // 
            // site_Datagrid
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.site_Datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.site_Datagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.site_Datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.site_Datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.site_Datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.site_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.site_Datagrid.DoubleBuffered = true;
            this.site_Datagrid.EnableHeadersVisualStyles = false;
            this.site_Datagrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.site_Datagrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.site_Datagrid.Location = new System.Drawing.Point(7, 65);
            this.site_Datagrid.Name = "site_Datagrid";
            this.site_Datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.site_Datagrid.Size = new System.Drawing.Size(719, 374);
            this.site_Datagrid.TabIndex = 6;
            // 
            // site_modify
            // 
            this.site_modify.ActiveBorderThickness = 1;
            this.site_modify.ActiveCornerRadius = 20;
            this.site_modify.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.site_modify.ActiveForecolor = System.Drawing.Color.White;
            this.site_modify.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.site_modify.BackColor = System.Drawing.Color.White;
            this.site_modify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("site_modify.BackgroundImage")));
            this.site_modify.ButtonText = "Modify";
            this.site_modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.site_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_modify.ForeColor = System.Drawing.Color.SeaGreen;
            this.site_modify.IdleBorderThickness = 1;
            this.site_modify.IdleCornerRadius = 20;
            this.site_modify.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.site_modify.IdleForecolor = System.Drawing.Color.White;
            this.site_modify.IdleLineColor = System.Drawing.Color.White;
            this.site_modify.Location = new System.Drawing.Point(221, 8);
            this.site_modify.Margin = new System.Windows.Forms.Padding(5);
            this.site_modify.Name = "site_modify";
            this.site_modify.Size = new System.Drawing.Size(98, 49);
            this.site_modify.TabIndex = 5;
            this.site_modify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // site_delete
            // 
            this.site_delete.ActiveBorderThickness = 1;
            this.site_delete.ActiveCornerRadius = 20;
            this.site_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.site_delete.ActiveForecolor = System.Drawing.Color.White;
            this.site_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.site_delete.BackColor = System.Drawing.Color.White;
            this.site_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("site_delete.BackgroundImage")));
            this.site_delete.ButtonText = "Delete";
            this.site_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.site_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.site_delete.IdleBorderThickness = 1;
            this.site_delete.IdleCornerRadius = 20;
            this.site_delete.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.site_delete.IdleForecolor = System.Drawing.Color.White;
            this.site_delete.IdleLineColor = System.Drawing.Color.White;
            this.site_delete.Location = new System.Drawing.Point(113, 8);
            this.site_delete.Margin = new System.Windows.Forms.Padding(5);
            this.site_delete.Name = "site_delete";
            this.site_delete.Size = new System.Drawing.Size(98, 49);
            this.site_delete.TabIndex = 4;
            this.site_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // site_add
            // 
            this.site_add.ActiveBorderThickness = 1;
            this.site_add.ActiveCornerRadius = 20;
            this.site_add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.site_add.ActiveForecolor = System.Drawing.Color.White;
            this.site_add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.site_add.BackColor = System.Drawing.Color.White;
            this.site_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("site_add.BackgroundImage")));
            this.site_add.ButtonText = "Add";
            this.site_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.site_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.site_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.site_add.IdleBorderThickness = 1;
            this.site_add.IdleCornerRadius = 20;
            this.site_add.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.site_add.IdleForecolor = System.Drawing.Color.White;
            this.site_add.IdleLineColor = System.Drawing.Color.White;
            this.site_add.Location = new System.Drawing.Point(5, 8);
            this.site_add.Margin = new System.Windows.Forms.Padding(5);
            this.site_add.Name = "site_add";
            this.site_add.Size = new System.Drawing.Size(98, 49);
            this.site_add.TabIndex = 3;
            this.site_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 484);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_navigation);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_exit)).EndInit();
            this.panel_navigation.ResumeLayout(false);
            this.panel_navigation.PerformLayout();
            this.panel_home.ResumeLayout(false);
            this.panel_contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contract_searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_searchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site_Datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_navigation;
        private System.Windows.Forms.Panel panel_home;
        private ns1.BunifuImageButton list_exit;
        private ns1.BunifuCustomLabel list_logo;
        private ns1.BunifuThinButton2 site_add;
        private ns1.BunifuThinButton2 site_modify;
        private ns1.BunifuThinButton2 site_delete;
        private ns1.BunifuCustomDataGrid site_Datagrid;
        private ns1.BunifuMaterialTextbox site_search;
        private ns1.BunifuImageButton site_searchBtn;
        private ns1.BunifuFlatButton btn_home;
        private System.Windows.Forms.Panel panel_contract;
        private ns1.BunifuImageButton contract_searchBtn;
        private ns1.BunifuMaterialTextbox contract_search;
        private ns1.BunifuCustomDataGrid contract_Datagrid;
        private ns1.BunifuThinButton2 contract_modify;
        private ns1.BunifuThinButton2 contract_delete;
        private ns1.BunifuThinButton2 contract_add;
        private ns1.BunifuFlatButton btn_contract;
        private ns1.BunifuFlatButton btn_supervisour;
        private ns1.BunifuFlatButton btn_setting;
        private ns1.BunifuFlatButton btn_empVerification;
        private ns1.BunifuFlatButton btn_employee;
        private ns1.BunifuFlatButton btn_site;
    }
}