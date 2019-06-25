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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        DB objdb = new DB();

        private void gbvehiclecolor_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtvehicletype.Text == "")
            {
                MessageBox.Show("vehicle Type cannot be empty!");
                return;
            }
            else
            {
                string sql = "insert into Vehicle_Type (Type_Description) values ('" + txtvehicletype.Text + "')";
                val = objdb.ExecuteNonQuery(sql);
                if (val > 0)
                {
                    MessageBox.Show("Successfully Inserted!");
                }
            }
            //loadGrid();
            clearText();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtvehiclecolor.Text == "")
            {
                MessageBox.Show("vehicle Color cannot be empty!");
                return;
            }
            else
            {
                string sql = "insert into Vehicle_Color (Color_Description) values ('" + txtvehiclecolor.Text + "')";
                val = objdb.ExecuteNonQuery(sql);
                if (val > 0)
                {

                    MessageBox.Show("Successfully Inserted!");
                }
            }

            clearText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtfueltype.Text == "")
            {
                MessageBox.Show("Fuel Type cannot be empty!");
                return;
            }
            else
            {
                string sql = "insert into Fuel_Type (FuelType_Description) values ('" + txtfueltype.Text + "')";
                val = objdb.ExecuteNonQuery(sql);
                if (val > 0)
                {

                    MessageBox.Show("Successfully Inserted!");
                }
            }
            clearText();

        }

        public void clearText()
        {
            txtvehicletype.Text = "";
            txtvehiclecolor.Text = "";
            txtfueltype.Text = "";
        }


        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbvehicleClass_Enter(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
