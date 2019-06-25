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
    public partial class frmAssetCategory : Form
    {
        public frmAssetCategory()
        {
            InitializeComponent();
        }


        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id = 0;
        int cnt = 0;
        int cnt1 = 0;
        int cnt2 = 0;
        int val = 0;
        string trdl = "";





        private void button1_Click(object sender, EventArgs e)
        {
            int val = 0;
            String trdl = txtDesigLetter.Text;
            if (txtDescription.Text == "")
            {
                label4.ForeColor = Color.Red;
                label4.Text = " ** ";
                label4.Visible = true;
                return;

            }
            else if (txtDesigLetter.Text == "")
            {
                label6.ForeColor = Color.Red;
                label6.Text = " ** ";
                label6.Visible = true;
                return;
            }
          
            else if (trdl.Length > 2)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Designated Letter should not be more than 2 letters! ";
                label5.Visible = true;
                txtDesigLetter.Text = "";
                return;
            }
            else if (trdl.Length < 2)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Designated Letter should not be less than 2 letters! ";
                label5.Visible = true;
                txtDesigLetter.Text = "";
                return;
            }
            else
            {
                string sql2 = "SELECT Category_Desc,Desig_letter,Status FROM Asset_Category WHERE Category_Desc like '" + txtDescription.Text + "' or Desig_letter like '" + txtDesigLetter.Text + "'";
                // val = objdb.ExecuteNonQuery(sql1);
                DataTable dt = objdb.RetrunDataTable(sql2);
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtDescription.Text == dr[0].ToString())
                    {
                        cnt += 1;
                    }
                    else if (txtDescription.Text == dr[1].ToString())
                    {
                        cnt1 += 1;
                    }

                }
                if (cnt > 0)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Category Description already exists!";
                    label5.Visible = true;
                    cnt = 0;
                }
                else if (cnt1 > 1)
                {
                    label5.ForeColor = Color.Red;
                    label5.Text = "Designated Letter already exists!";
                    label5.Visible = true;
                    cnt1 = 0;
                }
                else
                {
                    String sql = "insert into Asset_category (Category_Desc,Desig_letter,Status) values ('" + txtDescription.Text + "','" + txtDesigLetter.Text + "','0')";                   
                    val = objdb.ExecuteNonQuery(sql);

                        label5.ForeColor = Color.Green;
                        label5.Text = "Inserted Successfully!";
                        label5.Visible = true;                  
                }
                         
            loadGrid();
            clearText();
        }
    }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in gdwassetcat.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in gdwassetcat.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { label5.Text = "Please Assigned One Item at a time !"; label5.ForeColor = Color.Red; label5.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }
                        
                        if (BRestLoop) break;


                        int IntAssetcatId = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        //String StrAssignmentDate = dgvr.Cells[3].Value.ToString();
                        //String StrLocationName = dgvr.Cells[4].Value.ToString();
                        int val = 0;
                        trdl = txtDesigLetter.Text;
                        if (txtDescription.Text == "")
                        {
                            label4.ForeColor = Color.Red;
                            label4.Text = " ** ";
                            label4.Visible = true;
                            return;

                        }
                        else if (txtDesigLetter.Text == "")
                        {
                            label6.ForeColor = Color.Red;
                            label6.Text = " ** ";
                            label6.Visible = true;
                            return;
                        }
                        else if (trdl.Length > 2)
                        {
                            label5.ForeColor = Color.Red;
                            label5.Text = "Designated Letter should not be more than 2 letters! ";
                            label5.Visible = true;
                            txtDesigLetter.Text = "";
                            return;
                        }
                        else if (trdl.Length < 2)
                        {
                            label5.ForeColor = Color.Red;
                            label5.Text = "Designated Letter should not be less than 2 letters! ";
                            label5.Visible = true;
                            txtDesigLetter.Text = "";
                            return;
                        }
                        else
                        {
                            string sql2 = "SELECT Category_Desc,Desig_letter FROM Asset_Category WHERE Category_Desc like '" + txtDescription.Text + "' or Desig_letter like '" + txtDesigLetter.Text + "'";
                            // val = objdb.ExecuteNonQuery(sql1);
                            DataTable dt = objdb.RetrunDataTable(sql2);
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (txtDescription.Text == dr[0].ToString())
                                {
                                    cnt += 1;
                                }
                                else if (txtDescription.Text == dr[1].ToString())
                                {
                                    cnt1 += 1;
                                }

                            }
                            //if (cnt > 0)
                            //{
                            //    label5.ForeColor = Color.Red;
                            //    label5.Text = "Category Description already exists!";
                            //    label5.Visible = true;
                            //    cnt = 0;
                            //}
                            if (cnt1 > 1)
                            {
                                label5.ForeColor = Color.Red;
                                label5.Text = "Designated Letter already exists!";
                                label5.Visible = true;
                                cnt1 = 0;
                            }
                            else
                            {
                                String sql = "UPDATE Asset_Category SET Category_Desc='" + txtDescription.Text + "', Desig_letter='" + txtDesigLetter.Text + "'  WHERE Category_Id='" + IntAssetcatId + "'";
                                val = objdb.ExecuteNonQuery(sql);

                                label5.ForeColor = Color.Green;
                                label5.Text = "Updated Successfully!";
                                label5.Visible = true;
                            }
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


        private void frmAssetCategory_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        public void clearText()
        {
            txtDescription.Text = "";
            txtDesigLetter.Text = "";
        }
        public void loadGrid()
        {
            //Load divsion gridview
            string sqlassetcategory = "  Select [Assets].[dbo].[Asset_Category].Category_Id as [Category ID] ,[Assets].[dbo].[Asset_Category].Category_Desc as [Category Description] ,[Assets].[dbo].[Asset_Category].Desig_letter as [Designation Letter],[Assets].[dbo].[Asset_Category].Status from Asset_Category ";
            DataTable dt2 = objdb.RetrunDataTable(sqlassetcategory);
            gdwassetcat.DataSource = dt2;
            gdwassetcat.Refresh();
            button1.Enabled = true;
            btnupdate.Enabled = false;
            btnDelete.Enabled = false; ;
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gdwassetcat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                state = true;
                //int.TryParse(gdwassetcat.Rows[index].Cells[0].Value.ToString(), out id);
                txtDescription.Text = gdwassetcat.Rows[index].Cells[2].Value.ToString();
                txtDesigLetter.Text = gdwassetcat.Rows[index].Cells[3].Value.ToString();
                btnupdate.Enabled = true;
                button1.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdwassetcat_MouseClick(object sender, MouseEventArgs e)
        {
            ////int id = 0;
            ////int val = 0;

            ////int.TryParse(gdwassetcat.Rows[index].Cells[0].Value.ToString(), out id);
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        gdwassetcat.Rows.RemoveAt(index);

            //        string sql = "Update Asset_Category SET Status = '1' where category_Id='" + id + "'";
            //        val = objdb.ExecuteNonQuery(sql);
            //        if (val > 0)
            //        {
            //            label5.Text = "Deleted Successfully!";
            //            label5.Visible = true;
            //            clearText();
            //            loadGrid();
            //        }
            //    }
            //    else if (result == DialogResult.No)
            //    {

            //    }
            //}
            //else
            //{

            //}

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
           // label5.Visible = false;
        }

        private void txtDesigLetter_TextChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
           // label5.Visible = false;
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
        }

        private void txtDesigLetter_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in gdwassetcat.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in gdwassetcat.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { label5.Text = "Please Assigned One Item at a time !"; label5.ForeColor = Color.Red; label5.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }
                            

                        }
                        clearText();
                        if (BRestLoop) break;


                        int IntAssetcatId = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        String Status = (dgvr.Cells[4].Value.ToString().Trim());
                        DialogResult result = MessageBox.Show("Do you want to Enable/Disable this?", "warning", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //gdwassetcat.Rows.RemoveAt(index);
                            if (Status == "0")
                            {

                                string sql = "Update Asset_Category SET Status = '1' where category_Id='" + IntAssetcatId + "'";
                                val = objdb.ExecuteNonQuery(sql);
                                if (val > 0)
                                {
                                    label5.Text = "Disabled Successfully!";
                                    label5.Visible = true;
                                    clearText();
                                    loadGrid();
                                }
                            }
                            else
                            {
                                string sql = "Update Asset_Category SET Status = '0' where category_Id='" + IntAssetcatId + "'";
                                val = objdb.ExecuteNonQuery(sql);
                                if (val > 0)
                                {
                                    label5.Text = "Enabled Successfully!";
                                    label5.Visible = true;
                                    clearText();
                                    loadGrid();
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

    }

        private void gdwassetcat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwassetcat.CurrentCell = null;

        }




        //private void frmAssetCategory_Load(object sender, EventArgs e)
        //{
        //    string sql1 = "Select * from [Asset_Category] order by Category_Desc";
        //    DataTable dt = objdb.RetrunDataTable(sql1);
        //    comboDesigLetter.DataSource = dt;
        //    comboDesigLetter.DisplayMember = "Desig_letter";
        //    comboDesigLetter.ValueMember = "Category_Desc";
        //}
    }
}
