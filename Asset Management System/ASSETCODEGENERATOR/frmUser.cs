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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        DB objdb = new DB();


        private void btnsave_Click_1(object sender, EventArgs e)
        {
            int val = 0;
            int cnt = 0;
            string validatequery = " select Count([Assets].[dbo].[User].Username) from [Assets].[dbo].[User] where  [Assets].[dbo].[User].Username = '"+txtusername.Text+"'";
            cnt = objdb.ExecuteScalar(validatequery);

            if (txtusername.Text == "")
            {
                label3.Text = "**";
                label3.Visible = true;
                return;
                //MessageBox.Show("Username cannot be empty!");
            }
            else if (textBox1.Text == "")
            {
                label4.Text = "**";
                label4.Visible = true;
                //MessageBox.Show("Password cannot be empty!");
                return;
            }
            else if (cmbusertype.SelectedIndex == -1)
            {
                label7.Text = "**";
                label7.Visible = true;
                //MessageBox.Show("Password cannot be empty!");
                return;
            }
            else if(cnt>0)
            {
                label5.Text = "User already Exists!";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
                loadGrid();
                return;
            }
            else
            {
                string sql = "insert into [User] (Username,User_type,Password) values ('" + txtusername.Text + "','"+ cmbusertype.SelectedItem + "','" + textBox1.Text + "')";
                val = objdb.ExecuteNonQuery(sql);
                if (val > 0)
                {
                    label5.ForeColor = Color.Green;
                    label5.Text = "Successfully Inserted!";
                    label5.Visible = true;
                    loadGrid();
                }
            }
        }
        public void loadGrid()
        {
            //Load divsion gridview
            string sqluser = "Select * from [User]";
            DataTable dt2 = objdb.RetrunDataTable(sqluser);
            gdwLocation.DataSource = dt2;
            gdwLocation.Refresh();
            cleartext();
        }
        public void cleartext()
        {
            txtusername.Text = "";
            textBox1.Text = "";
            cmbusertype.SelectedIndex = -1;

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //string sql1 = "Select * from [[User]] order by User_Id";
            //DataTable dt = objdb.RetrunDataTable(sql1);
            //combousertype.DataSource = dt;
            //combousertype.DisplayMember = "User_type";
            //combousertype.ValueMember = "User_Id";
            loadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
