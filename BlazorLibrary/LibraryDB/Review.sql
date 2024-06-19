-- Script Date: 2024/06/15 21:20  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [BookReviews] (
  [RevID] INTEGER NOT NULL
, [Comment] TEXT 
, [Rating] INTEGER NOT NULL
, [BookReviewed] INTEGER NOT NULL
, [Reviewedby] INTEGER NOT NULL
, CONSTRAINT [PK_BookReviews] PRIMARY KEY ([RevID])
);
