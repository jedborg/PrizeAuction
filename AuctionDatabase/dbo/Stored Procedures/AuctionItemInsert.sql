CREATE PROC [dbo].[AuctionItemInsert] 
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
	
	INSERT INTO [dbo].[AuctionItem] ([ItemTypeId], [Name], [Description], [AuctionId], [Auctioned], [BidId])
	SELECT @ItemTypeId, @Name, @Description, @AuctionId, @Auctioned, @BidId
	
	-- Begin Return Select <- do not remove
	SELECT [AuctionItemId], [ItemTypeId], [Name], [Description], [AuctionId], [Auctioned], [BidId]
	FROM   [dbo].[AuctionItem]
	WHERE  [AuctionItemId] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
