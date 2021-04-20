DECLARE @CategoryStaging TABLE
(
   CategoryID TINYINT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(8) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @CategoryStaging(CategoryID, [Name])
VALUES
   (1, 'Fantasy'),
   (2, 'Romance'),
   (3, 'Mystery'),
   (4, 'Horror'),
   (5, 'Memoir'),
   (6, 'Cooking'),
   (7, 'Health'),
   (8, 'History'),
   (9, 'Travel'),
   (10, 'Humor'),
   (11, 'Children'),
   (12, 'Adventure'),
   (13, 'Action'),
   (14, 'RPG'),
   (15, 'Sumulation'),
   (15, 'Sport'),
   (15, 'MMO');
   

/******************************************************************************/

MERGE [Library].Category T
USING @CategoryStaging S ON S.CategoryID = T.CategoryID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(CategoryID, [Name])
   VALUES(S.CategoryID, S.[Name]);