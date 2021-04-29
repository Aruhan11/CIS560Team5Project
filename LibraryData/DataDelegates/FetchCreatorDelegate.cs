using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchCreatorDelegate : DataReaderDelegate<Creator>
    {

        private readonly int creatorID;

        public FetchCreatorDelegate(int creatorID)
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

        public override Creator Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(creatorID.ToString());

            return new Creator(creatorID,
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
                reader.GetString("Company"));
        }

    }
}