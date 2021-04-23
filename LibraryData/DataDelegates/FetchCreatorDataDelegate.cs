using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class FetchCreatorDataDelegate : DataReaderDelegate<Creator>
    {

        private readonly int creatorID;

        public FetchCreatorDataDelegate(int creatorID)
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
               reader.GetInt32("CreatorTypeID"));
        }

    }
}