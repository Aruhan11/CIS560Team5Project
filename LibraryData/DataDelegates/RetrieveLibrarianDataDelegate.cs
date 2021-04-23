using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{
    internal class RetrieveLibrarianDataDelegate : DataReaderDelegate<IReadOnlyList<Librarian>>
    {
        public RetrieveLibrarianDataDelegate()
           : base("Library.RetrieveLibrarian")
        {
        }

        public override IReadOnlyList<Librarian> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<Librarian>();

            while (reader.Read())
            {
                users.Add(new Librarian(
                   reader.GetInt32("LibrarianID"),
                   reader.GetInt32("UserID")));
            }

            return users;
        }
    }
}