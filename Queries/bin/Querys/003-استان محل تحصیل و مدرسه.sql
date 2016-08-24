/*	003	TahsilOstan,Madreseh	*/
IF COL_LENGTH('TABLENAME','TahsilOstan') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD TahsilOstan NVARCHAR(200) END
IF COL_LENGTH('TABLENAME','Madreseh') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD Madreseh NVARCHAR(MAX) END
GO
IF COL_LENGTH('TABLENAME','TahsilOstan') IS NOT NULL BEGIN UPDATE [TABLENAME] SET TahsilOstan=NULL END
IF COL_LENGTH('TABLENAME','Madreseh') IS NOT NULL BEGIN UPDATE [TABLENAME] SET Madreseh=NULL END
UPDATE c SET c.TahsilOstan=d.TahsilOstan,c.Madreseh=d.Madreseh FROM [TABLENAME] c
JOIN 
	(	SELECT StudentID,b.OstanStandard TahsilOstan,SchoolName Madreseh FROM AmarPartDB.dbo.TBL_Student a
		INNER JOIN Standard.dbo.Standard_SchoolOstan b ON b.OstanName = a.OstanName
	)d ON d.StudentID = c.StudentID
