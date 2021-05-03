using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByType
    {
        


        public int CreatorID { get; }

        public string CreatorType { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int Stock { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get; }

        public int InBorrowingTotal { get; }


        public CreatorByType(string CreatorType, int CreatorID, string CreatorName, string CompanyName, 
                              int Stock, DateTime CheckOutDate, DateTime ReturnByDate, int InBorrowingTotal)
        {
            
            this.CreatorType = CreatorType;
            this.CreatorID = CreatorID;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.Stock = Stock;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.InBorrowingTotal = InBorrowingTotal;


        }


    }
}
