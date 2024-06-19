-- Select all for Country Table

-- EXEC [dbo].[PR_LOC_Country_SelectAll]

CREATE PROCEDURE [dbo].[PR_LOC_Country_SelectAll]
AS
BEGIN
	SELECT [dbo].[LOC_Country].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_Country].[CountryCode],
			[dbo].[LOC_Country].[Created],
			[dbo].[LOC_Country].[Modified],
			COUNT([dbo].[LOC_State].[StateID]) AS StateCount

	FROM [dbo].[LOC_Country]

	INNER JOIN [dbo].[LOC_State]
	ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]

	ORDER BY [dbo].[LOC_Country].[CountryName]
END

-- Select by PK from Country Table

-- EXEC [dbo].[PR_LOC_Country_SelectByPK] 1

CREATE PROCEDURE [dbo].[PR_LOC_Country_SelectByPK]
@CountryID INT
AS
BEGIN
	SELECT [dbo].[LOC_Country].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_Country].[CountryCode],
			[dbo].[LOC_Country].[Created],
			[dbo].[LOC_Country].[Modified]

	FROM [dbo].[LOC_Country]

	WHERE [dbo].[LOC_Country].[CountryID] = @CountryID

	ORDER BY [dbo].[LOC_Country].[CountryName]
END

-- Insert for Country Table

-- EXEC [dbo].[PR_LOC_Country_Insert] "India","Gujrat"

CREATE PROCEDURE [dbo].[PR_LOC_Country_Insert]
@CountryName		VARCHAR(100),
@CountryCode		VARCHAR(50)

AS
BEGIN
	
	INSERT INTO [dbo].[LOC_Country]
	(
		[CountryName],
		[CountryCode]
	)
	VALUES
	(
		@CountryName,
		@CountryCode
	)
END

--Update for Country Table

-- EXEC [dbo].[PR_LOC_Country_UpdateByPK] 1,"INDIA","IND"

ALTER PROCEDURE [dbo].[PR_LOC_Country_UpdateByPK]
@CountryID			INT,
@CountryName		VARCHAR(100),
@CountryCode		VARCHAR(50)

AS
BEGIN
	UPDATE [dbo].[LOC_Country]
	SET [CountryName] = @CountryName,
		[CountryCode] = @CountryCode,
		[Modified] = getDate()

	WHERE [CountryID] = @CountryID

END

-- Delete for Country Table

--EXEC [dbo].[PR_LOC_Country_DeleteByPK] 1

CREATE PROCEDURE [dbo].[PR_LOC_Country_DeleteByPK]
@CountryID		INT

AS
BEGIN
	DELETE FROM [dbo].[LOC_Country]
	WHERE [dbo].[LOC_Country].[CountryID] = @CountryID

END


--------------------------------------------------------------------------------------------

--Select All for City table

--EXEC [dbo].[PR_LOC_City_SelectAll]

ALTER PROCEDURE [dbo].[PR_LOC_City_SelectAll]
AS
BEGIN
	SELECT	[dbo].[LOC_City].[CityID],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_City].[CityCode],
			[dbo].[LOC_City].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_City].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_City].[Created],
			[dbo].[LOC_City].[Modified]
		
	FROM [dbo].[LOC_City]

	INNER JOIN [dbo].[LOC_State]
	ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]

	INNER JOIN [dbo].[LOC_Country]
	ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_City].[CountryID]

	ORDER BY [dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_City].[CityName]
END

--Select by PK for City Table

-- EXEC [dbo].[PR_LOC_City_SelectByPK] 2

ALTER PROCEDURE [dbo].[PR_LOC_City_SelectByPK]
@CityID	INT
AS
BEGIN
	SELECT	[dbo].[LOC_City].[CityID],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_City].[CityCode],
			[dbo].[LOC_City].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_City].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_City].[Created],
			[dbo].[LOC_City].[Modified]
		
	FROM [dbo].[LOC_City]

	INNER JOIN [dbo].[LOC_State]
	ON [dbo].[LOC_State].[StateID] = [dbo].[LOC_City].[StateID]

	INNER JOIN [dbo].[LOC_Country]
	ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_City].[CountryID]

	WHERE [dbo].[LOC_City].[CityID] = @CityID

	ORDER BY [dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_City].[CityName]
END

-- Insert for City Table

-- EXEC [dbo].[PR_LOC_City_Insert] "Rajkot","360005",1,1

CREATE PROCEDURE [dbo].[PR_LOC_City_Insert]
@CityName	VARCHAR(100),
@CityCode	VARCHAR(50),
@StateID	INT,
@CountryID	INT

AS
BEGIN

	INSERT INTO [dbo].[LOC_City]
	(
		[CityName],
		[CityCode],
		[StateID],
		[CountryID]
	)

	VALUES
	(
		@CityName,
		@CityCode,
		@StateID,
		@CountryID
	)
END

-- Update for City Table

-- EXEC [dbo].[PR_LOC_City_UpdateByPK] 1,"Rajkot","RJT",1,1

CREATE or ALTER PROCEDURE [dbo].[PR_LOC_City_UpdateByPK]
@CityID		INT,
@CityName	VARCHAR(100),
@CityCode	VARCHAR(50),
@StateID	INT,
@CountryID	INT

AS
BEGIN

	UPDATE [dbo].[LOC_City]
		SET	[CityName] = @CityName,
			[CityCode] = @CityCode,
			[StateID] = @StateID,
			[CountryID] = @CountryID,
			[Modified] = getDate()

		WHERE [dbo].[LOC_City].[CityID] = @CityID
END

--Delete for City table

-- EXEC [dbo].[PR_LOC_City_DeleteByPK] 1

CREATE OR ALTER PROCEDURE [dbo].[PR_LOC_City_DeleteByPK]
@CityID		INT 

AS
BEGIN

	DELETE
		FROM [dbo].[LOC_City]
		WHERE [dbo].[LOC_City].[CityID] = @CityID
END


------------------------------------------------------------------------------------------------

-- Select All for State Table

-- EXEC [dbo].[PR_LOC_State_SelectAll]

CREATE PROCEDURE [dbo].[PR_LOC_State_SelectAll]
AS
BEGIN
	SELECT	[dbo].[LOC_State].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_State].[StateCode],
			[dbo].[LOC_State].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[Created],
			[dbo].[LOC_State].[Modified]
		
	FROM [dbo].[LOC_State]
	INNER JOIN  [dbo].[LOC_Country]
	ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]

	ORDER BY [dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[StateName]
END

-- Select by PK for State table

-- EXEC [dbo].[PR_LOC_State_SelectByPK] 1

CREATE PROCEDURE [dbo].[PR_LOC_State_SelectByPK]
@StateID	INT 

AS
BEGIN

	SELECT	[dbo].[LOC_State].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_State].[StateCode],
			[dbo].[LOC_State].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[Created],
			[dbo].[LOC_State].[Modified]

	FROM [dbo].[LOC_State]
	INNER JOIN [dbo].[LOC_Country]
	ON [dbo].[LOC_Country].[CountryID] = [dbo].[LOC_State].[CountryID]

	WHERE [dbo].[LOC_State].[StateID] = @StateID

	ORDER BY [dbo].[LOC_Country].[CountryName],
			[dbo].[LOC_State].[StateName]
END

-- Insert for State table

-- EXEC [dbo].[PR_LOC_State_Insert] "Gujrat","GUJ",1

CREATE PROCEDURE [dbo].[PR_LOC_State_Insert]
@StateName		VARCHAR(100),
@StateCode		VARCHAR(50),
@CountryID		INT

AS
BEGIN

	INSERT INTO [dbo].[LOC_State]
	(
		[StateName],
		[StateCode],
		[CountryID]
	)

	VALUES 
	(
		@StateName,
		@StateCode,
		@CountryID
	)
END

-- Update for State table

-- EXEC [dbo].[PR_LOC_State_UpdateByPK] 1,"Gujarat","GUJ",1

CREATE or ALTER PROCEDURE [dbo].[PR_LOC_State_UpdateByPK]
@StateID		INT,
@StateName		VARCHAR(100),
@StateCode		VARCHAR(50),
@CountryID		INT

AS
BEGIN
	UPDATE [dbo].[LOC_State]
		SET [StateName] = @StateName,
			[StateCode] = @StateCode,
			[CountryID] = @CountryID,
			[Modified] = getDate()

		WHERE [dbo].[LOC_State].[StateID] = @StateID
END

-- Delete for State table

-- EXEC [dbo].[PR_LOC_State_DeleteByPK] 1

CREATE PROCEDURE [dbo].[PR_LOC_State_DeleteByPK]
@StateID	INT

AS
BEGIN
	DELETE 
	FROM [dbo].[LOC_State]
	WHERE [dbo].[LOC_State].[StateID] = @StateID
END



--------------------------------------------------------------------------------------------------

-- Select All for Branch table

-- EXEC [dbo].[PR_MST_Branch_SelectAll]

CREATE PROCEDURE [dbo].[PR_MST_Branch_SelectAll]
AS
BEGIN 
	SELECT [dbo].[MST_Branch].[BranchID],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[MST_Branch].[BranchCode],
			[dbo].[MST_Branch].[Created],
			[dbo].[MST_Branch].[Modified]

	FROM [dbo].[MST_Branch]

	ORDER BY [dbo].[MST_Branch].[BranchName]
END

-- Select By pk for branch table

-- EXEC [dbo].[PR_MST_Branch_SelectByPK] 1

CREATE PROCEDURE [dbo].[PR_MST_Branch_SelectByPK]
@BranchID int 
AS
BEGIN 
	SELECT [dbo].[MST_Branch].[BranchID],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[MST_Branch].[BranchCode],
			[dbo].[MST_Branch].[Created],
			[dbo].[MST_Branch].[Modified]

	FROM [dbo].[MST_Branch]

	WHERE [dbo].[MST_Branch].[BranchID] = @BranchID

	ORDER BY [dbo].[MST_Branch].[BranchName]
END

-- Insert for branch table

-- EXEC [dbo].[PR_MST_Branch_Insert] "CSE","CE"

CREATE PROCEDURE [dbo].[PR_MST_Branch_Insert]
@BranchName		VARCHAR(100),
@BranchCode		VARCHAR(100)

AS
BEGIN
	INSERT INTO [dbo].[MST_Branch]
	(
		[BranchName],
		[BranchCode]
	)
	VALUES
	(
		@BranchName,
		@BranchCode
	)
END

-- Update for branch table

-- EXEC [dbo].[PR_MST_Branch_UpdateByPK] 1,"Computer","CS"

CREATE PROCEDURE [dbo].[PR_MST_Branch_UpdateByPK]
@BranchID		INT,
@BranchName		VARCHAR(100),
@BranchCode		VARCHAR(100)

AS
BEGIN
	UPDATE [dbo].[MST_Branch]
	SET [BranchName] = @BranchName,
		[BranchCode] = @BranchCode,
		[Modified] = getDate()

	WHERE [dbo].[MST_Branch].[BranchID] = @BranchID

END

-- Delete for branch table

-- EXEC [dbo].[PR_MST_Branch_DeleteByPK] 1

CREATE PROCEDURE [dbo].[PR_MST_Branch_DeleteByPK]
@BranchID INT

AS
BEGIN

	DELETE FROM [dbo].[MST_Branch]

	WHERE [dbo].[MST_Branch].[BranchID] = @BranchID

END


---------------------------------------------------------------------------------------------

-- Select All for Student table

-- EXEC [dbo].[PR_MST_Student_SelectAll]

CREATE PROCEDURE [dbo].[PR_MST_Student_SelectAll]
AS
BEGIN
	SELECT [dbo].[MST_Student].[StudentID],
			[dbo].[MST_Student].[StudentName],
			[dbo].[MST_Student].[BranchID],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[MST_Student].[CityID],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_City].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_State].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[MST_Student].[MobileNoStudent],
			[dbo].[MST_Student].[Email],
			[dbo].[MST_Student].[MobileNoFather],
			[dbo].[MST_Student].[Address],
			[dbo].[MST_Student].[BirthDate],
			[dbo].[MST_Student].[Age],
			[dbo].[MST_Student].[IsActive],
			[dbo].[MST_Student].[Gender],
			[dbo].[MST_Student].[Password],
			[dbo].[MST_Student].[Created],
			[dbo].[MST_Student].[Modified]

	FROM [dbo].[MST_Student]

	INNER JOIN [dbo].[MST_Branch]
	ON [dbo].[MST_Student].[BranchID] = [dbo].[MST_Branch].[BranchID]

	INNER JOIN [dbo].[LOC_City]
	ON [dbo].[MST_Student].[CityID] = [dbo].[LOC_City].[CityID]

	INNER JOIN [dbo].[LOC_State]
	ON [dbo].[LOC_City].[StateID] = [dbo].[LOC_State].[StateID]

	INNER JOIN [dbo].[LOC_Country]
	ON [dbo].[LOC_State].[CountryID] = [dbo].[LOC_Country].[CountryID]

	ORDER BY [dbo].[MST_Student].[StudentName],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_Country].[CountryName]

END

-- Select by pk for student table

-- EXEC [dbo].[PR_MST_Student_SelectbyPK]

ALTER PROCEDURE [dbo].[PR_MST_Student_SelectbyPK]
@StudentID INT

AS
BEGIN
	SELECT [dbo].[MST_Student].[StudentID],
			[dbo].[MST_Student].[StudentName],
			[dbo].[MST_Student].[BranchID],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[MST_Student].[CityID],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_City].[StateID],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_State].[CountryID],
			[dbo].[LOC_Country].[CountryName],
			[dbo].[MST_Student].[MobileNoStudent],
			[dbo].[MST_Student].[Email],
			[dbo].[MST_Student].[MobileNoFather],
			[dbo].[MST_Student].[Address],
			[dbo].[MST_Student].[BirthDate],
			[dbo].[MST_Student].[Age],
			[dbo].[MST_Student].[IsActive],
			[dbo].[MST_Student].[Gender],
			[dbo].[MST_Student].[Password],
			[dbo].[MST_Student].[Created],
			[dbo].[MST_Student].[Modified]

	FROM [dbo].[MST_Student]

	INNER JOIN [dbo].[MST_Branch]
	ON [dbo].[MST_Student].[BranchID] = [dbo].[MST_Branch].[BranchID]

	INNER JOIN [dbo].[LOC_City]
	ON [dbo].[MST_Student].[CityID] = [dbo].[LOC_City].[CityID]

	INNER JOIN [dbo].[LOC_State]
	ON [dbo].[LOC_City].[StateID] = [dbo].[LOC_State].[StateID]

	INNER JOIN [dbo].[LOC_Country]
	ON [dbo].[LOC_State].[CountryID] = [dbo].[LOC_Country].[CountryID]

	WHERE [dbo].[MST_Student].[StudentID] = @StudentID

	ORDER BY [dbo].[MST_Student].[StudentName],
			[dbo].[MST_Branch].[BranchName],
			[dbo].[LOC_City].[CityName],
			[dbo].[LOC_State].[StateName],
			[dbo].[LOC_Country].[CountryName]

END

-- Insert in Student table

-- EXEC [dbo].[PR_MST_Student_Insert] 1,2,"Dipesh","8238965966","dipeshkanzariya534@gmail.com","9979742066","Dhrol","17-APR-04",20,1,"Male","Dipesh@2004"

Alter PROCEDURE [dbo].[PR_MST_Student_Insert]
@BranchID				INT,
@CityID					INT,
@StudentName			VARCHAR(100),
@MobileNoStudent		VARCHAR(100),
@Email					VARCHAR(100),
@MobileNoFather			VARCHAR(100),
@Address				VARCHAR(500),
@BirthDate				DATETIME,
@Age					INT,
@IsActive				BIT,
@Gender					VARCHAR(50),
@Password				VARCHAR(100)

AS
BEGIN
	INSERT INTO [dbo].[MST_Student]
	(
		[BranchID],
		[CityID],
		[StudentName],
		[MobileNoStudent],
		[Email],
		[MobileNoFather],
		[Address],
		[BirthDate],
		[Age],
		[IsActive],
		[Gender],
		[Password]
	)
	VALUES
	(
		@BranchID,
		@CityID,
		@StudentName,
		@MobileNoStudent,
		@Email,
		@MobileNoFather,
		@Address,
		@BirthDate,
		@Age,
		@IsActive,
		@Gender,
		@Password
	)
END

-- Update for Student table 

-- EXEC [dbo].[PR_MST_Student_UpdateByPK] 2,1,2,"Dipesh","8238965966","dipeshkanzariya534@gmail.com","9979742066","Dhrol","17-APR-04",20,1,"Male","Dipesh@17"

CREATE PROCEDURE [dbo].[PR_MST_Student_UpdateByPK]
@StudentID				INT,
@BranchID				INT,
@CityID					INT,
@StudentName			VARCHAR(100),
@MobileNoStudent		VARCHAR(100),
@Email					VARCHAR(100),
@MobileNoFather			VARCHAR(100),
@Address				VARCHAR(500),
@BirthDate				DATETIME,
@Age					INT,
@IsActive				BIT,
@Gender					VARCHAR(50),
@Password				VARCHAR(100)

AS
BEGIN
	UPDATE [dbo].[MST_Student]
	SET [BranchID] = @BranchID,
		[CityID] = @CityID,
		[StudentName] = @StudentName,
		[MobileNoStudent]= @MobileNoStudent,
		[Email] = @Email,
		[MobileNoFather] = @MobileNoFather,
		[Address] = @Address,
		[BirthDate] = @BirthDate,
		[Age] = @Age,
		[IsActive] = @IsActive,
		[Gender] = @Gender,
		[Password] = @Password,
		[Modified] = getDate()

	WHERE [dbo].[MST_Student].[StudentID] = @StudentID

END

-- Delete for student table

-- EXEC [dbo].[PR_MST_Student_DeleteByPK] 1

CREATE PROCEDURE [dbo].[PR_MST_Student_DeleteByPK]
@StudentID INT

AS
BEGIN
	DELETE FROM [dbo].[MST_Student]

	WHERE [dbo].[MST_Student].[StudentID] = @StudentID

END

