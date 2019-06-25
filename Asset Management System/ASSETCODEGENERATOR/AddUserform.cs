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
    public partial class AddUserform : Form
    {
        public AddUserform()
        {
            InitializeComponent();
        }

        DB objdb = new DB();       

        private void tab_adduser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_adduser.SelectedIndex == 1)
            {
                frmUser frm = new frmUser();
                frm.TopLevel = false;
                panel_adduser.Controls.Clear();
                panel_adduser.Controls.Add(frm);
                frm.Show();
            }
        }

        private void panel_adduser_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
