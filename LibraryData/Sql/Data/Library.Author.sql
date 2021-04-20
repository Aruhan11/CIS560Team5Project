DECLARE @AuthorStaging TABLE
(
   CreatorID TINYINT NOT NULL PRIMARY KEY,
   CreatorTypeID TINYINT NOT NULL FOREIGN KEY REFERENCES [Library].CreatorType(CreatorTypeID),
   FirstName VARCHAR(10) NOT NULL,
   LastName VARCHAR(10) NOT NULL,
   
   UNIQUE (FirstName, LastName)

);

/***************************** Modify values here *****************************/

INSERT @AuthorStaging(CreatorID, CreatorTypeID, FirstName, LastName)
VALUES
   (1, 1, 'Kate', 'Smith'),
   (2, 1, 'Anna', 'Anderson'),
   (3, 1, 'Tom', 'Brown'),
   (4, 1, 'Taylor', 'White'),
   (5, 1, 'Josh', 'Derby');


/******************************************************************************/

MERGE [Library].Author T
USING @AuthorStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID AND S.FirstName <> T.FirstName AND S.LastName <> T.LastName THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID, FirstName = S.FirstName, LastName = S.LastName
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID, FirstName, LastName)
   VALUES(S.CreatorID, S.CreatorTypeID, S.FirstName, S.LastName);

MERGE [Library].Creator T
USING @AuthorStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID)
   VALUES(S.CreatorID, S.CreatorTypeID);