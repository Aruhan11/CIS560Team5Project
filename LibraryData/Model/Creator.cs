using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Creator
    {
        public int CreatorID { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string CompanyName { get; }


        public Creator(int CreatorID, string FirstName, string LastName, string CompanyName)
        {
            this.CreatorID = CreatorID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CompanyName = CompanyName;

        }
    }
}
