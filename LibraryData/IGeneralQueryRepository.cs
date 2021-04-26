using LibarayData.Model;
using System.Collections.Generic;
using System;
namespace LibraryData
{
    public interface IGeneralQueryRepository
    {
        User CreateUser(string firstname, string lastname, string phonenumber);

        void DeleteUser(int userID);

        Asset InsertAssetDelegate(string assetname, int assettypeID, string firstname, string lastname, string companyname, DateTime releasedate, int categoryID);

        void SavePhoneNumber(string phonenumber, int userID);
    }
}
