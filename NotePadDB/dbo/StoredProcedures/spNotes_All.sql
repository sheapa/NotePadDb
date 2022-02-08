CREATE PROCEDURE [dbo].[spNotes_All]
	@Id int
AS
begin
	set nocount on;

	select [Id], [TITLE], [Description], [Status], [NoteDate]
	from dbo.[Notes]
	where Id = @Id;
end
