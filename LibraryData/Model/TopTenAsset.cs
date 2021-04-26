using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class TopTenAsset
    {
       // public int RowNumber { get; }

        public string AssetName { get; }

        public string AssetTypeName { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int BorrowedTimes { get; }


        public TopTenAsset( string AssetName, string AssetTypeName, 
                          string CreatorName, string CompanyName, int BorrowedTimes)
        {
           // this.RowNumber = RowNumber;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.AssetName = AssetName;
            this.AssetTypeName = AssetTypeName;
            this.BorrowedTimes = BorrowedTimes;
        }



    }
}
