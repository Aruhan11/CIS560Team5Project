CREATE OR ALTER PROCEDURE [Library].CreateCheckOutAsset
   @AssetID INT,
   @UserID INT,
   @LibrarianID INT,
   @CheckOutID INT OUTPUT,
   @CheckOutDate DATETIMEOFFSET OUTPUT,
   @ReturnByDate DATETIMEOFFSET OUTPUT,
   @IsReturned INT OUTPUT
AS




INSERT [Library].CheckedOutAsset(AssetID, UserID, LibrarianID)
VALUES(@AssetID, @UserID, @LibrarianID);

SET @CheckOutID = SCOPE_IDENTITY();

SET @CheckOutDate = 
(
	SELECT COA.CheckOutDate
	FROM [Library].CheckedOutAsset COA 
	WHERE COA.CheckOutID = @CheckOutID
)

SET @ReturnByDate = 
(
	SELECT COA.ReturnByDate
	FROM [Library].CheckedOutAsset COA 
	WHERE COA.CheckOutID = @CheckOutID
)

SET @IsReturned = 
(
	SELECT COA.IsReturned
	FROM [Library].CheckedOutAsset COA 
	WHERE COA.CheckOutID = @CheckOutID
)

UPDATE [Library].Asset
SET
	Stock = Stock - 1
WHERE AssetID = @AssetID;

GO
