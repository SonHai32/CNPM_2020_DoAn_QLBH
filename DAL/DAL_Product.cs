using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Product
    {
        public DataTable findProduct(string key)
        {
            DataTable data = new DataTable(); 
            SqlCommand command = new SqlCommand("pr_findProduct", DAL.DAL_CDBConnect.myconn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@key", SqlDbType.NVarChar).Value = key;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(data);

            return data;
        }
    }
}
