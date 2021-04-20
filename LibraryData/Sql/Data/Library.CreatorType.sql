DECLARE @CreatorTypeStaging TABLE
(
   CreatorTypeID TINYINT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(8) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @CreatorTypeStaging(CreatorTypeID, [Name])
VALUES
   (1, 'Author'),
   (2, 'Producer'),
   (3, 'Developer');

/******************************************************************************/

MERGE [Library].CreatorType T
USING @CreatorTypeStaging S ON S.CreatorTypeID = T.CreatorTypeID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(CreatorTypeID, [Name])
   VALUES(S.CreatorTypeID, S.[Name]);