using LibarayData.Model;
using System.Collections.Generic;


namespace LibraryData
{
    public interface IQuestionQueryRepository
    {
        //1
        User GetUser(string phoneNumber);

        //2
        User FetchUser(int userID);

        IReadOnlyList<CheckOutHistory> FetchCheckOutHistory(int userID);

        Librarian FetchLibrarian(int librarianID);

        IReadOnlyList<PossibleAssets> GetPossibleAssets(string assetName);

        IReadOnlyList<ProductionOfCreator> FetchProductionOfCreator(int creatorID);

        IReadOnlyList<SituationOfAsset> FetchSituationOfAsset(int assetID);

        IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName);


    }
}
