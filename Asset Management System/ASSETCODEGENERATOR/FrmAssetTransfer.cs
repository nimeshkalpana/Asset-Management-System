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
    public partial class FrmAssetTransfer : Form
    {
        public FrmAssetTransfer()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        bool state = false;
        int index = -1;
        int id,cat_id = 0;
        string barcode_2 = "";

        private void FrmAssetTransfer_Load(object sender, EventArgs e)
        {
            string sql1 = "Select * from [Location] order by location_Id";
            DataTable dt = objdb.RetrunDataTable(sql1);
            cblocation.DataSource = dt;
            cblocation.DisplayMember = "Location_name";
            cblocation.ValueMember = "Location_Id";
            loadgrid();
        }

        public void loadgrid()
        {
            String loaddgwaa = "  select AA.AssetId as [Asset ID],L.Location_name as [Location Name],D.Division_name as [Division Name],E.Employee_Name as [Employee Name],AC.Category_Desc as [Category],SC.SubCategory_Desc as [SubCategory],AA.PO_NO as [PO NO],AA.SerialNo as [Serial No] from Asset_Assign AA inner join Location L on AA.Location_Id=L.Location_Id inner join Division D on AA.Division_Id =D.Division_Id inner join Employee E on AA.Employee_Id = E.Employee_Id inner join Asset_Category AC on AA.Category_Id = AC.Category_Id inner join Assets_subcategory SC on AA.Subcategory_Id= SC.Subcategory_Id order by AA.AssetId";
            DataTable dt1 = objdb.RetrunDataTable(loaddgwaa);
            gdwAsssetassign.DataSource = dt1;
            gdwAsssetassign.CurrentCell = null;
        
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cblocation.SelectedValue.ToString(), out id))
            {
                //combodivname.DataSource = null;
                string sql4 = "  Select D.Division_name,Dla.Division_Id from  Division_Location_Assignment Dla inner join Division D on Dla.Division_Id=D.Division_Id where Dla.Locatoin_Id='" + id + "'";
                DataTable dt3 = objdb.RetrunDataTable(sql4);
                cbdivision.DataSource = dt3;
                cbdivision.DisplayMember = "Division_name";
                cbdivision.ValueMember = "Division_Id";
                cbdivision.SelectedIndex = -1;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cbdivision.SelectedValue.ToString(), out id))
            {
                cbemployee.DataSource = null;
                string sql3 = "  Select Employee_Name,Employee_Id from [Employee] where Division_Id='" + id + "'";
                DataTable dt2 = objdb.RetrunDataTable(sql3);
                cbemployee.DataSource = dt2;
                cbemployee.DisplayMember = "Employee_Name";
                cbemployee.ValueMember = "Employee_Id";
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if ((cbdivision.Text == "") || (cbemployee.Text == "") || (cblocation.Text == "") || (tbcategory.Text == "") || (tbsubcategory.Text == ""))
            {
                label6.Text = "Required Fields are not Selected";
                label6.Visible = true;
                label6.ForeColor = Color.Red;
                return;


            }
            
            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in gdwAsssetassign.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in gdwAsssetassign.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label6.Text = "Please Select One Item at a time !"; label6.ForeColor = Color.Red; label6.Visible = true; loadgrid(); BRestLoop = true; break; ; }
                            if (IntChkCount < 1) { label6.Text = "Please Select a record !"; label6.ForeColor = Color.Red; label6.Visible = true; loadgrid(); BRestLoop = true; break; ; }
                        }

                    }

                    if (BRestLoop) break;

                    int val = 0;
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString().Trim());
                    string locid = dgvr.Cells[2].Value.ToString().Trim();
                    string divid = dgvr.Cells[3].Value.ToString().Trim();
                    string empid = dgvr.Cells[4].Value.ToString().Trim();
                    string catid = dgvr.Cells[5].Value.ToString().Trim();
                    string subcatid = dgvr.Cells[6].Value.ToString().Trim();
                    string pno = dgvr.Cells[7].Value.ToString().Trim();
                    string sno = dgvr.Cells[8].Value.ToString().Trim();

                    string idreturn = "select Location_Id,Division_Id ,Employee_Id,Category_Id,Subcategory_Id from Asset_Assign where AssetId='"+id+"'";
                    DataTable dt = objdb.RetrunDataTable(idreturn);
                    int lid = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int did = Convert.ToInt32(dt.Rows[0][1].ToString());
                    int eid = Convert.ToInt32(dt.Rows[0][2].ToString());
                    int cid = Convert.ToInt32(dt.Rows[0][3].ToString());
                    int scid = Convert.ToInt32(dt.Rows[0][4].ToString());


                    string transferquery = "insert into Asset_Transfer_History values ('"+id+"','"+lid+"','"+ did + "','"+ eid + "','" + cid + "','" + scid + "','" + sno + "','"+pno+"','"+DateTime.Now+"','"+true+"')";
                    int val1= objdb.ExecuteNonQuery(transferquery);
                    string updatequery = " update Asset_Assign set Location_Id='" + cblocation.SelectedValue + "',Division_Id='" + cbdivision.SelectedValue+"',Employee_Id='"+cbemployee.SelectedValue+ "'  where AssetId ='"+id+"'";
                    val = objdb.ExecuteNonQuery(updatequery);
                    if (val > 0)
                            {
                               label6.ForeColor = Color.ForestGreen;
                               label6.Text = "Transfered Successfully!";
                               label6.Visible = true;
                               loadgrid();
                            }
                        
                        else
                        {
                            //string sql = " update Location set Status = '0' where Location_Id = '" + id + "'";
                            //val = objdb.ExecuteNonQuery(sql);
                            //if (val > 0)
                            //{
                            //    label4.ForeColor = Color.ForestGreen;
                            //    label4.Text = "Enabled Successfully!";
                            //    label4.Visible = true;
                            //    loadgrid();
                            //}
                        }
                    }
                                  
                dgvr.Cells[0].Value = false;
            }

            loadgrid();
            cleartext();
        }

    
        public void cleartext()
        {
            tbcategory.Text = "";
            tbsubcategory.Text = "";
            cblocation.SelectedIndex = -1;
            cbemployee.SelectedIndex = -1;
            cbdivision.SelectedIndex = -1;
        }


        private void dgwBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gdwAsssetassign_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdwAsssetassign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                
                //label9.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                // label8.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                tbcategory.Text = gdwAsssetassign.Rows[index].Cells[5].Value.ToString();
                tbsubcategory.Text = gdwAsssetassign.Rows[index].Cells[6].Value.ToString();
                cbdivision.SelectedItem = gdwAsssetassign.Rows[index].Cells[3].Value.ToString();
                cblocation.SelectedItem = gdwAsssetassign.Rows[index].Cells[2].Value.ToString();
                cbemployee.SelectedItem = gdwAsssetassign.Rows[index].Cells[4].Value.ToString();
                


            }
        }

        private void cblocation_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gdwAsssetassign_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gdwAsssetassign.CurrentCell = null;
        }

        public static implicit operator FrmAssetTransfer(frmAssignAssets v)
        {
            throw new NotImplementedException();
        }
    }
}
