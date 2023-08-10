IF NOT EXISTS (SELECT 1 FROM dbo.Customer)
BEGIN
	INSERT INTO dbo.Customer (FirstName, LastName)
	VALUES	('Jojoe', 'Oliver'),
			('Kylexus', 'Flo'),
			('Symplexo', 'Lo'),
			('SwordyaN', 'Flo'),
			('Desastre', 'Zoldyack');
END