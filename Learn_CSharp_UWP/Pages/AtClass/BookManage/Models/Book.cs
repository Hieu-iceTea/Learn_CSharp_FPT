using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_UWP.Pages.AtClass.BookManage.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookID = 1, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 2, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 3, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 4, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 5, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 6, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 7, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 8, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 9, Title = "Title", Author = "Author", CoverImage = "CoverImage" });
            books.Add(new Book { BookID = 10, Title = "Title", Author = "Author", CoverImage = "CoverImage" });

            return books;
        }
    }
}
