CREATE PROC [dbo].[AuctionItemDelete] 
    @AuctionItemId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[AuctionItem]
	WHERE  [AuctionItemId] = @AuctionItemId

	COMMIT
