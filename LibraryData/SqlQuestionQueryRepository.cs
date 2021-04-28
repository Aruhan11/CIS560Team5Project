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
            var d = new FetchCheckOutHistoryDelegate(userID);
            return executor.ExecuteReader(d);
        }


        public Librarian FetchLibrarian(int librarianID)
        {
            var d = new FetchLibrarianDataDelegate(librarianID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<PossibleAssets> GetPossibleAssets(string assetName)
        {
            var d = new GetPossibleAssetsDelegate(assetName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ProductionOfCreator> FetchProductionsOfCreator(int creatorID)
        {
            var d = new FetchProductionsOfCreatorDelegate(creatorID);
            return executor.ExecuteReader(d);


        }

        public IReadOnlyList<SituationOfAsset> FetchSituationOfAsset(int assetID)
        {
            var d = new FetchSituationOfAssetDelegate(assetID);
            return executor.ExecuteReader(d);
        }


        public IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName)
        {
            var d = new GetCreatorsByTypeDelegate(CreatorTypeName);
            return executor.ExecuteReader(d);
        }




    }
}
