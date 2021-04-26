using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class TopTenAssetsStillAvaliableDelegate : DataReaderDelegate<IReadOnlyList<TopTenAsset>>
    {

        public TopTenAssetsStillAvaliableDelegate()
           : base("Library.TopTenAsset")
        {
        }


        public override IReadOnlyList<TopTenAsset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assetList = new List<TopTenAsset>();

            while (reader.Read())
            {
                assetList.Add(new TopTenAsset(
                    reader.GetString("AssetName"),
                    reader.GetString("AssetTypeName"),
                    reader.GetString("CreatorName"),
                    reader.GetString("CompanyName"),
                    reader.GetInt32("BorrowedTimes")));
            }

            return assetList;
        }
    }
}