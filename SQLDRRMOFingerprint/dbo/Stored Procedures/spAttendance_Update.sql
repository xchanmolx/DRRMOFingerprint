CREATE PROCEDURE [dbo].[spAttendance_Update]
	@Id INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Gender NVARCHAR(50),
	@OfficeName NVARCHAR(100),
	@Designation NVARCHAR(100),
	@LocalDate NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Attendance SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, OfficeName = @OfficeName, Designation = @Designation, LocalDate = @LocalDate WHERE Id = @Id;
END
