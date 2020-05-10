CREATE PROCEDURE [dbo].[spOccupation_Update]
	@PersonId INT,
	@WorkPosition NVARCHAR(150),
	@WorkAddress NVARCHAR(250),
	@WorkPhoneNumber NVARCHAR(200),
	@Organization NVARCHAR(150),
	@Designation NVARCHAR(150),
	@OfficeName NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Occupation SET WorkPosition = @WorkPosition, WorkAddress = @WorkAddress, WorkPhoneNumber = @WorkPhoneNumber, Organization = @Organization, Designation = @Designation, OfficeName = @OfficeName WHERE PersonId = @PersonId;
END