CREATE PROCEDURE [dbo].[spPerson_FilterByLastName]
	@LastName NVARCHAR(50)
AS
BEGIN
	SELECT [Id], [FirstName], [MiddleName], [LastName], [ExtensionName], [DateOfBirth], [Gender], [Remarks], [StringImage]
	FROM dbo.Person
	WHERE LastName = @LastName;
END
