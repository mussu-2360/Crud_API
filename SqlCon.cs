using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_API.Models
{
    public class SqlCon
    {
        public SqlConnection con;

        public SqlCon()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Defaultconnection"].ConnectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        
        }
    }
}


