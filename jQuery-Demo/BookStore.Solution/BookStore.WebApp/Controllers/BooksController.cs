using System.Linq;
using System.Web.Mvc;
using BookStore.Model;
using BookStore.Model.Entities;

namespace BookStore.WebApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public ActionResult BooksV1()
        {
            return View(_booksService.GetAllBooks().OrderBy(b => b.Title));
        }

        [HttpGet]
        public ActionResult BooksV2()
        {
            return View(_booksService.GetAllBooks().OrderBy(b => b.Title));
        }

        public ActionResult Create(Book book)
        {
            _booksService.AddBook(book);
            return PartialView("BooksList", _booksService.GetAllBooks().OrderBy(b => b.Title));
        }

        public ActionResult Remove(int bookId)
        {
            _booksService.RemoveBook(bookId);
            return PartialView("BooksList", _booksService.GetAllBooks().OrderBy(b => b.Title));
        }

    }
}
