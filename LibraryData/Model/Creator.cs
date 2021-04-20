using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Creator
    {
        public int CreatorID { get;}

        public int CreatorTypeID { get; }

        public Creator(int CreatorID, int CreatorTypeID)
        {
            this.CreatorID = CreatorID;
            this.CreatorTypeID = CreatorTypeID;
        
        }
    }
}
