﻿--	012	PayehaMiangin
IF COL_LENGTH('TABLENAME','PayehaMiangin') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD PayehaMiangin FLOAT END ELSE BEGIN UPDATE [TABLENAME] SET PayehaMiangin=NULL END
GO
UPDATE a SET a.COLUMN=b.COLUMN FROM [TABLENAME] b
JOIN (SELECT AVG(AVG)PayehaMiangin,StudentID FROM (SELECT * FROM [AmarPartDB].dbo.TBL_Arziabi  WHERE AVG IS NOT NULL AND AVG>0)a GROUP BY StudentID)c	
ON c.StudentID = a.StudentID
