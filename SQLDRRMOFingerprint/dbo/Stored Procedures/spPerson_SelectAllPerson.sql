CREATE PROCEDURE [dbo].[spPerson_SelectAllPerson]
AS
BEGIN
	SELECT * FROM dbo.Person ORDER BY Id DESC;
END
