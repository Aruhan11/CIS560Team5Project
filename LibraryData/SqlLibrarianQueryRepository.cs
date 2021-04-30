using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.DataDelegates;
using LibarayData.Model;
using LibraryData.DataDelegates;

namespace LibraryData
{
    public class SqlLibrarianQueryRepository : ILibrarianQueryRepository
    {

        private readonly SqlCommandExecutor executor;

        public SqlLibrarianQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Librarian FetchLibrarian(int librarianID)
        {
            if (librarianID <= 0)
                throw new ArgumentException("CreatorID should be greater than 0.", nameof(librarianID));
            var d = new FetchLibrarianDataDelegate(librarianID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Librarian> RetrieveLibrarian()
        {
            var d = new RetrieveLibrarianDelegate();
            return executor.ExecuteReader(d);
        }

    }
}
