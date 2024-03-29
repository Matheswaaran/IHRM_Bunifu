﻿namespace IHRM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.login_menu = new System.Windows.Forms.Panel();
            this.login_picture = new System.Windows.Forms.Panel();
            this.login_username = new ns1.BunifuMaterialTextbox();
            this.login_password = new ns1.BunifuMaterialTextbox();
            this.login_label2 = new ns1.BunifuCustomLabel();
            this.login_label3 = new ns1.BunifuCustomLabel();
            this.login_forgot = new System.Windows.Forms.LinkLabel();
            this.login_label1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.enter = new System.Windows.Forms.Button();
            this.login_reset = new ns1.BunifuThinButton2();
            this.login_contact = new ns1.BunifuThinButton2();
            this.login_about = new ns1.BunifuThinButton2();
            this.login_loginBtn = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_exit = new ns1.BunifuImageButton();
            this.login_menu.SuspendLayout();
            this.login_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // login_menu
            // 
            this.login_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.login_menu.Controls.Add(this.login_exit);
            this.login_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_menu.Location = new System.Drawing.Point(0, 0);
            this.login_menu.Name = "login_menu";
            this.login_menu.Size = new System.Drawing.Size(941, 29);
            this.login_menu.TabIndex = 0;
            // 
            // login_picture
            // 
            this.login_picture.Controls.Add(this.pictureBox1);
            this.login_picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.login_picture.Location = new System.Drawing.Point(0, 29);
            this.login_picture.Name = "login_picture";
            this.login_picture.Size = new System.Drawing.Size(621, 460);
            this.login_picture.TabIndex = 1;
            // 
            // login_username
            // 
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_username.HintForeColor = System.Drawing.Color.Empty;
            this.login_username.HintText = "";
            this.login_username.isPassword = false;
            this.login_username.LineFocusedColor = System.Drawing.Color.Green;
            this.login_username.LineIdleColor = System.Drawing.Color.Gray;
            this.login_username.LineMouseHoverColor = System.Drawing.Color.Green;
            this.login_username.LineThickness = 3;
            this.login_username.Location = new System.Drawing.Point(653, 158);
            this.login_username.Margin = new System.Windows.Forms.Padding(4);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(268, 31);
            this.login_username.TabIndex = 0;
            this.login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // login_password
            // 
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_password.HintForeColor = System.Drawing.Color.Empty;
            this.login_password.HintText = "";
            this.login_password.isPassword = true;
            this.login_password.LineFocusedColor = System.Drawing.Color.Green;
            this.login_password.LineIdleColor = System.Drawing.Color.Gray;
            this.login_password.LineMouseHoverColor = System.Drawing.Color.Green;
            this.login_password.LineThickness = 3;
            this.login_password.Location = new System.Drawing.Point(653, 231);
            this.login_password.Margin = new System.Windows.Forms.Padding(4);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(268, 31);
            this.login_password.TabIndex = 1;
            this.login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login_password.OnValueChanged += new System.EventHandler(this.login_password_OnValueChanged);
            // 
            // login_label2
            // 
            this.login_label2.AutoSize = true;
            this.login_label2.Location = new System.Drawing.Point(650, 141);
            this.login_label2.Name = "login_label2";
            this.login_label2.Size = new System.Drawing.Size(55, 13);
            this.login_label2.TabIndex = 4;
            this.login_label2.Text = "Username";
            // 
            // login_label3
            // 
            this.login_label3.AutoSize = true;
            this.login_label3.Location = new System.Drawing.Point(650, 214);
            this.login_label3.Name = "login_label3";
            this.login_label3.Size = new System.Drawing.Size(53, 13);
            this.login_label3.TabIndex = 5;
            this.login_label3.Text = "Password";
            // 
            // login_forgot
            // 
            this.login_forgot.AutoSize = true;
            this.login_forgot.Location = new System.Drawing.Point(650, 286);
            this.login_forgot.Name = "login_forgot";
            this.login_forgot.Size = new System.Drawing.Size(92, 13);
            this.login_forgot.TabIndex = 4;
            this.login_forgot.TabStop = true;
            this.login_forgot.Text = "Forgot Password?";
            this.login_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_forgot_LinkClicked);
            // 
            // login_label1
            // 
            this.login_label1.AutoSize = true;
            this.login_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label1.Location = new System.Drawing.Point(647, 53);
            this.login_label1.Name = "login_label1";
            this.login_label1.Size = new System.Drawing.Size(86, 33);
            this.login_label1.TabIndex = 7;
            this.login_label1.Text = "Login";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(650, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(210, 13);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Enter your Username and Password below.";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(653, 330);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(0, 0);
            this.enter.TabIndex = 1;
            this.enter.Text = " login";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // login_reset
            // 
            this.login_reset.ActiveBorderThickness = 1;
            this.login_reset.ActiveCornerRadius = 20;
            this.login_reset.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.login_reset.ActiveForecolor = System.Drawing.Color.White;
            this.login_reset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login_reset.BackColor = System.Drawing.Color.White;
            this.login_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_reset.BackgroundImage")));
            this.login_reset.ButtonText = "Reset";
            this.login_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_reset.ForeColor = System.Drawing.Color.SeaGreen;
            this.login_reset.IdleBorderThickness = 1;
            this.login_reset.IdleCornerRadius = 20;
            this.login_reset.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.login_reset.IdleForecolor = System.Drawing.Color.White;
            this.login_reset.IdleLineColor = System.Drawing.Color.White;
            this.login_reset.Location = new System.Drawing.Point(823, 330);
            this.login_reset.Margin = new System.Windows.Forms.Padding(5);
            this.login_reset.Name = "login_reset";
            this.login_reset.Size = new System.Drawing.Size(98, 49);
            this.login_reset.TabIndex = 3;
            this.login_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_reset.Click += new System.EventHandler(this.login_reset_Click);
            // 
            // login_contact
            // 
            this.login_contact.ActiveBorderThickness = 1;
            this.login_contact.ActiveCornerRadius = 20;
            this.login_contact.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.login_contact.ActiveForecolor = System.Drawing.Color.White;
            this.login_contact.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login_contact.BackColor = System.Drawing.Color.White;
            this.login_contact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_contact.BackgroundImage")));
            this.login_contact.ButtonText = "Contact Us";
            this.login_contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_contact.ForeColor = System.Drawing.Color.SeaGreen;
            this.login_contact.IdleBorderThickness = 1;
            this.login_contact.IdleCornerRadius = 20;
            this.login_contact.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.login_contact.IdleForecolor = System.Drawing.Color.White;
            this.login_contact.IdleLineColor = System.Drawing.Color.White;
            this.login_contact.Location = new System.Drawing.Point(801, 424);
            this.login_contact.Margin = new System.Windows.Forms.Padding(5);
            this.login_contact.Name = "login_contact";
            this.login_contact.Size = new System.Drawing.Size(120, 51);
            this.login_contact.TabIndex = 6;
            this.login_contact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_about
            // 
            this.login_about.ActiveBorderThickness = 1;
            this.login_about.ActiveCornerRadius = 20;
            this.login_about.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.login_about.ActiveForecolor = System.Drawing.Color.White;
            this.login_about.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login_about.BackColor = System.Drawing.Color.White;
            this.login_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_about.BackgroundImage")));
            this.login_about.ButtonText = "About Us";
            this.login_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_about.ForeColor = System.Drawing.Color.SeaGreen;
            this.login_about.IdleBorderThickness = 1;
            this.login_about.IdleCornerRadius = 20;
            this.login_about.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.login_about.IdleForecolor = System.Drawing.Color.White;
            this.login_about.IdleLineColor = System.Drawing.Color.White;
            this.login_about.Location = new System.Drawing.Point(674, 424);
            this.login_about.Margin = new System.Windows.Forms.Padding(5);
            this.login_about.Name = "login_about";
            this.login_about.Size = new System.Drawing.Size(117, 51);
            this.login_about.TabIndex = 5;
            this.login_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_about.Click += new System.EventHandler(this.login_about_Click);
            // 
            // login_loginBtn
            // 
            this.login_loginBtn.ActiveBorderThickness = 1;
            this.login_loginBtn.ActiveCornerRadius = 20;
            this.login_loginBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.login_loginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.login_loginBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.login_loginBtn.BackColor = System.Drawing.Color.White;
            this.login_loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_loginBtn.BackgroundImage")));
            this.login_loginBtn.ButtonText = "Login";
            this.login_loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_loginBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.login_loginBtn.IdleBorderThickness = 1;
            this.login_loginBtn.IdleCornerRadius = 20;
            this.login_loginBtn.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.login_loginBtn.IdleForecolor = System.Drawing.Color.White;
            this.login_loginBtn.IdleLineColor = System.Drawing.Color.White;
            this.login_loginBtn.Location = new System.Drawing.Point(823, 271);
            this.login_loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.login_loginBtn.Name = "login_loginBtn";
            this.login_loginBtn.Size = new System.Drawing.Size(98, 49);
            this.login_loginBtn.TabIndex = 2;
            this.login_loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_loginBtn.Click += new System.EventHandler(this.login_loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IHRM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_exit
            // 
            this.login_exit.BackColor = System.Drawing.Color.SeaGreen;
            this.login_exit.Image = ((System.Drawing.Image)(resources.GetObject("login_exit.Image")));
            this.login_exit.ImageActive = null;
            this.login_exit.Location = new System.Drawing.Point(913, 3);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(25, 22);
            this.login_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_exit.TabIndex = 6;
            this.login_exit.TabStop = false;
            this.login_exit.Zoom = 10;
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 489);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.login_reset);
            this.Controls.Add(this.login_contact);
            this.Controls.Add(this.login_about);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.login_label1);
            this.Controls.Add(this.login_forgot);
            this.Controls.Add(this.login_label3);
            this.Controls.Add(this.login_label2);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.login_loginBtn);
            this.Controls.Add(this.login_picture);
            this.Controls.Add(this.login_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.login_menu.ResumeLayout(false);
            this.login_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel login_picture;
        private System.Windows.Forms.Panel login_menu;
        private ns1.BunifuThinButton2 login_loginBtn;
        private ns1.BunifuMaterialTextbox login_password;
        private ns1.BunifuMaterialTextbox login_username;
        private ns1.BunifuCustomLabel login_label3;
        private ns1.BunifuCustomLabel login_label2;
        private ns1.BunifuImageButton login_exit;
        private System.Windows.Forms.LinkLabel login_forgot;
        private ns1.BunifuCustomLabel login_label1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuThinButton2 login_contact;
        private ns1.BunifuThinButton2 login_about;
        private ns1.BunifuThinButton2 login_reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button enter;
    }
}

