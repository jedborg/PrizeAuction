CREATE TABLE [dbo].[Bid] (
    [BidId]         INT   IDENTITY (1, 1) NOT NULL,
    [PersonId]      INT   NOT NULL,
    [AuctionItemId] INT   NOT NULL,
    [BidAmount]     MONEY NOT NULL,
    CONSTRAINT [PK_PersonAuctionBank] PRIMARY KEY CLUSTERED ([BidId] ASC),
    CONSTRAINT [FK_Bid_AuctionItem] FOREIGN KEY ([AuctionItemId]) REFERENCES [dbo].[AuctionItem] ([AuctionItemId]),
    CONSTRAINT [FK_Bid_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);

