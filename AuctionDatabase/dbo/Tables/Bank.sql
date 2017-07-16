CREATE TABLE [dbo].[Bank] (
    [BankId]    INT   IDENTITY (1, 1) NOT NULL,
    [PersonId]  INT   NOT NULL,
    [AuctionId] INT   NOT NULL,
    [Bank]      MONEY NOT NULL,
    CONSTRAINT [PK_PersonAuctionBank1] PRIMARY KEY CLUSTERED ([BankId] ASC),
    CONSTRAINT [FK_PersonAuctionBank1_Auction] FOREIGN KEY ([AuctionId]) REFERENCES [dbo].[Auction] ([AuctionId]),
    CONSTRAINT [FK_PersonAuctionBank1_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);

