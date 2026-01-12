-- STRING_AGG() is only available from MS SQL Server released from 2016 and beyond.
USE AdventureWorks2022
GO

SELECT
    [HRD].[GroupName],
    STRING_AGG([Name], ', ') AS BackEndDeveloperView,
    STRING_AGG([Name], '; ') AS FrontEndDeveloperView
FROM HumanResources.Department AS HRD
    GROUP BY [GroupName]

