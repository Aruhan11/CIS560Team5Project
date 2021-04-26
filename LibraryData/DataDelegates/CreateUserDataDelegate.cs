using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class CreateUserDataDelegate : NonQueryDataDelegate<User>
    {
        private readonly string firstname;
        private readonly string lastname;
        private readonly string phonenumber;
        private readonly DateTime lastcheckoutdate;
        private readonly int isdeleted;

        public CreateUserDataDelegate(string firstname, string lastname, string phonenumber, DateTime lastcheckoutdate, int isdeleted)
            : base("Library.CreateUser")
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
            this.lastcheckoutdate = lastcheckoutdate;
            this.isdeleted = isdeleted;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;

            p = command.Parameters.Add("PhoneNumber", SqlDbType.NVarChar);
            p.Value = phonenumber;

            p = command.Parameters.Add("LastCheckOutDate", SqlDbType.DateTime2);
            p.Value = lastcheckoutdate;

            p = command.Parameters.Add("IsDeleted", SqlDbType.Int);
            p.Value = isdeleted;

            p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override User Translate(SqlCommand command)
        {
            return new User((int)command.Parameters["UserID"].Value, firstname, lastname, phonenumber, lastcheckoutdate, isdeleted);

        }

    }

}