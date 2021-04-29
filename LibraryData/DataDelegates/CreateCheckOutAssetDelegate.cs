using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class CreateCheckOutAssetDelegate : NonQueryDataDelegate<CheckOutAsset>
    {
       
        public readonly int assetID;
        public readonly int userID;
        public readonly int librarianID;


        public CreateCheckOutAssetDelegate(int assetID, int userID, int librarianID)
            : base("Library.CreateCheckOutAsset")
        {

            this.assetID = assetID;
            this.userID = userID;
            this.librarianID = librarianID;
        
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Value = assetID;

            p = command.Parameters.Add("UserID", SqlDbType.Int);
            p.Value = userID;

            p = command.Parameters.Add("LibrarianID", SqlDbType.Int);
            p.Value = librarianID;

            p = command.Parameters.Add("CheckOutID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("CheckOutDate", SqlDbType.DateTimeOffset);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("ReturnByDate", SqlDbType.DateTimeOffset);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("IsReturned", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override CheckOutAsset Translate(SqlCommand command)
        {
            return new CheckOutAsset((int)command.Parameters["CheckOutID"].Value, assetID, userID, librarianID,  
                        (DateTimeOffset)command.Parameters["CheckOutDate"].Value, (DateTimeOffset)command.Parameters["ReturnByDate"].Value, (int)command.Parameters["IsReturned"].Value);

        }

    }

}