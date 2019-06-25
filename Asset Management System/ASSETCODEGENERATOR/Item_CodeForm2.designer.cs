namespace ASSETCODEGENERATOR
{
    partial class Item_CodeForm2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbemp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmblocation = new System.Windows.Forms.ComboBox();
            this.cmbassetsubcat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbassetcat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbdivision = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwItemCode = new System.Windows.Forms.DataGridView();
            this.chbPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnfilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_po = new System.Windows.Forms.Label();
            this.lbl_formClose = new System.Windows.Forms.Label();
            this.btnall_details = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbemp
            // 
            this.cmbemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbemp.FormattingEnabled = true;
            this.cmbemp.Location = new System.Drawing.Point(251, 101);
            this.cmbemp.Name = "cmbemp";
            this.cmbemp.Size = new System.Drawing.Size(121, 21);
            this.cmbemp.TabIndex = 22;
            this.cmbemp.SelectedIndexChanged += new System.EventHandler(this.cmbemp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(163, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Division";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(163, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Location";
            // 
            // cmblocation
            // 
            this.cmblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblocation.FormattingEnabled = true;
            this.cmblocation.Location = new System.Drawing.Point(251, 51);
            this.cmblocation.Name = "cmblocation";
            this.cmblocation.Size = new System.Drawing.Size(121, 21);
            this.cmblocation.TabIndex = 27;
            this.cmblocation.SelectedIndexChanged += new System.EventHandler(this.cmblocation_SelectedIndexChanged);
            this.cmblocation.Click += new System.EventHandler(this.cmblocation_Click);
            // 
            // cmbassetsubcat
            // 
            this.cmbassetsubcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassetsubcat.FormattingEnabled = true;
            this.cmbassetsubcat.Location = new System.Drawing.Point(539, 74);
            this.cmbassetsubcat.Name = "cmbassetsubcat";
            this.cmbassetsubcat.Size = new System.Drawing.Size(121, 21);
            this.cmbassetsubcat.TabIndex = 39;
            this.cmbassetsubcat.SelectedIndexChanged += new System.EventHandler(this.cmbassetsubcat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(426, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Asset Subcategory";
            // 
            // cmbassetcat
            // 
            this.cmbassetcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbassetcat.FormattingEnabled = true;
            this.cmbassetcat.Location = new System.Drawing.Point(539, 50);
            this.cmbassetcat.Name = "cmbassetcat";
            this.cmbassetcat.Size = new System.Drawing.Size(121, 21);
            this.cmbassetcat.TabIndex = 41;
            this.cmbassetcat.SelectedIndexChanged += new System.EventHandler(this.cmbassetcat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(426, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Asset Category";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(748, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 28);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Print Bar Codes ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbdivision
            // 
            this.cmbdivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdivision.FormattingEnabled = true;
            this.cmbdivision.Location = new System.Drawing.Point(251, 75);
            this.cmbdivision.Name = "cmbdivision";
            this.cmbdivision.Size = new System.Drawing.Size(121, 21);
            this.cmbdivision.TabIndex = 24;
            this.cmbdivision.SelectedIndexChanged += new System.EventHandler(this.cmbdivision_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(163, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Employee";
            // 
            // dgwItemCode
            // 
            this.dgwItemCode.AllowUserToAddRows = false;
            this.dgwItemCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgwItemCode.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwItemCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItemCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chbPrint});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwItemCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwItemCode.Location = new System.Drawing.Point(123, 205);
            this.dgwItemCode.Name = "dgwItemCode";
            this.dgwItemCode.RowHeadersVisible = false;
            this.dgwItemCode.Size = new System.Drawing.Size(772, 169);
            this.dgwItemCode.TabIndex = 44;
            this.dgwItemCode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItemCode_CellContentClick);
            this.dgwItemCode.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwItemCode_DataBindingComplete);
            // 
            // chbPrint
            // 
            this.chbPrint.HeaderText = "Check";
            this.chbPrint.Name = "chbPrint";
            this.chbPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnfilter
            // 
            this.btnfilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(601, 171);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(145, 28);
            this.btnfilter.TabIndex = 45;
            this.btnfilter.Text = "Load Filterd Asset Details";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_po);
            this.panel1.Controls.Add(this.lbl_formClose);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 30);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_po
            // 
            this.lbl_po.AutoSize = true;
            this.lbl_po.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_po.ForeColor = System.Drawing.Color.White;
            this.lbl_po.Location = new System.Drawing.Point(3, 6);
            this.lbl_po.Name = "lbl_po";
            this.lbl_po.Size = new System.Drawing.Size(113, 17);
            this.lbl_po.TabIndex = 22;
            this.lbl_po.Text = "Print Asset Code";
            // 
            // lbl_formClose
            // 
            this.lbl_formClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formClose.AutoSize = true;
            this.lbl_formClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formClose.ForeColor = System.Drawing.Color.White;
            this.lbl_formClose.Location = new System.Drawing.Point(977, 5);
            this.lbl_formClose.Name = "lbl_formClose";
            this.lbl_formClose.Size = new System.Drawing.Size(18, 17);
            this.lbl_formClose.TabIndex = 1;
            this.lbl_formClose.Text = "X";
            this.lbl_formClose.Click += new System.EventHandler(this.lbl_formClose_Click_1);
            // 
            // btnall_details
            // 
            this.btnall_details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnall_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnall_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnall_details.Location = new System.Drawing.Point(748, 171);
            this.btnall_details.Name = "btnall_details";
            this.btnall_details.Size = new System.Drawing.Size(147, 28);
            this.btnall_details.TabIndex = 48;
            this.btnall_details.Text = "Load All Asset Details";
            this.btnall_details.UseVisualStyleBackColor = true;
            this.btnall_details.Click += new System.EventHandler(this.btnall_details_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(124, 171);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(46, 18);
            this.lblmessage.TabIndex = 49;
            this.lblmessage.Text = "label1";
            this.lblmessage.Visible = false;
            this.lblmessage.Click += new System.EventHandler(this.lblmessage_Click);
            // 
            // Item_CodeForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1004, 466);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnall_details);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.dgwItemCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbassetcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbassetsubcat);
            this.Controls.Add(this.cmblocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbdivision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_CodeForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item_CodeForm2";
            this.Load += new System.EventHandler(this.Item_CodeForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItemCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmblocation;
        private System.Windows.Forms.ComboBox cmbassetsubcat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbassetcat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbdivision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwItemCode;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chbPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_formClose;
        private System.Windows.Forms.Label lbl_po;
        private System.Windows.Forms.Button btnall_details;
        private System.Windows.Forms.Label lblmessage;
    }
}