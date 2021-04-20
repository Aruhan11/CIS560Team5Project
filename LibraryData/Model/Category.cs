using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class Category
    {
        public int CategoryID { get; }

        public string CategoryName { get; }

        public Category(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
        }
    
    }
}
