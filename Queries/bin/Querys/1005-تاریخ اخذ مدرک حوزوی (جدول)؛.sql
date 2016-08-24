SELECT MIN(REPLACE(Date,'13',''))SathHozaviTarikh,StudentID,LevelID SathHozavi INTO [TABLENAME] FROM [AmarPartDB].dbo.TBL_Level GROUP BY StudentID,LevelID

