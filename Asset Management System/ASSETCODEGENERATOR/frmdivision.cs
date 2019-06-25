using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseEngine;
using System.Data.SqlClient;
namespace ASSETCODEGENERATOR
{
    public partial class frmdivision : Form
    {
        public frmdivision()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id = 0;
        int cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtDivision.Text == "")
            {
                label3.ForeColor = Color.Red;
                label3.Text = " ** ";
                label3.Visible = true;
                return;
            }
            

            else
            {                               
                int rowIndex = -1;

                string sql1 = "Select Division_name from Division WHERE Division_name like '" + txtDivision.Text + "'";
                DataTable dt = objdb.RetrunDataTable(sql1);

                try
                {
                    if ((dt != null) && (dt.Rows.Count > 0))
                    {
                        label4.ForeColor = Color.Red;
                        label4.Text = "Division already exists!";
                        label4.Visible = true;
                        cnt = 0;
                    }

                    else
                    {
                        DatabaseEngine.DatabaseEngine.ExecuteNonQuery("SP_Insert_Division_Details",
                                                                     new SqlParameter("@DivisionName", txtDivision.Text),
                                                                     new SqlParameter("@Datetime", System.DateTime.Now.ToString()),
                                                                     new SqlParameter("@Status", "EN"));
                    
                       
                        label4.ForeColor = Color.Green;
                        label4.Text = "Inserted Successfully!";
                        label4.Visible = true;
                        loadGrid();
                    }
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.ToString());
                }

              
                clearText();
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            try
            {

                
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in dgwDivition.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in dgwDivition.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { lblMessage.Text = "Please Assigned One Item at a time !"; lblMessage.ForeColor = Color.Red; lblMessage.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }

                        if (BRestLoop) break;



                        int IntDivisionId = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        String StrAssignmentDate = dgvr.Cells[3].Value.ToString();
                        String StrLocationName = dgvr.Cells[4].Value.ToString();

                        if ((StrAssignmentDate == "") && (StrLocationName == ""))
                        {

                            string query10 = "insert into Division_Location_Assignment(Division_Id,Locatoin_Id,Assigned_Date,Enable) values ('" + IntDivisionId + "','" + comboLocation.SelectedValue + "','" + System.DateTime.Now.ToString() + "','" + true + "')";
                            int val = objdb.ExecuteNonQuery(query10);
                            label4.ForeColor = Color.Green;
                            lblMessage.Text = "Assigned Successfully!";
                            lblMessage.Visible = true;
                            dgvr.Cells[0].Value = false;
                            loadGrid();
                            break;
                        }

                        else
                        {
                            if (StrLocationName != comboLocation.Text)
                            {
                                DataTable dt = new DataTable();
                                dt = DatabaseEngine.DatabaseEngine.ReturnDatatable("SP_Select_Division_Location_Assignments", new SqlParameter("@DivisioinID", IntDivisionId),
                                                                                                                               new SqlParameter("@LocationID", comboLocation.SelectedValue));
                                if (dt.Rows.Count > 0)
                                {
                                    lblMessage.Text = "Location Already Assigned"; lblMessage.Visible = true; dgvr.Cells[0].Value = false; loadGrid(); break;
                                }
                                else
                                {
                                    string query10 = "insert into Division_Location_Assignment(Division_Id,Locatoin_Id,Assigned_Date,Enable) values ('" + IntDivisionId + "','" + comboLocation.SelectedValue + "','" + System.DateTime.Now.ToString() + "','" + true + "')";
                                    int val = objdb.ExecuteNonQuery(query10);
                                    label4.ForeColor = Color.Green;
                                    lblMessage.Text = "Assigned Successfully!";
                                    lblMessage.Visible = true;
                                    dgvr.Cells[0].Value = false;
                                    loadGrid();
                                    break;
                                }

                            }
                            else { lblMessage.Text = "Location Already Assigned"; lblMessage.ForeColor = Color.Red; lblMessage.Visible = true; dgvr.Cells[0].Value = false; loadGrid(); break; }
                        }




                    }
                    dgvr.Cells[0].Value = false;
                }

                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void frmdivision_Load(object sender, EventArgs e)
        {
            //Load location combobox
            string sql1 = "Select * from [Location]  where Status != '1' order by location_Id";
            DataTable dt = objdb.RetrunDataTable(sql1);
            comboLocation.DataSource = dt;
            comboLocation.DisplayMember = "Location_name";
            comboLocation.ValueMember = "Location_Id";
            loadGrid();
        }
        public void loadGrid()
        {
            //Load divsion gridview
            // string sqldivision = "select DLA.Id ,DIV.Division_name,LOC.Location_name,DLA.Assigned_Date from Division_Location_Assignment DLA  inner join Division DIV on DLA.Division_Id = DIV.Division_Id inner join Location LOC on DLA.Locatoin_Id = LOC.Location_Id order by DLA.Id";
            String sqldivision = "SELECT [Assets].[dbo].[Division].Division_Id as [Division ID] ,[Assets].[dbo].[Division].Division_name as [Division Name],[dbo].[Division_Location_Assignment].Assigned_Date as [Assignment Date],[dbo].[Location].Location_name as [Location Name]" +
                                " FROM[Assets].[dbo].[Division] left outer join[dbo].[Division_Location_Assignment] on[Assets].[dbo].[Division].Division_Id = [dbo].[Division_Location_Assignment].Division_Id left outer join[dbo].[Location] on[dbo].[Location].Location_Id=[dbo].[Division_Location_Assignment].Locatoin_Id ";
            DataTable dt2 = objdb.RetrunDataTable(sqldivision);
            //foreach(DataRow r in dt2.Rows)
            //{
            //    int n = dgwDivition.Rows.Add();
            //    dgwDivition.Rows[n].Cells[0].Value = "false";
            //    dgwDivition.Rows[n].Cells[1].Value = r["Division_Id"].ToString();
            //    dgwDivition.Rows[n].Cells[2].Value = r["Division_name"].ToString();
            //   // dgwDivition.Rows[n].Cells[3].Value = r["Location_name"].ToString();
            //    //dgwDivition.Rows[n].Cells[3].Value = r["Assigned_Date"].ToString();
            //}
            dgwDivition.DataSource = dt2;          
            dgwDivition.Refresh();
            btnupdate.Enabled = false;
            pnlLocation.Enabled = false;
            button1.Enabled = true;
        }
        private void dgwDivition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                // state = true;
                // int.TryParse(dgwDivition.Rows[index].Cells[0].Value.ToString(), out id);
               // txtDivision.Text = dgwDivition.Rows[index].Cells[1].Value.ToString();
                comboLocation.Text = dgwDivition.Rows[index].Cells[4].Value.ToString();
                //    pnlLocation.Enabled = true;
                //    button1.Enabled = false;
                //    btnupdate.Enabled = true;
                //    label4.Visible = false;
                //    label3.Visible = false;
                //    label5.Visible = false;
                //}
            }
            }
        public void clearText()
        {
            txtDivision.Text = "";
            txtDivision.Focus();
        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwDivition_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
           lblMessage.Visible = false;



            //  int.TryParse(dgwDivition.Rows[index].Cells[0].Value.ToString(), out id);
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        dgwDivition.Rows.RemoveAt(index);

            //        string sql = "Delete FROM Division where Division_Id='" + id + "'";
            //        val = objdb.ExecuteNonQuery(sql);
            //        if (val > 0)
            //        {
            //            MessageBox.Show("Successfully Deleted!");
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

        private void dgwDivition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnupdate.Enabled = true;
            pnlLocation.Enabled = true;
            button1.Enabled = false;
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            //if (e.ColumnIndex == dgwDivition.Columns["Select"].Index)

            //{

            //    dgwDivition.EndEdit();  //Stop editing of cell.

            //    if ((bool)dgwDivition.Rows[e.RowIndex].Cells["Select"].Value)

            //        MessageBox.Show("The Value is Checked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    else

            //        MessageBox.Show("UnChecked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            try
            {
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach(DataGridViewRow dgvr in dgwDivition.Rows)
                {
                    if(dgvr.Cells[0].Value !=null)
                    {

                        foreach (DataGridViewRow dgvrr in dgwDivition.Rows) {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { lblMessage.Text = "Please Assigned One Item at a time !"; lblMessage.ForeColor = Color.Red; lblMessage.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }

                        if (BRestLoop) break;



                        int IntDivisionId = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        String StrAssignmentDate = dgvr.Cells[3].Value.ToString();
                        String StrLocationName = dgvr.Cells[4].Value.ToString();

                        if ((StrAssignmentDate == "") && (StrLocationName == "")) {
                      
                                string query10 = "insert into Division_Location_Assignment(Division_Id,Locatoin_Id,Assigned_Date,Enable) values ('" + IntDivisionId + "','" + comboLocation.SelectedValue + "','" + System.DateTime.Now.ToString() + "','" + true + "')";
                                int val = objdb.ExecuteNonQuery(query10);
                                label4.ForeColor = Color.Green;
                                lblMessage.Text = "Assigned Successfully!";
                                lblMessage.Visible = true;
                                dgvr.Cells[0].Value = false;
                                loadGrid();
                                break;
                        }

                        else
                        {
                            if (StrLocationName != comboLocation.Text) 
                            {
                                DataTable dt = new DataTable();
                                dt =DatabaseEngine .DatabaseEngine .ReturnDatatable ("SP_Select_Division_Location_Assignments",new SqlParameter("@DivisioinID",IntDivisionId),
                                                                                                                               new SqlParameter ("@LocationID",comboLocation.SelectedValue));
                                if (dt.Rows.Count > 0)
                                {
                                    lblMessage.Text = "Location Already Assigned"; lblMessage.ForeColor = Color.Red; lblMessage.Visible = true; dgvr.Cells[0].Value = false; loadGrid(); break; 
                                }
                                else
                                {
                                    string query10 = "insert into Division_Location_Assignment(Division_Id,Locatoin_Id,Assigned_Date,Enable) values ('" + IntDivisionId + "','" + comboLocation.SelectedValue + "','" + System.DateTime.Now.ToString() + "','" + true + "')";
                                    int val = objdb.ExecuteNonQuery(query10);
                                    label4.ForeColor = Color.Green;
                                    lblMessage.Text = "Assigned Successfully!";
                                    lblMessage.Visible = true;
                                    dgvr.Cells[0].Value = false;
                                    loadGrid();
                                    break;
                                }
                              
                            }
                            else { lblMessage.Text = "Location Already Assigned"; lblMessage.ForeColor = Color.Red; lblMessage.Visible = true; dgvr.Cells[0].Value = false; loadGrid(); break; }
                        }

                                        

                    
                    }
                    dgvr.Cells[0].Value = false;
                }
                
                loadGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void txtDivision_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;

        }

        private void txtDivision_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            lblMessage.Visible = false;
        }

        private void txtDivision_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgwDivition_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgwDivition.CurrentCell = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void comboLocation_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    int id = 0;
        //    if (int.TryParse(comboLocation.SelectedValue.ToString(), out id))
        //    {
        //        //combodivname.DataSource = null;
        //        string sql4 = "Select * from [Division] where Location_Id='" + id + "'";
        //        DataTable dt3 = objdb.RetrunDataTable(sql4);
        //        txtDivision.DataSource = dt3;
        //        txtDivision.DisplayMember = "Division_name";
        //        txtDivision.ValueMember = "Division_Id";
        //        loadGrid();
        //    } 
        //}
    }
}