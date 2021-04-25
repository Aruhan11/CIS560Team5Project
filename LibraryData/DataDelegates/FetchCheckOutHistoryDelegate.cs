using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;

namespace LibarayData.DataDelegates
{

    internal class FetchCheckOutHistoryDelegate : DataReaderDelegate<CheckOutHistory>
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



          //  p = command.Parameters.Add("LibrarianID", SqlDbType.Int);
          //  p.Direction = ParameterDirection.Output;
        }

        public override CheckOutHistory Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(userId.ToString());

            return new CheckOutHistory(userId,
               reader.GetInt32("RowNumber"),
               reader.GetString("AssetName"),
               reader.GetString("TypeName"), 
               reader.GetString("CreatorName"),
               reader.GetString("CompanyName"), 
               reader.GetDateTime("CheckOutDate"),
               reader.GetDateTime("ReturnByDate"), 
               reader.GetInt32("IsReturned"));
        }

    }

}
