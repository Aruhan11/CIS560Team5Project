using DataAccess;
using LibarayData.Model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibraryData.DataDelegates
{
    internal class RetriveCreatorsDelegate: DataReaderDelegate<IReadOnlyList<Creator>>
    {
        public RetriveCreatorsDelegate()
        : base("Library.RetriveCreators")
        {
        }

        public override IReadOnlyList<Creator> Translate(SqlCommand command, IDataRowReader reader)
        {
            var creators = new List<Creator>();

            while (reader.Read())
            {
                creators.Add(new Creator(
                   reader.GetInt32("CreatorID"),
                   reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Company")
              ));
            }

            return creators;
        }
    }
}
