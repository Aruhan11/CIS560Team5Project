using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;
using LibraryData.DataDelegates;

namespace LibraryData
{
    public class SqlCreatorQueryRepository : ICreatorQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlCreatorQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }


        public void UpdateCreator(int creatorID, int creatorTypeID)
        {
            if (creatorID <= 0)
                throw new ArgumentException("CreatorID should be greater than 0.", nameof(creatorID));

            if (creatorTypeID < 0)
                throw new ArgumentException("CreatorTypeID should be greater than 0.", nameof(creatorTypeID));


            var d = new UpdateCreatorDelegate(creatorID, creatorTypeID);
            executor.ExecuteNonQuery(d);
        }


        public Creator FetchCreator(int creatorID)
        {
            var d = new FetchCreatorDelegate(creatorID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Creator> RetrieveCreators()
        {
            return executor.ExecuteReader(new RetriveCreatorsDelegate());
        }


        public IReadOnlyList<ProductionOfCreator> FetchProductionsOfCreator(int creatorID)
        {
            var d = new FetchProductionsOfCreatorDelegate(creatorID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName)
        {
            var d = new GetCreatorsByTypeDelegate(CreatorTypeName);
            return executor.ExecuteReader(d);

        }


    }
    
}
