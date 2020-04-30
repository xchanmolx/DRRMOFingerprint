CREATE PROCEDURE [dbo].[spAccount_SelectAllAccount]
AS
BEGIN
	SELECT * FROM dbo.Account ORDER BY Id DESC;
END
