/*	003	OstanTahsil,Madreseh	*/
IF COL_LENGTH('TABLENAME','OstanTahsil') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanTahsil NVARCHAR(200) END
IF COL_LENGTH('TABLENAME','Madreseh') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD Madreseh NVARCHAR(MAX) END
GO
IF COL_LENGTH('TABLENAME','OstanTahsil') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanTahsil=NULL END
IF COL_LENGTH('TABLENAME','Madreseh') IS NOT NULL BEGIN UPDATE [TABLENAME] SET Madreseh=NULL END
UPDATE c SET c.OstanTahsil=d.OstanTahsil,c.Madreseh=d.Madreseh FROM [TABLENAME] c
JOIN 
	(	SELECT StudentID,b.OstanStandard OstanTahsil,SchoolName Madreseh FROM AmarPartDB.dbo.TBL_Student a
		INNER JOIN Standard.dbo.Standard_SchoolOstan b ON b.OstanName = a.OstanName
	)d ON d.StudentID = c.StudentID

