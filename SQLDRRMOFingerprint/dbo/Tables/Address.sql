CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [HomeAddress] NVARCHAR(250) NULL, 
    [Town] NVARCHAR(150) NULL, 
    [Barangay] NVARCHAR(50) NULL, 
    [Sitio] NVARCHAR(50) NULL, 
    [Province] NVARCHAR(50) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [ZipCode] NVARCHAR(30) NULL, 
    CONSTRAINT [FK_Address_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE
)
