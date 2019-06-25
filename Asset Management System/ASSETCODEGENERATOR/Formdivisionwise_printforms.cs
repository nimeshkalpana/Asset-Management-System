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

    public partial class Formdivisionwise_printforms : Form
    {
        DB objdb = new DB();
        public Formdivisionwise_printforms()
        {
            InitializeComponent();
        }

        private void Formdivisionwise_printforms_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string sql1 = "Select * from [Location]  where Status != '1' order by location_Id";
            DataTable dt2 = objdb.RetrunDataTable(sql1);
            cmblocation.DataSource = dt2;
            cmblocation.DisplayMember = "Location_name";
            cmblocation.ValueMember = "Location_Id";
            cmblocation.SelectedIndex = -1;
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {

                if (combodivname.SelectedIndex == -1 || combodivname.SelectedIndex == -1)
                {
                    label3.Text = "**";
                    label3.ForeColor = Color.Red;
                    label3.Visible = true;
                    return;
                }
               
                DataTable dt3 = new DataTable();
                int div = 0;
                int loc = 0;
                int.TryParse(combodivname.SelectedValue.ToString(), out div);
                int.TryParse(cmblocation.SelectedValue.ToString(), out loc);
                string space = " - ";
                if (div > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    dt3 = calBalance(div, loc);

                    if (dt3.Rows.Count > 0)
                    {
                        ReportParameter p1 = new ReportParameter("Division", combodivname.Text);
                        ReportParameter p2 = new ReportParameter("Location", cmblocation.Text);
                        ReportParameter p3 = new ReportParameter("Space", space);
                        ReportDataSource reportDSDetail = new ReportDataSource("DataSet1", dt3);
                        reportViewer1.LocalReport.ReportPath = "Reportdivisionwise_printforms.rdlc";
                        reportViewer1.LocalReport.DataSources.Add(reportDSDetail);
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
                        this.reportViewer1.RefreshReport();

                    }



                }
                else
                {
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }

            combodivname.SelectedIndex = -1;
            cmblocation.SelectedIndex = -1;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int PerLedger;
        public DataTable calBalance(int div, int loc)
        {
            DataTable dtSet = new DataTable();
            dtSet.Columns.Add("ArticleName", typeof(System.String));
            dtSet.Columns.Add("BalanceAsShownPerLedger", typeof(System.Int32));
            dtSet.Columns.Add("ActualBalanceOnHand", typeof(System.Int32));
            dtSet.Columns.Add("Surplus", typeof(System.Int32));
            dtSet.Columns.Add("Deficiency", typeof(System.Int32));


           // string sql3 = "select (ac.Category_Desc+' - '+cat.SubCategory_Desc) as ArticleName,COUNT(assign.AssetId) as BalanceAsShownPerLedger,cat.Subcategory_Id from Asset_Assign Assign join Assets_subcategory cat on cat.Subcategory_Id = Assign.Subcategory_Id join Division div on div.Division_Id = Assign.Division_Id,Asset_Category ac where Assign.Location_Id='" + loc + "' and  div.Division_Id='" + div + "' and ac.Category_Id=cat.Category_Id group by cat.SubCategory_Desc,ac.Category_Desc,cat.Subcategory_Id";
            string sql3 = "SELECT  (ctg.Category_Desc+' - '+subctg.SubCategory_Desc)as ArticleName,sum (Assigned_Quantity) as BalanceAsShownPerLedger,asa.Subcategory_Id FROM Assets_subcategory as subctg JOIN Asset_Assign as asa ON  subctg.Subcategory_Id=asa.Subcategory_Id JOIN Asset_Category as ctg ON ctg.Category_Id = asa.Category_Id Where( Location_Id = '" + loc + "' AND  Division_Id = '" + div + "' ) GROUP BY subctg.SubCategory_Desc ,ctg.Category_Desc,asa.Subcategory_Id";
            DataTable dt3 = objdb.RetrunDataTable(sql3);

            // string sqlActualBalance = "select cat.Subcategory_Id,COUNT(assign.Verified_Status) as Asset_Count ";
            //sqlActualBalance = sqlActualBalance + " from Asset_Assign Assign join Assets_subcategory cat on cat.Subcategory_Id = Assign.Subcategory_Id";
            // sqlActualBalance = sqlActualBalance + " join Asset_Category catM on catM.Category_Id = cat.Category_Id join Division div on div.Division_Id = Assign.Division_Id";

            // sqlActualBalance = sqlActualBalance + " where assign.Verified_Status = '1' and Assign.Location_Id='" + loc + "' and  div.Division_Id='" + div + "'";
            // sqlActualBalance = sqlActualBalance + " group by cat.Subcategory_Id";
            string sqlActualBalance = "SELECT  asa.Subcategory_Id,sum (Assigned_Quantity)  as Asset_Count FROM Asset_Assign as asa JOIN Assets_subcategory as subctg ON  subctg.Subcategory_Id=asa.Subcategory_Id JOIN Asset_Category as ctg ON ctg.Category_Id = asa.Category_Id Where( Location_Id = '" + loc + "' AND  Division_Id = '" + div + "' AND Verified_Status='1' ) GROUP BY subctg.SubCategory_Desc ,ctg.Category_Desc,asa.Subcategory_Id";

             DataTable dtAct = objdb.RetrunDataTable(sqlActualBalance);
             if (dt3.Rows.Count == 0)
             {                                             
                     dtSet.Rows.Add("    Empty",0, 0, 0, 0);
                     return dtSet;
                     
                                                                                       
             }

            foreach(DataRow row in dt3.Rows)
            {
                int subId = 0;
                PerLedger = 0;
                bool state = int.TryParse(row[2].ToString(),out subId);
                bool st2 = int.TryParse(row[1].ToString(), out PerLedger);

                if (state)
                {
                    DataRow[] results = dtAct.Select("Subcategory_Id = '" + subId + "'");

                    if (results.Count() > 0)
                    {
                        int onHand = 0;
                       
                        bool st = int.TryParse(results[0].ItemArray[1].ToString(), out onHand);
                       
                        int diff = PerLedger - onHand;

                        //Deficiency
                        if (diff > 0)
                        {
                            dtSet.Rows.Add(row[0].ToString(), PerLedger, onHand, 0, diff);
                        }
                        //No difference
                        else if (diff == 0)
                        {
                            dtSet.Rows.Add(row[0].ToString(), PerLedger, onHand, 0, 0);
                        }
                        //Surplus
                        else if (diff < 0)
                        {
                            dtSet.Rows.Add(row[0].ToString(), PerLedger, onHand, diff, 0);
                        }



                    }
                    else
                    {
                        dtSet.Rows.Add(row[0].ToString(), PerLedger,0 , 0, 0);
                    }
                }

            }
            
            return dtSet;
        }

        private void cmblocation_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmblocation_DropDown(object sender, EventArgs e)
        {

        }

        private void cmblocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false ;
        }

        private void combodivname_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}


