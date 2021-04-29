using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;
using LibraryData.DataDelegates;

namespace LibraryData
{
    public class SqlUserQueryRepository: IUserQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlUserQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

      
        public User CreateUser(string firstname, string lastname, string phonenumber, DateTime lastcheckoutdate, int isdeleted)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstname));

            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastname));

            if (string.IsNullOrWhiteSpace(phonenumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phonenumber));
            
            if (string.IsNullOrWhiteSpace(lastcheckoutdate.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastcheckoutdate));
            
            if (string.IsNullOrWhiteSpace(isdeleted.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(isdeleted));

            var d = new CreateUserDataDelegate(firstname, lastname, phonenumber, lastcheckoutdate, isdeleted);
            return executor.ExecuteNonQuery(d);
        }

        public void DeleteUser(int userID)
        {
         
            if (userID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(userID));

            var d = new DeleteUserDataDelegate(userID);
            executor.ExecuteNonQuery(d);
        }


        public void UpdateUser(int userID, string phonenumber)
        {

            if (userID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(userID));

            if (string.IsNullOrWhiteSpace(phonenumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phonenumber));

            var d = new UpdateUserDelegate(userID, phonenumber);
            executor.ExecuteNonQuery(d);

        }


        public User GetUser(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phoneNumber));

            var d = new GetUserDataDelegate(phoneNumber);
            return executor.ExecuteReader(d);
        }


        public User FetchUser(int userID)
        {
            var d = new FetchUserDelegate(userID);
            return executor.ExecuteReader(d);
        }
      

        public IReadOnlyList<User> RetrieveUsers()
        {
            return executor.ExecuteReader(new RetriveUsersDelegate());
        }
    }
}
