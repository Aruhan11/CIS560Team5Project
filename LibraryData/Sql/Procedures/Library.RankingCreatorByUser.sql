/*
* 12.The ranking of the creators of their assets which  users  borrowed the most  
*/
CREATE OR ALTER PROCEDURE [Library].RankingCreatorByUser

AS

WITH SourseCTE(UserID, CreatorID, AssetCount) AS
(
    SELECT COA.UserID, A.CreatorID, COUNT(*) OVER(PARTITION BY A.CreatorID)
    FROM [Library].[Asset] A
    INNER JOIN [Library].CheckedOutAsset COA ON COA.AssetID = A.AssetID
)

SELECT 
      (U.FirstName + N' '+ U.LastName) AS UserName,
      RANK() OVER( PARTITION BY S.UserID ORDER BY S.AssetCount DESC) AS AssetCountRank,
      (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company AS Company,      
      S.AssetCount AS AssetCount
FROM SourseCTE S
INNER JOIN [Library].[User] U ON U.UserID = S.UserID
INNER JOIN [Library].[Creator] C ON C.CreatorID = S.CreatorID
ORDER BY S.UserID ASC

GO
