/*  002  MdrakClassic  */ 
IF COL_LENGTH('TABLENAME','MdrakClassic') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD MdrakClassic NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','MdrakClassic') IS NOT NULL BEGIN UPDATE [TABLENAME] SET MdrakClassic=NULL END
UPDATE a SET a.MdrakClassic=b.MdrakClassic FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,e.MadrakClassicStandard MdrakClassic FROM HQ_Registery.dbo.STU_mainINFO c
		LEFT JOIN HQ_Registery.dbo.SubLevel_Course d ON d.id_sublevel=c.CourseID
		LEFT JOIN Standard.dbo.Standard_MadrakClassic e ON e.Madrak=d.title_sublevel
	) b ON b.CodePaziresh = a.CodePaziresh

