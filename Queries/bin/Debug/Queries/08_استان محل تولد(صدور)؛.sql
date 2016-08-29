/*	KeshvarSodor,OstanSodor	*/
IF COL_LENGTH('TABLENAME','KeshvarSodor') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD KeshvarSodor NVARCHAR(50) END
IF COL_LENGTH('TABLENAME','OstanSodor') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanSodor NVARCHAR(50) END
GO
IF COL_LENGTH('TABLENAME','KeshvarSodor') IS NOT NULL BEGIN UPDATE [TABLENAME] SET KeshvarSodor=NULL END
IF COL_LENGTH('TABLENAME','OstanSodor') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanSodor=NULL END
UPDATE c SET c.KeshvarSodor=d.KeshvarSodor,c.OstanSodor=d.OstanSodor FROM [TABLENAME] c
JOIN 
	(	SELECT a.StudentID,b.OstanKharg OstanSodor,b.Keshvar KeshvarSodor FROM 
			(SELECT StudentID,CASE WHEN CHARINDEX(N':',Sodor)>0THEN REPLACE(LEFT(Sodor,CHARINDEX(N':',Sodor)),N':','')ELSE Sodor END AS Sodor FROM AmarPartDB.dbo.TBL_Student WHERE Sodor IS NOT NULL)a
		LEFT JOIN [Standard].dbo.Standard_Ostan_Keshvar b ON b.Ostan = a.Sodor
	)d ON d.StudentID = c.StudentID



