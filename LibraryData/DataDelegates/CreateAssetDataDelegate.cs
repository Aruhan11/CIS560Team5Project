using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class CreateAssetDataDelegate : NonQueryDataDelegate<Asset>
    {
        public readonly string name;
        public readonly int assetypeId;
        public readonly int creatorId;
        public readonly DateTime relaseData;
        public readonly int stock;

        public CreateAssetDataDelegate(string name, int assettypeId, int creatorId, DateTime releaseDate, int stock)
            : base("Library.CreateAsset")
        {

            this.name = name;
            this.assetypeId = assetypeId;
            this.creatorId = creatorId;
            this.relaseData = relaseData;
            this.stock = stock;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;

            p = command.Parameters.Add("AssetTypeID", SqlDbType.NVarChar);
            p.Value = assetypeId;

            p = command.Parameters.Add("CreatorID", SqlDbType.NVarChar);
            p.Value = creatorId;


            p = command.Parameters.Add("ReleaseDate", SqlDbType.NVarChar);
            p.Value = creatorId;


            p = command.Parameters.Add("Stock", SqlDbType.NVarChar);
            p.Value = stock;


            p = command.Parameters.Add("AssetID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Asset Translate(SqlCommand command)
        {
            return new Asset((int)command.Parameters["AssetID"].Value, name, assetypeId, creatorId, relaseData, stock);

        }

    }

}
