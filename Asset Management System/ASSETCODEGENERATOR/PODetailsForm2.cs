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
    public partial class PODetailsForm2 : Form
    {
        public PODetailsForm2()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        int id = 0;
        int catID = 0;
        bool state = false;
        int index = -1;
        int sid, cid;
        //  int id = 0;

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtpo.Text == "")
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "PO cannot be blank";
            }

            else
            {
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                int poId = 0;
                int quantity = 0;
                int result = 0;
                int quant = 0;
                int id = 0;
                int cid = 0;
                int val = 0;

                int.TryParse(cmbitemsubcat.SelectedValue.ToString(), out catID);
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    try
                    {
                        string sql = "insert into PO_Header (PO_NO,PO_date,Assign_Status) values ('" + row1.Cells[4].Value.ToString() + "','" + row1.Cells[5].Value.ToString() + "','F')";
                        result = objdb.ExecuteNonQuery(sql);

                        int.TryParse(row1.Cells[0].Value.ToString(), out quant);
                        string sql2 = "select SubCategory_Id from Assets_subcategory where SubCategory_Desc =  '" + row1.Cells[2].Value.ToString() + "'";
                        id = objdb.Read_Subcat(sql2);

                        string sql3 = "select Category_Id from Asset_Category where Category_Desc = '" + row1.Cells[1].Value.ToString() + "'";
                        cid = objdb.Read_Subcat(sql3);

                        string sql1 = "insert into PO_Line (Quantity,PO_NO,item_total_Amount,Category_Id,SubCategory_Id,Assign_Status) values (" + quant + ",'" + row1.Cells[4].Value.ToString() + "','" + row1.Cells[3].Value.ToString() + "'," + cid + "," + id + ",'F');SELECT SCOPE_IDENTITY();";
                        poId = objdb.ExecuteScalar(sql1);


                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                if (poId > 0)
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Data Entered Successfully!";
                    txtpo.Text = "";
                    dateTimePicker1.Text = "";
                    cmbitemcat.Text = "";
                    cmbitemsubcat.Text = "";
                    txtquantity.Text = "";
                    txtamount.Text = "";
                    dataGridView1.Rows.Clear();
                    txtpo.Focus();
                    //lblmessage.Text = "";
                }

            }

        }


        private void formclear_function()
        {
        }

        private void PODetailsForm2_Load(object sender, EventArgs e)
        {
            //Add L

            lblMessage.Text = "";
            lblmessage1.Text = "";
            lblmessage2.Text = "";
            lblmessage3.Text = "";
            lblmessage4.Text = "";
            lblmessage5.Text = "";
            //PODetailsForm2_Load(null, null);

            txtpo.Text = "";
            dateTimePicker1.Text = "";
            cmbitemcat.Text = "";
            cmbitemsubcat.Text = "";
            txtquantity.Text = "";
            txtamount.Text = "";

            string sql1 = "select * from Asset_Category";
            DataTable dt2 = objdb.RetrunDataTable(sql1);
            cmbitemcat.DataSource = dt2;
            cmbitemcat.DisplayMember = "Category_Desc";
            cmbitemcat.ValueMember = "Category_Id";
            cmbitemcat.SelectedIndex = -1;


            // dataGridView1.Columns.Add("Item_Category", "Item_Category");
            //dataGridView1.Columns.Add("Item_Name", "Item_Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Category_Id", "Item Category");
            dataGridView1.Columns.Add("SubCategory_Id", "Item Subcategory");
            dataGridView1.Columns.Add("item_total_Amount", "Total Amount");
            dataGridView1.Columns.Add("PO_NO", "ProductOrderNumber");
            dataGridView1.Columns.Add("PO_date", "PurchaseDate");
            //dataGridView1.Columns.Add("SubCategory", "SubCategory");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void cmbitemcat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cmbitemcat.SelectedValue.ToString(), out id))
            {
                //combodivname.DataSource = null;
                string sql4 = "Select * from [Assets_subcategory] where Category_Id='" + id + "'";
                DataTable dt3 = objdb.RetrunDataTable(sql4);
                cmbitemsubcat.DataSource = dt3;
                cmbitemsubcat.DisplayMember = "SubCategory_Desc";
                cmbitemsubcat.ValueMember = "Subcategory_Id";
                cmbitemsubcat.SelectedIndex = -1;
            }
        }
        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                state = true;
                // int.TryParse(dataGridView1.Rows[index].Cells[0].Value.ToString(), out id);
                txtpo.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txtamount.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                cmbitemcat.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                cmbitemsubcat.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtquantity.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                //sid = Convert.ToInt32( dataGridView1.Rows[index].Cells[6].Value.ToString());                
            }
        }
        public void loadGrid()
        {
            //Load divsion gridview
            string sqlemployee = "Select * from ";
            DataTable dt2 = objdb.RetrunDataTable(sqlemployee);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bool end = false;
            string poduplicatecheckquery = "select PO_NO from PO_Header";
            DataTable dtpo = objdb.RetrunDataTable(poduplicatecheckquery);
            
            foreach(DataRow dgwr in dtpo.Rows)
            {
                String dbpo = dgwr[0].ToString().Trim();
               if (dbpo == txtpo.Text)
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "PO Number Already Exists";
                    label3.Visible = true;
                    end = true;
                    
                }               
                                  
                if (end) return;
            }
            if (txtquantity.Text == "")
            {

                lblmessage2.Text = "**";
                txtquantity.Focus();     

            }
            else
            {
                lblmessage2.Text = "";
            }
            if (txtamount.Text == "")
            {
                lblmessage3.Text = "**";
                txtamount.Focus();
               
            }
            else
            {
                lblmessage3.Text = "";
            }

            if (txtpo.Text == "")
            {
                lblmessage1.Text = "**";
                txtpo.Focus();
                // return;
            }
            else
            {
                lblmessage1.Text = "";
            }
            if (cmbitemcat.Text == "")
            {
                lblmessage4.Text = "**";
                cmbitemcat.Focus();
            }
            else
            {
                lblmessage4.Text = "";
            }
            if (cmbitemsubcat.Text == "")
            {
                lblmessage5.Text = "**";
                txtquantity.Focus();
            }
            else
            {
                lblmessage5.Text = "";
            }

            if (txtquantity.Text != "" && txtamount.Text != "" && txtpo.Text != "" && cmbitemcat.Text != "" && cmbitemsubcat.Text != "")
            {
                lblmessage2.Text = "";
                lblmessage3.Text = "";
                lblmessage1.Text = "";
                lblmessage4.Text = "";
                lblmessage5.Text = "";
                bool res = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string txtPoN = row.Cells[4].Value.ToString();
                    string itmCat = row.Cells[2].Value.ToString();
                    string itmSubCat = row.Cells[1].Value.ToString();

                    if (txtPoN == txtpo.Text && cmbitemcat.Text == itmSubCat && cmbitemsubcat.Text == itmCat)
                    {
                        res = true;

                    }
                }

                if (!res)
                {
                    var amount = String.Format("{0:0.00}", Convert.ToDouble(txtamount.Text));//Try with ##
                    dataGridView1.Rows.Add(txtquantity.Text, cmbitemcat.Text, cmbitemsubcat.Text, amount, txtpo.Text, dateTimePicker1.Text);
                    txtquantity.Text = "";
                    txtamount.Text = "";
                    cmbitemcat.Focus();
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Item already added to the list!";
                    label3.Visible = true;
                    
                }
            }

            //txtpo.Text = "";
            dateTimePicker1.Text = "";
            cmbitemcat.Text = "";
            cmbitemsubcat.Text = "";
            //txtquantity.Text = "";
            //txtamount.Text = "";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
        }
        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                int id = 0;
                int val = 0;

                int.TryParse(dataGridView1.Rows[index].Cells[0].Value.ToString(), out id);
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(index);

                        string sql = "Delete FROM PO_Line where Id='" + id + "'";
                        val = objdb.ExecuteNonQuery(sql);
                        if (val > 0)
                        {
                            label3.ForeColor = Color.Green;
                            label3.Text = "Successfully Deleted!";
                            label3.Visible = true;                            
                            loadGrid();
                        }
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
                else
                {
                }
            }
            catch (Exception)
            {         
               
            }           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void txtpo_MouseLeave(object sender, EventArgs e)
        {
        }
        private void txtpo_Leave(object sender, EventArgs e)
        {
            if (txtpo.Text != "")
            {
                lblmessage1.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void cmbitemcat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtpo_KeyUp(object sender, KeyEventArgs e)
        {
            lblMessage.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpo.Text = "";
            dateTimePicker1.Text = "";
            cmbitemcat.Text = "";
            cmbitemsubcat.Text = "";
            txtquantity.Text = "";
            txtamount.Text = "";
            dataGridView1.DataSource = null;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtpo_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false; ;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {


        }
    }
}

