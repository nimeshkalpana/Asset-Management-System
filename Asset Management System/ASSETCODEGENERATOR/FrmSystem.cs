using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ASSETCODEGENERATOR
{
    public partial class FrmSystem : Form
    {
        public FrmSystem()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
   

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_System_Details_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pnl_dataEntry_Transfer.SelectedIndex == 0)
            {

                PODetailsForm2 frm = new PODetailsForm2();
                frm.TopLevel = false;
                pnl_dataEntry_po.Controls.Clear();
                pnl_dataEntry_po.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }


            if (pnl_dataEntry_Transfer.SelectedIndex == 1)
            {

                frmAssignAssets frm = new frmAssignAssets();
                frm.TopLevel = false;
                panel_assetassign.Controls.Clear();
                panel_assetassign.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }

            if (pnl_dataEntry_Transfer.SelectedIndex == 2)
            {

                Item_CodeForm2 frm = new Item_CodeForm2();
                frm.TopLevel = false;
                panel_itemcode.Controls.Clear();
                panel_itemcode.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            if (pnl_dataEntry_Transfer.SelectedIndex == 3)
            {
                FrmAssetTransfer frm = new FrmAssetTransfer();
                frm.TopLevel = false;
                panel_AssetTransfer.Controls.Clear();
                panel_AssetTransfer.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
                //panel1.Visible = true;

            }
            if (pnl_dataEntry_Transfer.SelectedIndex == 4)
            {

                Frm_Csv_Generator frm = new Frm_Csv_Generator();
                frm.TopLevel = false;
                panel_Transfer.Controls.Clear();
                panel_Transfer.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
            if (pnl_dataEntry_Transfer.SelectedIndex == 5)
            {

                //FrmAssetVerification frm = new FrmAssetVerification();
                //frm.TopLevel = false;
                //panel_Transfer.Controls.Clear();
                //panel_Transfer.Controls.Add(frm);
                //frm.Dock = DockStyle.Fill;
                //frm.Show();
                Avppanel.Visible = true;


            }

        }

        private void pnl_currentstock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_itemcode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            
            PODetailsForm2 frm = new PODetailsForm2();
            frm.TopLevel = false;
            pnl_dataEntry_po.Controls.Clear();
            pnl_dataEntry_po.Controls.Add(frm);
            pnl_dataEntry_po.Dock = DockStyle.Fill;
            frm.Show();
            
        }

        private void pnl_dataEntry_po_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelvalidation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        

        private void panel_Transfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_assetassign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Asset_Varification_process_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Avppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Avppanel_VisibleChanged(object sender, EventArgs e)
        {
            FrmAssetVerification frm = new FrmAssetVerification();
            frm.TopLevel = false;
            Avppanel.Controls.Clear();
            Avppanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void pnlat_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void pnlat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Nimesh");
            FrmAssetTransfer frm = new FrmAssetTransfer();
            frm.TopLevel = false;
            //panel_Transfer.Controls.Clear();
            panel_Transfer.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }
    }  
}
