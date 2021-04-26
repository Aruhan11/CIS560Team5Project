using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByUser
    {
        //SELECT ROW_NUMBER() OVER(ORDER BY C.CreatorID ASC),
        //CT.[Name], (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
        //A.Stock, COA.CheckOutDate, COA.ReturnByDate, S.InBorrowingTotal

      //  public int RowNumber { get; }

        public string UserName { get; }

        public int AssetCounRank { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int AssetCount { get; }


        public CreatorByUser(string UserName, int AssetCounRank, string CreatorName, string CompanyName,
                                  int AssetCount)
        {
            //this.RowNumber = RowNumber;
            this.UserName = UserName;
            this.AssetCounRank = AssetCounRank;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;        
            this.AssetCount = AssetCount;
        }



    }
}
