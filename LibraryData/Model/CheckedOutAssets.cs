using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class CheckedOutAssets
    {
        // CheckedOutAssets(CheckOutID, AssetID, UserID, LibrarianID, CheckOutDate, ReturnByDate, Returned)
        public int CheckOutID { get; }

        public int AssetID { get; }

        public int UserID { get; }

        public int LibrarianID { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get;}

        public int IsReturned { get; }

        public CheckedOutAssets(int CheckOutID, int AssetID, int UserID, int LibrarianID, DateTime CheckOutDate, DateTime ReturnByDate, int IsReturned)
        {
            this.CheckOutID = CheckOutID;
            this.AssetID = AssetID;
            this.UserID = UserID;
            this.LibrarianID = LibrarianID;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.IsReturned = IsReturned;
        }


    }
}
