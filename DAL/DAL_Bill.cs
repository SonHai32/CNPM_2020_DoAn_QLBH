using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace DAL
{
    
    public class DAL_Bill
    {
        public bool insertBill(DTO_Bill bill)
        {
            bool success = false;
            String query = "INSERT INTO HOADON VALUES(@billID, @userID, @dateCreated, @totalPrice)";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);
            command.Parameters.Add("@billID", SqlDbType.VarChar).Value = bill.BillID;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = bill.UserID;
            command.Parameters.Add("@dateCreated", SqlDbType.VarChar).Value = bill.DateCreated;
            command.Parameters.Add("@totalPrice", SqlDbType.VarChar).Value = bill.TotalPrice;

            success = command.ExecuteNonQuery() >= 0;

            return success;
        }
    }
}
