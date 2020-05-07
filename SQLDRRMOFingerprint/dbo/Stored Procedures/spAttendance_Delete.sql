CREATE PROCEDURE [dbo].[spAttendance_Delete]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Attendance WHERE Id = @Id;
END