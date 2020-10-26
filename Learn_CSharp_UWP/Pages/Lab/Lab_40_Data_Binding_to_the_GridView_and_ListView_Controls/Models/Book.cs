using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_UWP.Pages.Lab.Lab_40_Data_Binding_to_the_GridView_and_ListView_Controls.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author{ get; set; }
        public string CoverImage { get; set; }
    }

    public class BookMamager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookID = 1, Title = "Title 1", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 2, Title = "Title 2", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 3, Title = "Title 2", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 4, Title = "Title 4", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 5, Title = "Title 5", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 6, Title = "Title 6", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 7, Title = "Title 7", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 8, Title = "Title 8", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 9, Title = "Title 9", Author = "Author", CoverImage = "/Assets/Logo.png" });
            books.Add(new Book { BookID = 10, Title = "Title 10", Author = "Author", CoverImage = "/Assets/Logo.png" });

            return books;
        }
    }
}
