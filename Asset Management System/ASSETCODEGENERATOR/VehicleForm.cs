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
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        int index = -1;
        bool state = false;
        int cnt = 0, ent = 0, dnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(combovehicletype.SelectedValue.ToString());
            int val = 0;
            if (txtAssetIdNo.Text == "")
            {
                label13.Text = " ** ";
                label13.Visible = true;
                return;
            }
            else if (combovehicletype.Text == "")
            {
                label14.Text = " ** ";
                label14.Visible = true;
                return;
            }
            else if (txtengineno.Text == "")
            {
                label15.Text = " ** ";
                label15.Visible = true;
                return;

            }
            else if (txtchassisno.Text == "")
            {
                label16.Text = " ** ";
                label16.Visible = true;
                return;
            }
            else if (txthorsepower.Text == "")
            {
                label17.Text = " ** ";
                label17.Visible = true;
                return;
            }
            else if (combovehiclecolor.Text == "")
            {
                label18.Text = " ** ";
                label18.Visible = true;
                return;
            }
            else if (combofueltype.Text == "")
            {
                label19.Text = " ** ";
                label19.Visible = true;
                return;
            }
            else if (txtsiteparked.Text == "")
            {
                label20.Text = " ** ";
                label20.Visible = true;
                return;
            }

            else
            {

                string sql2 = "SELECT Vehicle_No,Engine_No,Chassis_No FROM Vehicle WHERE Vehicle_No like '" + txtAssetIdNo.Text + "' or Engine_No like '" + txtengineno.Text + "' or Chassis_No like '" + txtchassisno.Text + "'";


                // val = objdb.ExecuteNonQuery(sql1);
                DataTable dt = objdb.RetrunDataTable(sql2);
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtAssetIdNo.Text == dr[0].ToString())
                    {
                        cnt += 1;
                    }
                    else if (txtengineno.Text == dr[1].ToString())
                    {
                        dnt += 1;
                    }
                    else if (txtchassisno.Text == dr[2].ToString())
                    {
                        ent += 1;
                    }

                }

                if (cnt > 0)
                {
                    txtAssetIdNo.Text = "";
                    label12.ForeColor = Color.Red;
                    label12.Text = "Vehicle number already exists!";
                    label12.Visible = true;
                    cnt = 0;
                    loadGrid();
                    return;
                }
                if (dnt > 0)
                {
                    txtengineno.Text = "";
                    label12.ForeColor = Color.Red;
                    label12.Text = "Engine number already exists!";
                    label12.Visible = true;
                    cnt = 0;
                    loadGrid();
                    return;
                }
                if (ent > 0)
                {
                    txtchassisno.Text = "";
                    label12.ForeColor = Color.Red;
                    label12.Text = "Chassis number already exists!";
                    label12.Visible = true;
                    cnt = 0;
                    loadGrid();
                    return;
                }


                else
                {
                    int assetsubCat = 0;
                    int.TryParse(combovehicletype.SelectedValue.ToString(), out assetsubCat);
                    int result = 0;
                    try
                    {
                        string sql = "insert into Vehicle (Vehicle_No,Vehicle_Type,Engine_No,Chassis_No,Horse_Power,Vehicle_Color,Fuel_Type,Registration_Date,Site_parked,AssetId) values ('" + txtAssetIdNo.Text + "'," + combovehicletype.SelectedValue + ",'" + txtengineno.Text + "','" + txtchassisno.Text + "','" + txthorsepower.Text + "'," + combovehiclecolor.SelectedValue + "," + combofueltype.SelectedValue + ",'" + dateTimePicker1.Text + "','" + txtsiteparked.Text + "',1);SELECT SCOPE_IDENTITY();";
                        val = objdb.ExecuteNonQuery(sql);
                        if (val > 0)
                        {
                            label12.ForeColor = Color.ForestGreen;
                            label12.Text = "Inserted Successfully!";
                            label12.Visible = true;
                        }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                }
            }
           // txtAssetIdNo.Enabled = true;
            loadGrid();
            clearText();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            //Load Vehicle Types
            string sql4 = "Select * from [Vehicle_Type] order by VehicleType_Id";
            DataTable dt3 = objdb.RetrunDataTable(sql4);
            combovehicletype.DataSource = dt3;
            combovehicletype.DisplayMember = "Type_Description";
            combovehicletype.ValueMember = "VehicleType_Id";
            combovehicletype.SelectedIndex = -1;

            //string sql1 = "Select * from Assets_subcategory WHERE Category_Id='8'";
            //DataTable dt = objdb.RetrunDataTable(sql1);
            //combovehicletype.DataSource = dt;
            //combovehicletype.DisplayMember = "Category_Desc";
            //combovehicletype.ValueMember = "Subcategory_Id";
            //loadGrid();
            //combovehicletype.SelectedIndex = -1;


            //Load Vehicle Colors
            string sql2 = "Select * from [Vehicle_Color] order by VehicleColor_Id";
            DataTable dt1 = objdb.RetrunDataTable(sql2);
            combovehiclecolor.DataSource = dt1;
            combovehiclecolor.DisplayMember = "Color_Description";
            combovehiclecolor.ValueMember = "VehicleColor_Id";
            combovehiclecolor.SelectedIndex = -1;

            string sql3 = "Select * from [Fuel_Type] order by FuelType_Id";
            DataTable dt2 = objdb.RetrunDataTable(sql3);
            combofueltype.DataSource = dt2;
            combofueltype.DisplayMember = "FuelType_Description";
            combofueltype.ValueMember = "FuelType_Id";
            combofueltype.SelectedIndex = -1;
            loadGrid();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in dgwvehicle.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in dgwvehicle.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label12.Text = "Please Assigned One Item at a time !"; label12.ForeColor = Color.Red; label12.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }

                    }

                    if (BRestLoop) break;


                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());


                    int val = 0;

                    string sql5 = "UPDATE Vehicle SET Vehicle_Type = " + combovehicletype.SelectedValue + ",Engine_No='" + txtengineno.Text + "',Chassis_No='" + txtchassisno.Text + "',Horse_Power='" + txthorsepower.Text + "',Vehicle_Color= " + combovehiclecolor.SelectedValue + ",Fuel_Type=" + combofueltype.SelectedValue + ",Registration_Date='" + dateTimePicker1.Text + "',Site_parked='" + txtsiteparked.Text + "' WHERE id='" + id + "'";
                    val = objdb.ExecuteNonQuery(sql5);

                    if (val > 0)
                    {
                        label12.Text = "Successfully updated!";
                        label12.ForeColor = Color.Green;
                        label12.Visible = true;
                        
                    }
                }
                dgvr.Cells[0].Value = false;
            }
            loadGrid();
            clearText();
        }

        public void loadGrid()
        {
            //Load divsion gridview
            string sqlvehicle = " Select v.id as [ID],v.Vehicle_No as [Vehicle No],v.Engine_No as [Engine No],v.Chassis_No as [Chassis No] ,v.Horse_Power as [Horse Power],v.Registration_Date as [Registration Date],v.Site_parked as [Site parked] ,f.FuelType_Description as [FuelType Description] ,c.Color_Description as [Color Description] ,t.Type_Description as[Type Description] from Vehicle v , Vehicle_Color c , Vehicle_Type t,Fuel_Type f where v.Vehicle_Type=t.VehicleType_Id and v.Vehicle_Color=c.VehicleColor_Id and v.Fuel_Type=f.FuelType_Id";
            DataTable dt4 = objdb.RetrunDataTable(sqlvehicle);
            dgwvehicle.DataSource = dt4;
            dgwvehicle.Refresh();
            btnDelete.Enabled = false;
            btnupdate.Enabled = false;
            button1.Enabled = true;
            txtAssetIdNo.Enabled = true;
        }

        private void dgwvehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                index = e.RowIndex;
                state = true;
               // txtAssetIdNo.Enabled = false;
                txtAssetIdNo.Text = dgwvehicle.Rows[index].Cells[2].Value.ToString();
                combovehicletype.Text = dgwvehicle.Rows[index].Cells[10].Value.ToString();
                txtengineno.Text = dgwvehicle.Rows[index].Cells[3].Value.ToString();
                txtchassisno.Text = dgwvehicle.Rows[index].Cells[4].Value.ToString();
                txthorsepower.Text = dgwvehicle.Rows[index].Cells[5].Value.ToString();
                combovehiclecolor.Text = dgwvehicle.Rows[index].Cells[9].Value.ToString();
                combofueltype.Text = dgwvehicle.Rows[index].Cells[8].Value.ToString();
                dateTimePicker1.Text = dgwvehicle.Rows[index].Cells[6].Value.ToString();
                txtsiteparked.Text = dgwvehicle.Rows[index].Cells[7].Value.ToString();
                btnDelete.Enabled = true;
                btnupdate.Enabled = true;
                button1.Enabled = false;
                label12.Visible = false;
                txtAssetIdNo.Enabled = false;
            }
        }
        public void clearText()
        {
            txtAssetIdNo.Text = "";
            combovehicletype.Text = "";
            txtengineno.Text = "";
            txtchassisno.Text = "";
            txthorsepower.Text = "";
            combovehiclecolor.Text = "";
            combofueltype.Text = "";
            dateTimePicker1.Text = "";
            txtsiteparked.Text = "";
        }
        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        private void dgwvehicle_MouseClick_1(object sender, MouseEventArgs e)
        {           
            //string id = "";
            //int val = 0;

            //id = (dgwvehicle.Rows[index].Cells[0].Value.ToString());
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        dgwvehicle.Rows.RemoveAt(index);

            //        string sql = "Delete FROM Vehicle where Asset_Id_No='" + id + "'";
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAssetIdNo_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            
        }

        private void combovehicletype_SelectedIndexChanged(object sender, EventArgs e)
        {

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void txtengineno_TextChanged(object sender, EventArgs e)
        {

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void txtchassisno_TextChanged(object sender, EventArgs e)
        {

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void txthorsepower_TextChanged(object sender, EventArgs e)
        {

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void combovehiclecolor_SelectedIndexChanged(object sender, EventArgs e)
        {

            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void combofueltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;


        }

        private void dgwvehicle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgwvehicle.CurrentCell = null;
        }

        private void txtsiteparked_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int IntChkCount = 0;
            bool BRestLoop = false;
            foreach (DataGridViewRow dgvr in dgwvehicle.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {

                    foreach (DataGridViewRow dgvrr in dgwvehicle.Rows)
                    {
                        if (dgvrr.Cells[0].Value != null)
                        {
                            if (dgvrr.Cells[0].Value.ToString() == "True") { IntChkCount = IntChkCount + 1; }
                            if (IntChkCount > 1) { label12.Text = "Please Assigned One Item at a time !"; label12.ForeColor = Color.Red; label12.Visible = true; loadGrid(); BRestLoop = true; break; ; }
                        }

                    }

                    if (BRestLoop) break;

                    int val = 0;
                    int id = Convert.ToInt32(dgvr.Cells[1].Value.ToString());
                    DialogResult result = MessageBox.Show("Do you want to delete this?", "warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "Delete FROM Vehicle where id='" + id + "'";

                        val = objdb.ExecuteNonQuery(sql);
                        if (val > 0)
                        {
                            label12.ForeColor = Color.Green;
                            label12.Text = "Deleted Successfully!";
                            label12.Visible = true; ;

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
    }
}
