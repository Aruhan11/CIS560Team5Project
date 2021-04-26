using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CheckOutHistory
    {
        //SELECT ROW_NUMBER() OVER(ORDER BY COA.CheckOutDate ASC) AS [RowNumber],
        //A.[Name], [AT].TypeName, C.FirstName + N' '+ C.LastName, C.Company, 
        //COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned

        public int UserID { get; }

       // public int RowNumber { get; }

        public string AssetName { get; }

        public string TypeName { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get; }


        public int IsReturned { get; }



        public CheckOutHistory(int UserID, string AssetName, string TypeName, string CreatorName, string CompanyName,
                               DateTime CheckOutDate, DateTime ReturnByDate, int IsReturned)
        {
            this.UserID = UserID;
          //  this.RowNumber = RowNumber;
            this.AssetName = AssetName;
            this.TypeName = TypeName;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.IsReturned = IsReturned;


        }
    }
}
