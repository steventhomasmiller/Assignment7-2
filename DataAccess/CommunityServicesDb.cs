using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment7b.DataAccess
{
    public class CommunityServicesDb
    {
        SqlConnection connect;

        public CommunityServicesDb()
        {
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ConnectionString);
        }

        public DataTable GetServices()
        {
            string sql = "Select ServiceName, ServiceDescription From CommunityService";
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader reader;
            DataTable table = new DataTable();
            connect.Open();
            reader = cmd.ExecuteReader();
            table.Load(reader);
            reader.Close();
            connect.Close();
            return table;

        }
    }
}