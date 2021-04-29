using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchCheckOutAssetDelegate : DataReaderDelegate<CheckOutAsset>
    {

        private readonly int checkoutassetID;

        public FetchCheckOutAssetDelegate(int checkoutassetID)
           : base("Library.FetchCheckOutAsset")
        {
            this.checkoutassetID = checkoutassetID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CheckOutID", SqlDbType.Int);
            p.Value = checkoutassetID;
        }

        public override CheckOutAsset Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(checkoutassetID.ToString());

            return new CheckOutAsset(checkoutassetID,
                 reader.GetInt32("AssetID"),
                reader.GetInt32("UserID"),
                reader.GetInt32("LibrarianID"),
                reader.GetDateTimeOffset("CheckOutDate"),
                reader.GetDateTimeOffset("ReturnByDate"),
                 reader.GetInt32("IsReturned")
               );
        }

    }
}