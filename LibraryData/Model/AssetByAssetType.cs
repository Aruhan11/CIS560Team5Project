using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class AssetByAssetType
    {
        // CheckedOutAssets(CheckOutID, AssetID, UserID, LibrarianID, CheckOutDate, ReturnByDate, Returned)
       // public int RowNumber { get; }

        public string AssetTypeName { get; }

        public long CheckOutRank { get; }

        public string AssetName { get; }

        public int CheckOutCount { get; }
 

        public AssetByAssetType(string AssetTypeName, long CheckOutRank,string AssetName, int CheckOutCount)
        {
           // this.RowNumber = RowNumber;
            this.AssetTypeName = AssetTypeName;
            this.CheckOutRank = CheckOutRank;
            this.AssetName = AssetName;
            this.CheckOutCount = CheckOutCount;
        }


    }
}
