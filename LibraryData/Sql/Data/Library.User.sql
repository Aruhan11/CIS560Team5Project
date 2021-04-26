DECLARE @UserStaging TABLE
(
   FirstName NVARCHAR(8) NOT NULL,
   LastName NVARCHAR(8) NOT NULL,
   PhoneNumber NVARCHAR(13) NOT NULL,
   LastCheckOutDate DateTime2 NOT NULL,
   IsDeleted TINYINT NOT NULL
);

/***************************** Modify values here *****************************/

INSERT @UserStaging(FirstName,LastName,PhoneNumber,LastCheckOutDate,IsDeleted)
VALUES
   ('First1', 'Last1','111-111-1111', '2016-10-23 00:00:00',0),
   ('First2', 'Last2','222-222-2222', '2016-10-23 00:00:00',0),
   ('First3', 'LastN3','333-333-3333', '2016-10-23 00:00:00',0);


   
MERGE [Library].[User] T
USING @UserStaging S ON S.PhoneNumber = T.PhoneNumber
WHEN MATCHED AND S.FirstName <> T.FirstName AND  S.LastName <> T.LastName THEN
   UPDATE
   SET FirstName = S.FirstName,
		LastName = S.LastName
WHEN NOT MATCHED THEN
   INSERT(FirstName,LastName,PhoneNumber,LastCheckOutDate,IsDeleted)
   VALUES(S.FirstName,S.LastName,S.PhoneNumber,S.LastCheckOutDate,S.IsDeleted);
