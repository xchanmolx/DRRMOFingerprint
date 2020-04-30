CREATE PROCEDURE [dbo].[spPersonInfo_InsertInfo]
	@PersonId INT,
	@NickName NVARCHAR(50),
	@CivilStatus NVARCHAR(50),
	@BirthPlace NVARCHAR(150),
	@Height NVARCHAR(50),
	@Weight NVARCHAR(50),
	@Religion NVARCHAR(50),
	@IdentifyingMarks NVARCHAR(150),
	@DateAdded NVARCHAR(150),
	@Age INT
AS
BEGIN
	INSERT INTO dbo.PersonInfo (PersonId, Nickname, CivilStatus, BirthPlace, Height, Weight, Religion, IdentifyingMarks, DateAdded, Age)
	VALUES (@PersonId, @NickName, @CivilStatus, @BirthPlace, @Height, @Weight, @Religion, @IdentifyingMarks, @DateAdded, @Age);
END
