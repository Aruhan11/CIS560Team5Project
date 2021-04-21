using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

using LibraryData.Model;

namespace LibarayData.DataDelegates
{

    internal class CreateDeveloperDataDelegate : NonQueryDataDelegate<Developer>
    {

        public readonly int creatortypeId;
        public readonly string company;


        public CreateDeveloperDataDelegate(int creatortypeId, string company)
            : base("Library.CreateDeveloper")
        {

            this.creatortypeId = creatortypeId;
            this.company = company;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorTypeID", SqlDbType.NVarChar);
            p.Value = creatortypeId;

            p = command.Parameters.Add("Company", SqlDbType.NVarChar);
            p.Value = company;

            p = command.Parameters.Add("CreatorID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Developer Translate(SqlCommand command)
        {
            return new Developer((int)command.Parameters["CreatorID"].Value, creatortypeId, company);

        }

    }

}
