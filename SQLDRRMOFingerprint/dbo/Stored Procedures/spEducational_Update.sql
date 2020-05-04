CREATE PROCEDURE [dbo].[spEducational_Update]
	@PersonId INT,
	@LevelOfEducation NVARCHAR(150),
	@NameOfSchool NVARCHAR(250)
AS
BEGIN
	UPDATE dbo.Educational SET LevelOfEducation = @LevelOfEducation, NameOfSchool = @NameOfSchool WHERE PersonId = @PersonId;
END