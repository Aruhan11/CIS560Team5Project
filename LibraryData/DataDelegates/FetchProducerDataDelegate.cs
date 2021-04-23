using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibraryData.Model;

namespace LibraryData.DataDelegates
{
    internal class FetchProducerDataDelegate : DataReaderDelegate<Producer>
    {

        private readonly int creatorID;

        public FetchProducerDataDelegate(int creatorID)
           : base("Library.FetchProducer")
        {
            this.creatorID = creatorID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Value = creatorID;
        }

        public override Producer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(creatorID.ToString());

            return new Producer(creatorID,
               reader.GetInt32("CreatorTypeID"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Company"));
        }

    }
}
