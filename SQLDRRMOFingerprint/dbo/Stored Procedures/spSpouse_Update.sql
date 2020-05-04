CREATE PROCEDURE [dbo].[spSpouse_Update]
	@PersonId INT,
	@NameOfSpouse NVARCHAR(50),
	@NameOfChildren NVARCHAR(MAX)
AS
BEGIN 
	UPDATE dbo.Spouse SET NameOfSpouse = @NameOfSpouse, NameOfChildren = @NameOfChildren WHERE PersonId = @PersonId;
END