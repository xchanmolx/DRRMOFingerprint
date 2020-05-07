CREATE PROCEDURE [dbo].[spAttendance_Insert]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Gender NVARCHAR(50),
	@OfficeName NVARCHAR(100),
	@Designation NVARCHAR(100),
	@LocalDate NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Attendance (FirstName, LastName, Gender, OfficeName, Designation, LocalDate)
	VALUES (@FirstName, @LastName, @Gender, @OfficeName, @Designation, @LocalDate);
END