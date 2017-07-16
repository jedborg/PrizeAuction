CREATE PROC [dbo].[AuctionItemTypeSelect] 
    @ItemTypeId int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [ItemTypeId], [Name] 
	FROM   [dbo].[AuctionItemType] 
	WHERE  ([ItemTypeId] = @ItemTypeId OR @ItemTypeId IS NULL) 

	COMMIT
