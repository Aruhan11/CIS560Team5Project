using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class AssetCategory
    {
        //AssetCategory(AssetCategoryID, AssetID, CategoryID)

        public int AssetCategoryID { get; }
        public int AssetID { get; }
        public int CategoryID { get; }

        public AssetCategory(int AssetCategoryID, int AssetID, int CategoryID)
        {
            this.AssetCategoryID = AssetCategoryID;
            this.AssetID = AssetID;
            this.CategoryID = CategoryID;
        }
    }
}
