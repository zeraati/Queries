/*	004	SodorKeshvar,SodorOstan	*/
IF COL_LENGTH('TABLENAME','SodorKeshvar') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD SodorKeshvar NVARCHAR(50) END
IF COL_LENGTH('TABLENAME','SodorOstan') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD SodorOstan NVARCHAR(50) END
GO
IF COL_LENGTH('TABLENAME','SodorKeshvar') IS NOT NULL BEGIN UPDATE [TABLENAME] SET SodorKeshvar=NULL END
IF COL_LENGTH('TABLENAME','SodorOstan') IS NOT NULL BEGIN UPDATE [TABLENAME] SET SodorOstan=NULL END
UPDATE c SET c.SodorKeshvar=d.SodorKeshvar,c.SodorOstan=d.SodorOstan FROM [TABLENAME] c
JOIN 
	(	SELECT a.StudentID,b.OstanStandard SodorOstan,b.Keshvar SodorKeshvar FROM 
			(SELECT StudentID,CASE WHEN CHARINDEX(N':',Sodor)>0THEN REPLACE(LEFT(Sodor,CHARINDEX(N':',Sodor)),N':','')ELSE Sodor END AS Sodor FROM AmarPartDB.dbo.TBL_Student WHERE Sodor IS NOT NULL)a
		LEFT JOIN [Standard].dbo.Standard_Ostan_Keshvar b ON b.Ostan = a.Sodor
	)d ON d.StudentID = c.StudentID

