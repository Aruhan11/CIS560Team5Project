using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class RankingCreatorByAssetTypeDelegate : DataReaderDelegate<IReadOnlyList<CreatorByAssetType>>
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

        public override IReadOnlyList<CreatorByAssetType> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creatorList = new List<CreatorByAssetType>();

            while(reader.Read()){
                creatorList.Add(new CreatorByAssetType(
                    reader.GetInt32("RowNumber"),
                    reader.GetString("CreatorName"),
                    reader.GetString("CompanyName"),
                    reader.GetString("AssetTypeName"),
                    reader.GetInt32("CheckOutRank"),
                    reader.GetString("AssetName"),
                    reader.GetInt32("CheckOutCount")))
            }

            return creatorList;
        }
    }
}