namespace ASSETCODEGENERATOR
{
    partial class FrmAssetVerification
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_formClose = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_upload.Location = new System.Drawing.Point(297, 197);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(160, 62);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload CSV";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btnstart
            // 
            this.btnstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstart.Location = new System.Drawing.Point(296, 125);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(175, 36);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "Start Verification Process";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclose.Enabled = false;
            this.btnclose.Location = new System.Drawing.Point(595, 126);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(144, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close Verification Process";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_formClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 28);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Asset Verification";
            // 
            // lbl_formClose
            // 
            this.lbl_formClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_formClose.AutoSize = true;
            this.lbl_formClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formClose.ForeColor = System.Drawing.Color.White;
            this.lbl_formClose.Location = new System.Drawing.Point(1089, 5);
            this.lbl_formClose.Name = "lbl_formClose";
            this.lbl_formClose.Size = new System.Drawing.Size(18, 17);
            this.lbl_formClose.TabIndex = 2;
            this.lbl_formClose.Text = "X";
            this.lbl_formClose.Click += new System.EventHandler(this.lbl_formClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMessage.Location = new System.Drawing.Point(305, 303);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 18);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // FrmAssetVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btn_upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAssetVerification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAssetVerification";
            this.Load += new System.EventHandler(this.FrmAssetVerification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_formClose;
        public System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMessage;
    }
}