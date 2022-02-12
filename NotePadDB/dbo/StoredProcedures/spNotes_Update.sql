CREATE PROCEDURE [dbo].[spNotes_Update]
	@Id int,
	@Description nvarchar(500)

AS
begin
	set nocount on;

	update dbo.[Notes]
	set [Description] = @Description
	where Id = @Id;
end
