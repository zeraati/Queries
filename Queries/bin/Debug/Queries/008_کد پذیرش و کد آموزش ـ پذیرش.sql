/*  002  CodePaziresh  */ 
IF COL_LENGTH('TABLENAME','CodePaziresh') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD CodePaziresh INT END
GO
IF COL_LENGTH('TABLENAME','CodePaziresh') IS NOT NULL BEGIN UPDATE [TABLENAME] SET CodePaziresh=NULL END
UPDATE a SET a.CodePaziresh=b.CodePaziresh FROM [TABLENAME] a
JOIN (
		SELECT USERCODE CodePaziresh,StudentID FROM HQ_Registery.dbo.STU_mainINFO a
		INNER JOIN Najah.dbo.HQ_Student b ON ISNULL(b.studentid_old,StudentID)=a.temp_code
		WHERE a.USERCODE!='498454'
	) b ON b.StudentID = a.StudentID



