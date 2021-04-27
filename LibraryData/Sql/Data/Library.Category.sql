DECLARE @CategoryStaging TABLE
(
  
   [Name] VARCHAR(32) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @CategoryStaging([Name])
VALUES
    (N'Fantasy'),
    (N'Romance'),
    (N'Mystery'),
    (N'Horror'),
    (N'Memoir'),
    (N'Cooking'),
    (N'Health'),
    (N'History'),
    (N'Travel'),
    (N'Humor'),
    (N'Children'),
    (N'Adventure'),
    (N'Action'),
    (N'RPG'),
    (N'Simulation'),
    (N'Sport'),
    (N'MMO');

   

/******************************************************************************/

MERGE [Library].Category T
USING @CategoryStaging S ON S.[Name]  = T.[Name] 
WHEN MATCHED AND S.[Name] <> T.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT([Name])
   VALUES(S.[Name]);