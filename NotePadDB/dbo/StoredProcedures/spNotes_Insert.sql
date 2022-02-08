CREATE PROCEDURE [dbo].[spNotes_Insert]
	@Title nvarchar(50),
	@Description nvarchar(max),
	@Status bit,
	@NoteDate datetime2(7),
	@Id int output
AS
begin
	set nocount on;

	insert into dbo.[Notes](Title, [Description], [Status], NoteDate)
	VALUES (@Title, @Description, @Status, @NoteDate);

	set @Id = SCOPE_IDENTITY();
end
