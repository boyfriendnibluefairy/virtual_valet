USE AdventureWorks2022
GO

SELECT
    [PersonList].[FirstName],
    [PersonList].[MiddleName],
    [PersonList].[LastName],
    CASE
        WHEN (MiddleName IS NOT NULL) THEN 1 ELSE 0
    END AS MiddleName_Checker
FROM Person.Person AS PersonList