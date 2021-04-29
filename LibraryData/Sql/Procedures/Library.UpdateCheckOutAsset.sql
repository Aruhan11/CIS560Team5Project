CREATE OR ALTER PROCEDURE [Library].UpdateCheckOutAsset
@CheckOutID INT

AS

UPDATE [Library].CheckedOutAsset
SET
	IsReturned = 1
	
WHERE CheckOutID = @CheckOutID;

GO

