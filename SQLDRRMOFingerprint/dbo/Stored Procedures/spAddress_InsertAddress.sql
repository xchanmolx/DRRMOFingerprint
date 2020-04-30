CREATE PROCEDURE [dbo].[spAddress_InsertAddress]
	@PersonId INT,
	@HomeAddress NVARCHAR(25),
	@Town NVARCHAR(150),
	@Barangay NVARCHAR(50),
	@Sitio NVARCHAR(50),
	@Province NVARCHAR(50),
	@Country NVARCHAR(50),
	@ZipCode NVARCHAR(30)
AS
BEGIN 
	INSERT INTO dbo.Address (PersonId, HomeAddress, Town, Barangay, Sitio, Province, Country, ZipCode)
	VALUES (@PersonId, @HomeAddress, @Town, @Barangay, @Sitio, @Province, @Country, @ZipCode);
END
