using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Product
    {
        public DataTable findProducts(string key)
        {
            return new DAL_Product().findProduct(key);
        }
    }
}
