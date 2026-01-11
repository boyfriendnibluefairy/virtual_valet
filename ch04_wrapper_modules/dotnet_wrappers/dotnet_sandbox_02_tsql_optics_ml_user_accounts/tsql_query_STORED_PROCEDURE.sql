USE AdventureWorks2022
GO

-- 2016 MS SQL Server allows CREATE OR ALTER
CREATE OR ALTER PROCEDURE HumanResources.spEmployees_Display
    @JobTitle VARCHAR(50) = NULL, -- equals means were providing default values
    @MaritalStatus NCHAR(1) = NULL,
    @Gender NCHAR(1) = NULL,
    @PageNumber INT = 1,
    @RowsPerPage INT = 10
/*
    To call this procedure, execute:
    EXEC HumanResources.spEmployees_Display @JobTitle = 'Design Engineer'
*/
AS
    BEGIN
        DECLARE @Offset INT = @RowsPerPage * (@PageNumber - 1)
        SELECT
            [HRE].[BusinessEntityID],
            [HRE].[NationalIDNumber],
            [HRE].[LoginID],
            [HRE].[JobTitle],
            [HRE].[BirthDate],
            [HRE].[MaritalStatus],
            [HRE].[Gender],
            [HRE].[HireDate],
            [HRE].[VacationHours],
            [HRE].[SickLeaveHours],
            [HRE].[CurrentFlag]
        FROM HumanResources.Employee AS HRE
            WHERE JobTitle = ISNULL( @JobTitle, JobTitle)
            AND MaritalStatus = ISNULL(@MaritalStatus, MaritalStatus)
            AND Gender = ISNULL(@Gender, Gender)
        ORDER BY JobTitle
        OFFSET @Offset ROWS FETCH NEXT @RowsPerPage ROWS ONLY
    END
GO

--EXEC HumanResources.spEmployees_Display @JobTitle = 'Design Engineer', @Gender = 'F'
-- EXEC HumanResources.spEmployees_Display @JobTitle = 'Design Engineer'
--EXEC HumanResources.spEmployees_Display @MaritalStatus = 'S'
-- EXEC HumanResources.spEmployees_Display
EXEC HumanResources.spEmployees_Display @PageNumber = 29
