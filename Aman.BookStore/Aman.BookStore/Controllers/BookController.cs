using Aman.BookStore.Models;
using Aman.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aman.BookStore.Controllers
{

    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;

        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public ViewResult GetAllBook()
        {
            // return bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBookById(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return bookRepository.SearchBook(title, authorName);
        }
    } 
}
