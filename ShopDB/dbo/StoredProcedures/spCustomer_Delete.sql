CREATE PROCEDURE [dbo].[spCustomer_Delete]
	@Id INT
AS
BEGIN
	DELETE 
	FROM dbo.Customer
	WHERE Id = @Id;
END
