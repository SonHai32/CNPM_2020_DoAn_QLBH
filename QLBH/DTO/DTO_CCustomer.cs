using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_CCustomer
    {
        private string _MsKH;
        private string _TENKH;
        private string _PHAI;
        private string _DIACHI;
        private string _DIENTHOAI;

        public string MsKH { get => _MsKH; set => _MsKH = value; }
        public string TENKH { get => _TENKH; set => _TENKH = value; }
        public string PHAI { get => _PHAI; set => _PHAI = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string DIENTHOAI { get => _DIENTHOAI; set => _DIENTHOAI = value; }
        public DTO_CCustomer() { }
        public DTO_CCustomer(string MsKH,string TENKH,string PHAI,string DIACHI,string DIENTHOAI)
        {
            this.MsKH = MsKH;
            this.TENKH = TENKH;
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
        }
    }
}
