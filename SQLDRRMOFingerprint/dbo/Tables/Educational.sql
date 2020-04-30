CREATE TABLE [dbo].[Educational]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [LevelOfEducation] NVARCHAR(150) NULL, 
    [NameOfSchool] NVARCHAR(250) NULL, 
    CONSTRAINT [FK_Educational_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
