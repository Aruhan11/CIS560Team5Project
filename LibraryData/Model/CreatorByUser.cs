using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorsByUser
    {
        //SELECT ROW_NUMBER() OVER(ORDER BY C.CreatorID ASC),
        //CT.[Name], (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
        //A.Stock, COA.CheckOutDate, COA.ReturnByDate, S.InBorrowingTotal

        public int RowNumber { get; }

        public string UserName { get; }

        public int AssetCounRank { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int AssetCount { get; }


        public CreatorsByUser(int RowNumber, string UserName, int AssetCounRank, string CreatorName, string CompanyName,
                                  int AssetCount)
        {
            this.RowNumber = RowNumber;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.UserName = UserName;
            this.AssetCounRank = AssetCounRank;
            this.AssetCount = AssetCount;
        }



    }
}
