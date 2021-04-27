using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class GetCreatorsByTypeDelegate : DataReaderDelegate<IReadOnlyList<CreatorByType>>
    {

        private readonly string creatorType;

        public GetCreatorsByTypeDelegate(string creatorType)
           : base("Library.GetCreatorsByType")
        {
            this.creatorType = creatorType;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("creatorType", SqlDbType.NVarChar);
            p.Value = creatorType;
        }

        public override IReadOnlyList<CreatorByType> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creators = new List<CreatorByType>();


            while (reader.Read())
            {
                creators.Add(new CreatorByType(
               creatorType,
               reader.GetString("CreatorName"),
               reader.GetString("Company"),
               reader.GetInt32("Stock"),
               reader.GetDateTimeOffset("CheckOutDate"),
               reader.GetDateTimeOffset("ReturnByDate"),
               reader.GetInt32("InBorrowingTotal")));
            }

            return creators;
        }

    }
}