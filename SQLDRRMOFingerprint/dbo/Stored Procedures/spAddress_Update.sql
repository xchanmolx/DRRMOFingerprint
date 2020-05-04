CREATE PROCEDURE [dbo].[spAddress_Update]
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
	UPDATE dbo.Address SET HomeAddress = @HomeAddress, Town = @Town, Barangay = @Barangay, Sitio = @Sitio, Province = @Province, Country = @Country, ZipCode = @ZipCode WHERE PersonId = @PersonId;
END