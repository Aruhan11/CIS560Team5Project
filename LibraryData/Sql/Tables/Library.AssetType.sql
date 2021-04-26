IF OBJECT_ID(N'Library.AssetType') IS NULL
BEGIN
   CREATE TABLE [Library].AssetType
   (
      AssetTypeID TINYINT NOT NULL,
      [Name] VARCHAR(8) NOT NULL,

      CONSTRAINT PK_Library_AssetType_AssetTypeID PRIMARY KEY CLUSTERED
      (
         AssetTypeID ASC
      )
   );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.AssetType')
         AND kc.[Name] = N'UK_Library_AssetType_Name'
   )
BEGIN
   ALTER TABLE [Library].AssetType
   ADD CONSTRAINT [UK_Library_AssetType_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
