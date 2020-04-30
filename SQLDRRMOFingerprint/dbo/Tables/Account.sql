CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(150) NOT NULL, 
    [LastName] NVARCHAR(150) NOT NULL, 
    [Username] NVARCHAR(250) NOT NULL, 
    [Password] NVARCHAR(250) NOT NULL, 
    [StringImage] NVARCHAR(MAX) NULL 
)
