-- Script Date: 2024/06/15 21:20  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [BooksStock] (
  [StockID] INTEGER NOT NULL
, [BookID] INTEGER NOT NULL
, [borrowedby] INTEGER NOT NULL
, CONSTRAINT [PK_BooksStock] PRIMARY KEY ([StockID])
);
