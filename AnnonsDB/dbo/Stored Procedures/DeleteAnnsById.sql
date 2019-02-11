
Create Procedure  [dbo].[DeleteAnnsById]

(
@AdId int

)
as begin 
Delete from [dbo].[Ads] where AdId=@AdId
End