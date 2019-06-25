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
    public partial class frmAssetSubCategory : Form
    {
        public frmAssetSubCategory()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id,cat_id = 0;
        int cnt = 0;

        private void btnsave_Click(object sender, EventArgs e)
        {
            int val = 0;

            if (txtsubcatdescription.Text == "")
            {
                label5.ForeColor = Color.Red;
                label5.Text = " ** ";
                label5.Visible = true;


            }
            else if (comboDescription.Text == "")
            {
                label8.ForeColor = Color.Red;
                label8.Text = " ** ";
                label8.Visible = true;
            }
            else
            {
                string sql2 = "SELECT  SubCategory_Desc FROM Assets_subcategory WHERE SubCategory_Desc like '" + txtsubcatdescription.Text + "'";
                
                // val = objdb.ExecuteNonQuery(sql1);
                DataTable dt = objdb.RetrunDataTable(sql2);
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtsubcatdescription.Text == dr[0].ToString())
                    {
                        cnt += 1;
                    }
                    else
                    {
                    }
                }
                if (cnt > 0)
                {

                    label6.ForeColor = Color.Red;
                    label6.Text = "Subcategory Description already exists!";
                    label6.Visible = true;
                    txtsubcatdescription.Text = "";
                    cnt = 0;
                }
                else
                {
                    string sql = "insert into Assets_subcategory (SubCategory_Desc,Category_Id,SubCategory_Number,Status) values ('" + txtsubcatdescription.Text + "','" + comboDescription.SelectedValue + "','" + txtItemNumber.Text + "','0')";
                    val = objdb.ExecuteNonQuery(sql);
                    label6.ForeColor = Color.Green;
                    label6.Text = "Inserted Successfully!";
                    label6.Visible = true;
                    clearText();
                }
            }
            loadGrid();
            
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in gdwassetsubcat.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in gdwassetsubcat.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { label6.Text = "Please Assigned One Item at a time !"; label6.ForeColor = Color.Red; label6.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }
                        
                        if (BRestLoop) break;


                        int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        //String StrAssignmentDate = dgvr.Cells[3].Value.ToString();
                        //String StrLocationName = dgvr.Cells[4].Value.ToString();
                        int val = 0;
                        if (txtsubcatdescription.Text == "")
                        {
                            label5.ForeColor = Color.Red;
                            label5.Text = " ** ";
                            label5.Visible = true;


                        }
                        else if (comboDescription.Text == "")
                        {
                            label8.ForeColor = Color.Red;
                            label8.Text = " ** ";
                            label8.Visible = true;
                        }
                       
                            else
                            {
                                string sql5 = "UPDATE Assets_subcategory SET Category_Id='" + comboDescription.SelectedValue + "', SubCategory_Desc='" + txtsubcatdescription.Text + "',SubCategory_Number='" + txtItemNumber.Text + "'  WHERE Subcategory_Id='" + id + "'";
                                val = objdb.ExecuteNonQuery(sql5);

                                label6.ForeColor = Color.Green;
                                label6.Text = "Updated Successfully!";
                                label6.Visible = true;
                                
                            }


                        

                    }
                    dgvr.Cells[0].Value = false;
                   
                }
                loadGrid();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                   
        }

        private void frmAssetSubCategory_Load(object sender, EventArgs e)
        {

            try
            {
                string sql1 = "SELECT [Category_Id],[Category_Desc]FROM[Assets].[dbo].[Asset_Category] where Status !='1' order by[Category_Desc] asc ";
                DataTable dt = objdb.RetrunDataTable(sql1);
                comboDescription.DataSource = dt;
                comboDescription.DisplayMember = "Category_Desc";
                comboDescription.ValueMember = "Category_Id";
                loadGrid();
                comboDescription.SelectedIndex = -1;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }


        }       
        public void clearText()
        {
            comboDescription.Text = "";
            txtsubcatdescription.Text = "";
            txtItemNumber.Text = "";
        }
        public void loadGrid()
        {
            //Load divsion gridview
            string sqlasetsubcategory = "SELECT[Assets].[dbo].[Assets_subcategory].Subcategory_Id as [SubCategory ID],[Assets].[dbo].[Asset_Category].Category_Desc as [Category Description],[Assets].[dbo].[Asset_Category].[Desig_letter] as [Designated Letter],[Assets].[dbo].[Assets_subcategory].SubCategory_Desc as [SubCategory Description],[Assets].[dbo].[Assets_subcategory].SubCategory_Number as [SubCategory Number],[Assets].[dbo].[Assets_subcategory].Status" +
       " FROM[Assets].[dbo].[Asset_Category] inner join[Assets].[dbo].[Assets_subcategory]on[Assets].[dbo].[Asset_Category].Category_Id= [Assets].[dbo].[Assets_subcategory].Category_Id";
            DataTable dt2 = objdb.RetrunDataTable(sqlasetsubcategory);
            gdwassetsubcat.DataSource = dt2;
            gdwassetsubcat.Refresh();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
        }

        private void comboDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gdwassetsubcat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                //state = true;
                //int.TryParse(gdwassetsubcat.Rows[index].Cells[0].Value.ToString(), out id);
               // int.TryParse(gdwassetsubcat.Rows[index].Cells[1].Value.ToString(),out cat_id);
               // string query = "select  Category_Desc from Asset_Category where Category_Id="+cat_id+"";
                //string value = objdb.Read_CatDesc(query);
                comboDescription.Text = gdwassetsubcat.Rows[index].Cells[2].Value.ToString(); ;
                txtsubcatdescription.Text = gdwassetsubcat.Rows[index].Cells[4].Value.ToString();
                txtItemNumber.Text = gdwassetsubcat.Rows[index].Cells[5].Value.ToString();
                btnupdate.Enabled = true;
                btnsave.Enabled = false;
                label6.Visible = false;
                label8.Visible = false;
                label5.Visible = false;
            }
        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdwassetsubcat_MouseClick(object sender, MouseEventArgs e)
        {
            btndelete.Enabled = true;
            btnupdate.Enabled = true;
            btnsave.Enabled = false;
        }

        private void comboDescription_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
            label8.Visible = false;
        }

        private void txtsubcatdescription_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
            label5.Visible = false;
        }

        private void txtItemNumber_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in gdwassetsubcat.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in gdwassetsubcat.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label6.Text = "Please Assigned One Item at a time !"; label6.ForeColor = Color.Red; label6.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }

                    }
                    
                    if (BRestLoop) break;
                   
                    int val = 0;
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                    String Status = (dgvr.Cells[6].Value.ToString());
                    DialogResult result = MessageBox.Show("Do you want to Enable/Disable this?", "warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)

                    {
                        if( Status == "0")
                        {
                            string sql = "Update Assets_subcategory SET Status = '1' where category_Id='" + id + "'";

                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label6.ForeColor = Color.Green;
                                label6.Text = "Disabled Successfully!";
                                label6.Visible = true; ;

                            }

                        }
                        else
                        {
                            string sql = "Update Assets_subcategory SET Status = '0' where category_Id='" + id + "'";

                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label6.ForeColor = Color.Green;
                                label6.Text = "Enabled Successfully!";
                                label6.Visible = true; ;

                            }
                        }
                        
                    }
                    else if (result == DialogResult.No)
                    {

                    }


                }
                dgvr.Cells[0].Value = false;
            }
            loadGrid();
            clearText();
        }

        private void gdwassetsubcat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwassetsubcat.CurrentCell = null;
        }

        private void gdwassetsubcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
