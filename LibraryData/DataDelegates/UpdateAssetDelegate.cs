using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class UpdateAssetDelegate : DataDelegate
    {
        private readonly int AssetID;
        private readonly int Stock;

        public UpdateAssetDelegate(int AssetID, int Stock)
           : base("Library.UpdateAsset")
        {
            this.AssetID = AssetID;
            this.Stock = Stock;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("AssetID", AssetID);
            command.Parameters.AddWithValue("Stock", Stock);
        }
    }
}