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
--IF NOT EXISTS (SELECT * FROM dbo.Person WHERE FirstName = 'Demo' and LastName = 'User')
--BEGIN
--    INSERT INTO dbo.Person (FirstName, MiddleName, LastName, ExtensionName, DateOfBirth, Gender, StringImage)
--    VALUES ('Demo','', 'User', '', '', '', '');
--END