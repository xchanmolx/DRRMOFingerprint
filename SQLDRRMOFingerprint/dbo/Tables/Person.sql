CREATE TABLE [dbo].[Person] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (50)   NOT NULL,
    [MiddleName]    NVARCHAR (50)   NULL,
    [LastName]      NVARCHAR (50)   NOT NULL,
    [ExtensionName] NVARCHAR (50)   NULL,
    [DateOfBirth]   NVARCHAR (50)   NULL,
    [Gender]        NVARCHAR (20)   NULL,
    [StringImage]   NVARCHAR (MAX)  NULL,
    [Remarks] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


