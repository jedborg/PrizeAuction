CREATE PROC [dbo].[AuctionSelect] 
    @AuctionId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [AuctionId], [Active], [Name], [Description] 
	FROM   [dbo].[Auction] 
	WHERE  ([AuctionId] = @AuctionId OR @AuctionId IS NULL) 

	COMMIT
