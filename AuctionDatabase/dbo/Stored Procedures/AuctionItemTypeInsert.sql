CREATE PROC [dbo].[AuctionItemTypeInsert] 
    @Name varchar(50)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[AuctionItemType] ([Name])
	SELECT @Name
	
	-- Begin Return Select <- do not remove
	SELECT [ItemTypeId], [Name]
	FROM   [dbo].[AuctionItemType]
	WHERE  [ItemTypeId] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
