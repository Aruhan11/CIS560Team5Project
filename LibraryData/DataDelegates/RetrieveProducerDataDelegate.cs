using DataAccess;

using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{
    internal class RetrieveProducerDataDelegate : DataReaderDelegate<IReadOnlyList<Producer>>
    {
        public RetrieveProducerDataDelegate()
           : base("Library.RetrieveProducer")
        {
        }

        public override IReadOnlyList<Producer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Producer>();

            while (reader.Read())
            {
                users.Add(new Producer(
                   reader.GetInt32("CreatorID"),
                   reader.GetInt32("CreatorTypeID"),
                   reader.GetString("FirstName"),
                   reader.GetString("LastName"),
                   reader.GetString("Company")));
            }

            return users;
        }
    }
}