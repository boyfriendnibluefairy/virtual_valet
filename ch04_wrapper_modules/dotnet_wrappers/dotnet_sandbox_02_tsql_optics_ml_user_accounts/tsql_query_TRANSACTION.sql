/*
  A transaction is a series of operations performed in a DB. If a transaction fails,
  all steps performed prior to that step that led to failure are reversed. The data
  in the DB returns to original state as if the transaction never existed. This process
  is called a rollback. The difference between transaction and a series of queries is
  that a series of queries cannot perform rollback if it fails.
*/
USE TestDatabase
GO

CREATE SCHEMA DummySchema
GO
DROP TABLE IF EXISTS DummySchema.DummyTable

CREATE TABLE DummySchema.DummyTable (
    WesterosID INT IDENTITY(1,1),
    FirstName VARCHAR(33),
    LastName VARCHAR(33),
    hasDragon BIT
)


SELECT * FROM DummySchema.DummyTable

INSERT INTO DummySchema.DummyTable (
    FirstName,
    LastName,
    hasDragon
) VALUES (
    'Aegon',
    'Targaryen',
    1
)

INSERT INTO DummySchema.DummyTable (
    FirstName,
    LastName,
    hasDragon
) VALUES (
    'Arya',
    'Stark',
    0
)

INSERT INTO DummySchema.DummyTable (
    FirstName,
    LastName,
    hasDragon
) VALUES (
    'Daenerys',
    'Targaryen',
    0
)

-- update field
UPDATE DummySchema.DummyTable SET hasDragon = 1 WHERE [WesterosID] = 5

SELECT * FROM DummySchema.DummyTable

-- add a column
ALTER TABLE DummySchema.DummyTable
    ADD Kingdom VARCHAR(33) DEFAULT 'Kings Landing'

UPDATE DummySchema.DummyTable SET [Kingdom] = 'Kings Landing'

--BEGIN TRANSACTION
    --SELECT * FROM DummySchema.DummyTable
    ALTER TABLE DummySchema.DummyTable DROP COLUMN [Kingdom]
    SELECT * FROM DummySchema.DummyTable
