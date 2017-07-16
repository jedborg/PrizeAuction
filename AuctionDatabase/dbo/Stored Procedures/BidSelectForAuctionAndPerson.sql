
CREATE PROC [dbo].[BidSelectForAuctionAndPerson] 
    @AuctionId int,
	@PersonId int
AS 


	SELECT *
	FROM   BidView 
	WHERE  AuctionId = @AuctionId
	and PersonId = @PersonId



