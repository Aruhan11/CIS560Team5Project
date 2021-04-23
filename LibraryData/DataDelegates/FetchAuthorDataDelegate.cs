using DataAccess;

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LibarayData.Model;

namespace LibraryData.DataDelegates
{
    class FetchAuthorDataDelegate : DataReaderDelegate<Librarian>
    {
        private readonly int librarianID;

        public FetchAuthorDataDelegate(int librarianID)
           : base("Library.FetchLibrarian")
        {
            this.librarianID = librarianID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LibrarianID", SqlDbType.Int);
            p.Value = librarianID;
        }

        public override Librarian Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(librarianID.ToString());

            return new Librarian(librarianID,
               reader.GetInt32("UserID"));
        }


    }
}
