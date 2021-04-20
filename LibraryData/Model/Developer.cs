using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class Developer
    {
        public int CreatorID { get; }

        public int CreatorTypeID { get; }

        public string Company { get; }

        public Developer(int CreatorID, int CreatorTypeID, string Company)
        {
            this.CreatorID = CreatorID;
            this.CreatorTypeID = CreatorTypeID;
            this.Company = Company;

        }
    }
}
