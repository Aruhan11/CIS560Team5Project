using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class AssetType
    {
        public int AssetTypeID { get; }

        public string TypeName { get; }

        public AssetType(int AssetTypeID, string TypeName)
        {
            this.AssetTypeID = AssetTypeID;
            this.TypeName = TypeName;
        }


    }
}
