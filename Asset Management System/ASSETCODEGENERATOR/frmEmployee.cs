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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id = 0;
        int cnt = 0;

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            int val = 0;

            if (comboDivisionId.Text == "")
            {
                label11.ForeColor = Color.Red;
                label11.Text = " ** ";
                label11.Visible = true;
                return;
            }
            else if (txtempname.Text == "")
            {
                label12.ForeColor = Color.Red;
                label12.Text = " ** ";
                label12.Visible = true;
                return;
            }
            else if (tbService_Number.Text == "")
            {
                label14.ForeColor = Color.Red;
                label14.Text = " ** ";
                label14.Visible = true;
                return;
            }
            else if (employee_designation.Text == "")
            {
                label8.ForeColor = Color.Red;
                label8.Text = " ** ";
                label8.Visible = true;
                return;
            }

            else
            {
                string sql2 = "  SELECT  Employee_Name,Division_Id,Location_Id,Service_No FROM Employee WHERE Service_No = '" +tbService_Number.Text+ "'";
                int cdsv = Convert.ToInt32(comboDivisionId.SelectedValue);
                int clsv = Convert.ToInt32(cmblocation.SelectedValue);
                // val = objdb.ExecuteNonQuery(sql1);
                DataTable dt = objdb.RetrunDataTable(sql2);
                    foreach (DataRow dr in dt.Rows)
                    {
                       int Divid = Convert.ToInt32(dr[1].ToString());
                       int Locid = Convert.ToInt32(dr[2].ToString());
                   
                    String sno = dr[3].ToString();
                    if(Divid == cdsv && Locid == clsv)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = "Employee already exists in this Division";
                        label9.Visible = true;
                        return;
                    }
                   

                   else if (txtempname.Text == dr[0].ToString())
                        {
                            cnt += 1;
                        }
                        else
                        {
                        }

                    }
                if (cnt > 0)
                {

                    label9.ForeColor = Color.Red;
                    label9.Text = "Employee already exists!";
                    label9.Visible = true;
                    cnt = 0;
                    
                }
                else
                {

                    String searchEmployee = txtempname.Text;

                    string sql = "insert into Employee (Employee_Name,Division_Id,Location_Id,Designation,Service_No,Status) values ('" + txtempname.Text + "','" + comboDivisionId.SelectedValue + "','" + cmblocation.SelectedValue + "','" + employee_designation.Text + "','" + tbService_Number.Text + "','0')";
                    val = objdb.ExecuteNonQuery(sql);
                    if (val > 0)
                    {
                        label9.ForeColor = Color.Green;
                        label9.Text = " Inserted Succesfully";
                        label9.Visible = true;
                        
                        
                    }
                 }
                   
                }
            loadGrid();
            clearText();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in gdwemployee.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in gdwemployee.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { label9.ForeColor = Color.Red; label9.Text = "Please Assigned One Item at a time !";label9.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }

                        if (BRestLoop) break;

                        int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                        if (comboDivisionId.Text == "")
                        {
                            label11.ForeColor = Color.Red;
                            label11.Text = " ** ";
                            label11.Visible = true;
                            break; ;
                        }
                        else if (txtempname.Text == "")
                        {
                            label12.ForeColor = Color.Red;
                            label12.Text = " ** ";
                            label12.Visible = true;
                            break;
                        }
                        else if (employee_designation.Text == "")
                        {
                            label8.ForeColor = Color.Red;
                            label8.Text = " ** ";
                            label8.Visible = true;
                            return;
                        }
                        else if (tbService_Number.Text == "")
                        {
                            label14.ForeColor = Color.Red;
                            label14.Text = " ** ";
                            label14.Visible = true;
                            break;
                        }
                        else
                        {                                              
                                int val1 = 0;
                                // MessageBox.Show(id.ToString());
                                string sql8 = "UPDATE Employee SET Designation = '" + employee_designation.Text + "',Division_Id='" + comboDivisionId.SelectedValue + "',Location_Id='" + cmblocation.SelectedValue + "'  WHERE Employee_Id='" + id + "'";
                                val1 = objdb.ExecuteNonQuery(sql8);
                                if (val1 > 0)
                                {
                                    label9.ForeColor = Color.Green;
                                    label9.Text = " Updated Succesfully";
                                    label9.Visible = true;
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

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string sql1 = "Select * from [Location]  where Status != '1' order by location_Id";
            DataTable dt2 = objdb.RetrunDataTable(sql1);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";          
            loadGrid();
        }
        private void cmblocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //int id = 0;
            //if (int.TryParse(cmblocation.SelectedValue.ToString(), out id))
            //{
            //    //combodivname.DataSource = null;
            //    string sql4 = "Select * from [Division] where Location_Id='" + id + "'";
            //    DataTable dt3 = objdb.RetrunDataTable(sql4);
            //    comboDivisionId.DataSource = dt3;
            //    comboDivisionId.DisplayMember = "Division_name";
            //    comboDivisionId.ValueMember = "Division_Id";
            //    loadGrid();
            //} 

            string sql2 = "  select D.Division_name,D.Division_Id from Division D inner join Division_Location_Assignment DLA on D.Division_Id=DLA.Division_Id where DLA.Locatoin_Id ='" + cmblocation.SelectedValue + "' ";
            DataTable dt = objdb.RetrunDataTable(sql2);
            comboDivisionId.DataSource = dt;
            comboDivisionId.DisplayMember = "Division_name";
            comboDivisionId.ValueMember = "Division_Id";
            comboDivisionId.SelectedIndex = -1;
        }

        public void clearText()
        {
            comboDivisionId.Text = "";
            txtempname.Text = "";
            cmblocation.Text = "";
            employee_designation.Text = "";
            tbService_Number.Text = "";

        }

        public void loadGrid()
        {
            //Load Employee gridview
            string sqlemployee = "    Select e.Employee_Id as [Employee ID],e.Employee_Name as [Employee Name],e.Designation,d.Division_name as [Division Name],l.Location_name as [Location Name],e.Service_No as [Service No],e.Status from Employee e,Location l , Division d where e.Division_Id = d.Division_Id and e.Location_Id = l.Location_Id ";
            DataTable dt2 = objdb.RetrunDataTable(sqlemployee);
        
            gdwemployee.DataSource = dt2;         
            gdwemployee.Refresh();
            

            btnupdate.Enabled = false;
            tbService_Number.Enabled = true;
            txtempname.Enabled = true;
            btnsave.Enabled = true;
            btnDisable.Enabled = false;
           
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void gdwemployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                //    state = true;
                //int.TryParse(gdwemployee.Rows[index].Cells[0].Value.ToString(), out id);
                txtempname.Text = gdwemployee.Rows[index].Cells[2].Value.ToString();
                comboDivisionId.Text = gdwemployee.Rows[index].Cells[4].Value.ToString();
                cmblocation.Text = gdwemployee.Rows[index].Cells[5].Value.ToString();
                employee_designation.Text = gdwemployee.Rows[index].Cells[3].Value.ToString();
                tbService_Number.Text = gdwemployee.Rows[index].Cells[6].Value.ToString();
            }

        }

        private void gdwemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void gdwemployee_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = false;
            label12.Visible = false;
            label14.Visible = false;
            label9.Visible = false;
            tbService_Number.Enabled = false;
            txtempname.Enabled = false;
            btnupdate.Enabled = true;
            btnsave.Enabled = false;
            btnDisable.Enabled = true;
            //int id = 0;
            ////int val = 0;

            //int.TryParse(gdwemployee.Rows[index].Cells[0].Value.ToString(), out id);
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        gdwemployee.Rows.RemoveAt(index);

            //        string sql = "Delete FROM Employee where Employee_Id='" + id + "'";
            //        val = objdb.ExecuteNonQuery(sql);
            //        if (val > 0)
            //        {
            //            label9.ForeColor = Color.Green;
            //            label9.Text = " Deleted Succesfully";
            //            label9.Visible = true;
            //            loadGrid();
            //            clearText();
            //        }
            //    }
            //    else if (result == DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            //else
            //{

            //}
        }

        private void comboDivisionId_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = false;
            label9.Visible = false;
        }

        private void txtempname_MouseClick(object sender, MouseEventArgs e)
        {
            label12.Visible = false;
            label9.Visible = false;
        }

        private void tbService_Number_MouseClick(object sender, MouseEventArgs e)
        {
            label14.Visible = false;
            label9.Visible = false;
        }

        private void employee_designation_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Visible = false;
        }

        private void cmblocation_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in gdwemployee.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in gdwemployee.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label9.Text = "Please Assigned One Item at a time !"; label9.ForeColor = Color.Red; label9.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }

                    }

                    if (BRestLoop) break;

                    int val = 0;
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                    String Status = (dgvr.Cells[7].Value.ToString().Trim());
                    DialogResult result = MessageBox.Show("Do you want to Enable/Disable this?", "warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (Status == "0")
                        {

                            string sql = "  update Employee set Status = '1' where Employee_Id = '" + id + "'";
                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label9.ForeColor = Color.ForestGreen;
                                label9.Text = "Disabled Successfully!";
                                label9.Visible = true;

                            }
                        }
                        else
                        {
                            string sql = "  update Employee set Status = '0' where Employee_Id = '" + id + "'";
                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label9.ForeColor = Color.ForestGreen;
                                label9.Text = "Enabled Successfully!";
                                label9.Visible = true;

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

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void gdwemployee_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwemployee.CurrentCell = null;
        }
    }
}
    
     








