-- Script Date: 2024/06/15 21:20  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Book] (
  [BookID] INTEGER NOT NULL
, [Author] TEXT NOT NULL
, [PublishedDate] TEXT NOT NULL
, [Title] TEXT NOT NULL
, [Genre] TEXT NOT NULL
, [Rating] INTEGER NOT NULL
, CONSTRAINT [PK_Book] PRIMARY KEY ([BookID])
);
