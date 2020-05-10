CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [PhoneNumber] NVARCHAR(200) NULL, 
    [EmailAddress] NVARCHAR(250) NULL, 
    CONSTRAINT [FK_Contact_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
