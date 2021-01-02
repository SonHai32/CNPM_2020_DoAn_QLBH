
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DAL
{
    public class DAL_CDBConnect
    {
        //------------1.Khai báo lớp kết nối CSDL
        public static SqlConnection myconn;

        //------------2.Viết hàm kết nối CSDL
        public bool DBConnect(DTO_CLogIn lg)
        {
            try
            {
                myconn = new SqlConnection("Data Source=" + lg.ServerName +
                                            "; Initial Catalog=" + lg.Database +
                                            "; User Id=" + lg.UserId +
                                            "; Password=" + lg.Password);
                myconn.Open(); //-------Mở kết nối CSDL
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return false;
            }
        }


        //-------------3.Viết hàm hủy kết nối với CSDL
        public bool DisDBConnect()
        {
            try
            {
                myconn.Close(); //----Đóng kết nối với CSDL
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return false;
            }
        }
    }
}
