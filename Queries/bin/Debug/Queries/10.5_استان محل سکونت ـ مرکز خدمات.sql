/*	OstanSokonat	*/
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanSokonat NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanSokonat=NULL END
UPDATE c SET c.OstanSokonat=d.OstanStandard FROM [TABLENAME] c
JOIN 
	(	SELECT a.CodeMarkazKhadamat MKID,b.OstanStandard FROM AmarPartDB.dbo.TBL_MKsarparast_uniq a
		LEFT JOIN Standard.dbo.Standard_Ostan_Keshvar b ON b.MarkazeOstan=a.Shobe
	)d ON d.MKID = c.MKID



