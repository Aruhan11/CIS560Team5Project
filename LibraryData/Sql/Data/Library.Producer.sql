DECLARE @ProducerStaging TABLE
(
   CreatorID TINYINT NOT NULL PRIMARY KEY,
   CreatorTypeID TINYINT NOT NULL FOREIGN KEY REFERENCES [Library].CreatorType(CreatorTypeID),
   FirstName VARCHAR(10) NOT NULL,
   LastName VARCHAR(10) NOT NULL,
   Company VARCHAR(10) NOT NULL,

   UNIQUE (FirstName, LastName, Company)

);

/***************************** Modify values here *****************************/

INSERT @ProducerStaging(CreatorID, CreatorTypeID, FirstName, LastName, Company)
VALUES
   (6, 2, 'Tom', 'Smith', 'DHX Media'),
   (7, 2, 'Lisa', 'Anderson', '20th Century Pictures'),
   (8, 2, 'Jack', 'Brown', 'Fox Searchlight Pictures'),
   (9, 2, 'Jean', 'White', 'Filmways'),
   (10, 2, 'Zac', 'Derby', 'DreamWorks');


/******************************************************************************/

MERGE [Library].Producer T
USING @ProducerStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID AND S.FirstName <> T.FirstName AND S.LastName <> T.LastName AND S.Company <> T.Company THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID, FirstName = S.FirstName, LastName = S.LastName, Company = S.Company
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID, FirstName, LastName, Company)
   VALUES(S.CreatorID, S.CreatorTypeID, S.FirstName, S.LastName, S.Company);

MERGE [Library].Creator T
USING @ProducerStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID)
   VALUES(S.CreatorID, S.CreatorTypeID);