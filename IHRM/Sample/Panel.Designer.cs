namespace IHRM.Sample
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.panel_contract = new System.Windows.Forms.Panel();
            this.contract_search = new ns1.BunifuMaterialTextbox();
            this.contract_Datagrid = new ns1.BunifuCustomDataGrid();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.contract_searchBtn = new ns1.BunifuImageButton();
            this.contract_modify = new ns1.BunifuThinButton2();
            this.contract_delete = new ns1.BunifuThinButton2();
            this.contract_add = new ns1.BunifuThinButton2();
            this.panel_contract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contract_Datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_searchBtn)).BeginInit();
            this.SuspendLayout();
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
            this.panel_contract.Location = new System.Drawing.Point(279, 0);
            this.panel_contract.Name = "panel_contract";
            this.panel_contract.Size = new System.Drawing.Size(737, 491);
            this.panel_contract.TabIndex = 10;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 491);
            this.Controls.Add(this.panel_contract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel";
            this.Text = "Panel";
            this.panel_contract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contract_Datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contract_searchBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contract;
        private ns1.BunifuImageButton contract_searchBtn;
        private ns1.BunifuMaterialTextbox contract_search;
        private ns1.BunifuCustomDataGrid contract_Datagrid;
        private ns1.BunifuThinButton2 contract_modify;
        private ns1.BunifuThinButton2 contract_delete;
        private ns1.BunifuThinButton2 contract_add;
        private ns1.BunifuElipse bunifuElipse1;
    }
}