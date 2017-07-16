CREATE PROC [dbo].[AuctionItemTypeUpdate] 
    @ItemTypeId int,
    @Name varchar(50)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[AuctionItemType]
	SET    [Name] = @Name
	WHERE  [ItemTypeId] = @ItemTypeId
	
	/*-- Begin Return Select <- do not remove
	SELECT [ItemTypeId], [Name]
	FROM   [dbo].[AuctionItemType]
	WHERE  [ItemTypeId] = @ItemTypeId	
	-- End Return Select <- do not remove*/

	COMMIT
