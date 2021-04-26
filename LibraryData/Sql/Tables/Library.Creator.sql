IF OBJECT_ID(N'Library.Creator') IS NULL
BEGIN

   CREATE TABLE [Library].Creator 
    (
        CreatorID INT NOT NULL IDENTITY(1, 1),
        FirstName NVARCHAR(32) NOT NULL,
        LastName NVARCHAR(32) NOT NULL,
        Company NVARCHAR(32) NOT NULL,

        CONSTRAINT PK_Library_Producer_CreatorID PRIMARY KEY CLUSTERED
        (
             CreatorID ASC
        )

    );
END;



/****************************
 * Check Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.check_constraints cc
      WHERE cc.parent_object_id = OBJECT_ID(N'Library.Creator')
         AND cc.[Name] = N'CK_Library_Producer_FirstName_LastName_Company'
   )
BEGIN
   ALTER TABLE [Library].Creator
   ADD CONSTRAINT [CK_Library_Creator_FirstName_LastName_Company] CHECK
   (
      FirstName > N'' OR LastName > N'' OR Company > N''
   )
END;

