using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;

namespace LibarayData.DataDelegates
{

    internal class FetchSituationOfAssetDelegate : DataReaderDelegate<SituationOfAsset>
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

        public override SituationOfAsset Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(assetId.ToString());

            return new SituationOfAsset(assetId,
                reader.GetInt32("RowNumber"),
                reader.GetString("Name"),
                reader.GetString("TypeName"),
                reader.GetString("CreatorName"),
                reader.GetString("CompanyName"),
                reader.GetDateTime("CheckOutDate"),
                reader.GetDateTime("ReturnByDate"),
                reader.GetInt32("Stock"));
        }

    }

}