namespace LibraryManagementApp.Models
{
    public class BooksModel
    {
        public class Book
        {
            private string p_author;
            private DateTime p_yearPublished;
            private string p_title;
            private string p_genre;
            private int p_rating;

            public Book(string author, DateTime yearPublished, string title, string genre, int rating)
            {
                p_author = author;
                p_yearPublished = yearPublished;
                p_title = title;
                p_genre = genre;
                p_rating = rating;

            }

            public string author { get { return p_author; } set { p_author = value; } }
            public DateTime yearPublished { get { return p_yearPublished; } set { p_yearPublished = value; } }
            public string title { get { return p_title; } set { p_title = value; } }
            public string genre { get { return p_genre; } set { p_genre = value; } }
            public int rating { get { return p_rating; } set { p_rating = value; } }

        }
    }
}
