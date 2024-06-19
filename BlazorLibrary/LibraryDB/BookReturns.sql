-- Script Date: 2024/06/15 21:20  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [BookReturns] (
  [ReturnID] INTEGER NOT NULL
, [AuditNo] INTEGER NOT NULL
, [DateReturned] TEXT NOT NULL
, CONSTRAINT [PK_BookReturns] PRIMARY KEY ([ReturnID])
);
