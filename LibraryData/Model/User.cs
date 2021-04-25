using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class User
    {
        //Users(UserID, FirstName, LastName, PhoneNumber, LastCheckoutDate)
        public int UserID { get; }

        public string FirstName { get; }

        public string LastName { get; }
        
        public string PhoneNumber { get; }

        public DateTime LastCheckOutDate { get; }

        public int IsDeleted { get; }

        public User(int UserID, string FirstName, string LastName, string PhoneNumber, DateTime LastCheckOutDate, int IsDeleted)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.LastCheckOutDate = LastCheckOutDate;
            this.IsDeleted = IsDeleted;
        }
    }
}
