DECLARE @AssetTypeStaging TABLE
(
   AssetTypeID TINYINT NOT NULL PRIMARY KEY,
   TypeName VARCHAR(8) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @AssetTypeStaging(AssetTypeID, TypeName)
VALUES
   (1, 'Book'),
   (2, 'Audio Book'),
   (3, 'Movie'),
   (4, 'Game');

/******************************************************************************/

MERGE [Library].AssetType T
USING @AssetTypeStaging S ON S.AssetTypeID = T.AssetTypeID
WHEN MATCHED AND S.TypeName <> T.TypeName THEN
   UPDATE
   SET TypeName = S.TypeName
WHEN NOT MATCHED THEN
   INSERT(AssetTypeID, TypeName)
   VALUES(S.AssetTypeID, S.TypeName);