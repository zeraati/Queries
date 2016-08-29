/*  002  ModelClassic  */ 
IF COL_LENGTH('TABLENAME','ModelClassic') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD ModelClassic FLOAT END
GO
IF COL_LENGTH('TABLENAME','ModelClassic') IS NOT NULL BEGIN UPDATE [TABLENAME] SET ModelClassic=NULL END
UPDATE a SET a.ModelClassic=b.ModelClassic FROM [TABLENAME] a
JOIN (SELECT USERCODE CodePaziresh,AVGlesson ModelClassic FROM HQ_Registery.dbo.STU_mainINFO) b
ON b.CodePaziresh = a.CodePaziresh



