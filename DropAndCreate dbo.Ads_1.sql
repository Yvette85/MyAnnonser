USE [AnnonserDB]
GO

/****** Object: Table [dbo].[Ads] Script Date: 2019-02-11 19:53:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Ads];


GO
CREATE TABLE [dbo].[Ads] (
    [AdId]         Uniqueidentifier          NOT NULL,
    [AdHeadline]   VARCHAR (255) NOT NULL,
    [AdText]       VARCHAR (255) NOT NULL,
    [AdvertiserId] INT           NOT NULL
);


