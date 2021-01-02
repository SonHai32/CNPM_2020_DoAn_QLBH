using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CLogIn
    {
        //--------Khai báo các biến chứa thông tin kết nối CSDL (Database)
        private string _ServerName;
        private string _Database;
        private string _UserId;
        private string _Password;

        public string ServerName { get => _ServerName; set => _ServerName = value; }
        public string Database { get => _Database; set => _Database = value; }
        public string UserId { get => _UserId; set => _UserId = value; }
        public string Password { get => _Password; set => _Password = value; }


        //--------Khai báo hàm tạo (Constructor)
        public DTO_CLogIn() { }
        public DTO_CLogIn(string SV, string DB, string US, string PW)
        {
            ServerName = SV;
            Database = DB;
            UserId = US;
            Password = PW;
        }
    }
}
