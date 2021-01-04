using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_BillDetail
    {
        public bool insertBillDetail(DTO_BillDetail billDetail)
        {
            return new DAL_BillDetail().insertBillID(billDetail);
        }
    }
}
