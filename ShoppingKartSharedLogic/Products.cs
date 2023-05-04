using ShoppingKartData;

namespace ShoppingKartSharedLogic
{
    public class Products
    {
        public static List<Product> GetProductList()
        {
            List<Product> Products = new List<Product>
            {
                new ('A', 5.00m, new Offer(3, 13.00m)),
                new ('B', 3.00m, new Offer(2, 4.50m)),
                new ('C', 2.00m),
                new ('D', 1.50m),
            };
            return Products;
        }
    }
}