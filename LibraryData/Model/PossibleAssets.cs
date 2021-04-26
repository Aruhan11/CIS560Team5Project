using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class PossibleAssets
    {
        //SELECT ROW_NUMBER() OVER(ORDER BY A.ReleaseDate ASC) AS [RowNumber],
        //A.[Name], [AT].TypeName, C.FirstName + N' '+ C.LastName, C.Company, A.ReleaseDate, A.Stock

       // public int RowNumber { get; }

        public string AssetName { get; }

        public string TypeName { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public DateTime ReleaseDate { get; }

        public int Stock { get; }

        
        public PossibleAssets(string AssetName, string TypeName, string CreatorName, string CompanyName, DateTime ReleaseDate, int Stock)
        {
           // this.RowNumber = RowNumber;
            this.AssetName = AssetName;
            this.TypeName = TypeName;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.ReleaseDate = ReleaseDate;
            this.Stock = Stock;


        }
    }
}
