using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByAssetType
    {
        // CheckedOutAssets(CheckOutID, AssetID, UserID, LibrarianID, CheckOutDate, ReturnByDate, Returned)
       // public int RowNumber { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public string AssetTypeName { get; }

        public int CheckOutRank { get; }

        public string AssetName { get; }

        public int CheckOutCount { get; }
 

        public CreatorByAssetType( string CreatorName, string CompanyName, 
                                 string AssetTypeName, int CheckOutRank, string AssetName, int CheckOutCount)
        {
           // this.RowNumber = RowNumber;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.AssetTypeName = AssetTypeName;
            this.CheckOutRank = CheckOutRank;
            this.AssetName = AssetName;
            this.CheckOutCount = CheckOutCount;
        }


    }
}
