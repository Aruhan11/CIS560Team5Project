using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;

namespace LibarayData.DataDelegates
{
    internal class InsertCreatorDelegate : NonQueryDataDelegate<Creator>
    {
      
        private readonly string firstname;
        private readonly string lastname;
        private readonly string companyname;

        public InsertCreatorDelegate(string firstname, string lastname, string companyname)
           : base("Library.InsertCreator")
        {

            this.firstname = firstname;
            this.lastname = lastname;
            this.companyname = companyname;


        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            
            var p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;

            p = command.Parameters.Add("Company", SqlDbType.NVarChar);
            p.Value = companyname;

            p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

        }


        public override Creator Translate(SqlCommand command)
        {
            return new Creator((int)command.Parameters["CreatorID"].Value,  firstname, lastname, companyname);
        }

       

        
    }
}