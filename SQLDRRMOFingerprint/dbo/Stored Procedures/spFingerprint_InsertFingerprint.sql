CREATE PROCEDURE [dbo].[spFingerprint_InsertFingerprint]
	@PersonId INT,
	@FingerprintPerson VARBINARY(MAX)
AS
BEGIN
	INSERT INTO dbo.Fingerprint (PersonId, FingerprintPerson)
	VALUES (@PersonId, @FingerprintPerson);
END
