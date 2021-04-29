using LibarayData.Model;
using System.Collections.Generic;
using System;

namespace LibraryData
{
   public interface IUserQueryRepository
    {
        User CreateUser(string firstname, string lastname, string phonenumber, DateTime lastcheckoutdate, int isdeleted);

        void UpdateUser(int userID, string phonenumber);
        
        void DeleteUser(int userID);

        User GetUser(string phoneNumber);

        User FetchUser(int userID);

        IReadOnlyList<User> RetrieveUsers();
    }
}
