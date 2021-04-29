using System;
using System.Collections.Generic;
using DataAccess;
using LibarayData.Model;
using LibarayData.DataDelegates;
using LibraryData.DataDelegates;

namespace LibraryData
{
    public class SqlAssetQueryRepository : IAssetQueryRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAssetQueryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
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

            var d = new InsertAssetDelegate(assetname, assettypeID, creatorID, releasedate, stock);
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

            var d = new InsertCreatorDelegate(firstname, lastname, company);
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


        public void UpdateAsset(int assetID, int stock)
        {

            if (assetID <= 0)
                throw new ArgumentException("AssetID should be greater than 0.", nameof(assetID));

            if (stock < 0)
                throw new ArgumentException("Stock should be greater than 0.", nameof(stock));


            var d = new UpdateAssetDelegate(assetID, stock);
            executor.ExecuteNonQuery(d);

        }


        public Asset FetchAsset(int assetID)
        {
            var d = new FetchAssetDelegate(assetID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Asset> RetrieveAssets()
        {
            return executor.ExecuteReader(new RetriveAssetsDelegate());
        }
    

       public  IReadOnlyList<SituationOfAsset> FetchSituationOfAsset(int assetID)
        {
            var d = new FetchSituationOfAssetDelegate(assetID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<PossibleAssets> GetPossibleAssets(string assetName)
        {
            var d = new GetPossibleAssetsDelegate(assetName);
            return executor.ExecuteReader(d);
        }




    }
  
}
