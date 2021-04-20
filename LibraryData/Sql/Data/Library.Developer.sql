DECLARE @DeveloperStaging TABLE
(
   CreatorID TINYINT NOT NULL PRIMARY KEY,
   CreatorTypeID TINYINT NOT NULL FOREIGN KEY REFERENCES [Library].CreatorType(CreatorTypeID),
   Company VARCHAR(10) NOT NULL UNIQUE

);

/***************************** Modify values here *****************************/

INSERT @DeveloperStaging(CreatorID, CreatorTypeID, Company)
VALUES
   (11, 3, 'miHoYo'),
   (12, 3, 'Tencent'),
   (13, 3, 'Sony Interactive Entertainment'),
   (14, 3, 'Ubisoft'),
   (15, 3, 'CD Projekt Red');


/******************************************************************************/

MERGE [Library].Producer T
USING @DeveloperStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID AND S.Company <> T.Company THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID, Company = S.Company
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID, Company)
   VALUES(S.CreatorID, S.CreatorTypeID, S.Company);

MERGE [Library].Creator T
USING @DeveloperStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.CreatorTypeID <> T.CreatorTypeID THEN
   UPDATE
   SET CreatorTypeID = S.CreatorTypeID
WHEN NOT MATCHED THEN
   INSERT(CreatorID, CreatorTypeID)
   VALUES(S.CreatorID, S.CreatorTypeID);