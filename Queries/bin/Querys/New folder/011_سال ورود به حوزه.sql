--	011	SaleWorod
IF COL_LENGTH('TABLENAME','SaleWorod') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD SaleWorod INT END ELSE BEGIN UPDATE [TABLENAME] SET SaleWorod=NULL END
GO
UPDATE a SET a.SaleWorod=b.SaleWorod FROM [TABLENAME] b
JOIN 
	(	SELECT StudentID,Min(a.MinInputScore)SaleWorod FROM 
		(SELECT * FROM [AmarPartDB].dbo.TBL_Arziabi WHERE MinInputScore IS NOT NULL AND  MinInputScore>0)a GROUP BY StudentID
	)c ON c.StudentID = b.StudentID
