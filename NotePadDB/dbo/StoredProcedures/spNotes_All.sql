CREATE PROCEDURE [dbo].[spNotes_All]
	
AS
begin
	set nocount on;

	select [Id], [Title], [Description], [Status], [NoteDate]
	from dbo.[Notes]
	
end
