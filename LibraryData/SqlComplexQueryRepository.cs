using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;

namespace LibraryData
{
    public class SqlComplexQueryRepository: IComplexQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public IReadOnlyList<AssetByAssetType> RankingAssetByAssetType()
        {
            return executor.ExecuteReader(new RankingAssetByAssetTypeDelegate());
        }

        public IReadOnlyList<CreatorByAssetType> RankingCreatorByAssetType()
        {
            return executor.ExecuteReader(new RankingCreatorByAssetTypeDelegate());
        }


        public IReadOnlyList<CreatorByUser> RankingCreatorByUser()
        {
            return executor.ExecuteReader(new RankingCreatorByUserDelegate());
        }


        public IReadOnlyList<TopTenAsset> TopTenAssetsStillAvaliable()
        {
            return executor.ExecuteReader(new TopTenAssetsStillAvaliableDelegate());
        }


    }
}
