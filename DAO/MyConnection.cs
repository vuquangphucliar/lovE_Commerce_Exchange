﻿using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;

//using BUS;

namespace DAO
{
    public class MyConnection
    {
        private MyConnection() { }
        public static string ConfigurationFile; 
        static object key = new object();
        private static MyConnection instance; // Ctrl + r + e
        //private string ConnectionString ;

        //Alternatives connection string
        private string ConnectionString = @"Data Source = LOVECRUSH; Initial Catalog = E_Commerce_Exchange; User ID = sa; Pwd = lovecrush; Application Name = Windows Forms Application";
        //private string AlternativeString = @"Data Source = LOVECRUSH; Initial Catalog = BikeStores; Integrated Security=true; Application Name = Windows Forms Application";
        public static MyConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new MyConnection();
                    }
                }
                return instance;
            }
        }

        public SqlDataReader ExecuteQuery(string sqlcommand, bool AutoCloseConnection = true)
        {
            //MyConnection.Instance.ExecuteQuery();
            SqlDataReader data;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {

                SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, SqlConnection);
                data = sqlCommand.ExecuteReader();

                if (AutoCloseConnection)
                {
                    SqlConnection.Close();
                }
            }
            return data;
        }
        public int ExecuteNonQuery(string command)
        {
            int rowReturn;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlCommand sqlCommand= new SqlCommand(command, SqlConnection);
                rowReturn = sqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                sqlCommand.Dispose();
            }
            return rowReturn;
        }
        public DataSet ExecuteDataset(string sqlcommand)
        {
            DataSet dataset;
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcommand, SqlConnection);
                dataset = new DataSet();
                dataadapter.Fill(dataset);
                SqlConnection.Close();
                dataadapter.Dispose();   

            }
            return dataset;
        }
        public DataTable ExecuteDataTable(string sqlcommand)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection SqlConnection = new SqlConnection(ConnectionString))
            {
                SqlConnection.Open();
                SqlDataAdapter datatableadapter = new SqlDataAdapter(sqlcommand, SqlConnection);
                datatableadapter.Fill(datatable);
                SqlConnection.Close();
                datatableadapter.Dispose();
            }
            return datatable;
        }

        //public void GetSeverName()
        //{
        //    try
        //    {
        //        SqlDataSourceEnumerator Instance = SqlDataSourceEnumerator.Instance;
        //        DataTable table = Instance.GetDataSources();
        //        ConnectionString = $"Data Source = {table.Rows[0][0]}; Initial Catalog = E_Commerce_Exchange; User ID = sa; Pwd = lovecrush; Application Name = Windows Forms Application";

        //    }
        //    catch
        //    {
        //        // Config right here;
        //    }
        //}
    }
}
