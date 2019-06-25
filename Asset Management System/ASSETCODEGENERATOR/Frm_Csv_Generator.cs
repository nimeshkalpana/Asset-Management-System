using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseEngine;
using System.Data .SqlClient;
using System.IO;

namespace ASSETCODEGENERATOR

{
    public partial class Frm_Csv_Generator : Form
    {
        public Frm_Csv_Generator()
        {
            InitializeComponent();
        }

          private string guid;

          public Frm_Csv_Generator(string aGuid)
       {
       guid = aGuid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
            DataTable dt = new DataTable();
            dt = DatabaseEngine.DatabaseEngine.ReturnDatatable("SP_Select_Location");
            if( (dt != null) && (dt.Rows.Count >0))
            {
                cmbLocation.DataSource = dt;
                cmbLocation.DisplayMember = "Location_name";
                cmbLocation.ValueMember = "Location_Id";
            }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }


        }

        public void CreateCSV(DataTable dt, string aDestPath, string aTitle)
        {

            string filePath = string.Concat(aDestPath, aTitle, @"-", this.guid, @".csv");
            string delimiter = ",";


            StringBuilder sb = new StringBuilder();
            List<string> CsvRow = new List<string>();


            //write headers
            foreach (DataColumn c in dt.Columns)
            {
                CsvRow.Add(c.ColumnName.ToString());

            }
            sb.AppendLine(string.Join(delimiter, CsvRow));


            //write data
            foreach (DataRow r in dt.Rows)
            {
                CsvRow.Clear();

                //go through each column adding to a list of strings
                foreach (DataColumn c in dt.Columns)
                {
                    CsvRow.Add(r[c.ColumnName].ToString());
                }

                sb.AppendLine(string.Join(delimiter, CsvRow));
            }



            File.WriteAllText(filePath, sb.ToString());

            Console.WriteLine();
            Console.WriteLine(String.Concat(@"just completed: ", aTitle, @"-", this.guid, @".csv"));
        }

        public void strname()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string divCode = "";
            string locationCode = "";
            string AssetLettFin = "";
            string subCatCode = "";
            string serialCode = "";
            if (cmbLocation.Text != "")
            {

                DataTable dt = new DataTable ();
                try 
	            {	        
		
                  dt = DatabaseEngine.DatabaseEngine.ReturnDatatable("SP_Select_Asset_Assigned_By_Location",
                   new SqlParameter("@LocationID",Convert.ToInt32(cmbLocation.SelectedValue)));

             	}
	             catch (Exception ee)
	            {
		
	         	MessageBox .Show(ee.ToString());
                return ;
	            }

                DataTable dtAssetCode = new DataTable();
                DataColumn dcAssetCode = new DataColumn();
                dcAssetCode.ColumnName = "AssetCode";
                DataColumn dcDateVerified = new DataColumn();
                dcDateVerified.ColumnName = "Date Verified";
                dtAssetCode.Columns.Add(dcAssetCode);
                dtAssetCode.Columns.Add(dcDateVerified);

                if ((dt != null) && (dt.Rows.Count == 0))
                { lblMessage.Text = "No Records Avialable for selected Location"; }

                foreach (DataRow row in dt.Rows)
                {
                  

                    if (row[1].ToString().Length < 2)
                    {
                        divCode = "0" + row[1].ToString();
                    }
                    else
                    {
                        divCode = row[1].ToString();
                    }
                    //Location
                    if (row[0].ToString().Length < 2)
                    {
                        locationCode = "0" + row[0].ToString();
                    }
                    else
                    {
                        locationCode = row[0].ToString();
                    }
                    if (row[4].ToString().Length < 2)
                    {
                        AssetLettFin = "0" + row[4].ToString();
                    }
                    else
                    {
                        AssetLettFin = row[4].ToString().ToString();
                    }

                    //Subcat
                    if (row[2].ToString().Length < 2)
                    {
                        subCatCode = "0" + row[2].ToString();
                    }
                    else
                    {
                        subCatCode = row[2].ToString();
                    }

                    //serial number
                    if (row[3].ToString().Length == 1)
                    {
                        serialCode = "000" + row[3].ToString();
                    }
                    else if (row[3].ToString().Length == 2)
                    {
                        serialCode = "00" + row[3].ToString();
                    }
                    else if (row[3].ToString().Length == 3)
                    {
                        serialCode = "0" + row[3].ToString();
                    }
                    else if (row[3].ToString().Length == 4)
                    {
                        serialCode = row[3].ToString();
                    }
                    string val = locationCode + divCode + subCatCode + serialCode + AssetLettFin;
                    DataRow dr = dtAssetCode.NewRow();

                    dtAssetCode.Rows.Add(val);

                    if (dtAssetCode.Rows.Count > 0)
                    {

                        String StrMonth = "";
                        if (System.DateTime.Now.Month.ToString().Length == 1)
                        { StrMonth="0"+System.DateTime.Now.Month.ToString(); }
                        else{StrMonth=System.DateTime.Now.Month.ToString();}

                        String StrDate = "";
                        if (System.DateTime.Now.Day.ToString().Length == 1)
                        { StrDate = "0" + StrDate; }
                        else { StrDate = System.DateTime.Now.Day.ToString(); }

                        String StrHour = "";
                        if (System.DateTime.Now.Hour.ToString().Length == 1)
                        { StrHour = "0" + System.DateTime.Now.Hour.ToString(); }
                        else { StrHour = System.DateTime.Now.Hour.ToString(); }

                        String StrMinutes = "";
                        if (System.DateTime.Now.Minute.ToString().Length == 1)
                        { StrMinutes = "0" + System.DateTime.Now.Minute.ToString(); }
                        else { StrMinutes = System.DateTime.Now.Minute.ToString(); }

                        String StrSeconds = "";
                        if(System.DateTime .Now .Second.ToString().Length==1)
                        {StrSeconds="0"+System.DateTime .Now .Second.ToString(); }
                        else{StrSeconds=System.DateTime .Now .Second.ToString();}

                        String StrCsvFileName ="Asset - "+cmbLocation.Text+" - " + System.DateTime.Now.Year.ToString() + StrMonth + StrDate + StrHour + StrMinutes + StrSeconds + ".csv";

                        CreateCSV(dtAssetCode, System.Configuration.ConfigurationManager.AppSettings["CSVPATH"], StrCsvFileName);
                        lblMessage.Text = StrCsvFileName+"  "+" File Generated";
                    }



                }

        }
    }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
    }