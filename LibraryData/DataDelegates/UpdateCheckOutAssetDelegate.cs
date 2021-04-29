using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;



namespace LibarayData.DataDelegates
{

    internal class UpdateCheckOutAssetDelegate : DataDelegate
    {
        public readonly int checkoutassetID;


        public UpdateCheckOutAssetDelegate(int checkoutassetID)
            : base("Library.UpdateCheckOutAsset")
        {
            this.checkoutassetID = checkoutassetID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);        

            command.Parameters.AddWithValue("CheckOutID", checkoutassetID);
            
        }


    }

}