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

            sda.Dispose();
            command.Dispose();

            return data;
        }

        public bool insertProduct(DTO_Product product)
        {
            String query = "INSERT INTO MATHANG VALUES(@productID, @productName, @productAmount, @productPrice, @productUnit)";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);

            command.Parameters.Add("@productID", SqlDbType.Char).Value = product.ProductID;
            command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = product.ProductName;
            command.Parameters.Add("@productAmount", SqlDbType.Int).Value = product.ProductAmount;
            command.Parameters.Add("@productPrice", SqlDbType.Float).Value = product.ProductPrice;
            command.Parameters.Add("@productUnit", SqlDbType.NVarChar).Value = product.ProductUnit;

            bool success = command.ExecuteNonQuery() >= 0;
            command.Dispose();
            return success;
        }
            public bool updateProduct(DTO_Product product)
        {
            String query = "UPDATE MATHANG SET TENMH = @productName, SL_TON = @productAmount, DONVITINH = @productUnit, DONGIA = @productPrice WHERE MSMH = @productID";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);

            command.Parameters.Add("@productID", SqlDbType.Char).Value = product.ProductID;
            command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = product.ProductName;
            command.Parameters.Add("@productAmount", SqlDbType.Int).Value = product.ProductAmount;
            command.Parameters.Add("@productPrice", SqlDbType.Float).Value = product.ProductPrice;
            command.Parameters.Add("@productUnit", SqlDbType.NVarChar).Value = product.ProductUnit;

            bool success = command.ExecuteNonQuery() >= 0;
            command.Dispose();
            return success;
        }

        public bool deleteProduct(String productID)
        {
            String query = "pr_deleteProduct";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@productID", SqlDbType.VarChar).Value = productID;

            bool success = command.ExecuteNonQuery() >= 0;
            command.Dispose();
            return success;
        }
    }
}
