CREATE PROC [dbo].[AuctionItemTypeDelete] 
    @ItemTypeId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[AuctionItemType]
	WHERE  [ItemTypeId] = @ItemTypeId

	COMMIT
