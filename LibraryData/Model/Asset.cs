using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Asset
    {
        //@Name NVARCHAR(32),
        //@AssetTypeID TINYINT,
        // @FirstName NVARCHAR(10),
        ///  @LastName NVARCHAR(10),
        //  @Company NVARCHAR(10),
        // @ReleaseDate DATETIME(2),
        //  @CategoryID INT,


        public int AssetID { get; }

        public string Name { get; }

        public int AssetTypeID { get; }

        public string FirstName { get; }
        public string LastName { get; }
        public string Company { get; }

        public DateTime ReleaseDate { get; }

        public int CategoryID { get; }

        public Asset(int AssetID, string Name, int AssetTypeID,string FirstName, string LastName, string Company, DateTime ReleaseDate, int CategoryID)
        {
            this.AssetID = AssetID;
            this.Name = Name;
            this.AssetTypeID = AssetTypeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Company = Company;
            this.ReleaseDate = ReleaseDate;
            this.CategoryID = CategoryID;
        }
    }
}
