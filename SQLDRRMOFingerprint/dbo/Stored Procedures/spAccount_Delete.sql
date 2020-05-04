CREATE PROCEDURE [dbo].[spAccount_Delete]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Account WHERE Id = @Id;
END
