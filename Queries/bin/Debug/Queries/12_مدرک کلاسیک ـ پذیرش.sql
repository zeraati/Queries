/*  MdrakClassic_Paziresh*/ 
IF COL_LENGTH('TABLENAME','MdrakClassic_Paziresh') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD MdrakClassic_Paziresh NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','MdrakClassic_Paziresh') IS NOT NULL BEGIN UPDATE [TABLENAME] SET MdrakClassic_Paziresh=NULL END
UPDATE a SET a.MdrakClassic_Paziresh=b.MdrakClassic_Paziresh FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,e.MadrakClassicStandard MdrakClassic_Paziresh FROM HQ_Registery.dbo.STU_mainINFO c
		LEFT JOIN HQ_Registery.dbo.SubLevel_Course d ON d.id_sublevel=c.CourseID
		LEFT JOIN Standard.dbo.Standard_MadrakClassic e ON e.Madrak=d.title_sublevel
	) b ON b.CodePaziresh = a.CodePaziresh



