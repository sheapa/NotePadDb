CREATE PROCEDURE [dbo].[spNotes_Delete]
	@Id int
AS
begin
	set nocount on;

	delete
	from dbo.[Notes]
	where Id =@Id;

end
