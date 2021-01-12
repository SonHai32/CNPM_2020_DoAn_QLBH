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
    public class DAL_WorkShift
    {
        public void insertWorkShift(DTO_WorkShift workShift) {
            String query = "INSERT INTO CALAM values(@workShiftID, @userID, @workDate, @startAt, @endAt)";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);

            command.Parameters.Add("@workShiftID", SqlDbType.VarChar).Value = workShift.WorkShiftID;
            command.Parameters.Add("@userID", SqlDbType.Char).Value = workShift.UserID;
            command.Parameters.Add("@workDate", SqlDbType.DateTime).Value = workShift.DateWork;
            command.Parameters.Add("@startAt", SqlDbType.Float).Value = Math.Round (workShift.BeginAt, 2);
            command.Parameters.Add("@endAt", SqlDbType.Float).Value = workShift.EndAt;

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void updateWorkShiftTime(String workShiftID, float time)
        {
String query = "UPDATE CALAM SET GIOKT = @endAt WHERE MACL = @workShiftID";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);

            command.Parameters.Add("@endAt", SqlDbType.Float).Value = Math.Round(time, 2);
            command.Parameters.Add("@workShiftID", SqlDbType.VarChar).Value = workShiftID;

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void insertWorkShiftDetail(string workShiftID, long money, long sales, long moneyOfEnd)
        {
            string query = "INSERT INTO CT_CALAM values(@workShiftID, @money, @sales, @moneyOfEnd)";
            SqlCommand command = new SqlCommand(query, DAL_CDBConnect.myconn);
            command.Parameters.Add("@workShiftID", SqlDbType.VarChar).Value = workShiftID;
            command.Parameters.Add("@money", SqlDbType.Float).Value = money;
            command.Parameters.Add("@sales", SqlDbType.Float).Value = sales;
            command.Parameters.Add("@moneyOfEnd", SqlDbType.Float).Value = moneyOfEnd;

            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
