CREATE PROC [dbo].[BankInsert] 
    @PersonId int,
    @AuctionId int,
    @Bank money
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Bank] ([PersonId], [AuctionId], [Bank])
	SELECT @PersonId, @AuctionId, @Bank
	
	-- Begin Return Select <- do not remove
	SELECT [BankId], [PersonId], [AuctionId], [Bank]
	FROM   [dbo].[Bank]
	WHERE  [BankId] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
