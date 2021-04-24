using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class InsertAssetDelegate : DataReaderDelegate<User>
    {
        private readonly string phonenumber;

        public InsertAssetDelegate(string phonenumber)
           : base("Library.GetPerson")
        {
            this.phonenumber = phonenumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PhoneNumber", phonenumber);
        }

        public override User Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new User(
               reader.GetInt32("PersonId"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               phonenumber,
               reader.GetDateTime("LastCheckOutDate"));
        }
    }
}