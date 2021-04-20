using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class Author
    {
        public int CreatorID { get; }

        public int CreatorTypeID { get; }

        public string FirstName { get; }
        public string LastName { get; }

        public Author(int CreatorID, int CreatorTypeID, string FirstName, string LastName)
        {
            this.CreatorID = CreatorID;
            this.CreatorTypeID = CreatorTypeID;
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

    }
}
