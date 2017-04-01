namespace IHRM.List
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.settings_cpwd = new ns1.BunifuMaterialTextbox();
            this.settings_newpwd = new ns1.BunifuMaterialTextbox();
            this.settings_confimpwd = new ns1.BunifuMaterialTextbox();
            this.btn_done = new ns1.BunifuFlatButton();
            this.btn_back = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(116, 163);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = " Current Password";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(116, 215);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 18);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = " Enter New Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(116, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(132, 18);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Confirm Password";
            // 
            // settings_cpwd
            // 
            this.settings_cpwd.AccessibleDescription = " ";
            this.settings_cpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.settings_cpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.settings_cpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings_cpwd.HintForeColor = System.Drawing.Color.Empty;
            this.settings_cpwd.HintText = "";
            this.settings_cpwd.isPassword = false;
            this.settings_cpwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.settings_cpwd.LineIdleColor = System.Drawing.Color.Gray;
            this.settings_cpwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.settings_cpwd.LineThickness = 3;
            this.settings_cpwd.Location = new System.Drawing.Point(347, 137);
            this.settings_cpwd.Margin = new System.Windows.Forms.Padding(4);
            this.settings_cpwd.Name = "settings_cpwd";
            this.settings_cpwd.Size = new System.Drawing.Size(370, 44);
            this.settings_cpwd.TabIndex = 3;
            this.settings_cpwd.Text = " ";
            this.settings_cpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // settings_newpwd
            // 
            this.settings_newpwd.AccessibleDescription = " ";
            this.settings_newpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.settings_newpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.settings_newpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings_newpwd.HintForeColor = System.Drawing.Color.Empty;
            this.settings_newpwd.HintText = "";
            this.settings_newpwd.isPassword = false;
            this.settings_newpwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.settings_newpwd.LineIdleColor = System.Drawing.Color.Gray;
            this.settings_newpwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.settings_newpwd.LineThickness = 3;
            this.settings_newpwd.Location = new System.Drawing.Point(347, 189);
            this.settings_newpwd.Margin = new System.Windows.Forms.Padding(4);
            this.settings_newpwd.Name = "settings_newpwd";
            this.settings_newpwd.Size = new System.Drawing.Size(370, 44);
            this.settings_newpwd.TabIndex = 4;
            this.settings_newpwd.Text = " ";
            this.settings_newpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // settings_confimpwd
            // 
            this.settings_confimpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.settings_confimpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.settings_confimpwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings_confimpwd.HintForeColor = System.Drawing.Color.Empty;
            this.settings_confimpwd.HintText = "";
            this.settings_confimpwd.isPassword = false;
            this.settings_confimpwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.settings_confimpwd.LineIdleColor = System.Drawing.Color.Gray;
            this.settings_confimpwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.settings_confimpwd.LineThickness = 3;
            this.settings_confimpwd.Location = new System.Drawing.Point(347, 250);
            this.settings_confimpwd.Margin = new System.Windows.Forms.Padding(4);
            this.settings_confimpwd.Name = "settings_confimpwd";
            this.settings_confimpwd.Size = new System.Drawing.Size(370, 44);
            this.settings_confimpwd.TabIndex = 5;
            this.settings_confimpwd.Text = "  ";
            this.settings_confimpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_done
            // 
            this.btn_done.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_done.BorderRadius = 0;
            this.btn_done.ButtonText = " Done";
            this.btn_done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_done.DisabledColor = System.Drawing.Color.Gray;
            this.btn_done.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_done.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_done.Iconimage")));
            this.btn_done.Iconimage_right = null;
            this.btn_done.Iconimage_right_Selected = null;
            this.btn_done.Iconimage_Selected = null;
            this.btn_done.IconMarginLeft = 0;
            this.btn_done.IconMarginRight = 0;
            this.btn_done.IconRightVisible = true;
            this.btn_done.IconRightZoom = 0D;
            this.btn_done.IconVisible = true;
            this.btn_done.IconZoom = 90D;
            this.btn_done.IsTab = false;
            this.btn_done.Location = new System.Drawing.Point(522, 371);
            this.btn_done.Name = "btn_done";
            this.btn_done.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_done.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_done.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_done.selected = false;
            this.btn_done.Size = new System.Drawing.Size(132, 38);
            this.btn_done.TabIndex = 6;
            this.btn_done.Text = " Done";
            this.btn_done.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_done.Textcolor = System.Drawing.Color.White;
            this.btn_done.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_back
            // 
            this.btn_back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.BorderRadius = 0;
            this.btn_back.ButtonText = " Back";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledColor = System.Drawing.Color.Gray;
            this.btn_back.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_back.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_back.Iconimage")));
            this.btn_back.Iconimage_right = null;
            this.btn_back.Iconimage_right_Selected = null;
            this.btn_back.Iconimage_Selected = null;
            this.btn_back.IconMarginLeft = 0;
            this.btn_back.IconMarginRight = 0;
            this.btn_back.IconRightVisible = true;
            this.btn_back.IconRightZoom = 0D;
            this.btn_back.IconVisible = true;
            this.btn_back.IconZoom = 90D;
            this.btn_back.IsTab = false;
            this.btn_back.Location = new System.Drawing.Point(175, 371);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_back.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(132, 38);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = " Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Textcolor = System.Drawing.Color.White;
            this.btn_back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(50, 64);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 24);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = " Settings";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 488);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.settings_confimpwd);
            this.Controls.Add(this.settings_newpwd);
            this.Controls.Add(this.settings_cpwd);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuFlatButton btn_back;
        private ns1.BunifuFlatButton btn_done;
        private ns1.BunifuMaterialTextbox settings_confimpwd;
        private ns1.BunifuMaterialTextbox settings_newpwd;
        private ns1.BunifuMaterialTextbox settings_cpwd;
    }
}