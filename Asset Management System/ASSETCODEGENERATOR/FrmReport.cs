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
    public partial class FrmReport : Form
    {
        DB objdb = new DB();    
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select v.Vehicle_No,t.Type_Description,v.Engine_No,v.Chassis_No,v.Horse_Power,c.Color_Description,f.FuelType_Description,v.Registration_Date,v.Site_parked from vehicle v inner join Fuel_Type f on v.Fuel_Type = f.FuelType_Id inner join Vehicle_Color c on v.Vehicle_Color=c.VehicleColor_Id inner join Vehicle_Type t on v.Vehicle_Type = t.VehicleType_Id ";
            dt = objdb.RetrunDataTable(sql);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "VehicleDetails.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
            this.reportViewer1.RefreshReport();
          
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
