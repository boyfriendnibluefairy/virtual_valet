USE AdventureWorks2022
GO

SELECT
    GETDATE() AS CurrentDate,
    DATEADD(DAY, 13, GETDATE()) AS Days13After, -- Add 13 days
    DATEADD(HOUR, -13, GETDATE()) AS Hours13Before -- Subtract 13 hours

-- DATEDIFF(datepart, start, end)
-- results to (end - date)
SELECT DATEDIFF(YEAR, GETDATE(), DATEADD(YEAR, 20, GETDATE())) AS Date_Difference