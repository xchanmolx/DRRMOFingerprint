CREATE PROCEDURE [dbo].[spContact_InsertContact]
	@PersonId INT,
	@PhoneNumber NVARCHAR(20),
	@EmailAddress NVARCHAR(250)
AS
BEGIN
	INSERT INTO dbo.Contact (PersonId, PhoneNumber, EmailAddress)
	VALUES (@PersonId, @PhoneNumber, @EmailAddress);
END
