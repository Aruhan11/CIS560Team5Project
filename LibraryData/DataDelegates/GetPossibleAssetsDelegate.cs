using DataAccess;
using LibarayData.Model;
using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class GetPossibleAssetsDelegate : DataReaderDelegate<IReadOnlyList<PossibleAssets>>
    {

        private readonly string assetName;

        public GetPossibleAssetsDelegate(string assetName)
           : base("Library.GetPossibleAssets")
        {
            this.assetName = assetName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AssetName", SqlDbType.NVarChar);
            p.Value = assetName;
        }

        public override IReadOnlyList<PossibleAssets> Translate(SqlCommand command, IDataRowReader reader)
        {

            var assets = new List<PossibleAssets>();


            while (reader.Read())
            {
                assets.Add(new PossibleAssets(
               reader.GetString("AssetName"),
               reader.GetString("TypeName"),
               reader.GetString("CreatorName"),
               reader.GetString("CompanyName"),
               reader.GetDateTime("ReleaseDate"),
               reader.GetInt32("Stock")));
            }

            return assets;

        }

    }
}