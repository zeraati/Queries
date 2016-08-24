/*  002  OstanSokonat  */ 
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanSokonat NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanSokonat=NULL END
UPDATE a SET a.OstanSokonat=b.OstanSokonat FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,e.State OstanSokonat FROM HQ_Registery.dbo.STU_mainINFO c
		LEFT JOIN HQ_Registery.dbo.city_t d ON d.CityID=c.Code_Location
		LEFT JOIN HQ_Registery.dbo.State e ON e.StateID = d.StateID
	) b ON b.CodePaziresh = a.CodePaziresh
