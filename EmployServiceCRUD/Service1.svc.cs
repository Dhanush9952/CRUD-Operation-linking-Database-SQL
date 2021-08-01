using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployService.svc or EmployService.svc.cs at the Solution Explorer and start debugging.
    public class EmployService : IEmployService
    {
        SqlConnection connection;
        SqlCommand command;


        public emp[] ShowEmploy()
        {
            connection = ConnectionHelper.GetConnection();
            connection.Open();
            command = new SqlCommand("SelectAllEmploy",connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int count = dt.Rows.Count;
            emp[] arrEmp = new emp[count];
            emp emp = null;
            int i = 0;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                emp = new emp();
                emp.Empno = Convert.ToInt32(dr["empno"]);
                emp.Name = dr["name"].ToString();
                emp.Dept = dr["dept"].ToString();
                emp.Desig = dr["desig"].ToString();
                emp.Basic = Convert.ToInt32(dr["basic"]);
                arrEmp[i] = emp;
                i++;
            }
            return arrEmp;
        }
    }
}
