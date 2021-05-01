﻿using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibarayData.DataDelegates
{

    internal class FetchUserDelegate : DataReaderDelegate<User>
    {

        private readonly int userID;

        public FetchUserDelegate(int userID)
           : base("Library.FetchUser")
        {
            this.userID = userID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Value = userID;
        }

        public override User Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new User(userID,
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("PhoneNumber"),
               reader.GetDateTime("LastCheckOutDate"),
               reader.GetInt32("IsDeleted"));
        }

    }
}