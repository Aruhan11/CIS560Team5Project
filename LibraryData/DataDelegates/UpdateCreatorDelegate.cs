using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class UpdateCreatorDelegate : DataDelegate
    {
        private readonly int creatorTypeID;
        private readonly int creatorID;

        public UpdateCreatorDelegate(int creatorID, int creatorTypeID)
           : base("Library.UpdateCreator")
        {
            this.creatorID = creatorID;
            this.creatorTypeID = creatorTypeID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

           
            command.Parameters.AddWithValue("CreatorID", creatorID);
            command.Parameters.AddWithValue("CreatorTypeID", creatorTypeID);
        }
    }
}