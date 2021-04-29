using LibarayData.Model;
using System.Collections.Generic;
using System;

namespace LibraryData
{
   public interface ICreatorQueryRepository
    {
        

        void UpdateCreator(int creatorID, int creatorTypeID);
       

        Creator FetchCreator(int creatorID);

        IReadOnlyList<Creator> RetrieveCreators();

        IReadOnlyList<ProductionOfCreator> FetchProductionsOfCreator(int creatorID);

        IReadOnlyList<CreatorByType> GetCreatorsByType(string CreatorTypeName);
    }
}
