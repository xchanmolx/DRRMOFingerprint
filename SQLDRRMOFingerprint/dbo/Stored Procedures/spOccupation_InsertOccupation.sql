CREATE PROCEDURE [dbo].[spOccupation_InsertOccupation]
	@PersonId INT,
	@WorkPosition NVARCHAR(150),
	@WorkAddress NVARCHAR(250),
	@WorkPhoneNumber NVARCHAR(200),
	@Organization NVARCHAR(150),
	@Designation NVARCHAR(150),
	@OfficeName NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.Occupation (PersonId, WorkPosition, WorkAddress, WorkPhoneNumber, Organization, Designation, OfficeName)
	VALUES (@PersonId, @WorkPosition, @WorkAddress, @WorkPhoneNumber, @Organization, @Designation, @OfficeName);
END
