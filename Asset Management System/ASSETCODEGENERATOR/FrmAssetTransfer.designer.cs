namespace ASSETCODEGENERATOR
{
    partial class FrmAssetTransfer
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
            this.gdwAsssetassign = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.cbdivision = new System.Windows.Forms.ComboBox();
            this.cbemployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_formClose = new System.Windows.Forms.Label();
            this.lbl_po = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcategory = new System.Windows.Forms.TextBox();
            this.tbsubcategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdwAsssetassign)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdwAsssetassign
            // 
            this.gdwAsssetassign.AllowUserToAddRows = false;
            this.gdwAsssetassign.AllowUserToDeleteRows = false;
            this.gdwAsssetassign.AllowUserToOrderColumns = true;
            this.gdwAsssetassign.AllowUserToResizeColumns = false;
            this.gdwAsssetassign.AllowUserToResizeRows = false;
            this.gdwAsssetassign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdwAsssetassign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdwAsssetassign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gdwAsssetassign.Location = new System.Drawing.Point(64, 241);
            this.gdwAsssetassign.Name = "gdwAsssetassign";
            this.gdwAsssetassign.RowHeadersVisible = false;
            this.gdwAsssetassign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdwAsssetassign.Size = new System.Drawing.Size(862, 237);
            this.gdwAsssetassign.TabIndex = 25;
            this.gdwAsssetassign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdwAsssetassign_CellClick);
            this.gdwAsssetassign.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdwAsssetassign_CellContentClick);
            this.gdwAsssetassign.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gdwAsssetassign_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "        Select";
            this.Column1.Name = "Column1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cblocation
            // 
            this.cblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(146, 59);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(134, 21);
            this.cblocation.TabIndex = 1;
            this.cblocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cblocation.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.cblocation.Click += new System.EventHandler(this.cblocation_Click);
            // 
            // cbdivision
            // 
            this.cbdivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdivision.FormattingEnabled = true;
            this.cbdivision.Location = new System.Drawing.Point(146, 96);
            this.cbdivision.Name = "cbdivision";
            this.cbdivision.Size = new System.Drawing.Size(134, 21);
            this.cbdivision.TabIndex = 2;
            this.cbdivision.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbdivision.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // cbemployee
            // 
            this.cbemployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbemployee.FormattingEnabled = true;
            this.cbemployee.Location = new System.Drawing.Point(146, 131);
            this.cbemployee.Name = "cbemployee";
            this.cbemployee.Size = new System.Drawing.Size(134, 21);
            this.cbemployee.TabIndex = 5;
            this.cbemployee.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sub Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_formClose);
            this.panel1.Controls.Add(this.lbl_po);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 33);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_formClose
            // 
            this.lbl_formClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formClose.AutoSize = true;
            this.lbl_formClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formClose.ForeColor = System.Drawing.Color.White;
            this.lbl_formClose.Location = new System.Drawing.Point(1086, 5);
            this.lbl_formClose.Name = "lbl_formClose";
            this.lbl_formClose.Size = new System.Drawing.Size(18, 17);
            this.lbl_formClose.TabIndex = 23;
            this.lbl_formClose.Text = "X";
            this.lbl_formClose.Click += new System.EventHandler(this.lbl_formClose_Click);
            // 
            // lbl_po
            // 
            this.lbl_po.AutoSize = true;
            this.lbl_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_po.ForeColor = System.Drawing.Color.White;
            this.lbl_po.Location = new System.Drawing.Point(9, 8);
            this.lbl_po.Name = "lbl_po";
            this.lbl_po.Size = new System.Drawing.Size(101, 17);
            this.lbl_po.TabIndex = 22;
            this.lbl_po.Text = "Asset Transfer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 23;
            this.label11.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 23;
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // tbcategory
            // 
            this.tbcategory.Location = new System.Drawing.Point(427, 56);
            this.tbcategory.Name = "tbcategory";
            this.tbcategory.Size = new System.Drawing.Size(134, 20);
            this.tbcategory.TabIndex = 24;
            // 
            // tbsubcategory
            // 
            this.tbsubcategory.Location = new System.Drawing.Point(427, 89);
            this.tbsubcategory.Name = "tbsubcategory";
            this.tbsubcategory.Size = new System.Drawing.Size(134, 20);
            this.tbsubcategory.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // FrmAssetTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1111, 543);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gdwAsssetassign);
            this.Controls.Add(this.tbsubcategory);
            this.Controls.Add(this.tbcategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbemployee);
            this.Controls.Add(this.cbdivision);
            this.Controls.Add(this.cblocation);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAssetTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAssetTransfer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAssetTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdwAsssetassign)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.ComboBox cbdivision;
        private System.Windows.Forms.ComboBox cbemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_formClose;
        private System.Windows.Forms.Label lbl_po;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbcategory;
        private System.Windows.Forms.TextBox tbsubcategory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        public System.Windows.Forms.DataGridView gdwAsssetassign;
        private System.Windows.Forms.Label label6;
    }
}