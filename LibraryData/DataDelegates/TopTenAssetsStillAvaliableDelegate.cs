using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class TopTenAssetsStillAvaliableDelegate : DataReaderDelegate<IReadOnlyList<TopTenAsset>>
    {
        private readonly string phonenumber;

        public TopTenAssetsStillAvaliableDelegate(string assetName)
           : base("Library.TopTenAsset")
        {
            this.assetName = assetName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AssetName", assetName);
        }

        public override IReadOnlyList<TopTenAsset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assetList = new List<TopTenAsset>();

            while (reader.Read()) {
                assetList.Add(new TopTenAsset(
                    reader.GetInt32("RowNumber"),
                    reader.GetString("AssetName"),
                    reader.GetString("AssetTypeName"),
                    reader.GetString("CreatorName"),
                    reader.GetString("CompanyName"),
                    reader.GetInt32("BorrowedTimes")))
            }

            return assetList;
        }
    }
}