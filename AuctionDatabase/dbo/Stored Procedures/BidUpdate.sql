CREATE PROC [dbo].[BidUpdate] 
    @BidId int,
    @PersonId int,
    @AuctionItemId int,
    @BidAmount money
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Bid]
	SET    [PersonId] = @PersonId, [AuctionItemId] = @AuctionItemId, [BidAmount] = @BidAmount
	WHERE  [BidId] = @BidId
	
	/*-- Begin Return Select <- do not remove
	SELECT [BidId], [PersonId], [AuctionItemId], [BidAmount]
	FROM   [dbo].[Bid]
	WHERE  [BidId] = @BidId	
	-- End Return Select <- do not remove*/

	COMMIT
