﻿/*	MaxLevel	*/
IF COL_LENGTH('TABLENAME','MaxLevel') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD MaxLevel INT END
GO
IF COL_LENGTH('TABLENAME','MaxLevel') IS NOT NULL BEGIN UPDATE [TABLENAME] SET MaxLevel=NULL END
UPDATE a SET a.MaxLevel=b.MaxLevel FROM [TABLENAME] a
JOIN (SELECT MAX(LevelID)MaxLevel,StudentID FROM [AmarPartDB].dbo.TBL_Level GROUP BY StudentID) b
ON b.StudentID = a.StudentID
