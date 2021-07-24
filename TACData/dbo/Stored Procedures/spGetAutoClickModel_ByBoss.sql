CREATE PROCEDURE [dbo].[spGetAutoClickModel_ByBoss]
	@Boss nvarchar(20)
AS
begin
	select *
	from AutoClickModels
	where Boss = @Boss
end
