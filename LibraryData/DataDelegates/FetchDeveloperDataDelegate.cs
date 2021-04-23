using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{

    internal class FetchDeveloperDataDelegate : DataReaderDelegate<Developer>
    {

        private readonly int creatorID;

        public FetchDeveloperDataDelegate(int creatorID)
           : base("Library.FetchCreator")
        {
            this.creatorID = creatorID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Value = creatorID;
        }

        public override Developer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(creatorID.ToString());

            return new Developer(creatorID,
               reader.GetInt32("CreatorTypeID"),
               reader.GetString("Company"));
        }

    }
}