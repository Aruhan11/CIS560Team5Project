IF OBJECT_ID(N'Library.Creator') IS NULL
BEGIN

    CREATE TABLE [Library].Creator 
    (
        CreatorID TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
        CreatorTypeID TINYINT NOT NULL,

        CONSTRAINT PK_Library_Creator_CreatorID PRIMARY KEY CLUSTERED
        (
             CreatorID ASC
        ),

        CONSTRAINT [FK_Library_Creator_Library_CreatorType] FOREIGN KEY(CreatorTypeID)
        REFERENCES [Library].CreatorType(CreatorTypeID),

    );
END;



/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.Creator')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.CreatorType')
         AND fk.[name] = N'FK_Library_Creator_Library_CreatorType'
   )
BEGIN
   ALTER TABLE [Library].Creator 
   ADD CONSTRAINT [FK_Library_Creator_Library_CreatorType] FOREIGN KEY
   (
      CreatorTypeID
   )
   REFERENCES [Library].CreatorType
   (
      CreatorTypeID
   );
END;
