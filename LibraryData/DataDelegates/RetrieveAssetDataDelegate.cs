using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{
    internal class RetrieveAssetDataDelegate : DataReaderDelegate<IReadOnlyList<Asset>>
    {
        public RetrieveAssetDataDelegate()
           : base("Library.RetrieveAsset")
        {
        }

        public override IReadOnlyList<Asset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Asset>();

            while (reader.Read())
            {
                users.Add(new Asset(
                   reader.GetInt32("AssetID"),
                   reader.GetString("Name"),
                   reader.GetInt32("AssetTypeID"),
                   reader.GetInt32("CreatorID"),
                   reader.GetDateTime("ReleaseDate"),
                   reader.GetInt32("Stock")));
            }

            return users;
        }
    }
}