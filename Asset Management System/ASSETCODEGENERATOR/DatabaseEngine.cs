using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data .SqlClient ;
using System .Data;
using System.Configuration;


namespace DatabaseEngine
{
    public static class DatabaseEngine
    {
        public static string Connection()
        {
            //return ConfigurationManager.AppSettings["ConnectionStirng"]; 
            //return "Data Source=GEETHIKA;Initial Catalog=Assets;User ID=sa;password=sa123";
            String DBConnectoin = "";
            DBConnectoin= System.Configuration.ConfigurationManager.AppSettings["DBConnectionString"];
           // return DBConnectoin;
            return "Data Source=attendance.airport.lk;Initial Catalog=Assets;User ID=Assets_Ministry;password=Assets_Ministry";
        }
        public static int ExecuteScalare(string StrCommand, params SqlParameter[] Parameters)
        {

            int IntReturnValue;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = StrCommand;
                foreach (SqlParameter Parameter in Parameters)
                {
                    cmd.Parameters.Add(Parameter);

                }
                IntReturnValue = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                con.Close();
                return IntReturnValue;

            }
            catch (Exception e)
            {
                IntReturnValue = 0;
                return IntReturnValue;

            }
        }

        public static string ExecuteScalare(string StrCommand)
        {

            string IntReturnValue;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = StrCommand;
                con.Open();
                IntReturnValue = cmd.ExecuteScalar().ToString();
                con.Close();
                return IntReturnValue;

            }
            catch (Exception e)
            {
                IntReturnValue = "";
                return IntReturnValue;

            }
        }
        public static int ExecuteNonQuery(string StrCommand,params SqlParameter[] Parameters)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter parameter in Parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;

            }
            catch (Exception  ee)
            {

                return 0;
            }

        }
        public static int ExecuteNonQuery(string StrCommand)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;

            }
            catch (Exception ee)
            {

                return 0;
            }
        }


        public static DataTable ReturnDatatable(string StrCommand, params SqlParameter[] Parameters)
        {
            DataTable dt = new DataTable();
            try

            {   SqlConnection con = new SqlConnection ();
                con .ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                foreach (SqlParameter parameter in Parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                SqlDataAdapter da= new SqlDataAdapter (cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ee)
            {
                dt = null;
                return dt;
            }
        
        }


        public static DataTable ReturnDatatable(string StrCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }
            catch (Exception ee)
            {
                dt = null;
                return dt;
            }
        
        }

        public static string ExecuteScaler(string StrCommand, params SqlParameter[] Parameters)
        {
            string StrRetunValue = "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (SqlParameter parameter in Parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                con.Open();
               StrRetunValue= cmd.ExecuteScalar().ToString();
                con.Close();
                return StrRetunValue;

            }
            catch (Exception ee)
            {

                return StrRetunValue;
            }
        }

        public static string ExecuteScaler(string StrCommand)
        {
            string StrRetunValue = "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Connection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = StrCommand;
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                StrRetunValue = cmd.ExecuteScalar().ToString();
                con.Close();
                return StrRetunValue;

            }
            catch (Exception ee)
            {
                return StrRetunValue;
            }
        }

    }
}
