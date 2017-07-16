CREATE TABLE [dbo].[Person] (
    [PersonId]    INT          IDENTITY (1, 1) NOT NULL,
    [Active]      BIT          NOT NULL,
    [FirstName]   VARCHAR (50) NOT NULL,
    [LastName]    VARCHAR (50) NOT NULL,
    [MobilePhone] VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

