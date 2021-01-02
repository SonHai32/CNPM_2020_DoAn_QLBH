using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_CCustomer
    {
        public bool addCustomer(DTO_CCustomer customer)
        {
            return new DAL_CCustomer().addCustomer(customer); 
        }

        public DataTable getCusList(String queryString)
        {
            return new DAL_CCustomer().getCusList(queryString);
        }
    }
}
