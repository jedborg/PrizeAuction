CREATE PROC [dbo].[BidInsert] 
    @PersonId int,
    @AuctionItemId int,
    @BidAmount money
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Bid] ([PersonId], [AuctionItemId], [BidAmount])
	SELECT @PersonId, @AuctionItemId, @BidAmount
	
	-- Begin Return Select <- do not remove
	SELECT [BidId], [PersonId], [AuctionItemId], [BidAmount]
	FROM   [dbo].[Bid]
	WHERE  [BidId] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
