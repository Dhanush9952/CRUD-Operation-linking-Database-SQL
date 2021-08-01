using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace EmployServiceCRUD
{
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("integrated security=true;data source=DESKTOP-C98URTR\\SQLEXPRESS;initial catalog=sqlpractice");
        }
    }
}