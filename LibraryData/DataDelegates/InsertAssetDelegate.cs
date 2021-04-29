using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class InsertAssetDelegate : NonQueryDataDelegate<Asset>
    {
        private readonly string name;
        private readonly int assettypeID;
        private readonly int creatorID;
        private readonly DateTime releaseDate;
        private readonly int stock;

        public InsertAssetDelegate(string name, int assettypeID, int creatorID, DateTime releaseDate, int stock)
           : base("Library.InsertAsset")
        {
            this.name = name;
            this.assettypeID = assettypeID;
            this.creatorID = creatorID;
            this.releaseDate = releaseDate;
            this.stock = stock;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = name;

            p = command.Parameters.Add("AssetTypeID", SqlDbType.Int);
            p.Value = assettypeID;

            p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Value = creatorID;

            p = command.Parameters.Add("ReleaseDate", SqlDbType.DateTime);
            p.Value = releaseDate;

            p = command.Parameters.Add("Stock", SqlDbType.Int);
            p.Value = stock;

            p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }


        public override Asset Translate(SqlCommand command)
        {
            return new Asset((int)command.Parameters["AssetID"].Value, name, assettypeID, creatorID, releaseDate,stock);
        }

        
    }
}