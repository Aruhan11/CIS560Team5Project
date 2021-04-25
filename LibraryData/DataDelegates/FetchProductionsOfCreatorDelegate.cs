using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;
using LibarayData.Model;

namespace LibarayData.DataDelegates
{

    internal class FetchProductionsOfCreatorDelegate : DataReaderDelegate<ProductionOfCreator>
    {

        public readonly int creatorId;

        public FetchProductionsOfCreatorDelegate(int creatorId)
            : base("Library.FetchProductionsOfCreator")
        {
            this.creatorId = creatorId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CreatorID", SqlDbType.Int);
            p.Value = creatorId;

        }

        public override ProductionOfCreator Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(creatorId.ToString());

            return new ProductionOfCreator(creatorId,
               reader.GetInt32("RowNumber"),
               reader.GetString("CreatorName"),
               reader.GetString("CompanyName"),
               reader.GetString("AssetName"),
               reader.GetString("AssetTypeName"),
               reader.GetInt32("Stock"));
        }

    }

}
