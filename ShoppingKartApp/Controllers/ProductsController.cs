using Microsoft.AspNetCore.Mvc;
using ShoppingKartSharedLogic;

namespace ShoppingKartApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetProductsAndOffers()
        {
            var products = Products.GetProductList();
            return new JsonResult(products);
        }
    }
}
