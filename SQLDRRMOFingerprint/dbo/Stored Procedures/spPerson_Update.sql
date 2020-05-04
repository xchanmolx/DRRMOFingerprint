CREATE PROCEDURE [dbo].[spPerson_Update]
	@Id INT,
	@FirstName NVARCHAR(50),
	@MiddleName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@ExtensionName NVARCHAR(50),
	@DateOfBirth NVARCHAR(50),
	@Gender NVARCHAR(20),
	@Remarks NVARCHAR(MAX),
	@StringImage NVARCHAR(MAX)
AS
BEGIN
	UPDATE dbo.Person SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, ExtensionName = @ExtensionName, DateOfBirth = @DateOfBirth, Gender = @Gender, Remarks = @Remarks, StringImage = @StringImage WHERE Id = @Id;
END