CREATE PROC [dbo].[PersonDelete] 
    @PersonId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Person]
	WHERE  [PersonId] = @PersonId

	COMMIT
