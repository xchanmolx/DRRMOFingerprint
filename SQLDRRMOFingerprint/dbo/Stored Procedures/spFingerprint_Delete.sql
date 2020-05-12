CREATE PROCEDURE [dbo].[spFingerprint_Delete]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Fingerprint WHERE Id = @Id;
END