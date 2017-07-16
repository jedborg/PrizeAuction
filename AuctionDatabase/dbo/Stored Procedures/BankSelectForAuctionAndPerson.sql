
CREATE PROC [dbo].[BankSelectForAuctionAndPerson] 
    @AuctionId int,
	@PersonId int
AS 


	select
		*
	from
		BankView bv
	where
		bv.AuctionId = @AuctionId
		and bv.PersonId = @PersonId
		



