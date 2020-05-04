CREATE PROCEDURE [dbo].[spAccount_Update]
	@Id INT,
	@FirstName NVARCHAR(150),
	@LastName NVARCHAR(150),
	@Username NVARCHAR(250),
	@Password NVARCHAR(250),
	@StringImage NVARCHAR(MAX)
AS
BEGIN
	UPDATE dbo.Account SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Password = @Password, StringImage = @StringImage WHERE Id = @Id;
END