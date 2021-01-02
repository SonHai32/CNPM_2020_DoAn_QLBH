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
    public class DAL_User
    {
        public DTO_CUser userLogin(DTO_CUser user)
        {
            DTO_CUser getUser = null;

            String queryString = "pr_userLogin";
            SqlCommand command = new SqlCommand(queryString, DAL_CDBConnect.myconn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", System.Data.SqlDbType.VarChar).Value = user.TenDangNhap;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.MatKhau;

            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                getUser = new DTO_CUser(result["MANV"].ToString(), result["TENNV"].ToString(), user.TenDangNhap, result["DIENTHOAI"].ToString(), int.Parse(result["ROLE"].ToString()), result["ROLENAME"].ToString());
            }
           
            result.Close();
            return getUser;
        }
    }
}
