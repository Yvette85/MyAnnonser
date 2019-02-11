Create Procedure  [dbo].[GetAllAds2]
as
begin
select AdId, Adheadline,AdText, AdvertiserId from [dbo].[Ads]
End