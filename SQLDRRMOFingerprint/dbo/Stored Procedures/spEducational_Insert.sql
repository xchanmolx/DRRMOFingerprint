CREATE PROCEDURE [dbo].[spEducational_Insert]
	@PersonId INT,
	@LevelOfEducation NVARCHAR(150),
	@NameOfSchool NVARCHAR(250)
AS
BEGIN
	INSERT INTO dbo.Educational (PersonId, LevelOfEducation, NameOfSchool)
	VALUES (@PersonId, @LevelOfEducation, @NameOfSchool);
END
