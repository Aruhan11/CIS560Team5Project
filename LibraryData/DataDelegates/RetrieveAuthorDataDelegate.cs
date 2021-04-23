using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{
    internal class RetrieveAuthorDataDelegate : DataReaderDelegate<IReadOnlyList<Author>>
    {
        public RetrieveAuthorDataDelegate()
           : base("Library.RetrieveAuthor")
        {
        }

        public override IReadOnlyList<Author> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Author>();

            while (reader.Read())
            {
                users.Add(new Author(
                   reader.GetInt32("CreatorID"),
                   reader.GetInt32("CreatorTypeID"),
                   reader.GetString("FirstName"),
                   reader.GetString("LastName")));
            }

            return users;
        }
    }
}