
using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class GetPossibleAssetsDelegate : DataReaderDelegate<PossibleAssets>
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

        public override PossibleAssets Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new PossibleAssets(
               reader.GetInt32("RowNumber"),
               assetName,
               reader.GetString("TypeName"),
               reader.GetString("CreatorName"),
               reader.GetString("CompanyName"),
               reader.GetDateTime("ReleaseDate"),
               reader.GetInt32("Stock"));
        }

    }
}