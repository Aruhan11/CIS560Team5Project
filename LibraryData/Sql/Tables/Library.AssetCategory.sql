IF OBJECT_ID(N'Library.AssetCategory') IS NULL
BEGIN

    CREATE TABLE [Library].AssetCategory 
    (
        AssetCategoryID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        AssetID INT NOT NULL,
        CategoryID INT NOT NULL,

        CONSTRAINT [FK_Library_AssetCategory_Asset] FOREIGN KEY(AssetID)
        REFERENCES Library.Asset(AssetID),
        CONSTRAINT [FK_Library_AssetCategory_Category] FOREIGN KEY(CategoryID)
        REFERENCES Library.Category(CategoryID) 
    );
END;


/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.AssetCategory')
         AND kc.[Name] = N'UK_Library_AssetCategory_AssetID_CategoryID'
   )
BEGIN
   ALTER TABLE [Library].AssetCategory
   ADD CONSTRAINT [UK_Library_AssetCategory_AssetID_CategoryID] UNIQUE NONCLUSTERED
   (
      AssetID ASC, CategoryID ASC
   )
END;


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.AssetCategory')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Asset')
         AND fk.[Name] = N'FK_Library_AssetCategory_Asset'
   )
BEGIN
   ALTER TABLE [Library].AssetCategory 
   ADD CONSTRAINT [FK_Library_AssetCategory_Asset] FOREIGN KEY
   (
      AssetID
   )
   REFERENCES [Library].Asset
   (
      AssetID
   );
END;


IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.AssetCategory')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Category')
         AND fk.[Name] = N'FK_Library_AssetCategory_Category'
   )
BEGIN
   ALTER TABLE [Library].AssetCategory 
   ADD CONSTRAINT [FK_Library_AssetCategory_Category] FOREIGN KEY
   (
      CategoryID
   )
   REFERENCES [Library].Category
   (
      CategoryID
   );
END;

