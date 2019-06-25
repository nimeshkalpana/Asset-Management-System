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
    public partial class FrmDivisionIT : Form
    {
        DB objdb = new DB();    
        public FrmDivisionIT()
        {
            InitializeComponent();
        }       

        private void FrmDivisionIT_Load_1(object sender, EventArgs e)
        {

            string sql1 = "Select * from [Location]  where Status != '1' order by location_Id";
            DataTable dt2 = objdb.RetrunDataTable(sql1);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void cmbDivision_SelectionChangeCommitted(object sender, EventArgs e)
        {          
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cmblocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql2 = "  select D.Division_name,D.Division_Id from Division D inner join Division_Location_Assignment DLA on D.Division_Id=DLA.Division_Id where DLA.Locatoin_Id ='" + cmblocation.SelectedValue + "' ";
            DataTable dt = objdb.RetrunDataTable(sql2);
            combodivname.DataSource = dt;
            combodivname.DisplayMember = "Division_name";
            combodivname.ValueMember = "Division_Id";
            combodivname.SelectedIndex = -1;
        }

        private void combodivname_SelectionChangeCommitted(object sender, EventArgs e)
        {          
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            try
            {
                int div = 0;
                int loc = 0;
                int.TryParse(combodivname.SelectedValue.ToString(), out div);
                int.TryParse(cmblocation.SelectedValue.ToString(), out loc);
                if (div > 0)
                {
                    string sql3 = " select (ac.Category_Desc+' - '+cat.SubCategory_Desc) as Category_Desc,COUNT(assign.AssetId) as Asset_Count from Asset_Assign Assign join Assets_subcategory cat on cat.Subcategory_Id = Assign.Subcategory_Id join Division div on div.Division_Id = Assign.Division_Id join Location loc on loc.Location_Id = Assign.Location_Id, Asset_Category ac where Assign.Location_Id='" + loc + "' and  div.Division_Id='" + div + "' and ac.Category_Id=cat.Category_Id group by cat.SubCategory_Desc,ac.Category_Desc";
                    string space = " - ";
                    DataTable dt3 = objdb.RetrunDataTable(sql3);
                    reportViewer1.LocalReport.DataSources.Clear();

                    ReportParameter p1 = new ReportParameter("Division", combodivname.Text);
                    ReportParameter p2 = new ReportParameter("Location", cmblocation.Text);
                    ReportParameter p3 = new ReportParameter("Space", space);
                    ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt3);
                    reportViewer1.LocalReport.ReportPath = "ReportDivisionIT.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });

                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                }   
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
          
        }
    }
}
