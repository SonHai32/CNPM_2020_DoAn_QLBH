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
    public class DAL_BillDetail
    {
        public bool insertBillID(DTO_BillDetail billDetail)
        {
            bool success = false;
            String query = "INSERT INTO CHITIET_HD VALUES(@billID, @productID, @productAmount, @totalPrice)";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);
            command.Parameters.Add("@billID", SqlDbType.VarChar).Value = billDetail.BillID;
            command.Parameters.Add("@productID", SqlDbType.VarChar).Value = billDetail.ProductID;
            command.Parameters.Add("@productAmount", SqlDbType.VarChar).Value = billDetail.ProductAmount;
            command.Parameters.Add("@totalPrice", SqlDbType.VarChar).Value = billDetail.ProductTotalPrice;
            success = command.ExecuteNonQuery() >= 0;
            return success;
        }
    }
}
