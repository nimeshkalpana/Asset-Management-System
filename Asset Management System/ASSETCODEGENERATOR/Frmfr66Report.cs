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
    public partial class Frmfr66Report : Form
    {
        DB objdb = new DB();
        public Frmfr66Report()
        {
            InitializeComponent();
        }

        private void Frmfr66Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select COUNT(aa.Subcategory_Id) as itm, Subcategory_Id from Asset_Assign aa  join tblBarcode br on br.barcodeId = aa.BarcodeID where br.verified = '1' group by Subcategory_Id";
            dt = objdb.RetrunDataTable(sql);

            DataTable dt2 = new DataTable();
            string sql2 = "select COUNT(aa.Subcategory_Id) as itm, Subcategory_Id from Asset_Assign aa join tblBarcode br on br.barcodeId = aa.BarcodeID where br.verified = '0' group by Subcategory_Id";
            dt2 = objdb.RetrunDataTable(sql2);

            //foreach(DataRow aa in dt.Rows)
            //{
            //    foreach (DataRow dd in dt2.Rows)
            //    {
            //        if (aa[1] == dd[1])
            //        { 
                       
            //        }
            //    }
            //}

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string sql6 = "select * from Location";
            DataTable dt2 = objdb.RetrunDataTable(sql6);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";
            cmblocation.SelectedIndex = -1;
        }

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
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
            int div = 0;
            int loc = 0;
            int.TryParse(combodivname.SelectedValue.ToString(), out div);
            int.TryParse(cmblocation.SelectedValue.ToString(), out loc);
            if (div > 0)
            {
                string sql5 = "select cc.Category_Desc,ss.Category_Desc from Asset_Category cc"+
               " join Assets_subcategory ss on cc.Category_Id = ss.Category_Id" +
               " join Division div on div.Division_Id = Assign.Division_Id" +
               " where Assign.Location_Id='" + loc + "' and  div.Division_Id='" + div + "'" +
               " group by cat.Category_Desc ";

                DataTable dt6 = objdb.RetrunDataTable(sql5);
                reportViewer1.LocalReport.DataSources.Clear();

                ReportParameter p1 = new ReportParameter("Division", combodivname.Text);
                ReportDataSource reportDSDetail = new ReportDataSource("DataSetfr66", dt6);
                reportViewer1.LocalReport.ReportPath = "Reportfr66.rdlc";
                reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
                this.reportViewer1.RefreshReport();

            }
            else
            {
            }
        }        
    }
}
