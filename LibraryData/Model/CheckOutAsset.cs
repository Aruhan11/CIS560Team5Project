using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CheckOutAsset
    {
        public int CheckOutAssetID { get; }

        public int AssetID { get; }

        public int UserID { get; }

        public int LibrarianID { get; }

        public DateTimeOffset CheckOutDate { get; }

        public DateTimeOffset ReturnByDate { get; }

        public int IsReturned { get; }


        public CheckOutAsset(int CheckOutAssetID, int AssetID, int UserID, int LibrarianID, DateTimeOffset CheckOutDate, DateTimeOffset ReturnByDate, int IsReturned)
        {
            this.CheckOutAssetID = CheckOutAssetID;
            this.AssetID = AssetID;
            this.UserID = UserID;
            this.LibrarianID = LibrarianID;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.IsReturned = IsReturned;

        }
    }
}
