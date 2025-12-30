USE AdventureWorks2022
GO

-- Look for a sample table with null values.
-- To enable fully-qualified list for the fields,
-- just disconnect and connect the database then
-- Ctrl+Space beside the asterisk.
SELECT
    [PersonList].[BusinessEntityID],
    [PersonList].[PersonType],
    [PersonList].[NameStyle],
    [PersonList].[Title],
    ISNULL(Title, 'Mr/Ms') AS Title_Corrected,
    [PersonList].[FirstName],
    [PersonList].[MiddleName],
    [PersonList].[LastName]
FROM Person.Person AS PersonList
