CREATE PROCEDURE [dbo].[sp_UpdateStatus]
	@Id int,
	@Status bit

AS
begin
	set nocount on;

	update dbo.[Notes]
	set [Status] = @STatus
	where Id = @Id;
end
