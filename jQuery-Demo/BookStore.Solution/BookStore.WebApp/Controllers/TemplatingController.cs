using System.Linq;
using System.Web.Mvc;
using BookStore.Model;

namespace BookStore.WebApp.Controllers
{
    public class TemplatingController : Controller
    {
        private readonly IBooksService _booksService;

        public TemplatingController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllBooks()
        {
            return Json(_booksService.GetAllBooks().OrderBy(b => b.Title), JsonRequestBehavior.AllowGet);
        }

    }
}
