ALTER TABLE [TABLENAME] ADD MosahebeKhareg INT
GO
UPDATE [TABLENAME] SET MosahebeKhareg=NULL

UPDATE a SET a.MosahebeKhareg=b.MosahebeKhareg FROM [TABLENAME] a
JOIN (SELECT COUNT(*)MosahebeKhareg,StudentID FROM [AmarPartDB].dbo.TBL_Level4 GROUP BY StudentID)b
ON b.StudentID = a.StudentID