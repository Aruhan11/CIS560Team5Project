using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibraryData.DataDelegates
{
    internal class RetriveCheckOutAssetsDelegate: DataReaderDelegate<IReadOnlyList<CheckOutAsset>>
    {
        public RetriveCheckOutAssetsDelegate()
        : base("Library.RetriveCheckOutAssets")
        {
        }

        public override IReadOnlyList<CheckOutAsset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var chekoutassets = new List<CheckOutAsset>();

            while (reader.Read())
            {
                chekoutassets.Add(new CheckOutAsset(
                 reader.GetInt32("CheckOutID"),
                reader.GetInt32("AssetID"),
                reader.GetInt32("UserID"),
                reader.GetInt32("LibrarianID"),
                reader.GetDateTimeOffset("CheckOutDate"),
                reader.GetDateTimeOffset("ReturnByDate"),
                 reader.GetInt32("IsReturned")));
            }

            return chekoutassets;
        }
    }
}
