CREATE PROCEDURE [dbo].[spCustomer_Insert]
	@FirstName	NVARCHAR(50),
	@LastName	NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Customer (FirstName, LastName)
	VALUES (@FirstName, @LastName);
END
