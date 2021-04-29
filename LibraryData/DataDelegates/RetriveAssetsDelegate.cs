using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibraryData.DataDelegates
{
    internal class RetriveAssetsDelegate: DataReaderDelegate<IReadOnlyList<Asset>>
    {
        public RetriveAssetsDelegate()
        : base("Library.RetriveAssets")
        {
        }

        public override IReadOnlyList<Asset> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assets = new List<Asset>();

            while (reader.Read())
            {
                assets.Add(new Asset(
                   reader.GetInt32("AssetID"),
                   reader.GetString("Name"),
                   reader.GetByte("AssetTypeID"),
                   reader.GetInt32("CreatorID"),
                   reader.GetDateTime("ReleaseDate"),
                   reader.GetInt32("Stock")));
            }

            return assets;
        }
    }
}
