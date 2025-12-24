-- How clustered and non clustered indexes work
USE AdventureWorks2022
GO

-- SELECT * FROM HumanResources.Department

-- create an empty table with the name Department_Indexes
CREATE TABLE [HumanResources].[Department_Indexes](
	[DepartmentID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [dbo].[Name] NOT NULL,
	[GroupName] [dbo].[Name] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL
)

-- Copy the contents of Department table to Department_Indexes table.
INSERT INTO HumanResources.Department_Indexes (
    [Name],
    [GroupName],
    [ModifiedDate]
)
    SELECT
    [Name],
    [GroupName],
    [ModifiedDate] FROM HumanResources.Department
-- At this point, they must have the same contents and arrangement of rows
SELECT
    --[DepartmentID]
    [Name],
    [GroupName],
    [ModifiedDate]
FROM HumanResources.Department

SELECT
    [Name],
    [GroupName],
    [ModifiedDate]
FROM HumanResources.Department_Indexes

-- Create clustered index for Department_Indexes
CREATE CLUSTERED INDEX cix_dept_index
    ON HumanResources.Department_Indexes ([Name])

-- Compare the tables Department table and Department_Indexes table.
-- Note that Department_Indexes are now indexed or arranged based on [Name]
SELECT
    --[DepartmentID]
    [Name],
    [GroupName],
    [ModifiedDate]
FROM HumanResources.Department

SELECT
    [Name],
    [GroupName],
    [ModifiedDate]
FROM HumanResources.Department_Indexes


