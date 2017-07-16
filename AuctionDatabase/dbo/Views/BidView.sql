
CREATE view [dbo].[BidView]
as
select
	
	p.FirstName + ' ' + p.LastName BidderName,
	p.MobilePhone BidderMobilePhone,

	ai.Description AuctionItemDescription,
	ai.Name AuctionItemName,

	ait.Name AuctionItemTypeName,

	a.AuctionId,
	a.Description AuctionDescription,
	a.Name AuctionName,
	a.Active AuctionActive,

	b.*

from
	Bid b
	join Person p on b.PersonId = p.PersonId
	join AuctionItem ai on b.AuctionItemId = ai.AuctionItemId
	join AuctionItemType ait on ai.ItemTypeId = ait.ItemTypeId
	join Auction a on ai.AuctionId = a.AuctionId
	
