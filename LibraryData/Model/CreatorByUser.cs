using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CreatorByUser
    {
       
        public int UserID { get; }

        public string UserName { get; }

        public long AssetCounRank { get; }

        public int CreatorID { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int AssetCount { get; }


        public CreatorByUser(int UserID, string UserName, long AssetCounRank, int CreatorID, string CreatorName, string CompanyName,
                                  int AssetCount)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.AssetCounRank = AssetCounRank;
            this.CreatorID = CreatorID;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;        
            this.AssetCount = AssetCount;
        }



    }
}
