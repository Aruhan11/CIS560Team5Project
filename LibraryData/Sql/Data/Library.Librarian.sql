DECLARE @LibrarianStaging TABLE
(
   UserID TINYINT NOT NULL PRIMARY KEY

);
INSERT @LibrarianStaging(UserID)
VALUES
     ('97'),
     ('12'),
     ('82'),
     ('63'),
     ('69'),
     ('51'),
     ('38'),
     ('33'),
     ('80'),
     ('25'),
     ('95'),
     ('44'),
     ('88'),
     ('47'),
     ('74'),
     ('42'),
     ('17'),
     ('48'),
     ('66'),
     ('11');




MERGE [Library].[Librarian] T
USING @LibrarianStaging S ON S.UserID = T.UserID
WHEN MATCHED AND S.UserID <> T.UserID AND  S.LastName <> T.LastName THEN
   UPDATE
   SET UserID = S.UserID
		
WHEN NOT MATCHED THEN
   INSERT(UserID)
   VALUES(S.UserID);
