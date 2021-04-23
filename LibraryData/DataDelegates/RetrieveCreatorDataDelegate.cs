using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class RetrieveCreatorDataDelegate : DataReaderDelegate<IReadOnlyList<Creator>>
    {
        public RetrieveCreatorDataDelegate()
           : base("Library.RetrieveCreator")
        {
        }

        public override IReadOnlyList<Creator> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Creator>();

            while (reader.Read())
            {
                users.Add(new Creator(
                   reader.GetInt32("CategoryID"),
                   reader.GetInt32("CreatorTypeID")));
            }

            return users;
        }
    }
}