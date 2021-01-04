using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_Bill
    {
        public bool insertBill(DTO_Bill bill)
        {
            return new DAL_Bill().insertBill(bill);
        }
    }
}
