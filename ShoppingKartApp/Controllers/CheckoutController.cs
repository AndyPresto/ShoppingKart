using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingKartApp.model;
using ShoppingKartData;
using ShoppingKartSharedLogic;
using System;

namespace ShoppingKartApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CheckoutController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalculateTotal(List<CartItem> cartItems)
        {
            var products = Products.GetProductList(); 
            Checkout checkout = new Checkout(products);

            foreach (var item in cartItems)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    checkout.Scan(item.Sku);
                }
            }
            decimal total = checkout.GetTotalPrice();
            return new JsonResult(new { cost = total });
        }
    }
}
