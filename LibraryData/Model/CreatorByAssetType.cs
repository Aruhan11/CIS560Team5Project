using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByAssetType
    {
       
        public int CreatorID { get; }
        public string CreatorName { get; }

        public string CompanyName { get; }

        public string AssetTypeName { get; }

        public long CheckOutRank { get; }

        public string AssetName { get; }

        public int CheckOutCount { get; }
 

        public CreatorByAssetType( int CreatorID, string CreatorName, string CompanyName, 
                                 string AssetTypeName, long CheckOutRank, string AssetName, int CheckOutCount)
        {
            this.CreatorID = CreatorID;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.AssetTypeName = AssetTypeName;
            this.CheckOutRank = CheckOutRank;
            this.AssetName = AssetName;
            this.CheckOutCount = CheckOutCount;
        }


    }
}
