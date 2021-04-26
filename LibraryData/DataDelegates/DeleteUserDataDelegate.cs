using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;


namespace LibarayData.DataDelegates
{

    internal class DeleteUserDataDelegate : DataDelegate
    {
        public readonly int userID;


        public DeleteUserDataDelegate(int userID)
            : base("Library.DeleteUser")
        {
            this.userID = userID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            

            command.Parameters.AddWithValue("UserID", userID);
            command.Parameters.AddWithValue("IsDeleted", 1);
        }


    }

}