CREATE PROCEDURE [dbo].[spCustomer_Update]
	@Id INT,
	@FirstName	NVARCHAR(50),
	@LastName	NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Customer
	SET FirstName	= @FirstName,
		LastName	= @LastName
	WHERE Id = @Id;
END
