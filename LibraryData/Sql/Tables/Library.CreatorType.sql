IF OBJECT_ID(N'Library.CreatorType') IS NULL
BEGIN
   CREATE TABLE [Library].CreatorType
   (
      CreatorTypeID TINYINT NOT NULL,
      [Name] VARCHAR(8) NOT NULL,

      CONSTRAINT PK_Library_CreatorType_CreatorTypeID PRIMARY KEY CLUSTERED
      (
         CreatorTypeID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.CreatorType')
         AND kc.[Name] = N'UK_Library_CreatorType_Name'
   )
BEGIN
   ALTER TABLE [Library].CreatorType
   ADD CONSTRAINT [UK_Library_CreatorType_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
