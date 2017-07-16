CREATE PROC [dbo].[BankUpdate] 
    @BankId int,
    @PersonId int,
    @AuctionId int,
    @Bank money
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Bank]
	SET    [PersonId] = @PersonId, [AuctionId] = @AuctionId, [Bank] = @Bank
	WHERE  [BankId] = @BankId
	
	/*-- Begin Return Select <- do not remove
	SELECT [BankId], [PersonId], [AuctionId], [Bank]
	FROM   [dbo].[Bank]
	WHERE  [BankId] = @BankId	
	-- End Return Select <- do not remove*/

	COMMIT
