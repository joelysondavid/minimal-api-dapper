CREATE PROCEDURE [dbo].[spCustomer_Get]
	@Id INT
AS
BEGIN	
	SELECT * 
	FROM dbo.Customer
	WHERE Id = @Id;
END
