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
    public partial class FrmMasterData : Form
    {
        public FrmMasterData()
        {
            InitializeComponent();
        }

        
        DB objdb = new DB();


     
        private void DataEntryTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnl_dataEntry_Employee.SelectedIndex == 0)
            {
                frmLocation frm = new frmLocation();
                frm.TopLevel = false;
                pnl_dataentry_location.Controls.Clear();
                pnl_dataentry_location.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }

            if (pnl_dataEntry_Employee.SelectedIndex == 1)
            {
                frmdivision frm = new frmdivision();
                frm.TopLevel = false;
                pnl_division.Controls.Clear();
                pnl_division.Controls.Add(frm);
                frm.Show();
            }
           

            if (pnl_dataEntry_Employee.SelectedIndex == 2)
            {

                frmEmployee frm = new frmEmployee();
                frm.TopLevel = false;
                panel_employee.Controls.Clear();
                panel_employee.Controls.Add(frm);
                frm.Show();
            }


            if (pnl_dataEntry_Employee.SelectedIndex == 3)
            {

                frmAssetCategory frm = new frmAssetCategory();
                frm.TopLevel = false;
                panel_assetcat.Controls.Clear();
                panel_assetcat.Controls.Add(frm);
                frm.Show();
            }

            if (pnl_dataEntry_Employee.SelectedIndex == 4)
            {

                frmAssetSubCategory frm = new frmAssetSubCategory();
                frm.TopLevel = false;
                panel_assetsubcat.Controls.Clear();
                panel_assetsubcat.Controls.Add(frm);
                frm.Show();
            }



            if (pnl_dataEntry_Employee.SelectedIndex == 5)
            {

                VehicleForm frm = new VehicleForm();
                frm.TopLevel = false;
                pnl_dataEntry_vehicle.Controls.Clear();
                pnl_dataEntry_vehicle.Controls.Add(frm);
                frm.Show();
            }
            else if (pnl_dataEntry_Employee.SelectedIndex == 6)
            {

                SettingsForm frm = new SettingsForm();
                frm.TopLevel = false;
                pnl_dataEntry_settings.Controls.Clear();
                pnl_dataEntry_settings.Controls.Add(frm);
                frm.Show();
            }        
        }

        private void FrmMasterData_Load_1(object sender, EventArgs e)
        {
            frmLocation frm = new frmLocation();
            frm.TopLevel = false;
            pnl_dataentry_location.Controls.Clear();
            pnl_dataentry_location.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void panel_employee_Paint(object sender, PaintEventArgs e)
        {

        }

   

        
    }
}
