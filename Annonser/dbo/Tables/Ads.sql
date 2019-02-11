CREATE TABLE [dbo].[Ads] (
    [AdId]         INT           NOT NULL,
    [AdHeadline]   VARCHAR (255) NOT NULL,
    [AdText]       VARCHAR (255) NOT NULL,
    [AdvertiserId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([AdId] ASC),
    FOREIGN KEY ([AdvertiserId]) REFERENCES [dbo].[Advertisers] ([AdvertiserId])
);

