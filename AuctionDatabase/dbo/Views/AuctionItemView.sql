CREATE view AuctionItemView
as

select 
	
	ait.Name AuctionItemTypeName,

	a.Description AuctionDescription,
	a.Name AuctionName,
	a.Active AuctionActive,

	b.PersonId BidPersonId,
	b.BidAmount,

	isnull(p.FirstName, '') + ' ' + isnull(p.LastName, '') BidderName,
	isnull(p.MobilePhone, '') BidderMobilePhone,


	ai.*
from
	AuctionItem ai
	join AuctionItemType ait on ai.ItemTypeId = ait.ItemTypeId
	join Auction a on ai.AuctionId = a.AuctionId
	left join Bid b on ai.BidId = b.BidId
	left join Person p on b.PersonId = p.PersonId
	
	
