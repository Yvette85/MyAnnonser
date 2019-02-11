Create Procedure  [dbo].[GetAllAds1]
as
begin
select AdId, Adheadline,AdText, AdvertiserId from [dbo].[Ads]
End
