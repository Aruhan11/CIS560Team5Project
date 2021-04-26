DECLARE @CategoryStaging TABLE
(
   CategoryID TINYINT NOT NULL PRIMARY KEY,
   [Name] VARCHAR(8) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @CategoryStaging(CategoryID, [Name])
VALUES
    (1,N'Fantasy'),
    (2,N'Romance'),
    (3,N'Mystery'),
    (4,N'Horror'),
    (5,N'Memoir'),
    (6,N'Cooking'),
    (7,N'Health'),
    (8,N'History'),
    (9,N'Travel'),
    (10,N'Humor'),
    (11,N'Children'),
    (12,N'Adventure'),
    (13,N'Action'),
    (14,N'RPG'),
    (15,N'Simulation'),
    (16,N'Sport'),
    (17,N'MMO');

   

/******************************************************************************/

MERGE [Library].Category T
USING @CategoryStaging S ON S.CategoryID = T.CategoryID
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(CategoryID, [Name])
   VALUES(S.CategoryID, S.[Name]);