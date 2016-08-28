/*	007	TarikhTavalod	*/
IF COL_LENGTH('TABLENAME','SokonatOstan') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD SokonatOstan NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','SokonatOstan') IS NOT NULL BEGIN UPDATE [TABLENAME] SET SokonatOstan=NULL END
UPDATE a SET a.SokonatOstan=b.Shobe FROM [TABLENAME] a
JOIN AmarPartDB.dbo.TBL_MKsarparast_uniq b ON b.CodeMarkazKhadamat = a.MKID
