IF OBJECT_ID(N'Library.Producer') IS NULL
BEGIN

   CREATE TABLE [Library].Producer 
    (
        CreatorID TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        CreatorTypeID TINYINT NOT NULL,
        FirstName NVARCHAR(32) NOT NULL,
        LastName NVARCHAR(32) NOT NULL,
        Company NVARCHAR(32) NOT NULL,

        CONSTRAINT PK_Library_Producer_CreatorID PRIMARY KEY CLUSTERED
        (
             CreatorID ASC
        ),

        CONSTRAINT [FK_Library_Producer_Library_CreatorType] FOREIGN KEY(CreatorTypeID)
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
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.Producer')
         AND kc.[name] = N'UK_Library_Producer_CreatorTypeID_FirstName_LastName'
   )
BEGIN
   ALTER TABLE [Library].Producer
   ADD CONSTRAINT [UK_Library_Producer_CreatorTypeID_FirstName_LastName] UNIQUE NONCLUSTERED
   (
      CreatorTypeID ASC, FirstName ASC, LastName ASC
   )
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.Producer')
         AND kc.[name] = N'UK_Library_Producer_CreatorTypeID_Company'
   )
BEGIN
   ALTER TABLE [Library].Producer
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
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Producer')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.CreatorType')
         AND fk.[name] = N'FK_Library_Producer_Library_CreatorType'
   )
BEGIN
   ALTER TABLE [Library].Producer 
   ADD CONSTRAINT [FK_Library_Producer_Library_CreatorType] FOREIGN KEY
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
   ALTER TABLE [Library].Producer
   ADD CONSTRAINT [CK_Library_Producer_FirstName_LastName_Company] CHECK
   (
      FirstName > N'' OR LastName > N'' OR Company > N''
   )
END;

