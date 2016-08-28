/*	001	StudentID	*/
IF OBJECT_ID('TABLENAME', 'U') IS NOT NULL BEGIN DROP TABLE [TABLENAME] END
SELECT * INTO [TABLENAME] FROM AmarPartDB.dbo.Student

/*  002  Vaziiat  */ 
IF OBJECT_ID('t01', 'U') IS NOT NULL BEGIN DROP TABLE t01 END
IF OBJECT_ID('t02', 'U') IS NOT NULL BEGIN DROP TABLE t02 END
GO
SELECT StudentID,MAX(Year)MaxYear INTO t01 FROM AmarPartDB.dbo.TBL_StudentSchool GROUP BY StudentID

SELECT a.* INTO t02 FROM  (SELECT StudentID,StudentSchoolID,Year FROM AmarPartDB.dbo.TBL_StudentSchool) a
INNER JOIN dbo.t01 b ON b.StudentID = a.StudentID AND b.MaxYear=a.Year
DROP TABLE t01
GO
SELECT StudentID,MAX(StudentSchoolID)MaxStudentSchoolID INTO t01 FROM dbo.t02 GROUP BY StudentID
DROP TABLE t02
GO
IF COL_LENGTH('TABLENAME','Vaziiat') IS NULL BEGIN ALTER TABLE [TABLENAME] ADD Vaziiat NVARCHAR(200) END
GO
IF COL_LENGTH('TABLENAME','Vaziiat') IS NOT NULL BEGIN UPDATE [TABLENAME] SET Vaziiat=NULL END
UPDATE a SET a.Vaziiat=b.Vaziiat FROM [TABLENAME] a
JOIN (
		SELECT a.StudentSchoolID,a.StudentID,a.Status Vaziiat FROM AmarPartDB.dbo.TBL_StudentSchool a
		INNER JOIN dbo.t01 b ON b.StudentID = a.StudentID AND b.MaxStudentSchoolID=a.StudentSchoolID
	) b ON b.StudentID = a.StudentID

DROP TABLE t01
