using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class DTO_CCustomer
    {
        private String cusID;
        private String cusName;
        private String cusAddr;
        private String cusPhone;
        private String cusGender;

        public DTO_CCustomer(string cusID, string cusName, string cusAddr, string cusPhone, String cusGender)
        {
            this.CusID = cusID;
            this.CusName = cusName;
            this.CusAddr = cusAddr;
            this.CusPhone = cusPhone;
            this.CusGender = cusGender;
        }

        public string CusID { get => cusID; set => cusID = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string CusAddr { get => cusAddr; set => cusAddr = value; }
        public string CusPhone { get => cusPhone; set => cusPhone = value; }
        public String CusGender { get => cusGender; set => cusGender = value; }
    }
}
