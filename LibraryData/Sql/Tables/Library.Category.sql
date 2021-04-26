IF OBJECT_ID(N'Library.Category') IS NULL
BEGIN
   CREATE TABLE [Library].Category 
    (
      CategoryID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      [Name] NVARCHAR(64) NOT NULL,


    );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.Category')
         AND kc.[Name] = N'UK_Library_Category_Name'
   )
BEGIN
   ALTER TABLE [Library].Category
   ADD CONSTRAINT [UK_Library_Category_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
