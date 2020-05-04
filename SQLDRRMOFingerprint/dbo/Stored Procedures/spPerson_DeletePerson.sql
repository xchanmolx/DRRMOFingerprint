CREATE PROCEDURE [dbo].[spPerson_DeletePerson]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Person WHERE Id = @Id;
END