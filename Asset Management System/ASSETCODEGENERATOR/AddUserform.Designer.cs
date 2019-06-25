namespace ASSETCODEGENERATOR
{
    partial class AddUserform
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
            this.tab_adduser = new System.Windows.Forms.TabControl();
            this.tabuser = new System.Windows.Forms.TabPage();
            this.panel_adduser = new System.Windows.Forms.Panel();
            this.tab_adduser.SuspendLayout();
            this.tabuser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_adduser
            // 
            this.tab_adduser.Controls.Add(this.tabuser);
            this.tab_adduser.Location = new System.Drawing.Point(12, 12);
            this.tab_adduser.Name = "tab_adduser";
            this.tab_adduser.SelectedIndex = 0;
            this.tab_adduser.Size = new System.Drawing.Size(582, 397);
            this.tab_adduser.TabIndex = 0;
            this.tab_adduser.SelectedIndexChanged += new System.EventHandler(this.tab_adduser_SelectedIndexChanged);
            // 
            // tabuser
            // 
            this.tabuser.Controls.Add(this.panel_adduser);
            this.tabuser.Location = new System.Drawing.Point(4, 22);
            this.tabuser.Name = "tabuser";
            this.tabuser.Padding = new System.Windows.Forms.Padding(3);
            this.tabuser.Size = new System.Drawing.Size(574, 371);
            this.tabuser.TabIndex = 0;
            this.tabuser.Text = "User";
            this.tabuser.UseVisualStyleBackColor = true;
            // 
            // panel_adduser
            // 
            this.panel_adduser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adduser.Location = new System.Drawing.Point(3, 3);
            this.panel_adduser.Name = "panel_adduser";
            this.panel_adduser.Size = new System.Drawing.Size(568, 365);
            this.panel_adduser.TabIndex = 0;
            this.panel_adduser.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_adduser_Paint);
            // 
            // AddUserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 400);
            this.Controls.Add(this.tab_adduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserform";
            this.Text = "AddUserform";
            this.tab_adduser.ResumeLayout(false);
            this.tabuser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_adduser;
        private System.Windows.Forms.TabPage tabuser;
        private System.Windows.Forms.Panel panel_adduser;
    }
}