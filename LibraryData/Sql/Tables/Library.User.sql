IF OBJECT_ID(N'Library.User') IS NULL
BEGIN

   CREATE TABLE [Library].[User] (
    UserID INT NOT NULL IDENTITY(1, 1),
    FirstName NVARCHAR(8) NOT NULL,
    LastName NVARCHAR(8) NOT NULL,
    PhoneNumber NVARCHAR(13) NOT NULL,
    CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    LastCheckoutDate DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    IsDeleted TINYINT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Library_User_UserID] PRIMARY KEY CLUSTERED
      (
         UserID ASC
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
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.User')
         AND kc.[Name] = N'UK_Library_User_FirstName_LastName'
   )
BEGIN
   ALTER TABLE [Library].[User]
   ADD CONSTRAINT [UK_Library_User_FirstName_LastName] UNIQUE NONCLUSTERED
   (
      FirstName ASC, LastName ASC
   )
END;


IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Library.User')
         AND kc.[Name] = N'UK_Library_User_PhoneNumber'
   )
BEGIN
   ALTER TABLE [Library].[User]
   ADD CONSTRAINT [UK_Library_User_PhoneNumber] UNIQUE NONCLUSTERED
   (
      PhoneNumber ASC
   )
END;

/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Library.User')
         AND cc.[Name] = N'CK_Library_User_LastName_FirstName'
   )
BEGIN
   ALTER TABLE [Library].[User]
   ADD CONSTRAINT [CK_Library_User_FirstName_LastName] CHECK
   (
      FirstName > N'' OR LastName > N''
   )
END;
