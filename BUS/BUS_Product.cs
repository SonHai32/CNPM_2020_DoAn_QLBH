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

        public bool insertProduct(DTO_Product product)
        {
            return new DAL_Product().insertProduct(product);
        }
        public bool updateProduct(DTO_Product product)
        {
            return new DAL_Product().updateProduct(product);
        }

        public bool deleteProduct(String productID)
        {
            return new DAL_Product().deleteProduct(productID);
        }
    }
}
