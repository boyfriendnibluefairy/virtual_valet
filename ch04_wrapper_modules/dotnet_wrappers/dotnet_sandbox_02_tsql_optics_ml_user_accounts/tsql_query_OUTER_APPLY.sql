USE AdventureWorks2022
GO

-- create new table from the top three rows of HRD
CREATE SCHEMA HRD
GO

SELECT TOP 3 * INTO HRD.TopThree
FROM HumanResources.Department

-- double check if table was created
SELECT * FROM HRD.TopThree

-- Check how OUTER APPLY works
SELECT * FROM HRD.TopThree
    OUTER APPLY(SELECT * FROM HRD.TopThree) AS RedundantDept
-- It seems that each row of HRD.TopThree was attached to each row of HRD.TopThree
-- Possible use case is to apply metadata for each row.

