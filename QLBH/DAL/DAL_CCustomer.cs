using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
   public class DAL_CCustomer
    {
        public void pr_ThemKH( DTO_CCustomer C)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MsKH",System.Data.SqlDbType.Char,10).Value=C.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 30).Value = C.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 50).Value = C.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 100).Value = C.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar, 10).Value = C.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception X) 
            {
                MessageBox.Show(X.Message.ToString());
            }
        }
    }
}
