using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class ProductionOfCreator
    {
        // SELECT ROW_NUMBER() OVER(ORDER BY A.AssetTypeID ASC),
        //(C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, A.[Name], [AT].TypeName,  
        // A.Stock
        public int CreatorID { get; }
        
      //  public int RowNumber { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public string AssetName { get; }

        public string AssetTypeName { get; }

        public int Stock { get; }

        public ProductionOfCreator(int CreatorID, string CreatorName, string CompanyName, string AssetName, string AssetTypeName, int Stock)
        {
            this.CreatorID = CreatorID;
           // this.RowNumber = RowNumber;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.AssetName = AssetName;
            this.AssetTypeName = AssetTypeName;
            this.Stock = Stock;
        }


    }
}
