using ShoppingKartSharedLogic;

namespace ShoppingKartSharedLogicTests
{
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTotalPrice_CorrectPriceSingleItem()
        {
            var products = Products.GetProductList();
            var checkout = new Checkout(products);

            checkout.Scan('A');
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(5.00m, totalPrice);
        }

        [Test]
        public void GetTotalPrice_CorrectPriceThreeItemWithOffer()
        {
            var products = Products.GetProductList();
            var checkout = new Checkout(products);

            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(13.00m, totalPrice);
        }
    }
}