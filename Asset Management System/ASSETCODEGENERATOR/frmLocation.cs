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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id = 0;
        int cnt = 0;
        int ckeckcnt = 0;


        private void btnsave_Click(object sender, EventArgs e)
        {
            int val = 0;
            //int val1 = 0;
            if (tblocation.Text == "")
            {
                label3.ForeColor = Color.Red;
                label3.Text = " ** ";
                label3.Visible = true;
                return;
            }


            else
            {
                string sql1 = "SELECT COUNT( Location_name ) FROM Location WHERE Location_name like '" + tblocation.Text + "'";
                string sql2 = "SELECT  Location_name FROM Location WHERE Location_name like '" + tblocation.Text + "'";

                try
                {
                    // val = objdb.ExecuteNonQuery(sql1);
                    DataTable dt = objdb.RetrunDataTable(sql2);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (tblocation.Text == dr[0].ToString())
                        {
                            cnt += 1;
                        }
                        else
                        { }

                    }
                    if (cnt > 0)
                    {
                        clearText();
                        label4.ForeColor = Color.Red;
                        label4.Text = "Location already exists!";
                        label4.Visible = true;
                        cnt = 0;
                    }
                    else
                    {
                        string sql = "insert into Location (Location_name,Status) values ('" + tblocation.Text + "','0')";
                        int val1 = objdb.ExecuteNonQuery(sql);
                        if (val1 > 0)
                        {
                            label4.Text = "Inserted Successfully!";
                            label4.ForeColor = Color.Green;
                            label4.Visible = true;
                        }
                        loadGrid();
                        clearText();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (tblocation.Text == "")
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = " ** ";
                    label3.Visible = true;
                    loadGrid();
                    return;
                }
                int IntChkCount = 0;
                bool BRestLoop = false;
                foreach (DataGridViewRow dgvr in gdwLocation.Rows)
                {
                    if (dgvr.Cells[0].Value != null)
                    {

                        foreach (DataGridViewRow dgvrr in gdwLocation.Rows)
                        {
                            if (dgvrr.Cells[0].Value != null)
                            {
                                if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                                if (IntChkCount > 1) { label4.Text = "Please Select One Item at a time !"; label4.ForeColor = Color.Red; label4.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                            }

                        }

                        if (BRestLoop) break;
                        if (tblocation.Text == "")
                        {
                            label3.ForeColor = Color.Red;
                            label3.Text = " ** ";
                            label3.Visible = true;
                            loadGrid();
                            break;
                        }

                        String StrLocationName = dgvr.Cells[2].Value.ToString();
                        id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());

                        string sql2 = "SELECT  Location_name FROM Location WHERE Location_name = '" + tblocation.Text + "'";


                        // val = objdb.ExecuteNonQuery(sql1);
                        DataTable dt = objdb.RetrunDataTable(sql2);
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (tblocation.Text == dr[0].ToString())
                            {
                                cnt += 1;
                            }
                            else
                            { }
                        }
                        if (cnt > 0)
                        {
                            clearText();
                            label4.ForeColor = Color.Red;
                            label4.Text = "Location already exists!";
                            label4.Visible = true;
                            cnt = 0;
                            loadGrid();
                            break;
                        }
                        else
                        {
                            int val = 0;

                            string sql5 = "UPDATE Location SET Location_name= '" + tblocation.Text + "'  WHERE Location_Id='" + id + "'";
                            val = objdb.ExecuteNonQuery(sql5);
                            label4.ForeColor = Color.ForestGreen;
                            label4.Text = "Updated Successfully!";
                            label4.Visible = true;
                            // loadGrid();

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




        public void clearText()
        {
            tblocation.Text = "";
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            loadGrid();
            
        }

        public void loadGrid()
        {
            //Load divsion gridview
            string sqldivision = "  Select Location_Id as [Location ID],Location_name as [Location Name],Status  from Location ";
            DataTable dt2 = objdb.RetrunDataTable(sqldivision);
            gdwLocation.DataSource = dt2;
          //  gdwLocation.Refresh();           
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            btndisable.Enabled = false ;
            clearText();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gdwLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                //state = true;
                // int.TryParse(gdwLocation.Rows[index].Cells[0].Value.ToString(), out id);
                tblocation.Text = gdwLocation.Rows[index].Cells[2].Value.ToString();
               
            }

        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gdwLocation_MouseClick(object sender, MouseEventArgs e)
        {

            btnupdate.Enabled = true;
            btnsave.Enabled = false;
            label4.Visible = false;
            label3.Visible = false;
            btndisable.Enabled = true;
           
        }


        private void gdwLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblocation_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;

        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
        }

        private void tblocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in gdwLocation.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in gdwLocation.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label4.Text = "Please Assigned One Item at a time !"; label4.ForeColor = Color.Red; label4.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }

                    }

                    if (BRestLoop) break;

                    int val = 0;
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString().Trim());
                    String Status = (dgvr.Cells[3].Value.ToString().Trim());
                    DialogResult result = MessageBox.Show("Do you want to Enable/disable this?", "warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (Status == "0")
                        {
                            string sql = " update Location set Status = '1' where Location_Id = '" + id + "'";
                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label4.ForeColor = Color.ForestGreen;
                                label4.Text = "Disabled Successfully!";
                                label4.Visible = true;
                                loadGrid();
                            }
                        }
                        else
                        {
                            string sql = " update Location set Status = '0' where Location_Id = '" + id + "'";
                            val = objdb.ExecuteNonQuery(sql);
                            if (val > 0)
                            {
                                label4.ForeColor = Color.ForestGreen;
                                label4.Text = "Enabled Successfully!";
                                label4.Visible = true;
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

        private void gdwLocation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwLocation.CurrentCell = null;
        }
    }
}