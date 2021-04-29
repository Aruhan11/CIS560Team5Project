using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibraryData.DataDelegates
{
    internal class RetriveUsersDelegate: DataReaderDelegate<IReadOnlyList<User>>
    {
        public RetriveUsersDelegate()
        : base("Library.RetriveUsers")
        {
        }

        public override IReadOnlyList<User> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User(
                   reader.GetInt32("UserID"),
                   reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("PhoneNumber"),
               reader.GetDateTime("LastCheckOutDate"),
               reader.GetInt32("IsDeleted")));
            }

            return users;
        }
    }
}
