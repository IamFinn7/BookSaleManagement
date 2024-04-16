using BookSaleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookSaleManagement.Controllers
{
    public class BookController : Controller
    {
        BookSaleManagementEntities bookSale_db = new BookSaleManagementEntities();

        // GET: Book
        public PartialViewResult OutStandingBooks()
        {
            var listBooks = bookSale_db.Saches.Take(4).ToList();
            return PartialView(listBooks);
        }
    }
}