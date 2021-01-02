using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_CCustomer
    {

        public DataTable getCusList(String queryString)
        {
            try
            {
                DataTable cusList = new DataTable();
                SqlCommand command = new SqlCommand(queryString, DAL_CDBConnect.myconn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(cusList);
                return cusList;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }

            
        }
        public bool addCustomer(DTO_CCustomer customer)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_ThemKH", DAL_CDBConnect.myconn);
                command.CommandType = System.Data.CommandType.StoredProcedure; 
                command.Parameters.Add("@MsKH", System.Data.SqlDbType.Char, 10).Value = customer.CusID;
                command.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 30).Value = customer.CusName;
                command.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = customer.CusGender;
                command.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = customer.CusAddr;
                command.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar, 10).Value = customer.CusPhone;

                bool success = command.ExecuteNonQuery() >= 0;
                command.Parameters.Clear();
                return success;

            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

    }
}
