using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using DatabaseEngine;

namespace ASSETCODEGENERATOR
{
    public partial class Item_CodeForm2 : Form
    {
        public Item_CodeForm2()
        {
            InitializeComponent();
        }

        DB objdb = new DB();
        int Cat = 0;
        DataTable dtCat;
        List<string> ItmList = new List<string>();
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Item_CodeForm2_Load(object sender, EventArgs e)
        {
            string sqlCat = "select * from Asset_Category";
            DataTable dtCat = objdb.RetrunDataTable(sqlCat);            
            DataRow dataRow3 = dtCat.NewRow();
            dataRow3["Category_Desc"] = "Blank";
            dtCat.Rows.InsertAt(dataRow3, 0);
            cmbassetcat.DataSource = dtCat;
            cmbassetcat.ValueMember = "Category_Id";
            cmbassetcat.DisplayMember = "Category_Desc";
            //cmbassetcat.SelectedIndex = -1;

            string sql1 = "select * from Location";
            DataTable dt2 = objdb.RetrunDataTable(sql1);
            DataRow dataRow = dt2.NewRow();
            dataRow["Location_name"] = "Blank";
            dt2.Rows.InsertAt(dataRow, 0);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";


            string sql2 = "select * from Division";
            DataTable dt3 = objdb.RetrunDataTable(sql2);
            DataRow dataRow1 = dt3.NewRow();
            dataRow1["Division_name"] = "Blank";
            dt3.Rows.InsertAt(dataRow1, 0);
            cmbdivision.DataSource = dt3;
            cmbdivision.DisplayMember = "Division_name";
            cmbdivision.ValueMember = "Division_Id";


            string sql3 = "select * from Employee";
            DataTable dt4 = objdb.RetrunDataTable(sql3);
            DataRow dataRow2 = dt4.NewRow();
            dataRow2["Employee_Name"] = "Blank";
            dt4.Rows.InsertAt(dataRow2, 0);
            cmbemp.DataSource = dt4;
            cmbemp.DisplayMember = "Employee_Name";
            cmbemp.ValueMember = "Employee_Id";


            string sql4 = "select * from Assets_subcategory";
            DataTable dt5 = objdb.RetrunDataTable(sql4);
            DataRow dataRow4 = dt5.NewRow();
            dataRow4["SubCategory_Desc"] = "Blank";
            dt5.Rows.InsertAt(dataRow4, 0);
            cmbassetsubcat.DataSource = dt5;
            cmbassetsubcat.DisplayMember = "SubCategory_Desc";
            cmbassetsubcat.ValueMember = "Subcategory_Id";          
        }       

        public void clearText()
        {
            cmbassetcat.Text= "";
            cmbassetsubcat.Text="";
            cmbdivision.Text = "";
            cmblocation.Text = "";
            cmbemp.Text = "";
        }

        public string createUniq(int unique)
        {
            string uniquecode = "";
            if (unique.ToString().Length < 5)
            {
                int len = unique.ToString().Length;
                for (; len < 4; len++)
                {
                    uniquecode = uniquecode + "0";
                }
                uniquecode = uniquecode + unique.ToString();
            }
            else
            {
                uniquecode = unique.ToString();
            }

            return uniquecode;
        }

        public void printBarode(string ItemCode)
        {
            try
            {

                string Barcode = "";
                string sStartupPath = Directory.GetCurrentDirectory();
                StreamReader BARCODETEMP = new StreamReader(sStartupPath + "\\PRINT.PRN");
                Barcode = BARCODETEMP.ReadToEnd();
                Barcode = Barcode.Replace("BARCODE", ItemCode);

                AppSettingsReader settingsReader = new AppSettingsReader();
                string SharedPrinterName = (string)settingsReader.GetValue("SharedPrinter", typeof(String));
                RawPrinterHelper.SendStringToPrinter("\\\\" + System.Environment.MachineName + "\\" + SharedPrinterName + "", Barcode);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string StrLocation;
            string StrDivision;
            string StrEmployee;
            string StrAssetCategory;
            string StrAssetSubCategory;

            StrLocation = cmblocation.Text;
            StrDivision = cmbdivision.Text;
            StrEmployee = cmbemp.Text;
            StrAssetCategory = cmbassetcat.Text;
            StrAssetSubCategory = cmbassetsubcat.Text;

            int Intlocation = 0;
            int Intdivision = 0;
            int Intemployee = 0;
            int Intasset_category = 0;
            int Intasset_subcategory = 0;

            string StrWhereCluse;
            StrWhereCluse = "";


            


            //location only
            if (StrLocation != "Blank" && StrDivision == "Blank" && StrEmployee == "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory == "Blank")
            {

                Intlocation = Convert.ToInt32(cmblocation.SelectedValue.ToString());

                StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Location_Id=" + Intlocation + "";
            }
            //division only
            if (StrLocation == "Blank" && StrDivision != "Blank" && StrEmployee == "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory == "Blank")
            {
                Intdivision = Convert.ToInt32(cmbdivision.SelectedValue.ToString());

                StrWhereCluse = "Where[Assets].[dbo].[Asset_Assign].[Division_Id]=" + Intdivision + "";
            }
            //employee only
            if (StrLocation == "Blank" && StrDivision == "Blank" && StrEmployee != "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory == "Blank")
            {

                Intemployee = Convert.ToInt32(cmbemp.SelectedValue.ToString());

                StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].[Employee_Id]=" + Intemployee + "";
            }
            //asset_category only

            if (StrLocation == "Blank" && StrDivision == "Blank" && StrEmployee == "Blank" && StrAssetCategory != "Blank" && StrAssetSubCategory == "Blank")
            {
                Intasset_category = Convert.ToInt32(cmbassetcat.SelectedValue.ToString());
                StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].[Category_Id]=" + Intasset_category + "";
            }
            //asset subcat
            if (StrLocation == "Blank" && StrDivision == "Blank" && StrEmployee == "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory != "Blank")
            {
                Intasset_subcategory = Convert.ToInt32(cmbassetsubcat.SelectedValue.ToString());
                StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].[Subcategory_Id]=" + Intasset_subcategory + "";
            }
            if (StrLocation == "Blank" && StrDivision == "Blank" && StrEmployee == "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory == "Blank")
            {
                lblmessage.Text = "All fields cannot be blank";
                lblmessage.ForeColor = Color.Red;
                lblmessage.Visible = true;
                return;
            }
            //if (StrLocation != "Blank" && StrDivision != "Blank" && StrEmployee == "Blank" && StrAssetCategory == "Blank" && StrAssetSubCategory == "Blank")
            //{
            //    lblmessage.Text = "Three fields cannot be empty";
            //    lblmessage.ForeColor = Color.Red;
            //    lblmessage.Visible = true;
            //    return;
            //}
            else
            {
                int count = 0;
                if (StrLocation == "Blank")
                {
                   
                    count = count + 1;
                }
                if (StrDivision == "Blank")
                {
                    count = count + 1;
                    
                }
                if (StrEmployee == "Blank")
                {
                    count = count + 1;
                }
                if (StrAssetCategory == "Blank")
                {
                    count = count + 1;
                }
                if (StrAssetSubCategory == "Blank")
                {
                    count = count + 1;
                }
                //MessageBox.Show(count.ToString());
                if (count == 2 || count == 3 || count == 0 || count == 1)
                {
                    lblmessage.Text = "Four fields should be blank!";
                    lblmessage.ForeColor = Color.Red;
                    lblmessage.Visible = true;
                    dgwItemCode.DataSource = null;
                    count = 0;
                    return;
                }

            }





            string uniquecode = "";
            int unique = 0;
            string AssetLett = "";
            string AssetLettFin = "";
            int val = 0;

            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Location_Id=" + Intlocation + "";
            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Location_Id=" + Intlocation + "";
            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Location_Id=" + Intlocation + "";
            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Employee_Id=" + Intemployee + "";
            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Category_Id=" + Intasset_category + "";
            //    StrWhereCluse = "Where [Assets].[dbo].[Asset_Assign].Subcategory_Id=" + Intasset_subcategory + "";
            DataTable dt = DatabaseEngine.DatabaseEngine.ReturnDatatable("SP_Select_Asset_Details_by_Where_Caluse", new SqlParameter("@StrWhereCluse", StrWhereCluse));
            DataTable dtt = new DataTable();
            dtt.Columns.Add("Barcode ID");
            dtt.Columns.Add("PO Number");
            dtt.Columns.Add("Location Name");
            dtt.Columns.Add("Divison Name ");
            dtt.Columns.Add("Employee Name");
            dtt.Columns.Add("Asset Category");
            dtt.Columns.Add("Asset Subcategory");
            dtt.Columns.Add("Designated Letter");

            dgwItemCode.DataSource = dtt;

            string StrLocation_Id = "";
            string StrDivision_Id = "";
            string StrAssetCategory_Id = "";
            string StrAssetSubCategory_Id = "";


            string StrPO_Number = "";
            string Strlocation_name = "";
            string Strdivision_name = "";
            string Stremployee_name = "";
            string Strcategory_name = "";
            string Strsubcategory_name = "";
            string Strdesignated_letter = "";

            string StrBarcode = "";
            string StrAsset_category_designated_letter;
            string Strbarcode_serial_Number;
            dgwItemCode.DataSource = dtt;

            foreach (DataRow drow in dt.Rows)
            {
                if (drow["Location_Id"].ToString().Count() == 1)
                {
                    StrLocation_Id = "0" + drow["Location_Id"].ToString();
                }
                else
                {
                    StrLocation_Id = drow["Location_Id"].ToString();
                }
                if (drow["Division_Id"].ToString().Count() == 1)
                {
                    StrDivision_Id = "0" + drow["Division_Id"].ToString();
                }
                else
                {
                    StrDivision_Id = drow["Division_Id"].ToString();
                }
                if (drow["Category_Id"].ToString().Count() == 1)
                {
                    StrAssetCategory_Id = "0" + drow["Category_Id"].ToString();
                }
                else
                {
                    StrAssetCategory_Id = drow["Category_Id"].ToString();
                }
                if (drow["Subcategory_Id"].ToString().Count() == 1)
                {

                    StrAssetSubCategory_Id = "0" + drow["Subcategory_Id"].ToString();
                }
                else
                {
                    StrAssetSubCategory_Id = drow["Subcategory_Id"].ToString();
                }
                StrAsset_category_designated_letter = drow["Desig_letter"].ToString();
                Strbarcode_serial_Number = createUniq(Convert.ToInt32(drow["SerialNo"].ToString()));
                StrBarcode = StrLocation_Id + StrDivision_Id + StrAssetSubCategory_Id + Strbarcode_serial_Number + StrAsset_category_designated_letter;


                if (dt.Rows.Count > 0)
                {

                    StrPO_Number = drow["PO_NO"].ToString();
                    Strlocation_name = drow["Location_name"].ToString();
                    Strdivision_name = drow["Division_name"].ToString();
                    Stremployee_name = drow["Employee_name"].ToString();
                    Strcategory_name = drow["Category_Desc"].ToString();
                    Strsubcategory_name = drow["SubCategory_Desc"].ToString();
                    Strdesignated_letter = drow["Desig_letter"].ToString();
                    dtt.Rows.Add(StrBarcode,StrPO_Number, Strlocation_name, Strdivision_name, Stremployee_name, Strcategory_name, Strsubcategory_name, Strdesignated_letter);
                }
            }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
        }
        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwItemCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            index = e.RowIndex;
            if (index < -1)
            {
                MessageBox.Show("Do You want to delete this!");
            }
        }        

        private void btnall_details_Click(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
            string uniquecode = "";
            int unique = 0;
            string AssetLett = "";
            string AssetLettFin = "";
            int val = 0;

            DataTable dt = objdb.RetrunDataTable_With_SP("SP_Select_All_Asset_Details");
            DataTable dtt = new DataTable();
            dtt.Columns.Add("Barcode ID");
            dtt.Columns.Add("PO Number");
            dtt.Columns.Add("Location Name");
            dtt.Columns.Add("Divison Name ");
            dtt.Columns.Add("Employee Name");
            dtt.Columns.Add("Asset Category");
            dtt.Columns.Add("Asset Subcategory");
            dtt.Columns.Add("Designated Letter");

            string StrLocation_Id = "";
            string StrDivision_Id = "";
            string StrAssetCategory_Id = "";
            string StrAssetSubCategory_Id = "";


            string StrPO_Number = "";
            string Strlocation_name = "";
            string Strdivision_name = "";
            string Stremployee_name = "";
            string Strcategory_name = "";
            string Strsubcategory_name = "";
            string Strdesignated_letter = "";

            string StrBarcode = "";
            string StrAsset_category_designated_letter;
            string Strbarcode_serial_Number;

            foreach (DataRow drow in dt.Rows)
            {
                if (drow["Location_Id"].ToString().Count() == 1)
                {
                    StrLocation_Id = "0" + drow["Location_Id"].ToString();
                }
                else
                {
                    StrLocation_Id = drow["Location_Id"].ToString();
                }
                if (drow["Division_Id"].ToString().Count() == 1)
                {
                    StrDivision_Id = "0" + drow["Division_Id"].ToString();
                }
                else
                {
                    StrDivision_Id = drow["Division_Id"].ToString();
                }
                if (drow["Category_Id"].ToString().Count() == 1)
                {
                    StrAssetCategory_Id = "0" + drow["Category_Id"].ToString();
                }
                else
                {
                    StrAssetCategory_Id = drow["Category_Id"].ToString();
                }
                if (drow["Subcategory_Id"].ToString().Count() == 1)
                {

                    StrAssetSubCategory_Id = "0" + drow["Subcategory_Id"].ToString();
                }
                else
                {
                    StrAssetSubCategory_Id = drow["Subcategory_Id"].ToString();
                }
                StrAsset_category_designated_letter = drow["Desig_letter"].ToString();
                Strbarcode_serial_Number = createUniq(Convert.ToInt32(drow["SerialNo"].ToString()));
                StrBarcode = StrLocation_Id + StrDivision_Id + StrAssetSubCategory_Id + Strbarcode_serial_Number + StrAsset_category_designated_letter;

                dgwItemCode.DataSource = dtt;
                StrPO_Number = drow["PO_NO"].ToString();
                Strlocation_name = drow["Location_name"].ToString();
                Strdivision_name = drow["Division_name"].ToString();
                Stremployee_name = drow["Employee_name"].ToString();
                Strcategory_name = drow["Category_Desc"].ToString();
                Strsubcategory_name = drow["SubCategory_Desc"].ToString();
                Strdesignated_letter = drow["Desig_letter"].ToString();
                dtt.Rows.Add(StrBarcode, StrPO_Number, Strlocation_name, Strdivision_name, Stremployee_name, Strcategory_name, Strsubcategory_name, Strdesignated_letter);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow dgwr in dgwItemCode.Rows)
                {
                    if (dgwr.Cells[0].Value != null)
                    {

                        if (dgwr.Cells[0].Value.ToString() == "True")
                        {
                            printBarode(dgwItemCode.Rows[dgwr.Index].Cells[1].Value.ToString());
                        }
                    }

                    dgwr.Cells[0].Value = false;

                }


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgwItemCode_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgwItemCode.CurrentCell = null;
        }

        private void cmblocation_Click(object sender, EventArgs e)
        {
            lblmessage.Visible = false; 
        }

        private void cmbdivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void cmbemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void cmbassetcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void cmbassetsubcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }

        private void dgwItemCode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_formClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}