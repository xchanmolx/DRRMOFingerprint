CREATE TABLE [dbo].[Fingerprint]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [FingerprintPerson] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [FK_Fingerprint_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
