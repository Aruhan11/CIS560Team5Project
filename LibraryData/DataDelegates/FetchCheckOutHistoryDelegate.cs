using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchCheckOutHistoryDelegate : DataReaderDelegate<IReadOnlyList<CheckOutHistory>>
    {

        public readonly int userId;

        public FetchCheckOutHistoryDelegate(int userId)
            : base("Library.FetchCheckOutHistory")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Value = userId;

        }

        public override IReadOnlyList<CheckOutHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var checkOutAssets = new List<CheckOutHistory>();

            while (reader.Read())
            {
                checkOutAssets.Add(new CheckOutHistory(
               userId,
               reader.GetString("AssetName"),
               reader.GetString("TypeName"),
               reader.GetString("CreatorName"),
               reader.GetString("Company"),
               reader.GetDateTimeOffset("CheckOutDate"),
               reader.GetDateTimeOffset("ReturnByDate"),
               reader.GetByte("IsReturned")));
            }

            return checkOutAssets;
        }

    }

}