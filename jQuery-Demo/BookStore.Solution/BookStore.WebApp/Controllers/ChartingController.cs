using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookStore.Model;
using BookStore.Model.Entities;

namespace BookStore.WebApp.Controllers
{
    public class ChartingController : Controller
    {
        private readonly IBooksService _booksService;

        public ChartingController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPercentages()
        {
            return Json(_booksService.GetPercentages(),JsonRequestBehavior.AllowGet);
        }

    }
}
