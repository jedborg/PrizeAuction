CREATE TABLE [dbo].[AuctionItem] (
    [AuctionItemId] INT           IDENTITY (1, 1) NOT NULL,
    [ItemTypeId]    INT           NOT NULL,
    [Name]          VARCHAR (50)  NOT NULL,
    [Description]   VARCHAR (255) NOT NULL,
    [AuctionId]     INT           NOT NULL,
    [Auctioned]     BIT           NOT NULL,
    [BidId]         INT           NULL,
    CONSTRAINT [PK_AuctionItem] PRIMARY KEY CLUSTERED ([AuctionItemId] ASC),
    CONSTRAINT [FK_AuctionItem_Auction] FOREIGN KEY ([AuctionId]) REFERENCES [dbo].[Auction] ([AuctionId]),
    CONSTRAINT [FK_AuctionItem_AuctionItemType] FOREIGN KEY ([ItemTypeId]) REFERENCES [dbo].[AuctionItemType] ([ItemTypeId]),
    CONSTRAINT [FK_AuctionItem_Bid] FOREIGN KEY ([BidId]) REFERENCES [dbo].[Bid] ([BidId])
);

