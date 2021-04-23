using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{
    internal class RetrieveDeveloperDataDelegate : DataReaderDelegate<IReadOnlyList<Developer>>
    {
        public RetrieveDeveloperDataDelegate()
           : base("Library.RetrieveDeveloper")
        {
        }

        public override IReadOnlyList<Developer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Developer>();

            while (reader.Read())
            {
                users.Add(new Developer(
                   reader.GetInt32("CreatorID"),
                   reader.GetInt32("CreatorTypeID"),
                   reader.GetString("Company")));
            }

            return users;
        }
    }
}