CREATE TABLE [dbo].[AuctionItemType] (
    [ItemTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_AuctionItemType] PRIMARY KEY CLUSTERED ([ItemTypeId] ASC)
);

