using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class CreatorType
    {
        public int CreatorTypeID { get; }

        public string Name { get; }

        public CreatorType(int CreatorTypeID, string Name)
        {
            this.CreatorTypeID = CreatorTypeID;
            this.Name = Name;

        }
    }
}
