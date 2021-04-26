IF OBJECT_ID(N'Library.CreatorCreatorType') IS NULL
BEGIN

   CREATE TABLE [Library].CreatorCreatorType 
    (
        CreatorCreatorTypeID INT NOT NULL IDENTITY(1, 1),
        CreatorID INT NOT NULL,
        CreatorTypeID TINYINT NOT NULL,


        CONSTRAINT PK_Library_CreatorCreatorType_CreatorCreatorTypeID PRIMARY KEY CLUSTERED
        (
             CreatorCreatorTypeID ASC
        ),

        CONSTRAINT [FK_Library_CreatorCreatorType_Library_Creator] FOREIGN KEY(CreatorID)
        REFERENCES [Library].Creator(CreatorID),

        CONSTRAINT [FK_Library_CreatorCreatorType_Library_CreatorType] FOREIGN KEY(CreatorTypeID)
        REFERENCES [Library].CreatorType(CreatorTypeID)

    );
END;


/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.CreatorCreatorType')
         AND kc.[Name] = N'UK_Library__CreatorCreatorType_CreatorID_CreatorTypeID'
   )
BEGIN
   ALTER TABLE [Library].CreatorCreatorType
   ADD CONSTRAINT [UK_Library__CreatorCreatorType_CreatorID_CreatorTypeID] UNIQUE NONCLUSTERED
   (
      CreatorID ASC,CreatorTypeID ASC
   )
END;


/****************************
 * Foreign Keys Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.CreatorCreatorType')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.Creator')
         AND fk.[Name] = N'FK_Library_CreatorCreatorType_Library_Creator'
   )
BEGIN
   ALTER TABLE [Library].CreatorCreatorType 
   ADD CONSTRAINT [FK_Library_CreatorCreatorType_Library_Creator] FOREIGN KEY
   (
      CreatorID
   )
   REFERENCES [Library].Creator
   (
      CreatorID
   );
END;

IF NOT EXISTS
   (
      SELECT *
      FROM sys.foreign_keys fk
      WHERE fk.parent_object_id = OBJECT_ID(N'Library.CreatorCreatorType')
         AND fk.referenced_object_id = OBJECT_ID(N'Library.CreatorType')
         AND fk.[Name] = N'FK_Library_CreatorCreatorType_Library_CreatorType'
   )
BEGIN
   ALTER TABLE [Library].CreatorCreatorType 
   ADD CONSTRAINT [FK_Library_CreatorCreatorType_Library_CreatorType] FOREIGN KEY
   (
      CreatorTypeID
   )
   REFERENCES [Library].CreatorType
   (
      CreatorTypeID
   );
END;

