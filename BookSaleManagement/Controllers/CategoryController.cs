using BookSaleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookSaleManagement.Controllers
{
    public class CategoryController : Controller
    {
        BookSaleManagementEntities bookSale_db = new BookSaleManagementEntities();
        // GET: Category
        public ActionResult CategoryPartial()
        {
            return PartialView(bookSale_db.ChuDes.ToList());
        }
    }
}