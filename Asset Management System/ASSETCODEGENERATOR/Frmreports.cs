using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace ASSETCODEGENERATOR
{
    public partial class Frmreports : Form
    {
        DB objdb = new DB();
        public Frmreports()
        {
            InitializeComponent();
        }

        private void departmentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frmreports_Load(object sender, EventArgs e)
        {
            Formdivisionwise_printforms frm = new Formdivisionwise_printforms();
            frm.TopLevel = false;
            departmentpanel.Controls.Clear();
            departmentpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void reporttabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reporttabControl.SelectedIndex == 1)
            {
                FrmDivisionIT frm = new FrmDivisionIT();
                frm.TopLevel = false;
                fr66panel.Controls.Clear();
                fr66panel.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            if (reporttabControl.SelectedIndex == 2)
            {
                FrmReport frm = new FrmReport();
                frm.TopLevel = false;
                vehiclepanel.Controls.Clear();
                vehiclepanel.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            if (reporttabControl.SelectedIndex == 0)
            {
                Formdivisionwise_printforms frm = new Formdivisionwise_printforms();
                frm.TopLevel = false;
                departmentpanel.Controls.Clear();
                departmentpanel.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }



        }

        private void fr66panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fr66panel_Paint_1(object sender, PaintEventArgs e)
        {

        }

    }
}