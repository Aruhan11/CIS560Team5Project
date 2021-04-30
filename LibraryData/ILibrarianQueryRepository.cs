using System;
using System.Collections.Generic;
using System.Text;
using LibarayData.Model;

namespace LibraryData
{
    public interface ILibrarianQueryRepository
    {

        public Librarian FetchLibrarian(int librarianID);

        public IReadOnlyList<Librarian> RetrieveLibrarian();
    }
}
