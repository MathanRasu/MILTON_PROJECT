using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MILTON_PROJECT.Repository.UnitOfWorks
{
    public class UnitOfWorksConn
    {
        private static readonly string ConnectionString = Convert.ToString(ConfigurationManager.AppSettings["ConnectionString"]);

        public static void ConnectionOpen()
        {
            SqlConnection DbConnection = new SqlConnection(ConnectionString);          
            DbConnection.Open();
           
            SqlCommand DbCommand = new SqlCommand(); 
            DbCommand.Connection = DbConnection; 
        }

    }
}