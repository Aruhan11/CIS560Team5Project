using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Model
{
    public class Producer
    {
        public int CreatorID { get; }

        public int CreatorTypeID { get; }

        public string FirstName { get; }
        public string LastName { get; }

        public string Company { get; }

        public Producer(int CreatorID, int CreatorTypeID, string FirstName, string LastName, string Company)
        {
            this.CreatorID = CreatorID;
            this.CreatorTypeID = CreatorTypeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Company = Company;

        }
    }
}
