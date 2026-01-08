-- NULLIF() is used to nullify a value.
-- WE can use NULLIF() together with ISNULL() to replace an old value
-- with a new value.
USE AdventureWorks2022
GO

SELECT TOP 100
    [PersonList].[BusinessEntityID],
    [PersonList].[PersonType],
    [PersonList].[NameStyle],
    [PersonList].[Title],
    ISNULL(NULLIF([PersonList].[Title], NULL), 'Sir/Maam') AS Title_Corrected,
    [PersonList].[FirstName],
    [PersonList].[MiddleName],
    [PersonList].[LastName]
FROM Person.Person as PersonList