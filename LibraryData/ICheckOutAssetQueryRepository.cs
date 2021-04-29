using System.Collections.Generic;
using System;
using LibarayData.Model;
using LibraryData.Model;

namespace LibraryData
{
   public interface ICheckOutAssetQueryRepository
    {
        CheckOutAsset InsertCheckOutAsset(int assetID, int userID, int LibrarianID);



        void UpdateCheckOutAsset(int checkoutassetID);


        CheckOutAsset FetchCheckOutAsset(int checkoutassetID);

        // retrive

        IReadOnlyList<CheckOutHistory> FetchCheckOutHistory(int userID);

    }
}
