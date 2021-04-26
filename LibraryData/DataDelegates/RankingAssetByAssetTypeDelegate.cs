using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class RankingAssetByAssetTypeDelegate : DataReaderDelegate<IReadOnlyList<AssetByAssetType>>
    {



        public RankingAssetByAssetTypeDelegate()
           : base("Library.RankingAssetByAssetType")
        {
        }


        public override IReadOnlyList<AssetByAssetType> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assetsList = new List<AssetByAssetType>();

            while (reader.Read())
            {
                assetsList.Add(new AssetByAssetType(
                    reader.GetString("AssetTypeName"),
                    reader.GetString("AssetName"),
                    reader.GetInt32("CheckOutCount")));
            }

            return assetsList;
        }
    }
}