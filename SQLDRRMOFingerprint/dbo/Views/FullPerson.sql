CREATE VIEW [dbo].[FullPerson]
	AS 
	SELECT [p].[Id], [p].[FirstName], [p].[MiddleName], [p].[LastName], [p].[ExtensionName], [p].[DateOfBirth], [p].[Gender], [p].[StringImage], 
	[a].[Id] AS AddressId, [a].[PersonId], [a].[HomeAddress], [a].[Town], [a].[Barangay], [a].[Sitio], [a].[Province], [a].[Country], [a].[ZipCode]
	FROM dbo.Person p
	LEFT JOIN dbo.Address a ON p.Id = a.PersonId
