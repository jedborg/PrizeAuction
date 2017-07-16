CREATE PROC [dbo].[AuctionDelete] 
    @AuctionId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Auction]
	WHERE  [AuctionId] = @AuctionId

	COMMIT
