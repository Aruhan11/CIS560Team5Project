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
        private readonly string assetTypeName;

        public RankingAssetByAssetTypeDelegate(string assetTypeName)
           : base("Library.RankingAssetByAssetType")
        {
            this.assetTypeName = assetTypeName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AssetTypeName", assetTypeName);
        }

        public override IReadOnlyList<AssetByAssetType> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assetTypeList = new List<AssetByAssetType>();

            while(reader.Read()){
                assetsList.Add(new AssetByAssetType(
                    reader.GetInt32("RowNumber"),
                    reader.GetString("AssetTypeName"),
                    //reader.GetInt32("CheckOutRank"),
                    reader.GetString("AssetName"),
                    reader.GetInt32("CheckOutCount")));
            }

            return assetTypeList;
        }
    }
}