CREATE PROC [dbo].[AuctionItemUpdate] 
    @AuctionItemId int,
    @ItemTypeId int,
    @Name varchar(50),
    @Description varchar(255),
    @AuctionId int,
    @Auctioned bit,
    @BidId int = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[AuctionItem]
	SET    [ItemTypeId] = @ItemTypeId, [Name] = @Name, [Description] = @Description, [AuctionId] = @AuctionId, [Auctioned] = @Auctioned, [BidId] = @BidId
	WHERE  [AuctionItemId] = @AuctionItemId
	
	/*-- Begin Return Select <- do not remove
	SELECT [AuctionItemId], [ItemTypeId], [Name], [Description], [AuctionId], [Auctioned], [BidId]
	FROM   [dbo].[AuctionItem]
	WHERE  [AuctionItemId] = @AuctionItemId	
	-- End Return Select <- do not remove*/

	COMMIT
