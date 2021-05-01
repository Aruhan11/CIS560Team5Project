using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchAssetDelegate : DataReaderDelegate<Asset>
    {

        private readonly int assetID;

        public FetchAssetDelegate(int assetID)
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
                return null;

            return new Asset(assetID,
               reader.GetString("Name"),
               reader.GetByte("AssetTypeID"),
               reader.GetInt32("CreatorID"),
               reader.GetDateTime("ReleaseDate"),
               reader.GetInt32("Stock"));
        }

    }
}