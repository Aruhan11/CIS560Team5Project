using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;

namespace LibraryData
{
    public class SqlQuestionQueryRepository : IQuestionQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlQuestionQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        // User GetUser(string phoneNumber);

        public User GetUser(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phoneNumber));

            var d = new GetUserDataDelegate(phoneNumber);
            return executor.ExecuteReader(d);
        }


        // User FetchUser(int userID);

        public User FetchUser(int userID)
        {
            var d = new FetchUserDelegate(userID);
            return executor.ExecuteReader(d);
        }


        public IReadOnlyList<CheckOutHistory> FetchCheckOutHistory(int userID)
        {

            return executor.ExecuteReader(new FetchCheckOutHistoryDelegate(userID));
        }


        public Librarian FetchLibrarian(int librarianID)
        {
            var d = new FetchLibrarianDataDelegate(librarianID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<PossibleAssets> GetPossibleAssets(string assetName)
        {
            return executor.ExecuteReader(new GetPossibleAssetsDelegate(assetName));
        }

        public IReadOnlyList<ProductionOfCreator> FetchProductionOfCreator(int creatorID)
        {
            return executor.ExecuteReader(new FetchProductionsOfCreatorDelegate(creatorID));


        }

        public IReadOnlyList<SituationOfAsset> FetchSituationOfAsset(int assetID)
        {
            return executor.ExecuteReader(new FetchSituationOfAssetDelegate(assetID));
        }


        public IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName)
        {
            return executor.ExecuteReader(new GetCreatorsByTypeDelegate(CreatorTypeName));
        }




    }
}
