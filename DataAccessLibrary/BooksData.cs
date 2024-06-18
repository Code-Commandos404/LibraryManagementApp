using LibraryManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLibrary.LibraryClass;

namespace DataAccessLibrary
{
    public class BooksData : IBooksData
    {
        private readonly ISqlDb _db;

        public BooksData(ISqlDb db)
        {
            _db = db;
        }

        public Task<List<BooksModel>> GetBooks()
        {
            string sql = @"SELECT * from Book;";
            return _db.LoadData<BooksModel, dynamic>(sql, new { });

        }

        public Task AddBooks(BooksModel book)
        {
            string sql = @"insert into Book(Author,PublishedDate,Title,Genre,Rating)
                values(@Author,@PublishedDate,@Title,@Genre,@Rating);";
            return _db.SaveData(sql, book);
        }
    }
}
