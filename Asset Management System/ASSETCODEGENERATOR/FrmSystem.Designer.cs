namespace ASSETCODEGENERATOR
{
    partial class FrmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystem));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Avppanel = new System.Windows.Forms.Panel();
            this.tabGenerateCsv = new System.Windows.Forms.TabPage();
            this.panel_Transfer = new System.Windows.Forms.Panel();
            this.Asset_trasfer = new System.Windows.Forms.TabPage();
            this.tabPrintAssetCode = new System.Windows.Forms.TabPage();
            this.panel_itemcode = new System.Windows.Forms.Panel();
            this.tabAssetAssign = new System.Windows.Forms.TabPage();
            this.panel_assetassign = new System.Windows.Forms.Panel();
            this.pnl_dataEntry_Transfer = new System.Windows.Forms.TabControl();
            this.tabPO = new System.Windows.Forms.TabPage();
            this.pnl_dataEntry_po = new System.Windows.Forms.Panel();
            this.panel_AssetTransfer = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            this.tabGenerateCsv.SuspendLayout();
            this.Asset_trasfer.SuspendLayout();
            this.tabPrintAssetCode.SuspendLayout();
            this.tabAssetAssign.SuspendLayout();
            this.pnl_dataEntry_Transfer.SuspendLayout();
            this.tabPO.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Avppanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(893, 540);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Asset Verification Process";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Avppanel
            // 
            this.Avppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avppanel.Location = new System.Drawing.Point(3, 3);
            this.Avppanel.Name = "Avppanel";
            this.Avppanel.Size = new System.Drawing.Size(887, 534);
            this.Avppanel.TabIndex = 0;
            this.Avppanel.Visible = false;
            this.Avppanel.VisibleChanged += new System.EventHandler(this.Avppanel_VisibleChanged);
            this.Avppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Avppanel_Paint);
            // 
            // tabGenerateCsv
            // 
            this.tabGenerateCsv.Controls.Add(this.panel_Transfer);
            this.tabGenerateCsv.Location = new System.Drawing.Point(4, 23);
            this.tabGenerateCsv.Name = "tabGenerateCsv";
            this.tabGenerateCsv.Size = new System.Drawing.Size(893, 540);
            this.tabGenerateCsv.TabIndex = 5;
            this.tabGenerateCsv.Text = "Generate CSV";
            this.tabGenerateCsv.UseVisualStyleBackColor = true;
            this.tabGenerateCsv.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel_Transfer
            // 
            this.panel_Transfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Transfer.Location = new System.Drawing.Point(0, 0);
            this.panel_Transfer.Name = "panel_Transfer";
            this.panel_Transfer.Size = new System.Drawing.Size(893, 540);
            this.panel_Transfer.TabIndex = 0;
            this.panel_Transfer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Transfer_Paint);
            // 
            // Asset_trasfer
            // 
            this.Asset_trasfer.Controls.Add(this.panel_AssetTransfer);
            this.Asset_trasfer.Location = new System.Drawing.Point(4, 23);
            this.Asset_trasfer.Name = "Asset_trasfer";
            this.Asset_trasfer.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Asset_trasfer.Size = new System.Drawing.Size(893, 540);
            this.Asset_trasfer.TabIndex = 8;
            this.Asset_trasfer.Text = "Asset Transfer";
            this.Asset_trasfer.UseVisualStyleBackColor = true;
            this.Asset_trasfer.Click += new System.EventHandler(this.tabPage1_Click_2);
            // 
            // tabPrintAssetCode
            // 
            this.tabPrintAssetCode.Controls.Add(this.panel_itemcode);
            this.tabPrintAssetCode.Location = new System.Drawing.Point(4, 23);
            this.tabPrintAssetCode.Name = "tabPrintAssetCode";
            this.tabPrintAssetCode.Size = new System.Drawing.Size(893, 540);
            this.tabPrintAssetCode.TabIndex = 3;
            this.tabPrintAssetCode.Text = "Print Asset Codes";
            this.tabPrintAssetCode.UseVisualStyleBackColor = true;
            // 
            // panel_itemcode
            // 
            this.panel_itemcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_itemcode.Location = new System.Drawing.Point(0, 0);
            this.panel_itemcode.Name = "panel_itemcode";
            this.panel_itemcode.Size = new System.Drawing.Size(893, 540);
            this.panel_itemcode.TabIndex = 0;
            this.panel_itemcode.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_itemcode_Paint);
            // 
            // tabAssetAssign
            // 
            this.tabAssetAssign.Controls.Add(this.panel_assetassign);
            this.tabAssetAssign.Location = new System.Drawing.Point(4, 23);
            this.tabAssetAssign.Name = "tabAssetAssign";
            this.tabAssetAssign.Size = new System.Drawing.Size(893, 540);
            this.tabAssetAssign.TabIndex = 2;
            this.tabAssetAssign.Text = "Asset Assignment";
            this.tabAssetAssign.UseVisualStyleBackColor = true;
            // 
            // panel_assetassign
            // 
            this.panel_assetassign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_assetassign.Location = new System.Drawing.Point(0, 0);
            this.panel_assetassign.Name = "panel_assetassign";
            this.panel_assetassign.Size = new System.Drawing.Size(893, 540);
            this.panel_assetassign.TabIndex = 0;
            this.panel_assetassign.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_assetassign_Paint);
            // 
            // pnl_dataEntry_Transfer
            // 
            this.pnl_dataEntry_Transfer.Controls.Add(this.tabPO);
            this.pnl_dataEntry_Transfer.Controls.Add(this.tabAssetAssign);
            this.pnl_dataEntry_Transfer.Controls.Add(this.tabPrintAssetCode);
            this.pnl_dataEntry_Transfer.Controls.Add(this.Asset_trasfer);
            this.pnl_dataEntry_Transfer.Controls.Add(this.tabGenerateCsv);
            this.pnl_dataEntry_Transfer.Controls.Add(this.tabPage2);
            this.pnl_dataEntry_Transfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataEntry_Transfer.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_dataEntry_Transfer.ImageList = this.imageList1;
            this.pnl_dataEntry_Transfer.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.pnl_dataEntry_Transfer.ItemSize = new System.Drawing.Size(69, 19);
            this.pnl_dataEntry_Transfer.Location = new System.Drawing.Point(0, 0);
            this.pnl_dataEntry_Transfer.Name = "pnl_dataEntry_Transfer";
            this.pnl_dataEntry_Transfer.SelectedIndex = 0;
            this.pnl_dataEntry_Transfer.Size = new System.Drawing.Size(901, 567);
            this.pnl_dataEntry_Transfer.TabIndex = 1;
            this.pnl_dataEntry_Transfer.SelectedIndexChanged += new System.EventHandler(this.pnl_System_Details_SelectedIndexChanged);
            // 
            // tabPO
            // 
            this.tabPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPO.Controls.Add(this.pnl_dataEntry_po);
            this.tabPO.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tabPO.Location = new System.Drawing.Point(4, 23);
            this.tabPO.Name = "tabPO";
            this.tabPO.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPO.Size = new System.Drawing.Size(893, 540);
            this.tabPO.TabIndex = 0;
            this.tabPO.Text = "PO";
            this.tabPO.UseVisualStyleBackColor = true;
            // 
            // pnl_dataEntry_po
            // 
            this.pnl_dataEntry_po.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dataEntry_po.Location = new System.Drawing.Point(3, 3);
            this.pnl_dataEntry_po.Name = "pnl_dataEntry_po";
            this.pnl_dataEntry_po.Size = new System.Drawing.Size(887, 534);
            this.pnl_dataEntry_po.TabIndex = 0;
            this.pnl_dataEntry_po.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_dataEntry_po_Paint);
            // 
            // panel_AssetTransfer
            // 
            this.panel_AssetTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AssetTransfer.Location = new System.Drawing.Point(3, 3);
            this.panel_AssetTransfer.Name = "panel_AssetTransfer";
            this.panel_AssetTransfer.Size = new System.Drawing.Size(887, 534);
            this.panel_AssetTransfer.TabIndex = 0;
            // 
            // FrmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 567);
            this.Controls.Add(this.pnl_dataEntry_Transfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSystem";
            this.Text = "FrmSystem";
            this.Load += new System.EventHandler(this.FrmSystem_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabGenerateCsv.ResumeLayout(false);
            this.Asset_trasfer.ResumeLayout(false);
            this.tabPrintAssetCode.ResumeLayout(false);
            this.tabAssetAssign.ResumeLayout(false);
            this.pnl_dataEntry_Transfer.ResumeLayout(false);
            this.tabPO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel Avppanel;
        private System.Windows.Forms.TabPage tabGenerateCsv;
        private System.Windows.Forms.Panel panel_Transfer;
        private System.Windows.Forms.TabPage Asset_trasfer;
        private System.Windows.Forms.TabPage tabPrintAssetCode;
        private System.Windows.Forms.Panel panel_itemcode;
        private System.Windows.Forms.TabPage tabAssetAssign;
        private System.Windows.Forms.Panel panel_assetassign;
        private System.Windows.Forms.TabControl pnl_dataEntry_Transfer;
        private System.Windows.Forms.TabPage tabPO;
        private System.Windows.Forms.Panel pnl_dataEntry_po;
        private System.Windows.Forms.Panel panel_AssetTransfer;
    }
}