using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Librarian
    {

        public int LibrarianID { get; }

        public int UserID { get; }

       // public string FirstName { get; }

       // public string LastName { get; }

       // public string PhoneNumber { get; }

      //  public DateTime LastCheckOutDate { get; }

        public Librarian(int LibrarianID, int UserID)
        {
            this.LibrarianID = LibrarianID;
            this.UserID = UserID;
           // this.FirstName = FirstName;
           // this.LastName = LastName;
           // this.PhoneNumber = PhoneNumber;
           // this.LastCheckOutDate = LastCheckOutDate;
        }

    }
}
