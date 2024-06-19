-- Script Date: 2024/06/15 21:20  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [BookCheckouts] (
  [AuditNo] INTEGER NOT NULL
, [BookBorrowed] INTEGER NOT NULL
, [BorrowedBy] INTEGER NOT NULL
, [DateBorrowed] TEXT NOT NULL
, [DueDate] TEXT NOT NULL
, CONSTRAINT [PK_BookCheckouts] PRIMARY KEY ([AuditNo])
);
