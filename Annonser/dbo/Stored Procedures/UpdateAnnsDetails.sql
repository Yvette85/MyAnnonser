Create Procedure  [dbo].[UpdateAnnsDetails]
(
@AdId int ,
@Adheadline varchar(255),
@AdText varchar(255),
@AdvertiersId int
)
As
begin
Update Ads

set
Adheadline= @Adheadline,
AdText = @AdText

Where AdId= @AdId
End