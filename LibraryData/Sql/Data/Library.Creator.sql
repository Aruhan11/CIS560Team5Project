DECLARE @CreatorStaging TABLE
(
   CreatorID TINYINT NOT NULL PRIMARY KEY,
   FirstName VARCHAR(10) NOT NULL,
   LastName VARCHAR(10) NOT NULL,
   Company VARCHAR(10) NOT NULL

);

/***************************** Modify values here *****************************/

INSERT @CreatorStaging(CreatorID, FirstName, LastName, Company)
VALUES
   (1, 'Kate', 'Smith', 'N/A'),
   (2, 'Anna', 'Anderson', 'N/A'),
   (3,  'Tom', 'Brown', 'N/A'),
   (4, 'Taylor', 'White', 'N/A'),
   (5, 'Josh', 'Derby', 'N/A'),
   (6, 'Tom', 'Smith', 'DHX Media'),
   (7, 'Lisa', 'Anderson', '20th Century Pictures'),
   (8, 'Jack', 'Brown', 'Fox Searchlight Pictures'),
   (9, 'Jean', 'White', 'Filmways'),
   (10, 'Zac', 'Derby', 'DreamWorks'),
   (11, 'N/A', 'N/A','miHoYo'),
   (12, 'N/A', 'N/A','Tencent'),
   (13, 'N/A', 'N/A','Sony Interactive Entertainment'),
   (14, 'N/A', 'N/A','Ubisoft'),
   (15, 'N/A', 'N/A','CD Projekt Red');


/******************************************************************************/

MERGE [Library].Creator T
USING @CreatorStaging S ON S.CreatorID = T.CreatorID
WHEN MATCHED AND S.FirstName <> T.FirstName AND S.LastName <> T.LastName AND S.Company <> T.Company THEN
   UPDATE
   SET FirstName = S.FirstName, LastName = S.LastName, Company = S.Company
WHEN NOT MATCHED THEN
   INSERT(CreatorID, FirstName, LastName, Company)
   VALUES(S.CreatorID, S.FirstName, S.LastName, S.Company);
