﻿using LibarayData.Model;
using System.Collections.Generic;

namespace LibraryData
{
    public interface IComplexQueryRepository
    {
        IReadOnlyList<AssetByAssetType> RankingAssetByAssetType();

        IReadOnlyList<CreatorByAssetType> RankingCreatorByAssetType();


        IReadOnlyList<CreatorsByUser> RankingCreatorByUser();


        IReadOnlyList<TopTenAsset> TopTenAssetsStillAvaliable();






    }
}
