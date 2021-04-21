CREATE OR ALTER PROCEDURE [Library].RetrieveCheckOutAsset
AS

SELECT COA.CheckOutID, U.FirstName, U.LastName,COA.[Name]
FROM [Library].CheckedOutAsset COA
INNER JOIN [Library].[User] U ON U.UserID = COA.UserID
INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
INNER JOIN [Libraray].[Creator] C ON C.CreatorID = A.CreatorID;
GO

