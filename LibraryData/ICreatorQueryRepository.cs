using LibarayData.Model;
using System.Collections.Generic;
using System;

namespace LibraryData
{
   public interface ICreatorQueryRepository
    {
        

        void UpdateCreator(string creatorID, int creatorTypeID);
       

        Creator FetchCreator(int creatorID);

        // retrive

        IReadOnlyList<ProductionOfCreator> FetchProductionsOfCreator(int creatorID);

        IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName);
    }
}
