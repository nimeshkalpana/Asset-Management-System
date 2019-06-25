namespace ASSETCODEGENERATOR
{
    partial class frmAssignAssets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.combodivname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboempname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboasset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combosubasset = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmblocation = new System.Windows.Forms.ComboBox();
            this.gdwassignassets = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmessage6 = new System.Windows.Forms.Label();
            this.lblmessage5 = new System.Windows.Forms.Label();
            this.lblmessage4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_formClose = new System.Windows.Forms.Label();
            this.lbl_po = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdwassignassets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combodivname
            // 
            this.combodivname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodivname.FormattingEnabled = true;
            this.combodivname.Location = new System.Drawing.Point(116, 81);
            this.combodivname.Name = "combodivname";
            this.combodivname.Size = new System.Drawing.Size(121, 21);
            this.combodivname.TabIndex = 0;
            this.combodivname.SelectionChangeCommitted += new System.EventHandler(this.combodivname_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Division Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(310, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // comboempname
            // 
            this.comboempname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboempname.FormattingEnabled = true;
            this.comboempname.Location = new System.Drawing.Point(408, 51);
            this.comboempname.Name = "comboempname";
            this.comboempname.Size = new System.Drawing.Size(121, 21);
            this.comboempname.TabIndex = 3;
            this.comboempname.SelectedIndexChanged += new System.EventHandler(this.comboempname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Asset Category";
            this.label3.Visible = false;
            // 
            // comboasset
            // 
            this.comboasset.FormattingEnabled = true;
            this.comboasset.Location = new System.Drawing.Point(125, 48);
            this.comboasset.Name = "comboasset";
            this.comboasset.Size = new System.Drawing.Size(114, 21);
            this.comboasset.TabIndex = 5;
            this.comboasset.Visible = false;
            this.comboasset.SelectedIndexChanged += new System.EventHandler(this.comboasset_SelectedIndexChanged);
            this.comboasset.SelectionChangeCommitted += new System.EventHandler(this.comboasset_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subasset Category";
            this.label4.Visible = false;
            // 
            // combosubasset
            // 
            this.combosubasset.FormattingEnabled = true;
            this.combosubasset.Location = new System.Drawing.Point(123, 77);
            this.combosubasset.Name = "combosubasset";
            this.combosubasset.Size = new System.Drawing.Size(116, 21);
            this.combosubasset.TabIndex = 7;
            this.combosubasset.Visible = false;
            this.combosubasset.SelectionChangeCommitted += new System.EventHandler(this.combosubasset_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(345, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Location Name";
            // 
            // cmblocation
            // 
            this.cmblocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblocation.FormattingEnabled = true;
            this.cmblocation.Location = new System.Drawing.Point(116, 54);
            this.cmblocation.Name = "cmblocation";
            this.cmblocation.Size = new System.Drawing.Size(121, 21);
            this.cmblocation.TabIndex = 11;
            this.cmblocation.SelectedIndexChanged += new System.EventHandler(this.cmblocation_SelectedIndexChanged);
            this.cmblocation.SelectionChangeCommitted += new System.EventHandler(this.cmblocation_SelectionChangeCommitted);
            // 
            // gdwassignassets
            // 
            this.gdwassignassets.AllowUserToAddRows = false;
            this.gdwassignassets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdwassignassets.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gdwassignassets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdwassignassets.DefaultCellStyle = dataGridViewCellStyle1;
            this.gdwassignassets.Location = new System.Drawing.Point(12, 310);
            this.gdwassignassets.Name = "gdwassignassets";
            this.gdwassignassets.RowHeadersVisible = false;
            this.gdwassignassets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdwassignassets.Size = new System.Drawing.Size(931, 193);
            this.gdwassignassets.TabIndex = 15;
            this.gdwassignassets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdwassignassets_CellClick);
            this.gdwassignassets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdwassignassets_CellContentClick);
            this.gdwassignassets.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gdwassignassets_DataBindingComplete);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(605, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Assign Assets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.comboasset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combosubasset);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 121);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Category";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(17, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "PONumber";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(262, 77);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Load Line Details";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblmessage6);
            this.groupBox2.Controls.Add(this.lblmessage5);
            this.groupBox2.Controls.Add(this.lblmessage4);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmblocation);
            this.groupBox2.Controls.Add(this.combodivname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboempname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 116);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // lblmessage6
            // 
            this.lblmessage6.AutoSize = true;
            this.lblmessage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage6.ForeColor = System.Drawing.Color.Red;
            this.lblmessage6.Location = new System.Drawing.Point(528, 52);
            this.lblmessage6.Name = "lblmessage6";
            this.lblmessage6.Size = new System.Drawing.Size(51, 20);
            this.lblmessage6.TabIndex = 20;
            this.lblmessage6.Text = "label3";
            // 
            // lblmessage5
            // 
            this.lblmessage5.AutoSize = true;
            this.lblmessage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage5.ForeColor = System.Drawing.Color.Red;
            this.lblmessage5.Location = new System.Drawing.Point(243, 82);
            this.lblmessage5.Name = "lblmessage5";
            this.lblmessage5.Size = new System.Drawing.Size(51, 20);
            this.lblmessage5.TabIndex = 19;
            this.lblmessage5.Text = "label3";
            // 
            // lblmessage4
            // 
            this.lblmessage4.AutoSize = true;
            this.lblmessage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage4.ForeColor = System.Drawing.Color.Red;
            this.lblmessage4.Location = new System.Drawing.Point(243, 54);
            this.lblmessage4.Name = "lblmessage4";
            this.lblmessage4.Size = new System.Drawing.Size(51, 20);
            this.lblmessage4.TabIndex = 18;
            this.lblmessage4.Text = "label3";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(408, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(116, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PONumber";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(562, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 16;
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_formClose);
            this.panel1.Controls.Add(this.lbl_po);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 32);
            this.panel1.TabIndex = 21;
            // 
            // lbl_formClose
            // 
            this.lbl_formClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formClose.AutoSize = true;
            this.lbl_formClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formClose.ForeColor = System.Drawing.Color.White;
            this.lbl_formClose.Location = new System.Drawing.Point(1015, 3);
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
            this.lbl_po.Size = new System.Drawing.Size(120, 17);
            this.lbl_po.TabIndex = 22;
            this.lbl_po.Text = "Asset Assignment";
            this.lbl_po.Click += new System.EventHandler(this.lbl_po_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(422, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 121);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "         Select  ";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(399, 506);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(52, 16);
            this.lblmessage.TabIndex = 23;
            this.lblmessage.Text = "label11";
            this.lblmessage.Visible = false;
            // 
            // frmAssignAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1034, 615);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gdwassignassets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssignAssets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssignAssets";
            this.Load += new System.EventHandler(this.frmAssignAssets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdwassignassets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combodivname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboempname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboasset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combosubasset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmblocation;
        private System.Windows.Forms.DataGridView gdwassignassets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_po;
        private System.Windows.Forms.Label lbl_formClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblmessage6;
        private System.Windows.Forms.Label lblmessage5;
        private System.Windows.Forms.Label lblmessage4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}