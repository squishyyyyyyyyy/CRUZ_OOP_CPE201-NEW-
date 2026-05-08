using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUZ_OOP_CPE201
{
    internal class payrol_dbconnection
    {
        public String payrol_connectionString = null;
        public SqlConnection payrol_sql_connection;
        public SqlCommand payrol_sql_command;
        public DataSet payrol_sql_dataset;
        public SqlDataAdapter payrol_sql_dataadapter;
        public string payrol_sql = null;



    }
}
