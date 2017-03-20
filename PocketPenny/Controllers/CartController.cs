using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PocketPenny.Models.ViewModels.Cart;

namespace PocketPenny.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CartPartial()
        {
            // Init CartVM
            CartVM model = new CartVM();

            // Init quantity
            int gty = 0;

            // Init price
            decimal price = 0m;

            // Check for cart session
            if (Session["cart"] != null)
            {                
                // Get total gty and price to 0
                var list = (List<CartVM>) Session["cart"];

                foreach (var item in list)
                {
                    gty += item.Quantity;
                    price += item.Quantity * item.Price;
                }
            }
            else
            {
                // Or set gty and price to 0
                model.Quantity = 0;
                model.Price = 0m;
            }

            // Return partial view with model 
            return PartialView(model);
        }
    }
}