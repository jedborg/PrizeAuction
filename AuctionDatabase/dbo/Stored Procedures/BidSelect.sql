CREATE PROC [dbo].[BidSelect] 
    @BidId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [BidId], [PersonId], [AuctionItemId], [BidAmount] 
	FROM   [dbo].[Bid] 
	WHERE  ([BidId] = @BidId OR @BidId IS NULL) 

	COMMIT
