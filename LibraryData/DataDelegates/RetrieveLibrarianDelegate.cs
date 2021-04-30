using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using LibarayData.Model;

namespace LibraryData.DataDelegates
{
    internal class RetrieveLibrarianDelegate : DataReaderDelegate<IReadOnlyList<Librarian>>
    {
        public RetrieveLibrarianDelegate()
        : base("Library.RetriveLibrarians")
        {

        }


        public override IReadOnlyList<Librarian> Translate(SqlCommand command, IDataRowReader reader)
        {
            var assets = new List<Librarian>();
            while (reader.Read())
            {
                assets.Add(new Librarian(
                    reader.GetInt32("LibrarianID"),
                    reader.GetInt32("UserID")));
            }

            return assets;

        }
    }
}
