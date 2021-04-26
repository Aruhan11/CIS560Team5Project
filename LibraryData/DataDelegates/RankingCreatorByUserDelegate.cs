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

        public RankingCreatorByUserDelegate()
           : base("Library.RankingCreatorByUser")
        {
        }


        public override IReadOnlyList<CreatorByUser> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creatorList = new List<CreatorByUser>();

            while (reader.Read())
            {
                creatorList.Add(new CreatorByUser(
                    reader.GetString("UserName"),
                    reader.GetInt32("AssetCountRank"),
                    reader.GetString("CreatorName"),
                    reader.GetString("CompanyName"),
                    reader.GetInt32("AssetCount"))
                    
                    );

                     
            }

            return creatorList;
        }
    }
}