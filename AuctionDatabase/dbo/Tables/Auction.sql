CREATE TABLE [dbo].[Auction] (
    [AuctionId]   INT           IDENTITY (1, 1) NOT NULL,
    [Active]      BIT           NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Auction] PRIMARY KEY CLUSTERED ([AuctionId] ASC)
);

