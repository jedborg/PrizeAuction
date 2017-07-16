alter PROC [dbo].[AuctionInsert] 
    @Active bit,
    @Name varchar(50),
    @Description varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Auction] ([Active], [Name], [Description])
	SELECT @Active, @Name, @Description
	
	-- Begin Return Select <- do not remove
	SELECT [AuctionId], [Active], [Name], [Description]
	FROM   [dbo].[Auction]
	WHERE  [AuctionId] = SCOPE_IDENTITY()
	-- End Return Select <- do not removetest
               
	COMMIT
