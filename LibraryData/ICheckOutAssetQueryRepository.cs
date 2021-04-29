using System.Collections.Generic;
using System;
using LibarayData.Model;
using LibraryData.Model;

namespace LibraryData
{
   public interface ICheckOutAssetQueryRepository
    {
        CheckOutAsset CreateCheckOutAsset(int assetID, int userID, int librarianID);

        void UpdateCheckOutAsset(int checkoutassetID);


        CheckOutAsset FetchCheckOutAsset(int checkoutassetID);

        IReadOnlyList<CheckOutAsset> RetrieveCheckOutAssets();

        IReadOnlyList<CheckOutHistory> FetchCheckOutHistory(int userID);

    }
}
