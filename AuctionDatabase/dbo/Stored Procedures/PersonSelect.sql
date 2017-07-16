CREATE PROC [dbo].[PersonSelect] 
    @PersonId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [PersonId], [Active], [FirstName], [LastName], [MobilePhone] 
	FROM   [dbo].[Person] 
	WHERE  ([PersonId] = @PersonId OR @PersonId IS NULL) 

	COMMIT
