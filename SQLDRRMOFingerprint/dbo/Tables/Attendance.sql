CREATE TABLE [dbo].[Attendance]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [OfficeName] NVARCHAR(100) NULL, 
    [Designation] NVARCHAR(100) NULL, 
    [LocalDate] NVARCHAR(50) NULL, 
    [Signature] VARBINARY(MAX) NULL,
)
