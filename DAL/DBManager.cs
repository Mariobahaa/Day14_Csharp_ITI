using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Diagnostics;

namespace DAL
{
    
    public class DBManager
    {
        SqlConnection Sqlcn;
        SqlCommand SqlCmd;
        SqlDataAdapter DA;
        DataTable Dt;

        public DBManager()
        {
            try
            {
                Sqlcn = new SqlConnection();
                Sqlcn.ConnectionString = ConfigurationManager.ConnectionStrings["pubsCS"].ConnectionString;

                SqlCmd = new SqlCommand("", Sqlcn);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                DA = new SqlDataAdapter(SqlCmd);

                Dt = new DataTable();
            }
            catch 
            {
                //log Exception
            }
        }

        public int ExecuteNonQuery(string SpName)
        {
            int R = -1;
            try
            {
                if (Sqlcn?.State == ConnectionState.Closed)
                    Sqlcn.Open();

                SqlCmd.Parameters.Clear();

                SqlCmd.CommandText = SpName;

                R = SqlCmd.ExecuteNonQuery();

                Sqlcn.Close();
            }
            catch
            {

            }
            return R;
        }

        public object ExecuteScaler(string SpName)
        {
            object R = new object();
            try
            {
                if (Sqlcn?.State == ConnectionState.Closed)
                    Sqlcn.Open();

                SqlCmd.Parameters.Clear();

                SqlCmd.CommandText = SpName;

                R = SqlCmd.ExecuteScalar();

                Sqlcn.Close();
            }
            catch
            {

            }
            return R;
        }

        public DataTable ExecuteDataTable(string SpName)
        {
            try
            {
                Dt.Clear();
                SqlCmd.Parameters.Clear();

                SqlCmd.CommandText = SpName;

                DA.Fill(Dt);
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
            }
            return Dt;
        }

        public int ExecuteNonQuery(string SpName, Dictionary<string, object> ParamList)
        {
            int R = -1;
            try
            {
                if (Sqlcn?.State == ConnectionState.Closed)
                    Sqlcn.Open();

                SqlCmd.Parameters.Clear();

                if (ParamList?.Count > 0)
                    foreach (var item in ParamList)
                        SqlCmd.Parameters.AddWithValue(item.Key, item.Value);


                SqlCmd.CommandText = SpName;

                R = SqlCmd.ExecuteNonQuery();

                Sqlcn.Close();
            }
            catch(Exception e)
            {
                Trace.WriteLine(e.Message);
            }
            return R;
        }

        public object ExecuteScaler(string SpName, Dictionary<string, object> ParamList)
        {
            throw new NotImplementedException();
        }

        public DataTable ExecuteDataTable(string SpName, Dictionary<string, object> ParamList)
        {
            throw new NotImplementedException();
        }

    }
}
