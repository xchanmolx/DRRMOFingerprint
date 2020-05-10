CREATE TABLE [dbo].[Occupation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [WorkPosition] NVARCHAR(150) NULL, 
    [WorkAddress] NVARCHAR(250) NULL, 
    [WorkPhoneNumber] NVARCHAR(200) NULL, 
    [Organization] NVARCHAR(150) NULL, 
    [Designation] NVARCHAR(150) NULL, 
    [OfficeName] NVARCHAR(100) NULL, 
    CONSTRAINT [FK_Occupation_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
