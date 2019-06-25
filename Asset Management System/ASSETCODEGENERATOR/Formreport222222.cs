using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ASSETCODEGENERATOR
{
    public partial class Formreport222222 : Form
    {
        DB objdb = new DB();

        public Formreport222222()
        {
            InitializeComponent();
        }

        private void Formreport222222_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string sql6 = "select * from Location";
            DataTable dt2 = objdb.RetrunDataTable(sql6);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";
        }

        private void cmblocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cmblocation.SelectedValue.ToString(), out id))
            {
                //combodivname.DataSource = null;
                string sql4 = "Select * from [Division] where Location_Id='" + id + "'";
                DataTable dt3 = objdb.RetrunDataTable(sql4);
                combodivname.DataSource = dt3;
                combodivname.DisplayMember = "Division_name";
                combodivname.ValueMember = "Division_Id";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            int id = 0;
            int Loc = 0;
            bool res = int.TryParse(cmblocation.SelectedValue.ToString(), out Loc);
            bool res2 = int.TryParse(combodivname.SelectedValue.ToString(), out id);

            if (res == true && res2 == true)
            { 
                    string sql="select COUNT(assign.Asset_Id) as Asset_Count,cat.Category_Desc as subCat,catM.Category_Desc as Cat, div.Division_name from Asset_Assign Assign join Assets_subcategory cat on cat.Subcategory_Id = Assign.Subcategory_Id join Asset_Category catM on catM.Category_Id = cat.Category_Id join Division div on div.Division_Id = Assign.Division_Id where Assign.Location_Id='"+Loc+"' and  div.Division_Id='"+id+"'";
                    sql = sql + "group by catM.Category_Desc,cat.Category_Desc,div.Division_name";
                    dt =objdb.RetrunDataTable(sql);

                    sql="";

                    sql = "select COUNT(assign.Asset_Id) as Asset_Count,cat.Category_Desc as subCat,catM.Category_Desc as Cat, div.Division_name from Asset_Assign Assign join Assets_subcategory cat on cat.Subcategory_Id = Assign.Subcategory_Id join Asset_Category catM on catM.Category_Id = cat.Category_Id join Division div on div.Division_Id = Assign.Division_Id join tblBarcode br on br.barcodeId = Assign.BarcodeID where Assign.Location_Id='" + Loc + "' and  div.Division_Id='" + id + "' and br.verified = 'true' group by catM.Category_Desc,cat.Category_Desc,div.Division_name";
                    dt2 =objdb.RetrunDataTable(sql);
                    
                    foreach(DataRow row in dt.Rows)
                    {
                        int originalCount = 0;
                        int VerifyCount = 0;
                        int.TryParse(row[0].ToString(), out originalCount);

                        DataRow[] filteredRows = dt2.Select("subCat = '" + row[1] + "' and Cat = '" + row[2] + "'");

                        if (filteredRows.Count() >0)
                        {
                            int.TryParse(filteredRows[0].ToString(), out VerifyCount);
                            if (VerifyCount > 0)
                            {

                            }
                        
                        }
                      
                      
                    }


            }           
        }
    }
}
