USE [AnnonserDB]
GO

/****** Object: SqlProcedure [dbo].[AddNewAnnons] Script Date: 2019-02-10 20:11:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[AddNewAnnons]
(
 @AdId int,
 @AdHeadline varchar(255),
 @AdText varchar(255) 
   
)
as
Begin
Insert into [AnnonserDB].[dbo].[Ads] Values (@AdId,@AdHeadline,@AdText)
End
