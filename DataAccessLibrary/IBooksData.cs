using LibraryManagementApp.Models;

namespace DataAccessLibrary
{
    public interface IBooksData
    {
        Task AddBooks(BooksModel book);
        Task<List<BooksModel>> GetBooks();
    }
}