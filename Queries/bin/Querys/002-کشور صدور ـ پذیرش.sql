/*  002  KeshvarSodor  */ 
IF COL_LENGTH('TABLENAME','KeshvarSodor') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD KeshvarSodor NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','KeshvarSodor') IS NOT NULL BEGIN UPDATE [TABLENAME] SET KeshvarSodor=NULL END
UPDATE a SET a.KeshvarSodor=b.KeshvarSodor FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,f.Keshvar KeshvarSodor FROM HQ_Registery.dbo.STU_mainINFO c
		LEFT JOIN HQ_Registery.dbo.city_t d ON c.Code_Location=d.CityID
		LEFT JOIN HQ_Registery.dbo.State e ON e.StateID = d.StateID
		LEFT JOIN Standard.dbo.Standard_Ostan_Keshvar f ON f.Ostan=e.State
	) b ON b.CodePaziresh = a.CodePaziresh

