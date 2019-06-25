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
    public partial class POdetails : Form
    {
        public POdetails()
        {
            InitializeComponent();
        }

        DB objdb = new DB();

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "insert into production_order (PO_No,Item_name,Quantity,Amount) values ('" + txtpono.Text + "','" + txtitemname.Text + "','" + txtquantity.Text + "','" + txtamount.Text + "')";
            objdb.ExecuteNonQuery(sql);
            clearText();
        }
        public void clearText()
        {
            txtpono.Text = "";
            txtitemname.Text = "";
            txtquantity.Text = "";
            txtamount.Text = "";
        }

        private void POdetails_Load(object sender, EventArgs e)
        {

        }

       
      
               
    }
}
