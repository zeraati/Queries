ALTER TABLE [TABLENAME] ADD MadrakClasic NVARCHAR(200)
GO
UPDATE [TABLENAME] SET MadrakClasic=NULL

UPDATE c SET c.MadrakClasic=d.MadrakClasic FROM [TABLENAME] c
JOIN 
	(	SELECT a.StudentID,b.MadrakClassicStandard_TD MadrakClasic FROM Najah.dbo.HQ_Student a
		LEFT JOIN dbo.MadrakClassicStandard b ON b.Madrak = a.Madrak
	)d
ON d.StudentID = c.StudentID

