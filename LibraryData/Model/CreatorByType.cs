using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByType
    {
        //SELECT ROW_NUMBER() OVER(ORDER BY C.CreatorID ASC),
	   //CT.[Name], (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
	   //A.Stock, COA.CheckOutDate, COA.ReturnByDate, S.InBorrowingTotal


       // public int RowNumber { get; }

        public string CreatorType { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int Stock { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get; }

        public int InBorrowingTotal { get; }


        public CreatorByType(string CreatorType, string CreatorName, string CompanyName, 
                              int Stock, DateTime CheckOutDate, DateTime ReturnByDate, int InBorrowingTotal)
        {
            //this.CreatorTypeName = CreatorTypeName;
           // this.RowNumber = RowNumber;
            this.CreatorType = CreatorType;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.Stock = Stock;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.InBorrowingTotal = InBorrowingTotal;


        }


    }
}
