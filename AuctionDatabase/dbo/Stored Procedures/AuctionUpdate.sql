CREATE PROC [dbo].[AuctionUpdate] 
    @AuctionId int,
    @Active bit,
    @Name varchar(50),
    @Description varchar(255)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Auction]
	SET    [Active] = @Active, [Name] = @Name, [Description] = @Description
	WHERE  [AuctionId] = @AuctionId
	
	/*-- Begin Return Select <- do not remove
	SELECT [AuctionId], [Active], [Name], [Description]
	FROM   [dbo].[Auction]
	WHERE  [AuctionId] = @AuctionId	
	-- End Return Select <- do not remove*/

	COMMIT
