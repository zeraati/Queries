/*	TarikhTavalod	*/
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD OstanSokonat NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','OstanSokonat') IS NOT NULL BEGIN UPDATE [TABLENAME] SET OstanSokonat=NULL END
UPDATE a SET a.OstanSokonat=b.Shobe FROM [TABLENAME] a
JOIN AmarPartDB.dbo.TBL_MKsarparast_uniq b ON b.CodeMarkazKhadamat = a.MKID




