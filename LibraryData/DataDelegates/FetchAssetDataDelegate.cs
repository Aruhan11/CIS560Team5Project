
using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class FetchAssetDataDelegate : DataReaderDelegate<Asset>
    {

        private readonly int assetID;

        public FetchAssetDataDelegate(int assetID)
           : base("Library.FetchAsset")
        {
            this.assetID = assetID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Value = assetID;
        }

        public override Asset Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(assetID.ToString());

            return new Asset(assetID,
               reader.GetString("Name"),
               reader.GetInt32("AssetTypeID"),
               reader.GetInt32("CreatorID"),
               reader.GetDateTime("ReleaseDate"),
               reader.GetInt32("Stock"));
        }

    }
}