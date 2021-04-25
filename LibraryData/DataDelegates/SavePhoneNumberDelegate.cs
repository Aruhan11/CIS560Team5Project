using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class SavePhoneNumberDelegate : DataDelegate
    {
        private readonly int userId;
        private readonly string fName;
        private readonly string lName;
        private readonly string phonenumber;
        private readonly DateTime lastCheckOut;
        private readonly int isDel;

        public SavePhoneNumberDelegate(int userId, string fName, string lName, string phonenumber,
            DateTime lastCheckOut, int isDel)
           : base("Library.SavePhoneNumber")
        {
            this.userId = userId;
            this.fName = fName;
            this.lName = lName;
            this.phonenumber = phonenumber;
            this.lastCheckOut = lastCheckOut;
            this.isDel = isDel;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserID", userId);
            command.Parameters.AddWithValue("FirstName", fName);
            command.Parameters.AddWithValue("LastName", lName);
            command.Parameters.AddWithValue("PhoneNumber", phonenumber);
            command.Parameters.AddWithValue("LastCheckOutDate", lastCheckOut);
            command.Parameters.AddWithValue("IsDeleted", isDel);
        }

    }
}