using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Asset
    {
        public int AssetID { get; }

        public string Name { get; }

        public int AssetTypeID { get; }

        public int CreatorID { get; }

        public DateTime ReleaseDate { get; }

        public int Stock { get; }

        public Asset(int AssetID, string Name, int AssetTypeID, int CreatorID, DateTime ReleaseDate, int Stock)
        {
            this.AssetID = AssetID;
            this.Name = Name;
            this.AssetTypeID = AssetTypeID;
            this.CreatorID = CreatorID;
            this.ReleaseDate = ReleaseDate;
            this.Stock = Stock;
        }
    }
}
