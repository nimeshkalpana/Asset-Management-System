namespace ASSETCODEGENERATOR
{
    partial class FrmMasterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterData));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl_dataEntry_settings = new System.Windows.Forms.Panel();
            this.Vehicle = new System.Windows.Forms.TabPage();
            this.pnl_dataEntry_vehicle = new System.Windows.Forms.Panel();
            this.sub = new System.Windows.Forms.TabPage();
            this.panel_assetsubcat = new System.Windows.Forms.Panel();
            this.Assets = new System.Windows.Forms.TabPage();
            this.panel_assetcat = new System.Windows.Forms.Panel();
            this.Employee = new System.Windows.Forms.TabPage();
            this.panel_employee = new System.Windows.Forms.Panel();
            this.Division = new System.Windows.Forms.TabPage();
            this.pnl_division = new System.Windows.Forms.Panel();
            this.Location = new System.Windows.Forms.TabPage();
            this.pnl_dataentry_location = new System.Windows.Forms.Panel();
            this.pnl_dataEntry_Employee = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.Vehicle.SuspendLayout();
            this.sub.SuspendLayout();
            this.Assets.SuspendLayout();
            this.Employee.SuspendLayout();
            this.Division.SuspendLayout();
            this.Location.SuspendLayout();
            this.pnl_dataEntry_Employee.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "location-icon-png.png");
            this.imageList1.Images.SetKeyName(1, "building_3-512.png");
            this.imageList1.Images.SetKeyName(2, "car-front-512.png");
            this.imageList1.Images.SetKeyName(3, "add-list.png");
            this.imageList1.Images.SetKeyName(4, "Asset.png");
            this.imageList1.Images.SetKeyName(5, "empIcon.png");
            this.imageList1.Images.SetKeyName(6, "sub.png");
            this.imageList1.Images.SetKeyName(7, "settings-icon.png");
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.pnl_dataEntry_settings);
            this.tabPage1.ImageKey = "settings-icon.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(512, 520);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_dataEntry_settings
            // 
            this.pnl_dataEntry_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataEntry_settings.Location = new System.Drawing.Point(3, 3);
            this.pnl_dataEntry_settings.Name = "pnl_dataEntry_settings";
            this.pnl_dataEntry_settings.Size = new System.Drawing.Size(506, 514);
            this.pnl_dataEntry_settings.TabIndex = 0;
            // 
            // Vehicle
            // 
            this.Vehicle.Controls.Add(this.pnl_dataEntry_vehicle);
            this.Vehicle.ImageKey = "car-front-512.png";
            this.Vehicle.Location = new System.Drawing.Point(4, 23);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(512, 520);
            this.Vehicle.TabIndex = 6;
            this.Vehicle.Text = "Vehicles";
            this.Vehicle.UseVisualStyleBackColor = true;
            // 
            // pnl_dataEntry_vehicle
            // 
            this.pnl_dataEntry_vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataEntry_vehicle.Location = new System.Drawing.Point(0, 0);
            this.pnl_dataEntry_vehicle.Name = "pnl_dataEntry_vehicle";
            this.pnl_dataEntry_vehicle.Size = new System.Drawing.Size(512, 520);
            this.pnl_dataEntry_vehicle.TabIndex = 0;
            // 
            // sub
            // 
            this.sub.Controls.Add(this.panel_assetsubcat);
            this.sub.ImageKey = "sub.png";
            this.sub.Location = new System.Drawing.Point(4, 23);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(512, 520);
            this.sub.TabIndex = 4;
            this.sub.Text = "Assets Subcategory";
            this.sub.UseVisualStyleBackColor = true;
            // 
            // panel_assetsubcat
            // 
            this.panel_assetsubcat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_assetsubcat.Location = new System.Drawing.Point(0, 0);
            this.panel_assetsubcat.Name = "panel_assetsubcat";
            this.panel_assetsubcat.Size = new System.Drawing.Size(512, 520);
            this.panel_assetsubcat.TabIndex = 0;
            // 
            // Assets
            // 
            this.Assets.Controls.Add(this.panel_assetcat);
            this.Assets.ImageKey = "Asset.png";
            this.Assets.Location = new System.Drawing.Point(4, 23);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(512, 520);
            this.Assets.TabIndex = 3;
            this.Assets.Text = "Assets Category";
            this.Assets.UseVisualStyleBackColor = true;
            // 
            // panel_assetcat
            // 
            this.panel_assetcat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_assetcat.Location = new System.Drawing.Point(0, 0);
            this.panel_assetcat.Name = "panel_assetcat";
            this.panel_assetcat.Size = new System.Drawing.Size(512, 520);
            this.panel_assetcat.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.panel_employee);
            this.Employee.ImageIndex = 5;
            this.Employee.Location = new System.Drawing.Point(4, 23);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(512, 520);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employees";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // panel_employee
            // 
            this.panel_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_employee.Location = new System.Drawing.Point(0, 0);
            this.panel_employee.Name = "panel_employee";
            this.panel_employee.Size = new System.Drawing.Size(512, 520);
            this.panel_employee.TabIndex = 0;
            this.panel_employee.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_employee_Paint);
            // 
            // Division
            // 
            this.Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Division.Controls.Add(this.pnl_division);
            this.Division.ImageKey = "building_3-512.png";
            this.Division.Location = new System.Drawing.Point(4, 23);
            this.Division.Name = "Division";
            this.Division.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Division.Size = new System.Drawing.Size(512, 520);
            this.Division.TabIndex = 1;
            this.Division.Text = "Divisions";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // pnl_division
            // 
            this.pnl_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_division.Location = new System.Drawing.Point(3, 3);
            this.pnl_division.Name = "pnl_division";
            this.pnl_division.Size = new System.Drawing.Size(506, 514);
            this.pnl_division.TabIndex = 0;
            // 
            // Location
            // 
            this.Location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Location.Controls.Add(this.pnl_dataentry_location);
            this.Location.ImageIndex = 0;
            this.Location.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Location.Location = new System.Drawing.Point(4, 23);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Location.Size = new System.Drawing.Size(512, 520);
            this.Location.TabIndex = 0;
            this.Location.Text = "Locations";
            this.Location.UseVisualStyleBackColor = true;
            // 
            // pnl_dataentry_location
            // 
            this.pnl_dataentry_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataentry_location.Location = new System.Drawing.Point(3, 3);
            this.pnl_dataentry_location.Name = "pnl_dataentry_location";
            this.pnl_dataentry_location.Size = new System.Drawing.Size(506, 514);
            this.pnl_dataentry_location.TabIndex = 0;
            // 
            // pnl_dataEntry_Employee
            // 
            this.pnl_dataEntry_Employee.Controls.Add(this.Location);
            this.pnl_dataEntry_Employee.Controls.Add(this.Division);
            this.pnl_dataEntry_Employee.Controls.Add(this.Employee);
            this.pnl_dataEntry_Employee.Controls.Add(this.Assets);
            this.pnl_dataEntry_Employee.Controls.Add(this.sub);
            this.pnl_dataEntry_Employee.Controls.Add(this.Vehicle);
            this.pnl_dataEntry_Employee.Controls.Add(this.tabPage1);
            this.pnl_dataEntry_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataEntry_Employee.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_dataEntry_Employee.ImageList = this.imageList1;
            this.pnl_dataEntry_Employee.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.pnl_dataEntry_Employee.ItemSize = new System.Drawing.Size(69, 19);
            this.pnl_dataEntry_Employee.Location = new System.Drawing.Point(0, 0);
            this.pnl_dataEntry_Employee.Name = "pnl_dataEntry_Employee";
            this.pnl_dataEntry_Employee.SelectedIndex = 0;
            this.pnl_dataEntry_Employee.Size = new System.Drawing.Size(520, 547);
            this.pnl_dataEntry_Employee.TabIndex = 0;
            this.pnl_dataEntry_Employee.SelectedIndexChanged += new System.EventHandler(this.DataEntryTab_SelectedIndexChanged);
            // 
            // FrmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 547);
            this.Controls.Add(this.pnl_dataEntry_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMasterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMasterData_Load_1);
            this.tabPage1.ResumeLayout(false);
            this.Vehicle.ResumeLayout(false);
            this.sub.ResumeLayout(false);
            this.Assets.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            this.Division.ResumeLayout(false);
            this.Location.ResumeLayout(false);
            this.pnl_dataEntry_Employee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnl_dataEntry_settings;
        private System.Windows.Forms.TabPage Vehicle;
        private System.Windows.Forms.Panel pnl_dataEntry_vehicle;
        private System.Windows.Forms.TabPage sub;
        private System.Windows.Forms.TabPage Assets;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.Panel panel_employee;
        private System.Windows.Forms.TabPage Division;
        private System.Windows.Forms.TabPage Location;
        private System.Windows.Forms.TabControl pnl_dataEntry_Employee;
        private System.Windows.Forms.Panel pnl_dataentry_location;
        private System.Windows.Forms.Panel pnl_division;
        private System.Windows.Forms.Panel panel_assetcat;
        private System.Windows.Forms.Panel panel_assetsubcat;
    }
}