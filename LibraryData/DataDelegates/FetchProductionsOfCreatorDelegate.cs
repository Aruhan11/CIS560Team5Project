﻿using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchProductionsOfCreatorDelegate : DataReaderDelegate<IReadOnlyList<ProductionOfCreator>>
    {

        public readonly int creatorId;

        public FetchProductionsOfCreatorDelegate(int creatorId)
            : base("Library.FetchProductionsOfCreator")
        {
            this.creatorId = creatorId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Value = creatorId;

        }
        public override IReadOnlyList<ProductionOfCreator> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assets = new List<ProductionOfCreator>();

            while (reader.Read())
            {
                assets.Add(new ProductionOfCreator(
                   creatorId,
                   reader.GetString("CreatorName"),
                   reader.GetString("Company"),
                   reader.GetString("AssetName"),
                   reader.GetString("AssetType"),
                   reader.GetInt32("Stock")));
            }

            return assets;


        }

    }

}