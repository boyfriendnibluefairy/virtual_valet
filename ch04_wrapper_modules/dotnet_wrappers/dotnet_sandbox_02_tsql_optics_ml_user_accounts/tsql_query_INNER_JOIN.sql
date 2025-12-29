USE AdventureWorks2022
GO

-- Choose a table that is tied down to other table.
SELECT * FROM HumanResources.EmployeeDepartmentHistory -- 296 records

SELECT * FROM Person.Person
   WHERE Person.PersonType = 'EM' -- 273 records

-- ON ensures that only match between common columns will be selected
-- ON is where we put the JOIN key
SELECT
[EDH].[BusinessEntityID],
[EDH].[DepartmentID],
[EDH].[ShiftID],
[EDH].[StartDate],
[EDH].[EndDate],
[EDH].[ModifiedDate],
[PersonList].[BusinessEntityID],
[PersonList].[FirstName],
[PersonList].[MiddleName],
[PersonList].[LastName]
FROM HumanResources.EmployeeDepartmentHistory AS EDH
    INNER JOIN Person.Person AS PersonList
        ON PersonList.BusinessEntityID = EDH.BusinessEntityID
