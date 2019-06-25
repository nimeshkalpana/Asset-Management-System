using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ASSETCODEGENERATOR
{
    public class DB
    {
        string StrConnection = System.Configuration.ConfigurationManager.AppSettings["DBConnectionString"];        
     

          SqlConnection con = new SqlConnection();

        public DataTable RetrunDataTable(string Strcommand)
        {
            DataTable dtreturn = new DataTable();
           
     
            try
            {
                connectdb();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = Strcommand;       
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtreturn);
                return dtreturn;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return dtreturn;
            }
        }



        public DataTable RetrunDataTable_With_SP(string Strcommand)
        {
            DataTable dtreturn = new DataTable();

          
            try
            {
                connectdb();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = Strcommand;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                             
                da.Fill(dtreturn);
                return dtreturn;
            }
            catch (Exception ee)
            {
                return dtreturn;
            }
        }


        public DataTable RetrunDataTable_With_Parameters(string Strcommand,SqlParameter[] parameter)
        {
            DataTable dtreturn = new DataTable();

            try
            {
                connectdb();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = Strcommand;
                SqlDataAdapter da = new SqlDataAdapter(cmd);


                da.Fill(dtreturn);
                return dtreturn;
            }
            catch (Exception ee)
            {
                return dtreturn;
            }
        }

        public int ExecuteNonQuery(string StrCommand)
        {
           try
            {

                connectdb();
                SqlCommand cmd = new SqlCommand(StrCommand, con);
                int i= cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ee)
            {

                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public int ExecuteScalar(string StrCommand)
        {
            int result = 0;
       
            try
            {
                connectdb();
                SqlCommand cmd = new SqlCommand(StrCommand, con);
                object i = cmd.ExecuteScalar();

                if (i != null)
                {
                    int.TryParse(i.ToString(), out result);
                }
                return result;
            }
            catch (Exception ee)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public void ExecuteReader(string query)
        {
            int array = 0;
            int i=0;
         
            try
            {
                connectdb();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(0) < DateTime.Now.Year)
                    {
                        array = reader.GetInt32(0);
                    }
                }
                string query_1 = "insert into History (barcode,verified,verifiedDate) (select barcode,verified,verifiedDate from tblBarcode where YEAR(verifiedDate)=" + array + ")";
                string query_2 = "update tblBarcode set verified='false' , verifiedDate=null where YEAR(verifiedDate)=" + array + "";
                ExecuteNonQuery(query_1);
                ExecuteNonQuery(query_2);
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have already clear database for last year");
            }
        }
        public string Read_CatDesc(string query)
        { 
            string desc="";
                connectdb();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   desc = reader.GetString(0);
                }
                reader.Close();
                return desc;
        }
        public int Read_Subcat(string query)
        {
            int id = 0;
          
            connectdb();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            con.Close();
            return id;
        }


        public int serialNo(string query)
        {
            connectdb();
                int result = 0;
                SqlCommand cmd = new SqlCommand(query, con);
                object i = cmd.ExecuteScalar();
                int.TryParse(i.ToString(), out result);
                return result;
        }

        public void connectdb()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = StrConnection;
                con.Open();
            }
        
        }
    }
}
