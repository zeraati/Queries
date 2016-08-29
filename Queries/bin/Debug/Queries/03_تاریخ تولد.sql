/*	006	TarikhTavalod	*/
IF COL_LENGTH('TABLENAME','TarikhTavalod') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD TarikhTavalod INT END
GO
IF COL_LENGTH('TABLENAME','TarikhTavalod') IS NOT NULL BEGIN UPDATE [TABLENAME] SET TarikhTavalod=NULL END
UPDATE a SET a.TarikhTavalod=b.TarikhTavalod FROM [TABLENAME] a
JOIN(SELECT StudentID,CONVERT(INT,LEFT(AmarPartDB.dbo.UDF_Gregorian_To_Persian(BirthDate),4))TarikhTavalod FROM AmarPartDB.dbo.TBL_Student)b
ON b.StudentID = a.StudentID
