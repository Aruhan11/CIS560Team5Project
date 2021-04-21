IF OBJECT_ID(N'Library.Developer') IS NULL
BEGIN

   CREATE TABLE [Library].Developer 
    (
        CreatorID TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        CreatorTypeID TINYINT NOT NULL,

        Company NVARCHAR(32) NOT NULL,

        CONSTRAINT PK_Library_Developer_CreatorID PRIMARY KEY CLUSTERED
        (
             CreatorID ASC
        ),

        CONSTRAINT [FK_Library_Developer_Library_CreatorType] FOREIGN KEY(CreatorTypeID)
        REFERENCES [Library].CreatorType(CreatorTypeID),

    );
END;


/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.Developer')
         AND kc.[name] = N'UK_Library_Producer_CreatorTypeID_Company'
   )
BEGIN
   ALTER TABLE [Library].Developer
   ADD CONSTRAINT [UK_Library_Producer_CreatorTypeID_Company] UNIQUE NONCLUSTERED
   (
      CreatorTypeID ASC, Company ASC
   )
END;


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Developer')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.CreatorType')
         AND fk.[name] = N'FK_Library_Developer_Library_CreatorType'
   )
BEGIN
   ALTER TABLE [Library].Developer 
   ADD CONSTRAINT [FK_Library_Developer_Library_CreatorType] FOREIGN KEY
   (
      CreatorTypeID
   )
   REFERENCES [Library].CreatorType
   (
      CreatorTypeID
   );
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Library.Producer')
         AND cc.[name] = N'CK_Library_Producer_FirstName_LastName_Company'
   )
BEGIN
   ALTER TABLE [Library].Developer
   ADD CONSTRAINT [CK_Library_Developer_Company] CHECK
   (
     Company > N''
   )
END;

