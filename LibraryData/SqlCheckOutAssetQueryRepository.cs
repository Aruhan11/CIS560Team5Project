using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;
using LibraryData.DataDelegates;

namespace LibraryData
{
    public class SqlCheckOutAssetQueryRepository: ICheckOutAssetQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlCheckOutAssetQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public CheckOutAsset CreateCheckOutAsset(int assetID, int userID, int librarianID)
        {

            if (assetID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(assetID));
            if (userID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(userID));
            if (librarianID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(librarianID));


            var d = new CreateCheckOutAssetDelegate(assetID, userID, librarianID);
            return executor.ExecuteNonQuery(d);
        }

        public void UpdateCheckOutAsset(int checkoutassetID)
        {

            if (checkoutassetID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(checkoutassetID));

            var d = new UpdateCheckOutAssetDelegate(checkoutassetID);
            executor.ExecuteNonQuery(d);
        }


        public CheckOutAsset FetchCheckOutAsset(int checkoutassetID)
        {
            var d = new FetchCheckOutAssetDelegate(checkoutassetID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<CheckOutAsset> RetrieveCheckOutAssets()
        {
            return executor.ExecuteReader(new RetriveCheckOutAssetsDelegate());
        }

        public IReadOnlyList<CheckOutHistory> FetchCheckOutHistory(int userID)
        {
            var d = new FetchCheckOutHistoryDelegate(userID);
            return executor.ExecuteReader(d);
        }

    }
}
