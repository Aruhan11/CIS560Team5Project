using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;

namespace LibraryData
{
    public class SqlGeneralQueryRepository: IGeneralQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlGeneralQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public User CreateUser(string firstname, string lastname, string phonenumber, DateTime lastcheckoutdate, int isdeleted)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstname));

            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastname));

            if (string.IsNullOrWhiteSpace(phonenumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phonenumber));
            
            if (string.IsNullOrWhiteSpace(lastcheckoutdate.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastcheckoutdate));
            
            if (string.IsNullOrWhiteSpace(isdeleted.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(isdeleted));

            var d = new CreateUserDataDelegate(firstname, lastname, phonenumber, lastcheckoutdate, isdeleted);
            return executor.ExecuteNonQuery(d);
        }

        public void DeleteUser(int userID)
        {
         
            if (userID <= 0)
                throw new ArgumentException("UserID should be greater than 0.", nameof(userID));

            var d = new DeleteUserDataDelegate(userID);
            executor.ExecuteNonQuery(d);
        }

        public Asset InsertAsset(string assetname, int assettypeID, int creatorID, DateTime releasedate, int stock)
        {
           

            if (string.IsNullOrWhiteSpace(assetname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(assetname));

            if (string.IsNullOrWhiteSpace(assettypeID.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(assettypeID));

            if (string.IsNullOrWhiteSpace(creatorID.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(creatorID));
            if (string.IsNullOrWhiteSpace(releasedate.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(releasedate));
            if (string.IsNullOrWhiteSpace(stock.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(stock));

            var d = new InsertAssetDelegate( assetname,  assettypeID,  creatorID,  releasedate,  stock);
            return executor.ExecuteNonQuery(d);
        }


        public Creator InsertCreator(string firstname, string lastname, string company)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstname));

            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastname));

            if (string.IsNullOrWhiteSpace(company))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(company));

            var d = new InsertCreatorDelegate(firstname, lastname, company );
            return executor.ExecuteNonQuery(d);

        }

        public AssetCategory InsertAssetCategory(int assetID, int categoryID)
        {
            if (string.IsNullOrWhiteSpace(assetID.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(assetID));

            if (string.IsNullOrWhiteSpace(categoryID.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(categoryID));

     

            var d = new InsertAssetCategoryDelegate(assetID, categoryID);
            return executor.ExecuteNonQuery(d);
        }


    }
}
