CREATE PROC [dbo].[BidDelete] 
    @BidId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Bid]
	WHERE  [BidId] = @BidId

	COMMIT
