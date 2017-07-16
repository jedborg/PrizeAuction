CREATE PROC [dbo].[PersonInsert] 
    @Active bit,
    @FirstName varchar(50),
    @LastName varchar(50),
    @MobilePhone varchar(10)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	

	
	INSERT INTO [dbo].[Person] ([Active], [FirstName], [LastName], [MobilePhone])
	SELECT @Active, @FirstName, @LastName, @MobilePhone
	
	-- Begin Return Select <- do not remove
	SELECT [PersonId], [Active], [FirstName], [LastName], [MobilePhone]
	FROM   [dbo].[Person]
	WHERE  [PersonId] = SCOPE_IDENTITY()
	
