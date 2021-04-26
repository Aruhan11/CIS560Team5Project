

CREATE OR ALTER PROCEDURE [Library].SavePhoneNumber
   @UserID INT,
   @PhoneNumber NVARCHAR(10)
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
   INSERT(UserID,PhoneNumber)
   VALUES(S.UserID, S.PhoneNumber);



GO
