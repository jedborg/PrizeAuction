CREATE view BankView
as
select
	a.Name AuctionName,
	a.Description AuctionDescription,

	isnull(p.FirstName, '') + ' ' + isnull(p.LastName, '') AuctionToName,
	isnull(p.MobilePhone, '') AuctionToMobilePhone,

	b.*
from
	Bank b
	join Person p on b.PersonId = p.PersonId
	join Auction a on b.AuctionId = a.AuctionId