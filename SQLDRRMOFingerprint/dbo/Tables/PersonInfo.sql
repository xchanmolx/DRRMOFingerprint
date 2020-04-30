CREATE TABLE [dbo].[PersonInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [Nickname] NVARCHAR(50) NULL, 
    [CivilStatus] NVARCHAR(50) NULL, 
    [BirthPlace] NVARCHAR(150) NULL, 
    [Height] NVARCHAR(50) NULL, 
    [Weight] NVARCHAR(50) NULL, 
    [Religion] NVARCHAR(50) NULL, 
    [IdentifyingMarks] NVARCHAR(150) NULL, 
    [DateAdded] NVARCHAR(150) NULL, 
    [Age] INT NULL, 
    CONSTRAINT [FK_PersonInfo_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
