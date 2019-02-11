Create procedure [dbo].[AddNewAnnons]
(
@AdId int,
 @AdHeadline varchar(255),
 @AdText varchar(255) ,
 @AdvertiserId int 
)
as
Begin
Insert into [AnnonsDB].[dbo].[Ads] Values (@AdId,@AdHeadline,@AdText,@AdvertiserId)
End