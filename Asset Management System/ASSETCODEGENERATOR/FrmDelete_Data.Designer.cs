namespace ASSETCODEGENERATOR
{
    partial class FrmDelete_Data
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
            this.btndelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbarcode = new System.Windows.Forms.ComboBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(195, 141);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 34);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // cmbbarcode
            // 
            this.cmbbarcode.FormattingEnabled = true;
            this.cmbbarcode.Location = new System.Drawing.Point(149, 97);
            this.cmbbarcode.Name = "cmbbarcode";
            this.cmbbarcode.Size = new System.Drawing.Size(121, 21);
            this.cmbbarcode.TabIndex = 6;
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(149, 57);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(121, 21);
            this.cmbid.TabIndex = 5;
            this.cmbid.SelectionChangeCommitted += new System.EventHandler(this.cmbid_SelectionChangeCommitted);
            // 
            // FrmDelete_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 285);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbarcode);
            this.Controls.Add(this.cmbid);
            this.Name = "FrmDelete_Data";
            this.Text = "FrmDelete_Data";
            this.Load += new System.EventHandler(this.FrmDelete_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbarcode;
        private System.Windows.Forms.ComboBox cmbid;
    }
}