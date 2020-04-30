CREATE TABLE [dbo].[Spouse]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [NameOfSpouse] NVARCHAR(50) NULL, 
    [NameOfChildren] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Spouse_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
