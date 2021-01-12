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

        private String userID;
        private String userName;
        private DateTime dayCreated;
        private String productName;
        private String productUnit;

        public DTO_BillDetail(string billID, string productID, int productAmount, int productTotalPrice)
        {
            this.BillID = billID;
            this.ProductID = productID;
            this.ProductAmount = productAmount;
            this.ProductTotalPrice = productTotalPrice;
        }

        public DTO_BillDetail(string billID, string productID, int productAmount, int productTotalPrice, string userID, string userName, DateTime dayCreated, string productName, string productUnit)
        {
            this.billID = billID;
            this.productID = productID;
            this.productAmount = productAmount;
            this.productTotalPrice = productTotalPrice;
            this.UserID = userID;
            this.UserName = userName;
            this.DayCreated = dayCreated;
            this.ProductName = productName;
            this.ProductUnit = productUnit;
        }

        public string BillID { get => billID; set => billID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        public int ProductTotalPrice { get => productTotalPrice; set => productTotalPrice = value; }
        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public DateTime DayCreated { get => dayCreated; set => dayCreated = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductUnit { get => productUnit; set => productUnit = value; }
    }
}
