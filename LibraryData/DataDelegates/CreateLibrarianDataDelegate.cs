using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;

namespace LibarayData.DataDelegates
{

    internal class CreateLibrarianDataDelegate : NonQueryDataDelegate<Librarian>
    {

        public readonly int userId;



        public CreateLibrarianDataDelegate(int userId)
            : base("Library.CreateLibrarian")
        {

            this.userId = userId;


        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("UserID", SqlDbType.NVarChar);
            p.Value = userId;



            p = command.Parameters.Add("LibrarianID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Librarian Translate(SqlCommand command)
        {
            return new Librarian((int)command.Parameters["CreatorID"].Value, userId);
        }

    }

}
