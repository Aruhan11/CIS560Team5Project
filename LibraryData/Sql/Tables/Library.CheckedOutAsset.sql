IF OBJECT_ID(N'Library.CheckedOutAsset') IS NULL
BEGIN

   CREATE TABLE [Library].CheckedOutAsset
   (
        CheckOutID INT NOT NULL IDENTITY(1,1) ,
        AssetID INT NOT NULL,
        UserID INT NOT NULL,
        LibrarianID INT NOT NULL,
        CheckOutDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
        ReturnByDate DATETIMEOFFSET NOT NULL DEFAULT(DATEADD(month, 3, SYSDATETIMEOFFSET())),
        IsReturned TINYINT NOT NULL DEFAULT(0),

        CONSTRAINT PK_Library_CheckedOutAsset_CheckOutID PRIMARY KEY CLUSTERED
        (
             CheckOutID ASC
        ),
    
        CONSTRAINT [FK_Library_CheckedOutAsset_Library_Asset] FOREIGN KEY(AssetID)
        REFERENCES [Library].Asset(AssetID),

        CONSTRAINT [FK_Library_CheckedOutAsset_Library_User] FOREIGN KEY(UserID)
        REFERENCES [Library].[User](UserID),

        CONSTRAINT [FK_Library_CheckedOutAsset_Library_Libraian] FOREIGN KEY(LibrarianID)
        REFERENCES [Library].Librarian(LibrarianID)

   );

END;

/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.CheckedOutAsset')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Asset')
         AND fk.[Name] = N'FK_Library_CheckedOutAsset_Library_Asset'
   )
BEGIN
   ALTER TABLE [Library].CheckedOutAsset 
   ADD CONSTRAINT [FK_Library_CheckedOutAsset_Library_Asset] FOREIGN KEY
   (
      AssetID
   )
   REFERENCES [Library].Asset
   (
      AssetID
   );
END;

/****************************
 * 
 ****************************/
IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.CheckedOutAsset')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.User')
         AND fk.[Name] = N'FK_Library_CheckedOutAsset_Library_User'
   )
BEGIN
   ALTER TABLE [Library].CheckedOutAsset 
   ADD CONSTRAINT [FK_Library_CheckedOutAsset_Library_User] FOREIGN KEY
   (
      UserID
   )
   REFERENCES [Library].[User]
   (
      UserID
   );
END;



IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.CheckedOutAsset')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Librarian')
         AND fk.[Name] = N'FK_Library_CheckedOutAsset_Library_Librarian'
   )
BEGIN
   ALTER TABLE [Library].CheckedOutAsset 
   ADD CONSTRAINT [FK_Library_CheckedOutAsset_Library_Librarian] FOREIGN KEY
   (
      LibrarianID
   )
   REFERENCES [Library].Librarian
   (
      LibrarianID
   );
END;

