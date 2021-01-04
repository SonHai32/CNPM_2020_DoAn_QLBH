using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BillDetail
    {
        private String billID;
        private String productID;
        private int productAmount;
        private int productTotalPrice;

        public DTO_BillDetail(string billID, string productID, int productAmount, int productTotalPrice)
        {
            this.BillID = billID;
            this.ProductID = productID;
            this.ProductAmount = productAmount;
            this.ProductTotalPrice = productTotalPrice;
        }

        public string BillID { get => billID; set => billID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        public int ProductTotalPrice { get => productTotalPrice; set => productTotalPrice = value; }
    }
}
