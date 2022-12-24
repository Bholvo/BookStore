using Aman.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aman.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int id)
        {
            return Datasource().Where(y => y.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return Datasource().Where( x => x.Title.Contains(title) || x.Author.Contains(authorName) ).ToList();
        }

        public List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1001,Title="JAVA",Author="Love bubber"},
                new BookModel(){Id=1002,Title="OS",Author="Ramesh"},
                new BookModel(){Id=1003,Title="NETWORK",Author="Shwetha kumari"},
                new BookModel(){Id=1004,Title="C#",Author="Raju"},
                new BookModel(){Id=1005,Title="JAVASCRIPT",Author="Harry"},
                new BookModel(){Id=1006,Title="ATOMIC HABIT",Author="James clear"},
                new BookModel(){Id=1006,Title="ATOMIC HABIT",Author="Jamun"},
                new BookModel(){Id=1007,Title="ALCHYMEST",Author="Nelson"}
            };
        }
    }
}
