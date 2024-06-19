using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApp.Models
{
    public class BooksModel {

        /*     SELECT[BookID]
           ,[Title]
           ,[Author]
           ,[PublishedDate]
           ,[Genre]
           ,[Rating]
           ,[BookImage]
         {*/

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author name is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Published date is required")]
        public DateTime? PublishedDate { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        public int Rating { get; set; }
        public byte[] BookImage { get; set; }
    }

    /* public class Book
     {
         public string p_author;
         public DateTime p_yearPublished;
         public string p_title;
         public string p_genre;
         public int p_rating;

         public Book(string author, DateTime yearPublished, string title, string genre, int rating)
         {
             p_author = author;
             p_yearPublished = yearPublished;
             p_title = title;
             p_genre = genre;
             p_rating = rating;

         }



     }*/
}
