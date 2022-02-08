/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select * from dbo.Notes)
begin
    insert into dbo.Notes(TITLE, [Description], [Status], NoteDate)
    values ('C# Class', 'Read about OOP', 1, '2022-02-10 12:35:29.1234567'),
    ('.Net Class', 'Create a website using Razor Pages', 0, '2022-02-11 12:35:29.1234567'),
    ('Azure Class', 'Deploy your new website', 1, '2022-02-12 12:35:29.1234567')
end