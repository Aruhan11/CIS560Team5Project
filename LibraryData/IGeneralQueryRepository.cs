using LibarayData.Model;
using System.Collections.Generic;
using System;
namespace LibraryData
{
    public interface IGeneralQueryRepository
    {
        User CreateUser(string firstname, string lastname, string phonenumber, DateTime lastcheckoutdate, int isdeleted);

        void DeleteUser(int userID);

        Asset InsertAsset(string assetname, int assettypeID, int creatorID, DateTime releasedate, int stock);

        Creator InsertCreator(string firstname, string lastname, string company);

        AssetCategory InsertAssetCategory(int assetID, int categoryID);

        void SavePhoneNumber(string phonenumber, int userID);
    }
}
