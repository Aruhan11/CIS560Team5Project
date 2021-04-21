/*using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{

    internal class CreateAssetDataDelegate : NonQueryDataDelegate<Asset>
    {
        public readonly string name;
        public readonly int assetypeId;
        public readonly int creatorId;
        public readonly DateTime RelaseData;
        public readonly int stock;

        public CreateAssetDataDelegate(string firstname, string lastname, string phonenumber)
            : base("Library.CreateAsset")
        {

            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("PhoneNumber", SqlDbType.NVarChar);
            p.Value = phonenumber;

            p = command.Paramaters.Add("UserID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override User Translate(SqlCommand command)
        {
            return new User((int)command.Parameters["UserID"].Value, firstname, lastname, phonenumber, DateTime.Now);

        }

    }

}
*/