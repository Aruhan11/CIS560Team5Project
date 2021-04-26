using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class InsertAssetDelegate : NonQueryDataDelegate<Asset>
    {
        private readonly string assetName;
        private readonly int assetTypeID;
        private readonly string firstname;
        private readonly string lastname;
        private readonly string companyname;
        private readonly DateTime releasedate;
        private readonly int categoryID;

        public InsertAssetDelegate(string assetName, int assetTypeID, string firstname, string lastname, string companyname, DateTime releasedate, int categoryID)
           : base("Library.InsertAssetDelegate")
        {
            this.assetName = assetName;
            this.assetTypeID = assetTypeID;
            this.firstname = firstname;
            this.lastname = lastname;
            this.companyname = companyname;
            this.releasedate = releasedate;
            this.categoryID = categoryID;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

          //  command.Parameters.AddWithValue("AssetName", assetName);
         //   command.Parameters.AddWithValue("AssetTypeID", assetTypeID);
          //  command.Parameters.AddWithValue("FirstName", firstname);
          //  command.Parameters.AddWithValue("LastName", lastname);
           // command.Parameters.AddWithValue("Company", companyname);
          //  command.Parameters.AddWithValue("ReleaseDate", releasedate);
          //  command.Parameters.AddWithValue("CategoryID", categoryID);


            var p = command.Parameters.Add("AssetName", SqlDbType.NVarChar);
            p.Value = assetName;

            p = command.Parameters.Add("AssetTypeID", SqlDbType.Int);
            p.Value = assetTypeID;

            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;

            p = command.Parameters.Add("Company", SqlDbType.NVarChar);
            p.Value = companyname;

            p = command.Parameters.Add("ReleaseDate", SqlDbType.DateTime);
            p.Value = releasedate;

            p = command.Parameters.Add("AssetTypeID", SqlDbType.Int);
            p.Value = categoryID;

            p = command.Parameters.Add("AssetID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }


        public override Asset Translate(SqlCommand command)
        {
            return new Asset((int)command.Parameters["AssetID"].Value, assetName, assetTypeID, firstname, lastname, companyname, releasedate, categoryID);
        }

       

           // return new Asset(
            //   reader.GetInt32("AssetID"),
             //  reader.GetString("Name"),
             //  reader.GetString("FirstName"),
             //  reader.GetString("LastName"),
             //  reader.GetString("Company"),
            //   reader.GetDateTime("ReleaseDate"),
            //   reader.GetInt32("CategoryID"));
        
    }
}