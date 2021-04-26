using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchSituationOfAssetDelegate : DataReaderDelegate<IReadOnlyList<SituationOfAsset>>
    {

        public readonly int assetId;

        public FetchSituationOfAssetDelegate(int assetId)
            : base("Library.FetchSituationOfAsset")
        {
            this.assetId = assetId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Value = assetId;

        }

        public override IReadOnlyList<SituationOfAsset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assets = new List<SituationOfAsset>();


            while (reader.Read())
            {
                assets.Add(new SituationOfAsset(
                reader.GetInt32("AssetID"),
                reader.GetString("Name"),
                reader.GetString("TypeName"),
                reader.GetString("CreatorName"),
                reader.GetString("CompanyName"),
                reader.GetDateTime("CheckOutDate"),
                reader.GetDateTime("ReturnByDate"),
                reader.GetInt32("Stock")));
            }
            return assets;
        }

    }

}