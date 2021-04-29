using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class InsertAssetCategoryDelegate : NonQueryDataDelegate<AssetCategory>
    {

        private readonly int assetID;
  
        private readonly int categoryID;

        public InsertAssetCategoryDelegate(int assetID,int categoryID)
           : base("Library.InsertAssetCategory")
        {
            this.assetID = assetID;
            this.categoryID = categoryID;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Value = assetID;

            p = command.Parameters.Add("CategoryID", SqlDbType.Int);
            p.Value = categoryID;

            p = command.Parameters.Add("AssetCategoryID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }


        public override AssetCategory Translate(SqlCommand command)
        {
            return new AssetCategory((int)command.Parameters["AssetCategoryID"].Value, assetID, categoryID);
        }
    }
}