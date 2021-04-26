using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class SavePhoneNumberDelegate : DataDelegate
    {
        private readonly string phonenumber;
        private readonly int userID;

        public SavePhoneNumberDelegate(string phonenumber, int userID)
           : base("Library.SavePhoneNumber")
        {
            this.phonenumber = phonenumber;
            this.userID  = userID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PhoneNumber", phonenumber);
            command.Parameters.AddWithValue("UserID", userID);
        }
    }
}