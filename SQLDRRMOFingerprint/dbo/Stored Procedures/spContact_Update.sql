CREATE PROCEDURE [dbo].[spContact_Update]
	@PersonId INT,
	@PhoneNumber NVARCHAR(20),
	@EmailAddress NVARCHAR(250)
AS
BEGIN
	UPDATE dbo.Contact SET PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress WHERE PersonId = @PersonId;
END