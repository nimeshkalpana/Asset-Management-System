using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using BLL;
using System.Globalization;

namespace ASSETCODEGENERATOR
{
    public partial class Main : Form
    {
        public Main()
        {
            //this.Visible = false;
            //LoginForm frmLog = new LoginForm();
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.setUserName("");
                User.setUserType("");
                this.Enabled = false;
                LoginForm frmLog = new LoginForm();
                frmLog.Show();
            }
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
            //lblLogTime.Text = DateTime.Now.ToString("hh:mm:ss");
            setDate();
            //timer_currentTime.Start();
            //lblLogName.Text = LoginForm.userName;
            //if (LoginForm.userType == "Employee")
            //{
            //    panelInfo.Enabled = false;
            //}
            //else
            //{
            //    panelInfo.Enabled = true;
            //}
        }

        private void setDate()
        {
            string[] date = DateTime.Now.ToString("D", CultureInfo.CreateSpecificCulture("en-US")).Split(',');
            label3.Text = " " + date[0] + Environment.NewLine + date[1] + "," + date[2];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //lblLogTime.Text = DateTime.Now.ToString("hh:mm tt");

        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {           
            //this.Visible = true;
            //LoginForm frmLog = new LoginForm();
            //frmLog.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            this.Enabled = false;
            LoginForm frmLog = new LoginForm();
            frmLog.Show();
            timer1.Start();
        }

        private void Main_EnabledChanged(object sender, EventArgs e)
        {
            if (User.getUserName() != "")
            {
                lblLogName.Text = User.getUserName();
                lbl_loginTime.Text = DateTime.Now.ToString("hh:mm tt");
                panelInfo.Visible = true;
                pic_logo.Visible = true;

                if (LoginForm.userName != "" && LoginForm.userType != "")
                {
                    if (LoginForm.userType == "user")
                    {
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = false;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                    }
                    else
                    {
                        pictureBox1.Enabled = true;
                        pictureBox2.Enabled = true;
                        pictureBox3.Enabled = true;
                        pictureBox4.Enabled = true;
                    }
                }
            }
            else
            {
                lblLogName.Text = "-";
                lbl_loginTime.Text = "-";
                panelInfo.Visible = false;
                pic_logo.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMasterData frm = new FrmMasterData();
            frm.TopLevel = false;
            panelView.Controls.Clear();
            panelView.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSystem frm = new FrmSystem();
            frm.TopLevel = false;
            panelView.Controls.Clear();
            panelView.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.TopLevel = false;
            panelView.Controls.Clear();
            panelView.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frmreports frm = new Frmreports();
            frm.TopLevel = false;
            panelView.Controls.Clear();
            panelView.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void pictureBox4_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void panelDateTime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}