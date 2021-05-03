using System;
using System.Collections.Generic;
using System.Text;

namespace LibarayData.Model
{
    public class SituationOfAsset
    {
       

        public int AssetID { get; } 

        public string Name { get; }

        public string TypeName { get; }

        public string CreatorName { get; }

        public string CompanyName { get; }

        public int Stock { get; }

        public int UserID { get; }

        public DateTime CheckOutDate { get; }

        public DateTime ReturnByDate { get; }

        public int IsReturned { get; }


        public SituationOfAsset(int AssetID, string Name, string TypeName, string CreatorName, string CompanyName, int Stock, int UserID, DateTime CheckOutDate, DateTime ReturnByDate,  int IsReturned)
        {
            this.AssetID = AssetID;
        
            this.Name = Name;
            this.TypeName = TypeName;
            this.CreatorName = CreatorName;
            this.CompanyName = CompanyName;
            this.Stock = Stock;
            this.UserID = UserID;
            this.CheckOutDate = CheckOutDate;
            this.ReturnByDate = ReturnByDate;
            this.IsReturned = IsReturned;


        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("AssetID: " + AssetID);
            sb.Append("  Name: " + Name);
            sb.Append("  Type Name: " + TypeName);
            sb.Append("  Creator Name: " + CreatorName);
            sb.Append("  Company Name: " + CompanyName);
            sb.Append("  Stock: " + Stock.ToString());
            sb.Append("  UserID: " + UserID);
            sb.Append("  Check Out Date: " + CheckOutDate.ToShortDateString());
            sb.Append("  Return By Date: " + ReturnByDate.ToShortDateString());
            sb.Append("  IsReturned: " + IsReturned.ToString());

            return sb.ToString();
        }
    }
}
