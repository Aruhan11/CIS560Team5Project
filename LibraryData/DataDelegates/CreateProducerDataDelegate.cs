using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibraryData.Model;

namespace LibarayData.DataDelegates
{

    internal class CreateProducerDataDelegate : NonQueryDataDelegate<Producer>
    {

        public readonly int creatortypeId;
        public readonly string firstname;
        public readonly string lastname;
        public readonly string company;


        public CreateProducerDataDelegate(int creatortypeId, string firstname, string lastname, string company)
            : base("Library.CreateProducer")
        {

            this.creatortypeId = creatortypeId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.company = company;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorTypeID", SqlDbType.NVarChar);
            p.Value = creatortypeId;

            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;
;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;

            p = command.Parameters.Add("Company", SqlDbType.NVarChar);
            p.Value = company;

            p = command.Parameters.Add("CreatorID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Producer Translate(SqlCommand command)
        {
            return new Producer((int)command.Parameters["CreatorID"].Value, creatortypeId, firstname, lastname, company);

        }

    }

}
