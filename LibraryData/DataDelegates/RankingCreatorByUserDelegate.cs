using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class RankingCreatorByUserDelegate : DataReaderDelegate<IReadOnlyList<CreatorByUser>>
    {
        private readonly int userId;

        public RankingAssetByUserDelegate(int userId)
           : base("Library.RankingCreatorByUser")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", userId);
        }

        public override IReadOnlyList<CreatorByUser> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creatorList = new List<CreatorByUser>();

            while (reader.Read())
            {
                creatorList.Add(new CreatorByUser(
                    reader.GetInt32("RowNumber"),
                    reader.GetString("UserName"),
                    reader.GetString("AssetCountRank"),
                    reader.GetString("CreatorName"),
                    reader.GetInt32("CompanyName"),
                    reader.GetString("AssetName")));
            }

            return creatorList;
        }
    }
}