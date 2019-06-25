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
    public partial class frmAssignAssets : Form
    {
        public frmAssignAssets()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        int id = 0;
        int ID = 0;
        int i;
        int j;
        bool state = false;
        int index = -1;
        string sql = "";
        string subcat_value, cat_value = "";
        int cat, subcat;
        string assignid;
        int countqunt, countqunt1,val3;
        private void button1_Click(object sender, EventArgs e)
        {
            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in dataGridView1.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { lblmessage.Text = "Please Assigned One Item at a time !"; lblmessage.ForeColor = Color.Red; lblmessage.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }
                        
                    }
                    if (cmblocation.Text == "" || combodivname.Text == "" || comboempname.Text == "" || label9.Text == "" || textBox8.Text == "")
                    {                                             
                            lblmessage.ForeColor = Color.Red;
                            lblmessage.Text = "Some fields are empty!";
                            lblmessage.Visible = true;
                        return;
                    }

                    if (BRestLoop) break;
                    int val = 0;
                    int val1 = 0;
                    int tb8;
                    int qunatity = 0;
                   

                    string sql5 = "select Quantity from PO_Line where Id = '" + Convert.ToInt32(assignid) + "'";
                    val1 = objdb.ExecuteScalar(sql5);
                    // MessageBox.Show(val1.ToString());
                    //  MessageBox.Show(textBox8.Text);  
                    tb8 = Convert.ToInt32(textBox8.Text);
                    if (cmblocation.Text == "")
                    {

                        lblmessage4.Text = "**";
                        cmblocation.Focus();
                    }
                    else
                    {
                        lblmessage4.Text = "";
                    }
                    if (combodivname.Text == "")
                    {
                        lblmessage5.Text = "**";
                        combodivname.Focus();
                    }
                    else
                    {
                        lblmessage5.Text = "";
                    }
                    if (comboempname.Text == "")
                    {
                        lblmessage6.Text = "**";
                        comboempname.Focus();
                    }
                    else
                    {
                        lblmessage6.Text = "";
                    }
                    if (cmblocation.Text != "" && combodivname.Text != "" && comboempname.Text != "" && label9.Text!="" && textBox8.Text!="")
                    {
                        lblmessage4.Text = "";
                        lblmessage5.Text = "";
                        lblmessage6.Text = "";
                        if (val1 == tb8)
                        {
                            //string sql = "insert into Asset_Assign (Location_Id,Division_Id,Employee_Id,Subcategory_Id,PO_NO,PO_ID) values ('" + cmblocation.SelectedValue + "','" + combodivname.SelectedValue + "','" + comboempname.SelectedValue + "','" + combosubasset.SelectedValue + "','" + label9.Text + "'," + Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value) + ")";
                            //val = objdb.ExecuteNonQuery(sql);
                            string sub_query = "select Subcategory_Id from Assets_subcategory where SubCategory_Desc='" + subcat_value + "'";
                            string cat_query = "select Category_Id from Asset_Category where Category_Desc='" + cat_value + "'";
                            int cat = objdb.Read_Subcat(cat_query);
                            int subcat = objdb.Read_Subcat(sub_query);

                           
                            int x = Convert.ToInt32(textBox8.Text);
                            for (j = 0; j<x; j++)
                            {
                                string serial_query = "select max(SerialNo) from Asset_Assign where Category_Id=" + cat + " and Subcategory_Id=" + objdb.Read_Subcat(sub_query) + "";
                                int i = objdb.serialNo(serial_query);
                                if (i == 0)
                                {
                                    i = 1;
                                }
                                else
                                {
                                    i = i + 1;
                                }
                                
                                string sql = "insert into Asset_Assign(Location_Id,Division_Id,Employee_Id,Subcategory_Id,PO_NO,Assigned_Quantity,Category_Id,SerialNo,Verified_Status) values (" + Convert.ToInt32(cmblocation.SelectedValue) + "," + Convert.ToInt32(combodivname.SelectedValue) + "," + Convert.ToInt32(comboempname.SelectedValue) + "," + subcat + ",'" + label9.Text + "','" +1+ "'," + cat + "," + i + ",'0')";
                                val = objdb.ExecuteNonQuery(sql);

                            }

                          
                            
                           
                            //string sql1 = "insert into Asset_Transfer_History(AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO) Select AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO from Asset_Assign";
                            //val = objdb.ExecuteNonQuery(sql1);

                            //string sql2 = "insert into Asset_Verification_History(AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO) Select AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO from Asset_Assign";
                            //val = objdb.ExecuteNonQuery(sql2);
                            loadGrid();
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            
                            //string sql8 = "Update PO_Line set Assigned_Status='t' where Id = '" + Convert.ToInt32(assignid) + "'";
                            //val = objdb.ExecuteNonQuery(sql8);
                            //comboBox1.Text = "";
                            //cmblocation.Text = "";
                            //combodivname.Text = "";
                            //comboempname.Text = "";                               
                            comboBox1.Focus();
                            if (val > 0)
                            {
                                //MessageBox.Show("Successfully inserted!");
                                lblmessage.Text = "Asset Assignment Completed Successfully!";
                                lblmessage.ForeColor = Color.Green;
                                lblmessage.Visible = true;


                                //ID = Convert.ToInt32(label9.Text.Rows[index].Cells[0].Value.ToString());
                                bool state = false;
                                string sqldelete = "Update PO_Line set Assign_Status='T' where Id = '" + Convert.ToInt32(assignid) + "'";
                                val = objdb.ExecuteNonQuery(sqldelete);
                                string polinestatus = " select Assign_Status from PO_Line where PO_NO ='" + label9.Text + "'";
                                DataTable dt = objdb.RetrunDataTable(polinestatus);
                                int rowcun = 0;
                                foreach(DataRow dr in dt.Rows)
                                {
                                   String stat = dr[0].ToString().Trim();
                                    if(stat == "T")
                                    {
                                        rowcun += 1;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                    state = true;
                                }

                                if(state)
                                {
                                    string pohuquery = "update PO_Header set Assign_Status = 'T' where PO_NO = '"+ label9.Text + "'";
                                    val = objdb.ExecuteNonQuery(pohuquery);
                                }
                               

                                //string sqldelete1 = "Update PO_Header set Assigne_Status='T' where PO_NO = '" + label9.Text + "'";
                                //val = objdb.ExecuteNonQuery(sqldelete1);
                                //MessageBox.Show(label9.Text);
                                // dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                                comboBox1.SelectedIndex = -1;
                                comboasset.SelectedIndex = -1;
                                combosubasset.SelectedIndex = -1;
                                comboBox1.Focus();
                                // MessageBox.Show(cmblocation.SelectedValue.ToString());
                                gdwassignassets.DataSource = null;
                                loadGrid();
                                //loadgrid_1();
                                //for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                                //{
                                //    if ((bool)dataGridView1.Rows[i].Cells[0].FormattedValue)
                                //    {
                                //        dataGridView1.Rows.RemoveAt(i);
                                //    }
                                //}
                            }
                        }

                        else if (val1 < tb8)
                        {
                            lblmessage.Visible = true;
                            lblmessage.ForeColor = Color.Red;
                            lblmessage.Text = "Assigning Quantity is higher than the available Quantity";

                        }
                        else if (val1 > tb8)
                        {
                            string sub_query = "select Subcategory_Id from Assets_subcategory where SubCategory_Desc='" + subcat_value + "'";
                            string cat_query = "select Category_Id from Asset_Category where Category_Desc='" + cat_value + "'";
                            int cat = objdb.Read_Subcat(cat_query);
                            int subcat = objdb.Read_Subcat(sub_query);


                            int x = Convert.ToInt32(textBox8.Text);
                            for (j = 0; j < x; j++)
                            {
                                string serial_query = "select max(SerialNo) from Asset_Assign where Category_Id=" + cat + " and Subcategory_Id=" + objdb.Read_Subcat(sub_query) + "";
                                int i = objdb.serialNo(serial_query);
                                if (i == 0)
                                {
                                    i = 1;
                                }
                                else
                                {
                                    i = i + 1;
                                }

                                string sql = "insert into Asset_Assign(Location_Id,Division_Id,Employee_Id,Subcategory_Id,PO_NO,Assigned_Quantity,Category_Id,SerialNo,Verified_Status) values (" + Convert.ToInt32(cmblocation.SelectedValue) + "," + Convert.ToInt32(combodivname.SelectedValue) + "," + Convert.ToInt32(comboempname.SelectedValue) + "," + subcat + ",'" + label9.Text + "','" + 1 + "'," + cat + "," + i + ",'0')";
                                val3 = objdb.ExecuteNonQuery(sql);
                            }
                                int remainingQuantity = val1 - tb8;
                           // MessageBox.Show(assignid);
                            string sql6 = "update PO_Line set Quantity = '" + remainingQuantity + "'  where Id = '" + Convert.ToInt32(assignid) + "'";
                            val = objdb.ExecuteNonQuery(sql6);
                            lblmessage.ForeColor = Color.Green;
                            lblmessage.Text = "Database Updated Successfully";
                            lblmessage.Visible = true;
                            //MessageBox.Show(remainingQuantity.ToString());
                            clearText();
                            loadGrid();
                            loadgrid1();
                        }
                        // MessageBox.Show(Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value).ToString());
                        clearText();
                    }
                  
                
                    
                }
                
            }
            foreach (DataGridViewRow dgvr1 in dataGridView1.Rows)
            { dgvr1.Cells[0].Value = false; }
            dataGridView1.CurrentCell = null;
            loadGrid();
            clearText();
        }
        
        
        private void frmAssignAssets_Load(object sender, EventArgs e)
        {
            lblmessage.Text = "";
            lblmessage4.Text = "";
            lblmessage5.Text = "";
            lblmessage6.Text = "";

            string sql1 = "  Select PO_NO from [PO_Header] where Assign_Status !='T'";
            DataTable dt = objdb.RetrunDataTable(sql1);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PO_NO";
            comboBox1.ValueMember = "PO_NO";

            string sql2 = "Select * from [Location] where Status !=''";
            DataTable dt1 = objdb.RetrunDataTable(sql2);
            cmblocation.DataSource = dt1;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";
            cmblocation.SelectedIndex = -1;
            loadGrid();
        }
        //Loading the employee values

        private void cmblocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cmblocation.SelectedValue.ToString(), out id))
            {
                //combodivname.DataSource = null;
                string sql4 = "select Distinct dla.Division_Id,div.Division_name from Division_Location_Assignment dla inner join Division div on dla.Division_Id = div.Division_Id where dla.Locatoin_Id ='" + id + "'";
                DataTable dt3 = objdb.RetrunDataTable(sql4);
                combodivname.DataSource = dt3;
                combodivname.DisplayMember = "Division_name";
                combodivname.ValueMember = "Division_Id";
            }
        }
        //loading the emoloyee values

        private void combodivname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(combodivname.SelectedValue.ToString(), out id))
            {
                comboempname.DataSource = null;
                string sql3 = "Select * from [Employee] where Division_Id='" + id + "' and Status !='1'";
                DataTable dt2 = objdb.RetrunDataTable(sql3);
                comboempname.DataSource = dt2;
                comboempname.DisplayMember = "Employee_Name";
                comboempname.ValueMember = "Employee_Id";
            }
        }
        //load subcategory descriptions
        private void comboasset_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //combosubasset.DataSource = null;
            //string sql5 = "Select DISTINCT(s.SubCategory_Desc),s.Subcategory_Id from PO_Line p,Assets_subcategory s where PO_NO='" + comboBox1.SelectedValue + "' and p.Category_Id='" + comboasset.SelectedValue + "' and p.SubCategory_Id=s.Subcategory_Id and s.Status!='1'";
            //DataTable dt4 = objdb.RetrunDataTable(sql5);
            //combosubasset.DataSource = dt4;
            //combosubasset.DisplayMember = "SubCategory_Desc";
            //combosubasset.ValueMember = "Subcategory_Id";

        }
        public void loadGrid()
        {
            // gdwassignassets.DataSource = null;
            //int id = 0;
            //int.TryParse(combosubasset.SelectedValue.ToString(), out id);
            string sql1 = "  Select PO_NO from [PO_Header] where Assign_Status !='T'";
            DataTable dt = objdb.RetrunDataTable(sql1);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "PO_NO";
            comboBox1.ValueMember = "PO_NO";
            string sqlassetassign = "    select L.Location_name,D.Division_name,M.Category_Desc,S.SubCategory_Desc,E.Employee_Name,count(A.Assigned_Quantity) as Assigned_Quantity ,A.PO_NO from Location L ,Division D,Asset_Category M,Assets_subcategory S,Employee E,Asset_Assign A where E.Employee_Id=A.Employee_Id and L.Location_Id=A.Location_Id and D.Division_Id=A.Division_Id and S.Subcategory_Id=A.Subcategory_Id and M.Category_Id=A.Category_Id group by Location_name,Division_name,Category_Desc,SubCategory_Desc,Employee_Name,Assigned_Quantity,PO_NO";
            DataTable dt2 = objdb.RetrunDataTable(sqlassetassign);

            if (dt2.Rows.Count > 0)
            {
                gdwassignassets.DataSource = dt2;
                gdwassignassets.Refresh();
                //gdwassignassets.Columns[1].ReadOnly = true;
                //gdwassignassets.Columns[2].ReadOnly = true;
            }
        

        }
        public void loadgrid_1()
        {
            //string sql_load = "select PO_NO,Quantity,Item_ID from PO_Line where Cu_Status=1";
            //DataTable dt3 = objdb.RetrunDataTable(sql_load);
            //if (dt3.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = dt3;
            //    dataGridView1.Refresh();
            //    //gdwassignassets.Columns[1].ReadOnly = true;
            //    //gdwassignassets.Columns[2].ReadOnly = true;
            //}
        }

        public void loadgrid1()
        {
           
            string sql9 = "select a.Category_Desc,s.SubCategory_Desc,p.Quantity,Id from Asset_Category a ,Assets_subcategory s,PO_Line p  where p.Category_Id = a.Category_Id and p.SubCategory_Id = s.Subcategory_Id and  PO_NO='" + comboBox1.Text + "'and P.Assign_Status !='T'";
            DataTable dt2 = objdb.RetrunDataTable(sql9);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
            //string sql7 = "select Category_Id as [Category]='" + dataGridView1.Rows[index].Cells[1].Value.ToString() + "',SubCategory_Id as  [SubCategory] = '" + dataGridView1.Rows[index].Cells[2].Value.ToString() + "',Quantity,Id = '" + dataGridView1.Rows[index].Cells[3].Value.ToString() + "' from PO_Line where Id = '" + Convert.ToInt32(assignid) + "'";
            //DataTable dt3 = objdb.RetrunDataTable(sql7);
            //if (dt3.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = dt3;
            //    dataGridView1.Refresh();
            //    //    dataGridView1.Refresh();
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clearText()
        {
            cmblocation.SelectedIndex= -1;
            combodivname.SelectedIndex = -1;
            comboempname.SelectedIndex = -1;
            comboasset.SelectedIndex = -1;
            combosubasset.SelectedIndex = -1;
            textBox8.Text = "";
            label9.Text = "";
            //comboBox1.SelectedIndex = -1;
            //label8.Text = "";
            //gdwassignassets.DataSource = null;
            //gdwassignassets.Refresh();
        }

        private void gdwassignassets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    index = e.RowIndex;
            //    state = true;
            //    int.TryParse(gdwassignassets.Rows[index].Cells[0].Value.ToString(), out id);
            //    cmblocation.Text = gdwassignassets.Rows[index].Cells[1].Value.ToString();
            //    combodivname.Text = gdwassignassets.Rows[index].Cells[2].Value.ToString();
            //    comboempname.Text = gdwassignassets.Rows[index].Cells[3].Value.ToString();
            //    comboasset.Text = gdwassignassets.Rows[index].Cells[4].Value.ToString();
            //    combosubasset.Text = gdwassignassets.Rows[index].Cells[5].Value.ToString();
            //    txtquantity.Text = gdwassignassets.Rows[index].Cells[6].Value.ToString();
            //}
        }

        private void combosubasset_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //loadGrid();
        }

        private void gdwassignassets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboempname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show(comboasset.Text + combosubasset.Text + comboBox1.Text);
            try
            {
                //string sql9 = "select PO_NO,Quantity from PO_Line where Item_Category='" + comboasset.Text + "' and Sub_Category=" + combosubasset.Text + " and PO_NO='" + comboBox1.Text + "'";
                //string sql9 = "select a.Category_Desc,s.SubCategory_Desc,p.Quantity,Id from Asset_Category a ,Assets_subcategory s,PO_Line p  where p.Category_Id = a.Category_Id and p.SubCategory_Id = s.Subcategory_Id and  PO_NO='" + comboBox1.Text + "'";
                //DataTable dt2 = objdb.RetrunDataTable(sql9);
                //dataGridView1.DataSource = dt2;
                //dataGridView1.Refresh();
                loadgrid1();
            }
            catch(Exception ex)
            {
              //  MessageBox.Show(ex.ToString());
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string sql4 = "Select DISTINCT(a.Category_Desc),p.Category_Id from PO_Line p , Asset_Category a where PO_NO='" + comboBox1.SelectedValue + "'and p.Category_Id=a.Category_Id and p.Status!='1'";
            //DataTable dt3 = objdb.RetrunDataTable(sql4);
            //comboasset.DataSource = dt3;
            //comboasset.DisplayMember = "Category_Desc";
            //comboasset.ValueMember = "Category_Id";

        }

        private void comboasset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblmessage.Visible = false;
            ///index = e.RowIndex;
            ///label9.Text = comboBox1.Text;
            //label9.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            // label8.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            /// subcat_value = dataGridView1.Rows[index].Cells[1].Value.ToString();
            ///cat_value = dataGridView1.Rows[index].Cells[0].Value.ToString();
            /// textBox8.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {         

        }

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
           // lblmessage.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblmessage.Text = "";
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void gdwassignassets_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwassignassets.CurrentCell = null;
        }

        private void lbl_po_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                label9.Text = comboBox1.Text;
                //label9.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                // label8.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                subcat_value = dataGridView1.Rows[index].Cells[2].Value.ToString();
                cat_value = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textBox8.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                assignid = dataGridView1.Rows[index].Cells[4].Value.ToString();
               
            }
            
        }

       
            
    }
}
