using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookSaleManagement.Models;

namespace BookSaleManagement.Controllers
{
    public class HomeController : Controller
    {
        BookSaleManagementEntities bookSale_db = new BookSaleManagementEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult OutStandingBooks()
        {
            var listBooks = bookSale_db.Saches.Take(4).ToList();
            return PartialView(listBooks);
        }
    }
}