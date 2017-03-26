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
            // Init the cart list
            var cart = Session["cart"] as List<CartVM> ?? new List<CartVM>();

            // Check if cart empty
            if (cart.Count == 0 || Session["cart"] == null)
            {
                ViewBag.Message = "Your cart is empty.";
                return View();
            }

            // Calculate total and save to ViewBag
            decimal total = 0m;

            foreach (var item in cart)
            {
                total += item.Total;
            }

            ViewBag.GrandTotal = total;

            // Return view with model
            return View(cart);
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