-- Script Date: 2024/06/15 21:03  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [People] (
  [PersonID] INTEGER NOT NULL
, [FirstName] TEXT NOT NULL
, [LastName] TEXT NOT NULL
, [ContactNumber] TEXT NOT NULL
, [Address] TEXT NOT NULL
, [Gender] TEXT NOT NULL
, [Email] TEXT NOT NULL
, CONSTRAINT [PK_People] PRIMARY KEY ([PersonID])
);
