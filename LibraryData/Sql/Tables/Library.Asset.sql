IF OBJECT_ID(N'Library.Asset') IS NULL
BEGIN

    CREATE TABLE Library.Asset
    (
        AssetID INT NOT NULL IDENTITY(1,1),
        [Name] NVARCHAR(64) NOT NULL,
        AssetCategoryID INT NOT NULL,
        AssetTypeID TINYINT NOT NULL,
        CreatorID INT NOT NULL,
        ReleaseDate DATETIME2 NOT NULL DEFAULT('0000-00-00'),
        Stock INT NOT NULL ,

        CONSTRAINT PK_Library_Asset_AssetID PRIMARY KEY CLUSTERED
        (
             AssetID ASC
        ),
    
        CONSTRAINT [FK_Library_Asset_Library_AssetType] FOREIGN KEY(AssetTypeID)
        REFERENCES [Library].AssetType(AssetTypeID),

        CONSTRAINT [FK_Library_Asset_Library_Creator] FOREIGN KEY(CreatorID)
        REFERENCES [Library].Creator(CreatorID)

    );
END;

/*

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.Asset')
         AND kc.[Name] = N'UK_Library_Asset_Name'
   )
BEGIN
   ALTER TABLE [Library].[User]
   ADD CONSTRAINT [UK_Library_Asset_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;

*/


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Asset')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.AssetType')
         AND fk.[Name] = N'FK_Library_Asset_Library_AssetType'
   )
BEGIN
   ALTER TABLE [Library].Asset 
   ADD CONSTRAINT [FK_Library_Asset_Library_AssetType] FOREIGN KEY
   (
      AssetTypeID
   )
   REFERENCES [Library].AssetType
   (
      AssetTypeID
   );
END;


IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Asset')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Creator')
         AND fk.[Name] = N'FK_Library_Asset_Library_Creator'
   )
BEGIN
   ALTER TABLE [Library].Asset 
   ADD CONSTRAINT [FK_Library_Asset_Library_Creator] FOREIGN KEY
   (
      CreatorID
   )
   REFERENCES [Library].Creator
   (
      CreatorID
   );
END;

