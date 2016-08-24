/*  002  OstanSodor  */ 
IF COL_LENGTH('TABLENAME','OstanSodor') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanSodor NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','OstanSodor') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanSodor=NULL END
UPDATE a SET a.OstanSodor=b.OstanSodor FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,e.State OstanSodor FROM HQ_Registery.dbo.STU_mainINFO c
		LEFT JOIN HQ_Registery.dbo.city_t d ON d.CityID=c.Code_Location
		LEFT JOIN HQ_Registery.dbo.State e ON e.StateID = d.StateID
	) b ON b.CodePaziresh = a.CodePaziresh
