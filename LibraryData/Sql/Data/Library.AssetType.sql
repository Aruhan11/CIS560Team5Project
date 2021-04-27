DECLARE @AssetTypeStaging TABLE
(
   AssetTypeID TINYINT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(32) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @AssetTypeStaging(AssetTypeID, [Name])
VALUES
   (1, 'Book'),
   (2, 'Audio Book'),
   (3, 'Movie'),
   (4, 'Game');

/******************************************************************************/

MERGE [Library].AssetType T
USING @AssetTypeStaging S ON S.AssetTypeID = T.AssetTypeID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(AssetTypeID, [Name])
   VALUES(S.AssetTypeID, S.[Name]);