/*  SalePaziresh  */ 
IF COL_LENGTH('TABLENAME','SalePaziresh') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD SalePaziresh NVARCHAR(100) END
GO
IF COL_LENGTH('TABLENAME','SalePaziresh') IS NOT NULL BEGIN UPDATE [TABLENAME] SET SalePaziresh=NULL END
UPDATE a SET a.SalePaziresh=b.SalePaziresh FROM [TABLENAME] a
JOIN (
		SELECT a.USERCODE CodePaziresh,b.PeriodName SalePaziresh FROM HQ_Registery.dbo.STU_mainINFO a 
		LEFT JOIN HQ_Registery.dbo.Period b ON b.PeriodID = a.PeriodID
	  ) b
 ON b.CodePaziresh = a.CodePaziresh



