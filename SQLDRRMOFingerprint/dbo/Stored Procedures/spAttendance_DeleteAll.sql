CREATE PROCEDURE [dbo].[spAttendance_DeleteAll]
AS
BEGIN
	DELETE FROM dbo.Attendance;
END