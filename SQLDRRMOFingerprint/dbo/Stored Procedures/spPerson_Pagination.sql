CREATE PROCEDURE [dbo].[spPerson_Pagination]
	@PageNumber INT,
	@PageSize INT
AS
BEGIN
	SELECT * FROM dbo.Person
	ORDER BY Id DESC
	OFFSET (@PageNumber - 1) * @PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY;
END
