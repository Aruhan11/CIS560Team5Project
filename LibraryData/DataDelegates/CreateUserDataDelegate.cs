using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class CreateUserDataDelegate : NonQueryDataDelegate<User>
    {
        public readonly string firstname;
        public readonly string lastname;
        public readonly string phonenumber;

        public CreateUserDataDelegate(string firstname, string lastname, string phonenumber)
            : base("Library.CreateUser")
        {

            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("PhoneNumber", SqlDbType.NVarChar);
            p.Value = phonenumber;

            p = command.Parameters.Add("UserID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override User Translate(SqlCommand command)
        {
            return new User((int)command.Parameters["UserID"].Value, firstname, lastname, phonenumber, DateTime.Now, 0);

        }

    }

}