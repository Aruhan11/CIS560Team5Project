CREATE OR ALTER PROCEDURE [Library].InsertCreator

   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @Company NVARCHAR(32),
   @CreatorID INT OUTPUT
AS



MERGE [Library].Creator T
USING 
    (
        VALUES(@FirstName, @LastName, @Company)
    )S(FirstName, LastName, Company) ON T.FirstName = S.FirstName AND T.LastName = S.LastName AND T.Company = S.Company
WHEN NOT MATCHED 
 THEN
    INSERT(FirstName, LastName, Company)
    VALUES(S.FirstName, S.LastName, S.Company);

SET @CreatorID = 
(
    SELECT C.CreatorID
    FROM [Library].Creator C
    WHERE  C.FirstName = @FirstName AND C.LastName = @LastName AND C.Company = @Company
);


