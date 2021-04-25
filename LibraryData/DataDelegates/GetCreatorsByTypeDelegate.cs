using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class GetCreatorsByTypeDelegate : DataReaderDelegate<CreatorByType>
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

            var p = command.Parameters.Add("CreatorTypeName", SqlDbType.NVarChar);
            p.Value = creatorType;
        }

        public override CreatorByType Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new CreatorByType(
               reader.GetString("CreatorTypeName"),
               reader.GetInt32("RowNumber"),
               creatorType,
               reader.GetString("CreatorName"),
               reader.GetString("CompanyName"),
               reader.GetInt32("Stock"),
               reader.GetDateTime("CheckOutDate"),
               reader.GetDateTime("ReturnByDate"),
               reader.GetInt32("InBorrowingTotal"));
        }

    }
}