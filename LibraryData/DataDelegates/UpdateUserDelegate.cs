using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class UpdateUserDelegate : DataDelegate
    {
        private readonly string phonenumber;
        private readonly int userID;

        public UpdateUserDelegate(int userID, string phonenumber)
           : base("Library.UpdateUser")
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