using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class FetchLibrarianDataDelegate : DataReaderDelegate<Librarian>
    {

        private readonly int librarianID;

        public FetchLibrarianDataDelegate(int librarianID)
           : base("Library.FetchLibrarianData")
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