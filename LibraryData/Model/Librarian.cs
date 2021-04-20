using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Librarian
    {
        //Librarian(LibrarianID, UserID)

        public int LibrarianID { get; }
        
        public int UserID { get; }

        public Librarian(int LibrarianID, int UserID)
        {
            this.LibrarianID = LibrarianID;
            this.UserID = UserID;
        }

    }
}
