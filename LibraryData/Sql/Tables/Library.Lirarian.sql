IF OBJECT_ID(N'Library.Librarian') IS NULL
BEGIN

   CREATE TABLE [Library].Librarian 
   (
        LibrarianID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        UserID INT NOT NULL,

        CONSTRAINT PK_Library_Librarian_LibrarianID PRIMARY KEY CLUSTERED
        (
             LibrarianID ASC
        ),

        CONSTRAINT [FK_Library_Librarian_UserID] FOREIGN KEY(UserID)
        REFERENCES [Library].[User](UserID)

   );
END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Librarian')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.User')
         AND fk.[name] = N'FK_Library_Librarian_Library_User'
   )
BEGIN
   ALTER TABLE [Library].Librarian 
   ADD CONSTRAINT [FK_Library_Librarian_Library_User] FOREIGN KEY
   (
      UserID
   )
   REFERENCES [Library].[User]
   (
      UserID
   );
END;

