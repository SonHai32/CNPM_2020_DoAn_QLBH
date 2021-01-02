using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;



namespace BUS
{
    public class BUS_CDBConnect
    {
        //------------1.Khai báo lớp: DAL_CDBConnect
        DAL_CDBConnect cn = new DAL_CDBConnect();

        //------------2.Viết hàm để gọi hàm kết nối CSDL bên tầng DAL
        public bool DBConnect(DTO_CLogIn lg)
        {
            return cn.DBConnect(lg);
        }

        //------------3.Viết hàm để gọi hàm hủy kết nới CSDL bên tầng DAL
        public bool DisDBConnect()
        {
            return cn.DisDBConnect();
        }

        public SqlConnection getConnection()
        {
            return DAL_CDBConnect.myconn;
        }

    }
}
