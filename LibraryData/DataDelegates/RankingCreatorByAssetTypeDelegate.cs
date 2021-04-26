using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class RankingCreatorByAssetTypeDelegate : DataReaderDelegate<IReadOnlyList<CreatorByAssetType>>
    {


        public RankingCreatorByAssetTypeDelegate()
           : base("Library.RankingCreatorByAssetType")
        {
          
        }

        public override IReadOnlyList<CreatorByAssetType> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creatorList = new List<CreatorByAssetType>();

            while (reader.Read())
            {
                creatorList.Add(new CreatorByAssetType(
                    reader.GetString("CreatorName"),
                    reader.GetString("CompanyName"),
                    reader.GetString("AssetTypeName"),
                    reader.GetInt32("CheckOutRank"),
                    reader.GetString("AssetName"),
                    reader.GetInt32("CheckOutCount")));
            }

            return creatorList;
        }
    }
}