
CREATE OR ALTER PROCEDURE [Library].UpdateCreator
   @CreatorID INT,
   @CreatorTypeID INT
AS



MERGE [Library].CreatorCreatorType T
USING 
(
    VALUES(@CreatorID, @CreatorTypeID)
) S(CreatorID, CreatorTypeID) ON S.CreatorID = T.CreatorID AND S.CreatorTypeID = T.CreatorTypeID
WHEN NOT MATCHED THEN
INSERT(CreatorID, CreatorTypeID)
VALUES( S.CreatorID, S.CreatorTypeID);




GO
