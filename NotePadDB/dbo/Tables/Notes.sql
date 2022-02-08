CREATE TABLE [dbo].[Notes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [Status] BIT NOT NULL, 
    [NoteDate] DATETIME2 NOT NULL
)
