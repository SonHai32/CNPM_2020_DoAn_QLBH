using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class DTO_Bill
    {
        private string billID;
        private String userID;
        private DateTime dateCreated;
        private int totalPrice;

        public DTO_Bill(string billID, string userID, DateTime dateCreated, int totalPrice)
        {
            this.BillID = billID;
            this.UserID = userID;
            this.DateCreated = dateCreated;
            this.TotalPrice = totalPrice;
        }

        public string BillID { get => billID; set => billID = value; }
        public string UserID { get => userID; set => userID = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
