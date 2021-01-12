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

            command.Dispose();
            return success;
        }

        public DataTable getBill(String searchValue, String start, String end)
        {
            DataTable data = new DataTable();
            String query = "pr_timHoaDon";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@value", SqlDbType.NVarChar).Value = searchValue;
            if(start != null && end != null)
            {
                command.Parameters.Add("@ngayBatDau", SqlDbType.Date).Value = start;
                command.Parameters.Add("@ngayKetThuc", SqlDbType.Date).Value = end;
            }

            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(data);
            sda.Dispose();
            command.Dispose();
            return data;
        }
    }

}
