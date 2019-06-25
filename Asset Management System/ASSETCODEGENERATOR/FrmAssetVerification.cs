using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace ASSETCODEGENERATOR
{
    public partial class FrmAssetVerification : Form
    {
        public FrmAssetVerification()
        {
            InitializeComponent();
        }
        DB objdb = new DB();
        int configvalue1;
        String StrCsvFileName = "";
        DataTable dtfileinfo;
        String Locationid;
        String Divisionid;
        String SubCategoryid;
        String dbLid, dbDid, dbSCid, dbSno, dbDL;
        String assetid, Status;
        String SerialNo;
        String DesignatedLetter;
        DataTable dt1;
        String sname;
        // String datecsv;
        String Verified_date;
        String Verified_Status;
        int val;


        private void FrmAssetVerification_Load(object sender, EventArgs e)
        {
            String DBConnectoin = "";
            DBConnectoin = System.Configuration.ConfigurationManager.AppSettings["AVPS"];
            //return DBConnectoin;
            string configvalue1 = ConfigurationManager.AppSettings["AVPS"];
            if (configvalue1 == "0")
            {
                btnclose.Enabled = false;
                btn_upload.Enabled = false;
                btnstart.Enabled = true;
            }
            else
            {
                btnclose.Enabled = true;
                btn_upload.Enabled = true;
                btnstart.Enabled = false;
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //Add dialog box 
            lblMessage.Visible = false;
            btn_upload.Enabled = false;
            btnstart.Enabled = true;
            btnclose.Enabled = false;
            AddOrUpdateAppSettings("AVPS", "0");
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (configvalue1 == 0)
            {
                btnstart.Enabled = true;
            }
        }

        private void btnstart_Click_1(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            btnstart.Enabled = false;
            AddOrUpdateAppSettings("AVPS", "1");
            btnclose.Enabled = true;
            btn_upload.Enabled = true;

            int val = 0;
            string sql2 = "insert into Asset_Verification_History(AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO,verified_by,verifiedDate,Verified_Status) Select AssetId,Location_Id,Division_Id,Employee_Id,Category_Id,Subcategory_Id,SerialNo,PO_NO,verified_by,verifiedDate,Verified_Status from Asset_Assign";
            try
            {
                val = objdb.ExecuteNonQuery(sql2);
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                String name;
                bool check_varified = true;
                string filename = @"D:\Generated_CSV_files\";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = filename;
                dialog.Title = "Open CSV File";
                dialog.Filter = "CSV Files (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.FileName;
                    string ext = Path.GetExtension(dialog.FileName);
                    dtfileinfo = ConvertCSVtoDataTable(dialog.FileName);
                    //MessageBox.Show(ext);
                    if (ext == ".csv")
                    {
                        string sql = "SELECT[Assets].[dbo].[Asset_Assign].Location_Id,[Assets].[dbo].[Asset_Assign].[Division_Id],[Assets].[dbo].[Asset_Assign].[Subcategory_Id],[Assets].dbo.[Asset_Assign].[SerialNo],[Assets].dbo.[Asset_Category].Desig_letter FROM [Assets].[dbo].[Asset_Assign] Inner join [Assets].dbo.[Asset_Category]on [Assets].[dbo].[Asset_Assign].[Category_Id] = [Assets].dbo.[Asset_Category].[Category_Id]";
                        dt1 = objdb.RetrunDataTable(sql);
                        //foreach (String name in filePaths)
                        //{
                        //    string[] filename = name.Split();
                        //    sname = name;
                        //    dtfileinfo = ConvertCSVtoDataTable(name);
                        //}


                        foreach (DataRow dr in dtfileinfo.Rows)
                        {

                            String Lid = dr[0].ToString().Substring(0, 2);
                            String Did = dr[0].ToString().Substring(2, 2);
                            String SCid = dr[0].ToString().Substring(4, 2);
                            String Sno = dr[0].ToString().Substring(6, 4);
                            String DL = dr[0].ToString().Substring(10, 2);
                            if(dr[1].ToString().Trim() == "")
                            {
                                Verified_date = null;
                                Verified_Status = "0";
                                name = null;
                                check_varified = false;
                            }
                            else
                            {
                                Verified_date = dr[1].ToString();
                                Verified_Status = "1";
                                name = User.getUserName(); 

                            }

                            //if (dr[1].ToString() != "")
                            //{
                            //    Verified_date = dr[1].ToString();
                                
                            //    // MessageBox.Show(Verified_date);
                            //}

                            if (Lid.Length == 2)
                            {
                                StringBuilder sb = new StringBuilder(Lid);
                                sb.Remove(0, 1);
                                Locationid = sb.ToString();
                            }
                            else
                            {
                                StringBuilder sb = new StringBuilder(Lid);
                                Locationid = sb.ToString();
                            }

                            if (Did.Length == 2)
                            {
                                StringBuilder sb = new StringBuilder(Did);
                                sb.Remove(0, 1);
                                Divisionid = sb.ToString();
                            }
                            else
                            {
                                StringBuilder sb = new StringBuilder(Did);
                                Divisionid = sb.ToString();
                            }

                            if (SCid.Length == 2)
                            {
                                StringBuilder sb = new StringBuilder(SCid);
                                sb.Remove(0, 1);
                                SubCategoryid = sb.ToString();
                            }
                            else
                            {
                                StringBuilder sb = new StringBuilder(SCid);
                                SubCategoryid = sb.ToString();
                            }

                            if (Sno.Length == 4)
                            {
                                SerialNo = Sno.TrimStart('0');
                            }
                            else
                            {
                                SerialNo = Sno.TrimStart('0');
                            }

                            if (DL.Length == 2)
                            {

                                DesignatedLetter = DL.ToString();
                            }
                            else
                            {
                                DesignatedLetter = DL.ToString();
                            }


                            foreach (DataRow dr2 in dt1.Rows)
                            {
                                dbLid = dr2[0].ToString();
                                dbDid = dr2[1].ToString();
                                dbSCid = dr2[2].ToString();
                                dbSno = dr2[3].ToString();
                                dbDL = dr2[4].ToString();

                                if ((Locationid == dbLid) && (Divisionid == dbDid) && (SubCategoryid == dbSCid) && (SerialNo == dbSno) && (DesignatedLetter == dbDL))
                                {
                                    String queryreturnassetid = "select AA.AssetId,AA.Verified_Status from Asset_Assign AA inner join Asset_Category AC on AA.Category_Id= AC.Category_Id where AA.Location_Id='" + Locationid + "' and AA.Division_Id ='" + Divisionid + "' and AA.Subcategory_Id='" + SubCategoryid + "' and AA.SerialNo='" + SerialNo + "' and AC.Desig_letter='" + DesignatedLetter + "'";
                                    DataTable dt = objdb.RetrunDataTable(queryreturnassetid);
                                    if (dt.Rows.Count > 0)
                                    {
                                        assetid = dt.Rows[0][0].ToString();
                                        Status = dt.Rows[0][1].ToString();
                                    }
                                    if (check_varified)
                                   {
                                        string queryupdate = "update Asset_Assign set verifiedDate = '" + Verified_date + "' ,verified_by='" + name + "', Verified_Status = '" + Verified_Status + "'  where AssetId = '" + assetid + "' ";
                                        val = objdb.ExecuteNonQuery(queryupdate);
                                   }

                                    
                                }
                                else
                                {
                                    //  MessageBox.Show("Not equal");
                                }

                            }
                            // MessageBox.Show("end of file");
                        }
                        if(val >0)
                        {
                            lblMessage.Text = "The barcodes are verified ";
                            lblMessage.Visible = true;
                           // MessageBox.Show("The barcodes of the particular Location is verified and updated the database");
                        }
                    }
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }

        private void lbl_formClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}










