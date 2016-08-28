/* table TeacherID  */ 
IF OBJECT_ID('TeacherID', 'U') IS NOT NULL BEGIN DROP TABLE TeacherID END 
SELECT a.* INTO TeacherID FROM (SELECT TeacherID,StudentId StudentID FROM Najah.dbo.Tbl_Teacher) a 
INNER JOIN(SELECT [StudentId], COUNT(*)cnt FROM (SELECT TeacherID,StudentId FROM Najah.dbo.Tbl_Teacher) d GROUP BY [StudentId] HAVING COUNT(*) = 1)b 
ON b.[StudentId] = a.[StudentId]

/*	TBL_Teacher add StudentID	*/
IF COL_LENGTH('TBL_Teacher','StudentId') IS NULL BEGIN ALTER TABLE [TBL_Teacher] ADD StudentID INT END
GO
IF COL_LENGTH('TBL_Teacher','StudentId') IS NOT NULL BEGIN UPDATE [TBL_Teacher] SET StudentID=NULL END
UPDATE a SET a.StudentID=b.StudentID FROM [TBL_Teacher] a
JOIN TeacherID b ON b.TeacherID = a.TeacherID