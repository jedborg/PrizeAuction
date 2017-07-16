CREATE PROC [dbo].[AuctionItemSelect] 
    @AuctionItemId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [AuctionItemId], [ItemTypeId], [Name], [Description], [AuctionId], [Auctioned], [BidId] 
	FROM   [dbo].[AuctionItem] 
	WHERE  ([AuctionItemId] = @AuctionItemId OR @AuctionItemId IS NULL) 

	COMMIT
