using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{

    internal class CreateAuthorDataDelegate : NonQueryDataDelegate<Author>
    {
        
        public readonly int creatortypeId;
        public readonly string firstname;
        public readonly string lastname;
 

        public CreateAuthorDataDelegate(int creatortypeId, string firstname, string lastname)
            : base("Library.CreateAuthor")
        {

            this.creatortypeId = creatortypeId;
            this.firstname = firstname;
            this.lastname = lastname;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorTypeID", SqlDbType.NVarChar);
            p.Value = creatortypeId;

            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;


            p = command.Parameters.Add("CreatorID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Author Translate(SqlCommand command)
        {
            return new Author((int)command.Parameters["CreatorID"].Value, creatortypeId, firstname, lastname);

        }

    }

}
