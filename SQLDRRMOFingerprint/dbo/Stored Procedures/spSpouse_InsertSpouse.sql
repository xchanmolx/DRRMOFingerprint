CREATE PROCEDURE [dbo].[spSpouse_InsertSpouse]
	@PersonId INT,
	@NameOfSpouse NVARCHAR(50),
	@NameOfChildren NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO dbo.Spouse (PersonId, NameOfSpouse, NameOfChildren)
	VALUES (@PersonId, @NameOfSpouse, @NameOfChildren);
END
