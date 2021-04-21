using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;

namespace LibarayData.DataDelegates
{

    internal class CreateCreatorDataDelegate : NonQueryDataDelegate<Creator>
    {

        public readonly int creatortypeId;


        public CreateCreatorDataDelegate(int creatortypeId)
            : base("Library.CreateCreator")
        {

            this.creatortypeId = creatortypeId;


        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorTypeID", SqlDbType.NVarChar);
            p.Value = creatortypeId;


            p = command.Parameters.Add("CreatorID", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;
        }

        public override Creator Translate(SqlCommand command)
        {
            return new Creator((int)command.Parameters["CreatorID"].Value, creatortypeId);

        }

    }

}
