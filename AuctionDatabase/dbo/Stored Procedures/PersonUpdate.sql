CREATE PROC [dbo].[PersonUpdate] 
    @PersonId int,
    @Active bit,
    @FirstName varchar(50),
    @LastName varchar(50),
    @MobilePhone varchar(10)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Person]
	SET    [Active] = @Active, [FirstName] = @FirstName, [LastName] = @LastName, [MobilePhone] = @MobilePhone
	WHERE  [PersonId] = @PersonId
	
	/*-- Begin Return Select <- do not remove
	SELECT [PersonId], [Active], [FirstName], [LastName], [MobilePhone]
	FROM   [dbo].[Person]
	WHERE  [PersonId] = @PersonId	
	-- End Return Select <- do not remove*/

	COMMIT
