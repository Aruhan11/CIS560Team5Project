using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class SituationOfAsset
    {
        //SELECT S.RowNumber, A.[Name], [AT].TypeName, (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
        //A.Stock, COA.CheckOutDate, COA.ReturnByDate, S.InBorrowingTotal

        public int AssetID { get; }

       // public int RowNumber { get; }

        public string Name { get; }

        public string TypeName { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int Stock { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get; }

        public int InBorrowingTotal { get; }


        public SituationOfAsset(int AssetID, string Name, string TypeName, string CreatorName, string CompanyName, DateTime CheckOutDate, DateTime ReturnByDate, int Stock)
        {
            this.AssetID = AssetID;
           // this.RowNumber = RowNumber;
            this.Name = Name;
            this.TypeName = TypeName;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.Stock = Stock;


        }
    }
}
