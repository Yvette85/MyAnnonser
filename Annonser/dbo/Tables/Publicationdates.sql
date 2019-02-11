CREATE TABLE [dbo].[Publicationdates] (
    [AdId] INT      NOT NULL,
    [Date] DATETIME NOT NULL,
    FOREIGN KEY ([AdId]) REFERENCES [dbo].[Ads] ([AdId])
);

