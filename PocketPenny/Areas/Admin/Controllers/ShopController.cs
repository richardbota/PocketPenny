using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PocketPenny.Models.ViewModels.Shop;
using PocketPenny.Models.Data;

namespace PocketPenny.Areas.Admin.Controllers
{
    public class ShopController : Controller
    {
        // GET: Admin/Shop/Categories
        public ActionResult Categories()
        {
            // Declare list of models
            List<CategoryVM> categoryVmList;

            using (Db db = new Db())
            {
                // Init the list
                categoryVmList = db.Categories
                                .ToArray()
                                .OrderBy(x => x.Sorting)
                                .Select(x => new CategoryVM(x))
                                .ToList();
            }


            // Return view with list
            return View(categoryVmList);
        }
    }
}
