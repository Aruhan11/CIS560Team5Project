

CREATE OR ALTER PROCEDURE [Library].UpdateUser
   @UserID INT,
   @PhoneNumber NVARCHAR(32)
AS

MERGE [Library].[User] T
USING
      (
         VALUES(@UserID,@PhoneNumber)
      ) S(UserID,PhoneNumber)
   ON S.UserID = T.UserID
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.PhoneNumber
         INTERSECT
         SELECT  T.PhoneNumber
      ) THEN
   UPDATE
   SET
      PhoneNumber = S.PhoneNumber,
      UpdatedOn = SYSDATETIMEOFFSET()
WHEN NOT MATCHED THEN
   INSERT(PhoneNumber)
   VALUES(S.PhoneNumber);



GO
