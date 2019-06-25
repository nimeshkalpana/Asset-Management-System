namespace ASSETCODEGENERATOR
{
    partial class SettingsForm
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
            this.gbvehicleClass = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtvehicletype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbvehiclecolor = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtvehiclecolor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFuelType = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtfueltype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_formClose = new System.Windows.Forms.Label();
            this.gbvehicleClass.SuspendLayout();
            this.gbvehiclecolor.SuspendLayout();
            this.gbFuelType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbvehicleClass
            // 
            this.gbvehicleClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbvehicleClass.BackColor = System.Drawing.Color.DarkGray;
            this.gbvehicleClass.Controls.Add(this.button1);
            this.gbvehicleClass.Controls.Add(this.txtvehicletype);
            this.gbvehicleClass.Controls.Add(this.label1);
            this.gbvehicleClass.ForeColor = System.Drawing.Color.White;
            this.gbvehicleClass.Location = new System.Drawing.Point(233, 60);
            this.gbvehicleClass.Name = "gbvehicleClass";
            this.gbvehicleClass.Size = new System.Drawing.Size(467, 141);
            this.gbvehicleClass.TabIndex = 0;
            this.gbvehicleClass.TabStop = false;
            this.gbvehicleClass.Text = "VehicleClass";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(305, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvehicletype
            // 
            this.txtvehicletype.Location = new System.Drawing.Point(247, 42);
            this.txtvehicletype.Name = "txtvehicletype";
            this.txtvehicletype.Size = new System.Drawing.Size(116, 21);
            this.txtvehicletype.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type";
            // 
            // gbvehiclecolor
            // 
            this.gbvehiclecolor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbvehiclecolor.BackColor = System.Drawing.Color.DarkGray;
            this.gbvehiclecolor.Controls.Add(this.button2);
            this.gbvehiclecolor.Controls.Add(this.txtvehiclecolor);
            this.gbvehiclecolor.Controls.Add(this.label2);
            this.gbvehiclecolor.ForeColor = System.Drawing.Color.White;
            this.gbvehiclecolor.Location = new System.Drawing.Point(233, 220);
            this.gbvehiclecolor.Name = "gbvehiclecolor";
            this.gbvehiclecolor.Size = new System.Drawing.Size(467, 140);
            this.gbvehiclecolor.TabIndex = 1;
            this.gbvehiclecolor.TabStop = false;
            this.gbvehiclecolor.Text = "VehicleColor";
            this.gbvehiclecolor.Enter += new System.EventHandler(this.gbvehiclecolor_Enter);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(305, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtvehiclecolor
            // 
            this.txtvehiclecolor.Location = new System.Drawing.Point(247, 37);
            this.txtvehiclecolor.Name = "txtvehiclecolor";
            this.txtvehiclecolor.Size = new System.Drawing.Size(116, 21);
            this.txtvehiclecolor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle Color";
            // 
            // gbFuelType
            // 
            this.gbFuelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFuelType.BackColor = System.Drawing.Color.DarkGray;
            this.gbFuelType.Controls.Add(this.button3);
            this.gbFuelType.Controls.Add(this.txtfueltype);
            this.gbFuelType.Controls.Add(this.label3);
            this.gbFuelType.ForeColor = System.Drawing.Color.White;
            this.gbFuelType.Location = new System.Drawing.Point(233, 378);
            this.gbFuelType.Name = "gbFuelType";
            this.gbFuelType.Size = new System.Drawing.Size(467, 130);
            this.gbFuelType.TabIndex = 2;
            this.gbFuelType.TabStop = false;
            this.gbFuelType.Text = "FuelType";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(305, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtfueltype
            // 
            this.txtfueltype.Location = new System.Drawing.Point(247, 37);
            this.txtfueltype.Name = "txtfueltype";
            this.txtfueltype.Size = new System.Drawing.Size(116, 21);
            this.txtfueltype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fuel Type";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_formClose);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 27);
            this.panel1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vehicle Settings";
            // 
            // lbl_formClose
            // 
            this.lbl_formClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formClose.AutoSize = true;
            this.lbl_formClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formClose.ForeColor = System.Drawing.Color.White;
            this.lbl_formClose.Location = new System.Drawing.Point(911, 2);
            this.lbl_formClose.Name = "lbl_formClose";
            this.lbl_formClose.Size = new System.Drawing.Size(18, 17);
            this.lbl_formClose.TabIndex = 23;
            this.lbl_formClose.Text = "X";
            this.lbl_formClose.Click += new System.EventHandler(this.lbl_formClose_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFuelType);
            this.Controls.Add(this.gbvehiclecolor);
            this.Controls.Add(this.gbvehicleClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbvehicleClass.ResumeLayout(false);
            this.gbvehicleClass.PerformLayout();
            this.gbvehiclecolor.ResumeLayout(false);
            this.gbvehiclecolor.PerformLayout();
            this.gbFuelType.ResumeLayout(false);
            this.gbFuelType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbvehicleClass;
        private System.Windows.Forms.TextBox txtvehicletype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbvehiclecolor;
        private System.Windows.Forms.TextBox txtvehiclecolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFuelType;
        private System.Windows.Forms.TextBox txtfueltype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_formClose;
    }
}