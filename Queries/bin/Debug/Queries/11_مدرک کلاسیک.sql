/*  MdrakClassic  */ 
IF COL_LENGTH('TABLENAME','MdrakClassic') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD MdrakClassic NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','MdrakClassic') IS NOT NULL BEGIN UPDATE [TABLENAME] SET MdrakClassic=NULL END
UPDATE c SET c.MadrakClasic=d.MadrakClasic FROM [TABLENAME] c
JOIN 
	(	SELECT a.StudentID,b.MadrakClassicStandard_TD MadrakClasic FROM Najah.dbo.HQ_Student a
		LEFT JOIN dbo.MadrakClassicStandard b ON b.Madrak = a.Madrak
	)d
ON d.StudentID = c.StudentID



