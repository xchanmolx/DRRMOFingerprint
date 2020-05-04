CREATE PROCEDURE [dbo].[spPersonInfo_Update]
	@PersonId INT,
	@Nickname NVARCHAR(50),
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
	UPDATE dbo.PersonInfo SET Nickname = @Nickname, CivilStatus = @CivilStatus, BirthPlace = @BirthPlace, Height = @Height, Weight = @Weight, Religion = @Religion, IdentifyingMarks = @IdentifyingMarks, DateAdded = @DateAdded, Age = @Age WHERE PersonId = @PersonId;
END
