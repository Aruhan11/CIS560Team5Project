

CREATE OR ALTER PROCEDURE [Library].UpdateAsset
   @AssetID INT,
   @Stock INT
AS

MERGE [Library].Asset T
USING
      (
         VALUES(@AssetID,@Stock)
      ) S(AssetID,Stock)
   ON S.AssetID = T.AssetID
WHEN MATCHED THEN
   UPDATE
   SET
      Stock = S.Stock
;



GO
