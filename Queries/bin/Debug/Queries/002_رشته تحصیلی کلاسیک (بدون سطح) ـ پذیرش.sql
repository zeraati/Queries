/*  002  ReshtehClassic  */ 
IF COL_LENGTH('TABLENAME','ReshtehClassic') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD ReshtehClassic NVARCHAR(500) END
GO
IF COL_LENGTH('TABLENAME','ReshtehClassic') IS NOT NULL BEGIN UPDATE [TABLENAME] SET ReshtehClassic=NULL END
UPDATE a SET a.ReshtehClassic=b.ReshtehClassic FROM [TABLENAME] a
JOIN (
		SELECT a.USERCODE CodePaziresh,b.name_group ReshtehClassic FROM HQ_Registery.dbo.STU_mainINFO a
		LEFT JOIN HQ_Registery.dbo.Group_Course b ON b.id_group=a.reshte_groupID
	) b ON b.CodePaziresh = a.CodePaziresh


