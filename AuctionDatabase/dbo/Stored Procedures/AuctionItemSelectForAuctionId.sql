create PROC [dbo].[AuctionItemSelectForAuctionId] 
    @AuctionId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [AuctionItemId], [ItemTypeId], [Name], [Description], [AuctionId], [Auctioned], [BidId] 
	FROM   [dbo].[AuctionItem] 
	WHERE  ([AuctionItemId] = @AuctionId OR @AuctionId IS NULL) 

	COMMIT
