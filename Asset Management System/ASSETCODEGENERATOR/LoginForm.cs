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
    public partial class LoginForm : Form
    {
        public static string userName = "";
        public static string userType = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblmessage.Text = "";
            this.TopMost = true;
            this.AcceptButton = btnlogin;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string sql1 = "Select * from [User] where Username='" + txtusername.Text + "' and Password='" + txtpassword.Text + "'";
            DataTable dt = objdb.RetrunDataTable(sql1);

            if (dt.Rows.Count > 0)
            {
                userName = dt.Rows[0][1].ToString();
                userType = dt.Rows[0][2].ToString();

                User.setUserName(dt.Rows[0][1].ToString());
                User.setUserType(dt.Rows[0][2].ToString());

                //frmMain frm = new frmMain();
                //frm.Show();

                this.Close();
                Form mainInterface_form = (Form)Application.OpenForms["Main"];
                mainInterface_form.Enabled = true;
                     

                 
            }
            else
            {
                //MessageBox.Show("Invalid Login!");
                lblmessage.Text = "Invalid Login!";
                txtusername.Focus();
                txtpassword.Text = "";
                txtusername.Text = "";
            }

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusername_KeyUp(object sender, KeyEventArgs e)
        {
            lblmessage.Text = "";
        }
    }
}