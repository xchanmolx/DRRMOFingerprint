CREATE PROCEDURE [dbo].[spAccount_InsertAccount]
	@FirstName NVARCHAR(150),
	@LastName NVARCHAR(150),
	@Username NVARCHAR(250),
	@Password NVARCHAR(250),
	@StringImage NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO dbo.Account (FirstName, LastName, Username, Password, StringImage)
	VALUES (@FirstName, @LastName, @Username, @Password, @StringImage);
END
