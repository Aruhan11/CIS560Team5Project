using LibarayData.Model;
using System.Collections.Generic;
using System;

namespace LibraryData
{
   public interface IAssetQueryRepository
    {

        Asset InsertAsset(string assetname, int assettypeID, int creatorID, DateTime releasedate, int stock);

        Creator InsertCreator(string firstname, string lastname, string company);

        AssetCategory InsertAssetCategory(int assetID, int categoryID);


        void UpdateAsset(int assetID, int stock);
       

        Asset FetchAsset(int assetID);

        IReadOnlyList<Asset> RetriveAssets();

        IReadOnlyList<SituationOfAsset> FetchSituationOfAsset(int assetID);

        IReadOnlyList<PossibleAssets> GetPossibleAssets(string assetName);

    }
}
