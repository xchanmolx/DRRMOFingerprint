CREATE PROCEDURE [dbo].[spFingerprint_SelectAllFingerprint]
AS
BEGIN
	SELECT * FROM dbo.Fingerprint ORDER BY Id DESC;
END
