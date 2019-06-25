namespace ASSETCODEGENERATOR
{
    partial class Frmreports
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
            this.reporttabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.departmentpanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fr66panel = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vehiclepanel = new System.Windows.Forms.Panel();
            this.reporttabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporttabControl
            // 
            this.reporttabControl.Controls.Add(this.tabPage1);
            this.reporttabControl.Controls.Add(this.tabPage2);
            this.reporttabControl.Controls.Add(this.tabPage3);
            this.reporttabControl.Location = new System.Drawing.Point(1, 0);
            this.reporttabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reporttabControl.Name = "reporttabControl";
            this.reporttabControl.SelectedIndex = 0;
            this.reporttabControl.Size = new System.Drawing.Size(1519, 769);
            this.reporttabControl.TabIndex = 2;
            this.reporttabControl.SelectedIndexChanged += new System.EventHandler(this.reporttabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.departmentpanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1511, 740);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Annual Report FR66";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // departmentpanel
            // 
            this.departmentpanel.Location = new System.Drawing.Point(0, 0);
            this.departmentpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentpanel.Name = "departmentpanel";
            this.departmentpanel.Size = new System.Drawing.Size(1508, 745);
            this.departmentpanel.TabIndex = 0;
            this.departmentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.departmentpanel_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fr66panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1511, 740);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Location & Division Wise Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fr66panel
            // 
            this.fr66panel.Location = new System.Drawing.Point(0, 0);
            this.fr66panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fr66panel.Name = "fr66panel";
            this.fr66panel.Size = new System.Drawing.Size(1511, 732);
            this.fr66panel.TabIndex = 0;
            this.fr66panel.Paint += new System.Windows.Forms.PaintEventHandler(this.fr66panel_Paint_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.vehiclepanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1511, 740);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vehicle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // vehiclepanel
            // 
            this.vehiclepanel.Location = new System.Drawing.Point(0, 0);
            this.vehiclepanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vehiclepanel.Name = "vehiclepanel";
            this.vehiclepanel.Size = new System.Drawing.Size(1511, 745);
            this.vehiclepanel.TabIndex = 0;
            // 
            // Frmreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1524, 726);
            this.Controls.Add(this.reporttabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmreports";
            this.Text = "Frmreports";
            this.Load += new System.EventHandler(this.Frmreports_Load);
            this.reporttabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl reporttabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel departmentpanel;
        private System.Windows.Forms.Panel fr66panel;
        private System.Windows.Forms.Panel vehiclepanel;


    }
}