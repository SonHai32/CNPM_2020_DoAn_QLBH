using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    class DTO_Product
    {
        private string productID;
        private string productName;
        private int productAmount;
        private int productPrice;
        private string productUnit;

        public DTO_Product()
        {
            this.productID = "";
            this.productName = "";
            this.productUnit = "";
            this.productAmount = 0;
            this.productPrice = 0;
        }
        public DTO_Product(string productID, string productName, int productAmount, int productPrice, string productUnit)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.ProductAmount = productAmount;
            this.ProductPrice = productPrice;
            this.ProductUnit = productUnit;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        public int ProductPrice { get => productPrice; set => productPrice = value; }
        public string ProductUnit { get => productUnit; set => productUnit = value; }
    }
}
