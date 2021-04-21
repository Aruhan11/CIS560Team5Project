using LibarayData.Model;
using System.Collections.Generic;

namespace LibraryData
{
    public interface IUserRepository
    {
        IReadOnlyList<User> RetrieveUsers();

        User FetchUser(int userID);

        User GetUser(string phoneNumber);

        User CreateUser(string firstName, string lastName, string phoneNumber);
    }
}
